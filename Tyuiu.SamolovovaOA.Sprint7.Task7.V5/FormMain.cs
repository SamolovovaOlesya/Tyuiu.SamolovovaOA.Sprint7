using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SamolovovaOA.Sprint7.Task7.V5.Lib;

namespace Tyuiu.SamolovovaOA.Sprint7.Task7.V5
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        private string[,] allData;
        private string[,] originalData;

        public FormMain()
        {
            InitializeComponent();

            chartTotals_SOA.Series.Clear();
            chartTotals_SOA.Titles.Clear();
            chartTotals_SOA.Titles.Add("Нет данных для составления статистики");
        }

        // Работа с файлами
        private void menuItemOpen_SOA_Click(object sender, EventArgs e)
        {
            if (openFileDialogProducts_SOA.ShowDialog() != DialogResult.OK)
                return;

            allData = ds.LoadFromCsv(openFileDialogProducts_SOA.FileName);
            originalData = (string[,])allData.Clone();

            toolStripStatusLabelInfo_SOA.Text = System.IO.Path.GetFileName(openFileDialogProducts_SOA.FileName);

            UpdateView();
        }

        private void menuItemSave_SOA_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts_SOA.Rows.Count == 0)
                return;

            if (saveFileDialogProducts_SOA.ShowDialog() != DialogResult.OK)
                return;

            allData = GetDataFromGrid();
            ds.SaveToCsv(saveFileDialogProducts_SOA.FileName, allData);
        }

        private void menuItemExit_SOA_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Обновление отображения (таблица + график)
        private void UpdateView()
        {
            dataGridViewProducts_SOA.Rows.Clear();
            chartTotals_SOA.Series.Clear();
            chartTotals_SOA.Titles.Clear();

            if (allData == null)
                return;

            string[,] view = allData;

            if (!string.IsNullOrWhiteSpace(textBoxSearch_SOA.Text))
                view = ds.Search(view, textBoxSearch_SOA.Text);

            if (checkBoxInStock_SOA.Checked)
                view = ds.FilterInStock(view);

            view = ApplySort(view);

            ShowData(view);
        }

        // Сортировка
        private string[,] ApplySort(string[,] data)
        {
            if (data == null || data.GetLength(0) == 0)
                return data;

            int col = -1;
            bool asc = true;
            bool isNumeric = false;

            switch (comboBoxSort_SOA.SelectedIndex)
            {
                case 1: col = 0; asc = true; break;
                case 2: col = 0; asc = false; break;
                case 3: col = 3; asc = true; isNumeric = true; break;
                case 4: col = 3; asc = false; isNumeric = true; break;
                case 5: col = 2; asc = true; isNumeric = true; break;
                case 6: col = 2; asc = false; isNumeric = true; break;
                case 7: col = 5; asc = true; isNumeric = true; break;
                case 8: col = 5; asc = false; isNumeric = true; break;
                default:
                    return data;
            }

            return ds.SortData(data, col, asc, isNumeric);
        }

        // Таблица
        private void ShowData(string[,] data)
        {
            dataGridViewProducts_SOA.Rows.Clear();

            if (dataGridViewProducts_SOA.Columns.Count == 0) CreateGridColumns();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                string[] row = new string[data.GetLength(1)];
                for (int j = 0; j < data.GetLength(1); j++)
                    row[j] = data[i, j];

                dataGridViewProducts_SOA.Rows.Add(row);
            }

            DrawChart(data);
        }

        private string[,] GetDataFromGrid()
        {
            int rows = dataGridViewProducts_SOA.Rows.Count;
            int cols = dataGridViewProducts_SOA.Columns.Count;

            string[,] result = new string[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = dataGridViewProducts_SOA.Rows[i].Cells[j].Value?.ToString() ?? "";

            return result;
        }

        private void CreateGridColumns()
        {
            dataGridViewProducts_SOA.Columns.Clear();

            dataGridViewProducts_SOA.Columns.Add("Code", "Код");
            dataGridViewProducts_SOA.Columns.Add("Name", "Название");
            dataGridViewProducts_SOA.Columns.Add("Quantity", "Количество");
            dataGridViewProducts_SOA.Columns.Add("Price", "Цена");
            dataGridViewProducts_SOA.Columns.Add("Note", "Примечание");
            dataGridViewProducts_SOA.Columns.Add("Sum", "Сумма");
        }

        // График
        private void DrawChart(string[,] data)
        {
            chartTotals_SOA.Series.Clear();
            chartTotals_SOA.Titles.Clear();

            var area = chartTotals_SOA.ChartAreas[0];

            area.AxisY.Minimum = double.NaN;
            area.AxisY.Maximum = double.NaN;
            area.RecalculateAxesScale();
            area.AxisY.Interval = double.NaN;

            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = 0;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = true;
            area.AxisY.IsStartedFromZero = true;

            if (data == null || data.GetLength(0) == 0)
            {
                chartTotals_SOA.Titles.Add("Нет данных для составления статистики");
                return;
            }

            var list = new List<(string Code, double Sum)>();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (double.TryParse(data[i, 5], out double sum))
                {
                    list.Add((data[i, 0], sum));
                }
            }

            var top10 = list.OrderByDescending(x => x.Sum).Take(10).ToList();

            Series series = new Series("ТОП-10 по стоимости");
            series.ChartType = SeriesChartType.Column;
            series.IsXValueIndexed = true;
            series.IsValueShownAsLabel = true;

            for (int i = 0; i < top10.Count; i++)
            {
                DataPoint p = new DataPoint();
                p.XValue = i;
                p.YValues = new double[] { top10[i].Sum };
                p.AxisLabel = top10[i].Code;
                series.Points.Add(p);
            }

            chartTotals_SOA.Series.Add(series);


            string[,] statData = new string[top10.Count, 6];
            for (int i = 0; i < top10.Count; i++)
            {
                statData[i, 5] = top10[i].Sum.ToString();
            }


            var stats = ds.GetValueStatistics(statData);

            double min = stats.Min;
            double max = stats.Max;
            double avg = stats.Avg;
            double totalSum = stats.Sum;

            chartTotals_SOA.Titles.Add($"Кол-во: {top10.Count} | Мин: {min:F2} | Макс: {max:F2} | Ср: {avg:F2} | Сумма: {totalSum:F2}");
        }

        // Редактирование данных
        private void buttonAdd_SOA_Click(object sender, EventArgs e)
        {
            if (allData == null) return; 

            string[] newRow =
            {
                "A999",
                "Новый товар",
                "0",
                "0",
                "",
                "0"
            };

            allData = AddRowToArray(allData, newRow);
            originalData = (string[,]) allData.Clone();

            UpdateView();
        }

        private void buttonDelete_SOA_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts_SOA.CurrentRow == null)
                return;
            allData = RemoveRowFromArray(allData, dataGridViewProducts_SOA.CurrentRow.Index);
            originalData = (string[,])allData.Clone();

            UpdateView();
        }

        private void dataGridViewProducts_SOA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewProducts_SOA.Rows[e.RowIndex];

            if (int.TryParse(row.Cells[2].Value?.ToString(), out int qty) && double.TryParse(row.Cells[3].Value?.ToString(), out double price))
            {
                row.Cells[5].Value = (qty * price).ToString();
            }

            SyncGridToAllData();
            DrawChart(allData);
        }

        private void SyncGridToAllData()
        {
            allData = GetDataFromGrid();
            originalData = (string[,])allData.Clone();
        }

        private string[,] AddRowToArray(string[,] source, string[] newRow)
        {
            int rows = source.GetLength(0);
            int cols = source.GetLength(1);

            var result = new string[rows + 1, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = source[i, j];

            for (int j = 0; j < cols; j++)
                result[rows, j] = newRow[j];

            return result;
        }

        private string[,] RemoveRowFromArray(string[,] source, int index)
        {
            int rows = source.GetLength(0);
            int cols = source.GetLength(1);

            var result = new string[rows - 1, cols];
            int r = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i == index) continue;

                for (int j = 0; j < cols; j++)
                    result[r, j] = source[i, j];

                r++;
            }

            return result;
        }

        // Элементы управления
        private void textBoxSearch_SOA_TextChanged(object sender, EventArgs e) => UpdateView();
        private void comboBoxSort_SOA_SelectedIndexChanged(object sender, EventArgs e) => UpdateView();
        private void checkBoxInStock_SOA_CheckedChanged(object sender, EventArgs e) => UpdateView();
        private void buttonResetFilters_SOA_Click(object sender, EventArgs e)
        {
            if (originalData == null) return;
            textBoxSearch_SOA.Clear();
            checkBoxInStock_SOA.Checked = false;
            comboBoxSort_SOA.SelectedIndex = -1;

            allData = (string[,])originalData.Clone();
            UpdateView();
        }
        private void toolStripButtonRefresh_SOA_Click(object sender, EventArgs e) => UpdateView();
        private void menuItemAbout_SOA_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }
        private void menuItemHelp_SOA_Click(object sender, EventArgs e)
        {
            new FormHelp().ShowDialog();
        }
    }
}