using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SamolovovaOA.Sprint7.Project.V5.Lib;

namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        private List<DataService.Product> productsAll_SOA = new();
        private BindingList<DataService.Product> productsView_SOA = new();
        private BindingSource productsSource_SOA = new();
        private readonly DataService ds_SOA = new DataService();
        private string currentFilePath_SOA = string.Empty;

        public FormMain()
        {
            InitializeComponent();
            MinimumSize = new Size(1100, 650);
            InitChart_SOA();
            Text = "Оптовая база — управление товарами";
            toolStripStatusLabelInfo_SOA.Text = "Готово";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupProductsGrid_SOA();

            productsSource_SOA.DataSource = productsView_SOA;
            dataGridViewProducts_SOA.DataSource = productsSource_SOA;

            dataGridViewProducts_SOA.ReadOnly = false;
            dataGridViewProducts_SOA.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dataGridViewProducts_SOA.AllowUserToAddRows = false;
            dataGridViewProducts_SOA.AllowUserToDeleteRows = false;

            dataGridViewProducts_SOA.CellValueChanged += dataGridViewProducts_SOA_CellValueChanged;
            dataGridViewProducts_SOA.CellEndEdit += dataGridViewProducts_SOA_CellEndEdit;
            dataGridViewProducts_SOA.DataError += dataGridViewProducts_SOA_DataError;

            textBoxSearch_SOA.TextChanged += (s, ev) => ApplyFilter_SOA();
            checkBoxInStock_SOA.CheckedChanged += (s, ev) => ApplyFilter_SOA();

            if (comboBoxSort_SOA.Items.Count == 0)
            {
                comboBoxSort_SOA.Items.AddRange(new object[]
                {
                    "Без сортировки",
                    "Код (A→Z)",
                    "Код (Z→A)",
                    "Цена (возр.)",
                    "Цена (убыв.)",
                    "Кол-во (возр.)",
                    "Кол-во (убыв.)",
                    "Сумма (возр.)",
                    "Сумма (убыв.)"
                });

                comboBoxSort_SOA.SelectedIndex = 0;
            }

            comboBoxSort_SOA.SelectedIndexChanged += (s, ev) => ApplyFilter_SOA();

            ApplyFilter_SOA();
        }

        private void menuItemExit_SOA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemHelp_SOA_Click(object sender, EventArgs e)
        {
            string guide =
                "РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ\n\n" +
                "Назначение программы:\n" +
                "Приложение предназначено для учета и анализа товаров оптовой базы.\n" +
                "Позволяет работать с перечнем товаров, редактировать данные, " +
                "сохранять и загружать информацию, а также просматривать " +
                "статистику и графическое представление данных.\n\n" +
                "Интерфейс программы:\n" +
                "Главное окно содержит таблицу товаров, панель меню и область аналитики.\n" +
                "В таблице отображаются поля:\n" +
                "Код, Название, Количество, Цена, Сумма, Примечание.\n" +
                "Поле «Сумма» рассчитывается автоматически.\n\n" +
                "Работа с файлами:\n" +
                "• Открыть — загрузка данных из CSV-файла.\n" +
                "• Сохранить — сохранение текущих данных в CSV-файл.\n\n" +
                "Работа с товарами:\n" +
                "• Добавить — добавление нового товара.\n" +
                "• Удалить — удаление выбранного товара.\n" +
                "• Редактирование выполняется прямо в таблице.\n\n" +
                "Поиск и фильтрация:\n" +
                "В программе реализован поиск и фильтрация товаров по заданным условиям.\n\n" +
                "Статистика и график:\n" +
                "В правой части окна отображается статистика и график,\n" +
                "построенный по данным таблицы для наглядного анализа.\n\n" +
                "Примечание:\n" +
                "При вводе некорректных данных необходимо исправить значение в ячейке.";

            MessageBox.Show(
                guide,
                "Руководство пользователя",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuItemAbout_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Оптовая база – управление товарами\n\n" +
                "Разработчик: Самоловова О.А.\n" +
                "Группа: ПИН6-25-1\n\n" +
                "Тюменский индустриальный университет\n" +
                "© 2025",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SetupProductsGrid_SOA()
        {
            dataGridViewProducts_SOA.AutoGenerateColumns = false;
            dataGridViewProducts_SOA.Columns.Clear();

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Код",
                DataPropertyName = nameof(DataService.Product.ProductCode),
                Width = 80,
                ReadOnly = true
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Название",
                DataPropertyName = nameof(DataService.Product.ProductName),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 180,
                FillWeight = 65
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Кол-во",
                DataPropertyName = nameof(DataService.Product.Quantity),
                Width = 80
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Цена",
                DataPropertyName = nameof(DataService.Product.UnitPrice),
                Width = 90
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Сумма",
                DataPropertyName = nameof(DataService.Product.TotalValue),
                Width = 110,
                ReadOnly = true
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Примечание",
                DataPropertyName = nameof(DataService.Product.Notes),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 180,
                FillWeight = 65
            });
        }

        private void dataGridViewProducts_SOA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            productsSource_SOA.ResetBindings(false);
        }

        private void dataGridViewProducts_SOA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            toolStripStatusLabelInfo_SOA.Text = "Изменения внесены";
        }

        private void dataGridViewProducts_SOA_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некорректное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.ThrowException = false;
        }

        private void ApplyFilter_SOA()
        {
            IEnumerable<DataService.Product> query = productsAll_SOA;

            string q = (textBoxSearch_SOA.Text ?? "").Trim();
            if (!string.IsNullOrWhiteSpace(q))
            {
                query = query.Where(p =>
                    (p.ProductCode ?? "").Contains(q, StringComparison.OrdinalIgnoreCase) || (p.ProductName ?? "").Contains(q, StringComparison.OrdinalIgnoreCase));
            }

            if (checkBoxInStock_SOA.Checked)
            {
                query = query.Where(p => p.Quantity > 0);
            }

            query = comboBoxSort_SOA.SelectedItem switch
            {
                "Код (A→Z)" => query.OrderBy(p => p.ProductCode),
                "Код (Z→A)" => query.OrderByDescending(p => p.ProductCode),
                "Цена (возр.)" => query.OrderBy(p => p.UnitPrice),
                "Цена (убыв.)" => query.OrderByDescending(p => p.UnitPrice),
                "Кол-во (возр.)" => query.OrderBy(p => p.Quantity),
                "Кол-во (убыв.)" => query.OrderByDescending(p => p.Quantity),
                "Сумма (возр.)" => query.OrderBy(p => p.TotalValue),
                "Сумма (убыв.)" => query.OrderByDescending(p => p.TotalValue),
                _ => query
            };

            var filtered = query.ToList();

            productsView_SOA = new BindingList<DataService.Product>(filtered);
            productsSource_SOA.DataSource = productsView_SOA;
            productsSource_SOA.ResetBindings(false);

            labelFound_SOA.Text = $"Найдено: {filtered.Count} из {productsAll_SOA.Count}";

            UpdateStatsAndChart_SOA(filtered);
        }

        private void InitChart_SOA()
        {
            if (chartTotals_SOA == null) return;

            var area = chartTotals_SOA.ChartAreas[0];

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.LabelStyle.Format = "N0";
            area.AxisX.Title = "Товар (код)";
            area.AxisY.Title = "Сумма";

            chartTotals_SOA.Series.Clear();

            var s = new Series("Топ-10 по сумме")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelFormat = "N0",
                ChartArea = area.Name,
                XValueType = ChartValueType.String,
                IsXValueIndexed = true
            };

            chartTotals_SOA.Series.Add(s);
        }

        private void UpdateStatsAndChart_SOA(List<DataService.Product> current)
        {
            if (current == null || current.Count == 0)
            {
                labelStats_SOA.Text = "Нет данных для расчёта статистики";
                chartTotals_SOA.Series[0].Points.Clear();
                return;
            }

            decimal sum = current.Sum(p => p.TotalValue);
            decimal min = current.Min(p => p.TotalValue);
            decimal max = current.Max(p => p.TotalValue);
            decimal avg = current.Average(p => p.TotalValue);

            labelStats_SOA.Text =
                $"Кол-во позиций: {current.Count} | " +
                $"Всего шт: {current.Sum(p => p.Quantity)} | " +
                $"Сумма: {sum:N0} | " +
                $"Мин: {min:N0} | " +
                $"Макс: {max:N0} | " +
                $"Среднее: {avg:N0}";

            var series = chartTotals_SOA.Series[0];
            series.Points.Clear();

            foreach (var p in current.OrderByDescending(p => p.TotalValue).Take(10))
            {
                series.Points.AddXY(p.ProductCode, Convert.ToDouble(p.TotalValue));
            }
        }

        private void DoOpenFile_SOA()
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Открыть данные (CSV)"
            };

            if (ofd.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                var loaded = ds_SOA.LoadFromCsv(ofd.FileName);
                currentFilePath_SOA = ofd.FileName;
                productsAll_SOA = loaded ?? new List<DataService.Product>();
                toolStripStatusLabelInfo_SOA.Text = $"Открыто: {Path.GetFileName(currentFilePath_SOA)}";
                ApplyFilter_SOA();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл.\n{ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DoSaveFile_SOA(bool forceChoosePath)
        {
            if (forceChoosePath || string.IsNullOrWhiteSpace(currentFilePath_SOA))
            {
                using var sfd = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                    Title = "Сохранить данные (CSV)",
                    FileName = "products.csv"
                };

                if (sfd.ShowDialog(this) != DialogResult.OK) return;
                currentFilePath_SOA = sfd.FileName;
            }

            try
            {
                ds_SOA.SaveToCsv(currentFilePath_SOA, productsAll_SOA);
                toolStripStatusLabelInfo_SOA.Text = $"Сохранено: {Path.GetFileName(currentFilePath_SOA)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не удалось сохранить файл.\n{ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DoRefresh_SOA()
        {
            ApplyFilter_SOA();
            toolStripStatusLabelInfo_SOA.Text = "Обновлено";
        }

        private void DoFillDemo_SOA()
        {
            productsAll_SOA = ds_SOA.GetDemoProducts();
            currentFilePath_SOA = string.Empty;
            toolStripStatusLabelInfo_SOA.Text = "Загружены демонстрационные данные";
            ApplyFilter_SOA();
        }

        private void DoAdd_SOA()
        {
            var newItem = new DataService.Product
            {
                ProductCode = $"A{productsAll_SOA.Count + 1}",
                ProductName = "Новый товар",
                Quantity = 0,
                UnitPrice = 0,
                Notes = ""
            };

            productsAll_SOA.Add(newItem);
            ApplyFilter_SOA();

            var idx = productsView_SOA.IndexOf(newItem);
            if (idx >= 0 && idx < dataGridViewProducts_SOA.Rows.Count)
            {
                dataGridViewProducts_SOA.ClearSelection();
                dataGridViewProducts_SOA.Rows[idx].Selected = true;
                dataGridViewProducts_SOA.FirstDisplayedScrollingRowIndex = idx;
            }
        }

        private void DoDelete_SOA()
        {
            if (dataGridViewProducts_SOA.CurrentRow == null) return;

            if (dataGridViewProducts_SOA.CurrentRow.DataBoundItem is DataService.Product item)
            {
                productsAll_SOA.Remove(item);
                ApplyFilter_SOA();
                toolStripStatusLabelInfo_SOA.Text = "Удалено";
            }
        }

        private void DoResetFilters_SOA()
        {
            textBoxSearch_SOA.Text = "";
            checkBoxInStock_SOA.Checked = false;

            if (comboBoxSort_SOA.Items.Count > 0)
            {
                comboBoxSort_SOA.SelectedIndex = 0;
            }

            ApplyFilter_SOA();
        }

        private void toolButtonOpen_SOA_Click(object sender, EventArgs e)
        {
            DoOpenFile_SOA();
        }

        private void toolButtonSave_SOA_Click(object sender, EventArgs e)
        {
            DoSaveFile_SOA(forceChoosePath: false);
        }

        private void toolButtonRefresh_SOA_Click(object sender, EventArgs e)
        {
            DoRefresh_SOA();
        }

        private void buttonFillDemo_SOA_Click(object sender, EventArgs e)
        {
            DoFillDemo_SOA();
        }

        private void buttonAdd_SOA_Click(object sender, EventArgs e)
        {
            DoAdd_SOA();
        }

        private void buttonDelete_SOA_Click(object sender, EventArgs e)
        {
            DoDelete_SOA();
        }

        private void buttonResetFilters_SOA_Click(object sender, EventArgs e)
        {
            DoResetFilters_SOA();
        }
    }
}