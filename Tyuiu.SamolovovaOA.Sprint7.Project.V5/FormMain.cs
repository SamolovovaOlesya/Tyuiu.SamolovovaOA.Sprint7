using System;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using Tyuiu.SamolovovaOA.Sprint7.Project.V5.Lib;

namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        // Полный список (сохраняем в CSV именно его)
        private List<DataService.Product> productsAll_SOA = new();

        // То, что показываем в таблице (может быть отфильтровано)
        private BindingList<DataService.Product> productsView_SOA = new();
        private BindingSource productsSource_SOA = new();

        private DataService dataService_SOA = new();
        private string currentFilePath_SOA = string.Empty;

        public FormMain()
        {
            InitializeComponent();
            Text = "Оптовая база — управление товарами";
            toolStripStatusLabelInfo_SOA.Text = "Готово";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupProductsGrid_SOA();

            productsSource_SOA.DataSource = productsView_SOA;
            dataGridViewProducts_SOA.DataSource = productsSource_SOA;

            // Редактирование
            dataGridViewProducts_SOA.ReadOnly = false;
            dataGridViewProducts_SOA.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dataGridViewProducts_SOA.AllowUserToAddRows = false;
            dataGridViewProducts_SOA.AllowUserToDeleteRows = false;

            // Автоперерисовка суммы + защита ввода
            dataGridViewProducts_SOA.CellValueChanged += dataGridViewProducts_SOA_CellValueChanged;
            dataGridViewProducts_SOA.CellEndEdit += dataGridViewProducts_SOA_CellEndEdit;
            dataGridViewProducts_SOA.DataError += dataGridViewProducts_SOA_DataError;

            // Поиск/фильтр
            textBoxSearch_SOA.TextChanged += (s, ev) => ApplyFilter_SOA();
            checkBoxInStock_SOA.CheckedChanged += (s, ev) => ApplyFilter_SOA();

            ApplyFilter_SOA();
        }

        // ===== ОТКРЫТЬ =====
        private void toolButtonOpen_SOA_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new()
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Открыть CSV"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            currentFilePath_SOA = ofd.FileName;

            productsAll_SOA = dataService_SOA.LoadFromCsv(currentFilePath_SOA);
            ApplyFilter_SOA();

            toolStripStatusLabelInfo_SOA.Text =
                $"Открыт файл: {Path.GetFileName(currentFilePath_SOA)} (записей: {productsAll_SOA.Count})";
        }

        // ===== СОХРАНИТЬ =====
        private void toolButtonSave_SOA_Click(object sender, EventArgs e)
        {
            dataGridViewProducts_SOA.EndEdit();
            productsSource_SOA.EndEdit();

            if (productsAll_SOA == null || productsAll_SOA.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения.", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(currentFilePath_SOA))
            {
                using SaveFileDialog sfd = new()
                {
                    Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                    Title = "Сохранить CSV",
                    FileName = "products.csv"
                };

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                currentFilePath_SOA = sfd.FileName;
            }

            dataService_SOA.SaveToCsv(currentFilePath_SOA, productsAll_SOA);

            toolStripStatusLabelInfo_SOA.Text =
                $"Сохранено: {Path.GetFileName(currentFilePath_SOA)} (записей: {productsAll_SOA.Count})";
        }

        // ===== ОБНОВИТЬ =====
        private void toolButtonRefresh_SOA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentFilePath_SOA) || !File.Exists(currentFilePath_SOA))
            {
                MessageBox.Show("Сначала открой CSV файл.", "Обновить",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            productsAll_SOA = dataService_SOA.LoadFromCsv(currentFilePath_SOA);
            ApplyFilter_SOA();

            toolStripStatusLabelInfo_SOA.Text =
                $"Обновлено: {Path.GetFileName(currentFilePath_SOA)} (записей: {productsAll_SOA.Count})";
        }

        // ===== ДЕМО =====
        private void buttonFillDemo_SOA_Click(object sender, EventArgs e)
        {
            productsAll_SOA = dataService_SOA.GetDemoProducts().ToList();
            currentFilePath_SOA = string.Empty;

            textBoxSearch_SOA.Text = "";
            checkBoxInStock_SOA.Checked = false;

            ApplyFilter_SOA();
            toolStripStatusLabelInfo_SOA.Text = "Загружены демонстрационные данные";
        }

        // ===== ДОБАВИТЬ =====
        private void buttonAdd_SOA_Click(object sender, EventArgs e)
        {
            dataGridViewProducts_SOA.EndEdit();
            productsSource_SOA.EndEdit();

            string nextCode = GetNextProductCode_SOA();

            var newProduct = new DataService.Product
            {
                ProductCode = nextCode,
                ProductName = "Новый товар",
                Quantity = 1,
                UnitPrice = 0,
                Notes = ""
            };

            productsAll_SOA.Add(newProduct);
            ApplyFilter_SOA();
            SelectProductInGrid_SOA(newProduct);

            toolStripStatusLabelInfo_SOA.Text = $"Добавлен товар: {nextCode} (не забудьте сохранить)";
        }

        // ===== УДАЛИТЬ =====
        private void buttonDelete_SOA_Click(object sender, EventArgs e)
        {
            dataGridViewProducts_SOA.EndEdit();
            productsSource_SOA.EndEdit();

            if (dataGridViewProducts_SOA.CurrentRow == null ||
                dataGridViewProducts_SOA.CurrentRow.DataBoundItem is not DataService.Product p)
            {
                MessageBox.Show("Выберите строку для удаления.", "Удаление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"Удалить товар {p.ProductCode} — {p.ProductName}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            productsAll_SOA.Remove(p);
            ApplyFilter_SOA();

            toolStripStatusLabelInfo_SOA.Text = $"Удалено: {p.ProductCode} (не забудьте сохранить)";
        }

        // ===== СБРОС =====
        private void buttonResetFilters_SOA_Click(object sender, EventArgs e)
        {
            textBoxSearch_SOA.Text = "";
            checkBoxInStock_SOA.Checked = false;
            ApplyFilter_SOA();
        }

        // ===== МЕНЮ =====
        private void menuItemExit_SOA_Click(object sender, EventArgs e) => Close();

        private void menuItemAbout_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Оптовая база (Sprint 7)\nХранение данных в CSV\n\nРазработчик: SOA",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuItemHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Открыть — загрузить CSV\nСохранить — записать CSV\nОбновить — перечитать файл\n" +
                "Демо — тестовые данные\nДобавить/Удалить — работа со строками\n" +
                "Поиск + В наличии — фильтрация",
                "Руководство пользователя",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ===== ТАБЛИЦА =====
        private void SetupProductsGrid_SOA()
        {
            dataGridViewProducts_SOA.AutoGenerateColumns = false;
            dataGridViewProducts_SOA.Columns.Clear();

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columnProductCode_SOA",
                HeaderText = "Код",
                DataPropertyName = nameof(DataService.Product.ProductCode),
                Width = 90,
                ReadOnly = true
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columnProductName_SOA",
                HeaderText = "Название",
                DataPropertyName = nameof(DataService.Product.ProductName),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 200
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columnQuantity_SOA",
                HeaderText = "Кол-во",
                DataPropertyName = nameof(DataService.Product.Quantity),
                Width = 80
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columnUnitPrice_SOA",
                HeaderText = "Цена",
                DataPropertyName = nameof(DataService.Product.UnitPrice),
                Width = 90
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columnNotes_SOA",
                HeaderText = "Примечание",
                DataPropertyName = nameof(DataService.Product.Notes),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 200
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columnTotalValue_SOA",
                HeaderText = "Сумма",
                DataPropertyName = nameof(DataService.Product.TotalValue),
                Width = 110,
                ReadOnly = true
            });
        }

        // ===== ФИЛЬТР =====
        private void ApplyFilter_SOA()
        {
            IEnumerable<DataService.Product> query = productsAll_SOA;

            string q = (textBoxSearch_SOA.Text ?? "").Trim();
            if (!string.IsNullOrWhiteSpace(q))
            {
                query = query.Where(p =>
                    (p.ProductCode ?? "").Contains(q, StringComparison.OrdinalIgnoreCase) ||
                    (p.ProductName ?? "").Contains(q, StringComparison.OrdinalIgnoreCase));
            }

            if (checkBoxInStock_SOA.Checked)
                query = query.Where(p => p.Quantity > 0);

            var filtered = query.ToList();

            productsView_SOA = new BindingList<DataService.Product>(filtered);
            productsSource_SOA.DataSource = productsView_SOA;
            productsSource_SOA.ResetBindings(false);

            labelFound_SOA.Text = $"Найдено: {filtered.Count} из {productsAll_SOA.Count}";
        }

        private void SelectProductInGrid_SOA(DataService.Product product)
        {
            for (int i = 0; i < dataGridViewProducts_SOA.Rows.Count; i++)
            {
                if (dataGridViewProducts_SOA.Rows[i].DataBoundItem == product)
                {
                    dataGridViewProducts_SOA.ClearSelection();
                    dataGridViewProducts_SOA.Rows[i].Selected = true;
                    dataGridViewProducts_SOA.CurrentCell = dataGridViewProducts_SOA.Rows[i].Cells[1];
                    dataGridViewProducts_SOA.FirstDisplayedScrollingRowIndex = i;
                    break;
                }
            }
        }

        // ===== АВТОСУММА/ОШИБКИ =====
        private void dataGridViewProducts_SOA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            productsSource_SOA.ResetBindings(false);
        }

        private void dataGridViewProducts_SOA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            productsSource_SOA.EndEdit();
            productsSource_SOA.ResetBindings(false);
            toolStripStatusLabelInfo_SOA.Text = "Изменения внесены (не забудьте сохранить)";
        }

        private void dataGridViewProducts_SOA_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(
                "Некорректное значение. Проверьте ввод числа (кол-во или цена).",
                "Ошибка ввода",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            e.ThrowException = false;
        }

        // ===== КОД A01, A02... =====
        private string GetNextProductCode_SOA()
        {
            int max = 0;

            foreach (var p in productsAll_SOA)
            {
                string code = p?.ProductCode?.Trim() ?? "";
                if (code.Length < 2) continue;
                if (code[0] != 'A' && code[0] != 'a') continue;

                if (int.TryParse(code.Substring(1), out int n))
                    if (n > max) max = n;
            }

            return "A" + (max + 1).ToString("00");
        }
    }
}