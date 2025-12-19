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
        private BindingList<DataService.Product> products_SOA = new();
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

            productsSource_SOA.DataSource = products_SOA;
            dataGridViewProducts_SOA.DataSource = productsSource_SOA;
            dataGridViewProducts_SOA.ReadOnly = false;
            dataGridViewProducts_SOA.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            dataGridViewProducts_SOA.AllowUserToAddRows = false;
            dataGridViewProducts_SOA.AllowUserToDeleteRows = false;

            toolStripStatusLabelInfo_SOA.Text = "Таблица товаров готова";
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

            var loaded = dataService_SOA.LoadFromCsv(currentFilePath_SOA);
            products_SOA = new BindingList<DataService.Product>(loaded);
            productsSource_SOA.DataSource = products_SOA;

            toolStripStatusLabelInfo_SOA.Text =
                $"Открыт файл: {Path.GetFileName(currentFilePath_SOA)} (записей: {loaded.Count})";
        }

        // ===== СОХРАНИТЬ =====
        private void toolButtonSave_SOA_Click(object sender, EventArgs e)
        {
            dataGridViewProducts_SOA.EndEdit();
            productsSource_SOA.EndEdit();

            if (products_SOA == null || products_SOA.Count == 0)
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

            dataService_SOA.SaveToCsv(currentFilePath_SOA, products_SOA.ToList());

            toolStripStatusLabelInfo_SOA.Text =
                $"Сохранено: {Path.GetFileName(currentFilePath_SOA)} (записей: {products_SOA.Count})";
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

            var loaded = dataService_SOA.LoadFromCsv(currentFilePath_SOA);
            products_SOA = new BindingList<DataService.Product>(loaded);
            productsSource_SOA.DataSource = products_SOA;

            toolStripStatusLabelInfo_SOA.Text =
                $"Обновлено: {Path.GetFileName(currentFilePath_SOA)} (записей: {loaded.Count})";
        }

        // ===== ДЕМО =====
        private void buttonFillDemo_SOA_Click(object sender, EventArgs e)
        {
            products_SOA.Clear();

            foreach (var p in dataService_SOA.GetDemoProducts())
                products_SOA.Add(p);

            currentFilePath_SOA = string.Empty;
            toolStripStatusLabelInfo_SOA.Text = "Загружены демонстрационные данные";
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
                "Приложение предназначено для управления товарами.\nРабота с CSV файлами.",
                "Руководство пользователя",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ===== ТАБЛИЦА =====
        private void SetupProductsGrid_SOA()
        {
            dataGridViewProducts_SOA.AutoGenerateColumns = false;
            dataGridViewProducts_SOA.AllowUserToAddRows = false;
            dataGridViewProducts_SOA.RowHeadersVisible = false;
            dataGridViewProducts_SOA.Columns.Clear();

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Код",
                DataPropertyName = nameof(DataService.Product.ProductCode),
                Width = 90
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Название",
                DataPropertyName = nameof(DataService.Product.ProductName),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 200
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
                HeaderText = "Примечание",
                DataPropertyName = nameof(DataService.Product.Notes),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 200
            });

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Сумма",
                DataPropertyName = nameof(DataService.Product.TotalValue),
                Width = 110,
                ReadOnly = true
            });
        }
    }
}