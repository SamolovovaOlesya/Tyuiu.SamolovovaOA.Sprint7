namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
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
    }
}

