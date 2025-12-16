using System.ComponentModel;
using Tyuiu.SamolovovaOA.Sprint7.Project.V5.Lib;
namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5
{
    public partial class FormMain : Form

    {
        private BindingList<DataService.Product> products_SOA = new BindingList<DataService.Product>();
        private BindingSource productsSource_SOA = new BindingSource();
        private DataService dataService_SOA = new DataService();
        public FormMain()
        {
            InitializeComponent(); 

            Text = "Оптовая база — управление товарами";
            toolStripStatusLabelInfo_SOA.Text = "Готово";  
        }

        private void menuItemExit_SOA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemAbout_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Оптовая база (Sprint 7)\n" +
                "Хранение данных в CSV\n\n" +
                "Разработчик: SOA",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void menuItemHelp_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Приложение предназначено для управления товарами оптовой базы.\n\n" +
                "Функции будут добавляться поэтапно.",
                "Руководство пользователя",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void toolButtonOpen_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открытие CSV будет реализовано позже.");
        }

        private void toolButtonSave_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранение CSV будет реализовано позже.");
        }

        private void toolButtonRefresh_SOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обновление данных будет реализовано позже.");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupProductsGrid_SOA();

            productsSource_SOA.DataSource = products_SOA;
            dataGridViewProducts_SOA.DataSource = productsSource_SOA;

            toolStripStatusLabelInfo_SOA.Text = "Таблица товаров готова";
        }

        private void SetupProductsGrid_SOA()
        {
            dataGridViewProducts_SOA.AutoGenerateColumns = false;
            dataGridViewProducts_SOA.Columns.Clear();

            dataGridViewProducts_SOA.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columnProductCode_SOA",
                HeaderText = "Код",
                DataPropertyName = nameof(DataService.Product.ProductCode),
                Width = 90
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
                Width = 110
            });
        }

        private void buttonFillDemo_SOA_Click(object sender, EventArgs e)
        {
            products_SOA.Clear();

            foreach (var p in dataService_SOA.GetDemoProducts())
            {
                products_SOA.Add(p);
            }

            toolStripStatusLabelInfo_SOA.Text = "Загружены демонстрационные данные";
        }
    }
}

