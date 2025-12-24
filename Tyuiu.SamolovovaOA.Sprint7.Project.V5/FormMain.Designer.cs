using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuMain_SOA;
        private ToolStripMenuItem menuFile_SOA;
        private ToolStripMenuItem menuItemOpen_SOA;
        private ToolStripMenuItem menuItemSave_SOA;
        private ToolStripSeparator menuSeparator_SOA;
        private ToolStripMenuItem menuItemExit_SOA;
        private ToolStripMenuItem menuHelp_SOA;
        private ToolStripMenuItem menuItemHelp_SOA;
        private ToolStripMenuItem menuItemAbout_SOA;

        private ToolStrip toolStripMain_SOA;
        private ToolStripButton toolButtonOpen_SOA;
        private ToolStripButton toolButtonSave_SOA;
        private ToolStripButton toolButtonRefresh_SOA;

        private StatusStrip statusStripMain_SOA;
        private ToolStripStatusLabel toolStripStatusLabelInfo_SOA;

        private DataGridView dataGridViewProducts_SOA;

        private Panel panelProductsActions_SOA;
        private TableLayoutPanel tableBottom_SOA;

        private FlowLayoutPanel flowLeft_SOA;
        private Button buttonFillDemo_SOA;
        private Button buttonAdd_SOA;
        private Button buttonDelete_SOA;
        private Label labelFound_SOA;

        private FlowLayoutPanel flowSearch_SOA;
        private Label labelSearch_SOA;
        private TextBox textBoxSearch_SOA;
        private CheckBox checkBoxInStock_SOA;
        private Button buttonResetFilters_SOA;
        private Label labelSort_SOA;
        private ComboBox comboBoxSort_SOA;

        private Panel panelAnalytics_SOA;
        private Label labelStats_SOA;
        private Chart chartTotals_SOA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();

            menuMain_SOA = new MenuStrip();
            menuFile_SOA = new ToolStripMenuItem();
            menuItemOpen_SOA = new ToolStripMenuItem();
            menuItemSave_SOA = new ToolStripMenuItem();
            menuSeparator_SOA = new ToolStripSeparator();
            menuItemExit_SOA = new ToolStripMenuItem();
            menuHelp_SOA = new ToolStripMenuItem();
            menuItemHelp_SOA = new ToolStripMenuItem();
            menuItemAbout_SOA = new ToolStripMenuItem();

            toolStripMain_SOA = new ToolStrip();
            toolButtonOpen_SOA = new ToolStripButton();
            toolButtonSave_SOA = new ToolStripButton();
            toolButtonRefresh_SOA = new ToolStripButton();

            statusStripMain_SOA = new StatusStrip();
            toolStripStatusLabelInfo_SOA = new ToolStripStatusLabel();

            dataGridViewProducts_SOA = new DataGridView();

            panelAnalytics_SOA = new Panel();
            chartTotals_SOA = new Chart();
            labelStats_SOA = new Label();

            panelProductsActions_SOA = new Panel();
            tableBottom_SOA = new TableLayoutPanel();

            flowLeft_SOA = new FlowLayoutPanel();
            buttonFillDemo_SOA = new Button();
            buttonAdd_SOA = new Button();
            buttonDelete_SOA = new Button();
            labelFound_SOA = new Label();

            flowSearch_SOA = new FlowLayoutPanel();
            labelSearch_SOA = new Label();
            textBoxSearch_SOA = new TextBox();
            checkBoxInStock_SOA = new CheckBox();
            buttonResetFilters_SOA = new Button();
            labelSort_SOA = new Label();
            comboBoxSort_SOA = new ComboBox();

            menuMain_SOA.SuspendLayout();
            toolStripMain_SOA.SuspendLayout();
            statusStripMain_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts_SOA).BeginInit();
            panelAnalytics_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTotals_SOA).BeginInit();
            panelProductsActions_SOA.SuspendLayout();
            tableBottom_SOA.SuspendLayout();
            flowLeft_SOA.SuspendLayout();
            flowSearch_SOA.SuspendLayout();
            SuspendLayout();

            // 
            // menuMain_SOA
            // 
            menuMain_SOA.ImageScalingSize = new Size(24, 24);
            menuMain_SOA.Items.AddRange(new ToolStripItem[] { menuFile_SOA, menuHelp_SOA });
            menuMain_SOA.Location = new Point(0, 0);
            menuMain_SOA.Name = "menuMain_SOA";
            menuMain_SOA.Padding = new Padding(4, 1, 0, 1);
            menuMain_SOA.Size = new Size(1042, 24);
            menuMain_SOA.TabIndex = 5;

            // 
            // menuFile_SOA
            // 
            menuFile_SOA.DropDownItems.AddRange(new ToolStripItem[] { menuItemOpen_SOA, menuItemSave_SOA, menuSeparator_SOA, menuItemExit_SOA });
            menuFile_SOA.Name = "menuFile_SOA";
            menuFile_SOA.Size = new Size(48, 22);
            menuFile_SOA.Text = "Файл";

            // 
            // menuItemOpen_SOA
            // 
            menuItemOpen_SOA.Name = "menuItemOpen_SOA";
            menuItemOpen_SOA.Size = new Size(180, 22);
            menuItemOpen_SOA.Text = "Открыть";
            menuItemOpen_SOA.Click += toolButtonOpen_SOA_Click;

            // 
            // menuItemSave_SOA
            // 
            menuItemSave_SOA.Name = "menuItemSave_SOA";
            menuItemSave_SOA.Size = new Size(180, 22);
            menuItemSave_SOA.Text = "Сохранить";
            menuItemSave_SOA.Click += toolButtonSave_SOA_Click;

            // 
            // menuSeparator_SOA
            // 
            menuSeparator_SOA.Name = "menuSeparator_SOA";
            menuSeparator_SOA.Size = new Size(177, 6);

            // 
            // menuItemExit_SOA
            // 
            menuItemExit_SOA.Name = "menuItemExit_SOA";
            menuItemExit_SOA.Size = new Size(180, 22);
            menuItemExit_SOA.Text = "Выход";
            menuItemExit_SOA.Click += menuItemExit_SOA_Click;

            // 
            // menuHelp_SOA
            // 
            menuHelp_SOA.DropDownItems.AddRange(new ToolStripItem[] { menuItemHelp_SOA, menuItemAbout_SOA });
            menuHelp_SOA.Name = "menuHelp_SOA";
            menuHelp_SOA.Size = new Size(65, 22);
            menuHelp_SOA.Text = "Справка";

            // 
            // menuItemHelp_SOA
            // 
            menuItemHelp_SOA.Name = "menuItemHelp_SOA";
            menuItemHelp_SOA.Size = new Size(221, 22);
            menuItemHelp_SOA.Text = "Руководство пользователя";
            menuItemHelp_SOA.Click += menuItemHelp_SOA_Click;

            // 
            // menuItemAbout_SOA
            // 
            menuItemAbout_SOA.Name = "menuItemAbout_SOA";
            menuItemAbout_SOA.Size = new Size(221, 22);
            menuItemAbout_SOA.Text = "О программе";
            menuItemAbout_SOA.Click += menuItemAbout_SOA_Click;

            // 
            // toolStripMain_SOA
            // 
            toolStripMain_SOA.ImageScalingSize = new Size(24, 24);
            toolStripMain_SOA.Items.AddRange(new ToolStripItem[] { toolButtonOpen_SOA, toolButtonSave_SOA, toolButtonRefresh_SOA });
            toolStripMain_SOA.Location = new Point(0, 24);
            toolStripMain_SOA.Name = "toolStripMain_SOA";
            toolStripMain_SOA.Size = new Size(1042, 25);
            toolStripMain_SOA.TabIndex = 4;

            // 
            // toolButtonOpen_SOA
            // 
            toolButtonOpen_SOA.Name = "toolButtonOpen_SOA";
            toolButtonOpen_SOA.Size = new Size(58, 22);
            toolButtonOpen_SOA.Text = "Открыть";
            toolButtonOpen_SOA.Click += toolButtonOpen_SOA_Click;

            // 
            // toolButtonSave_SOA
            // 
            toolButtonSave_SOA.Name = "toolButtonSave_SOA";
            toolButtonSave_SOA.Size = new Size(69, 22);
            toolButtonSave_SOA.Text = "Сохранить";
            toolButtonSave_SOA.Click += toolButtonSave_SOA_Click;

            // 
            // toolButtonRefresh_SOA
            // 
            toolButtonRefresh_SOA.Name = "toolButtonRefresh_SOA";
            toolButtonRefresh_SOA.Size = new Size(65, 22);
            toolButtonRefresh_SOA.Text = "Обновить";
            toolButtonRefresh_SOA.Click += toolButtonRefresh_SOA_Click;

            // 
            // statusStripMain_SOA
            // 
            statusStripMain_SOA.ImageScalingSize = new Size(24, 24);
            statusStripMain_SOA.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo_SOA });
            statusStripMain_SOA.Location = new Point(0, 505);
            statusStripMain_SOA.Name = "statusStripMain_SOA";
            statusStripMain_SOA.Padding = new Padding(1, 0, 10, 0);
            statusStripMain_SOA.Size = new Size(1042, 22);
            statusStripMain_SOA.TabIndex = 3;

            // 
            // toolStripStatusLabelInfo_SOA
            // 
            toolStripStatusLabelInfo_SOA.Name = "toolStripStatusLabelInfo_SOA";
            toolStripStatusLabelInfo_SOA.Size = new Size(43, 17);
            toolStripStatusLabelInfo_SOA.Text = "Статус";

            // 
            // dataGridViewProducts_SOA
            // 
            dataGridViewProducts_SOA.AllowUserToAddRows = false;
            dataGridViewProducts_SOA.AllowUserToResizeRows = false;
            dataGridViewProducts_SOA.BackgroundColor = SystemColors.Window;
            dataGridViewProducts_SOA.BorderStyle = BorderStyle.None;
            dataGridViewProducts_SOA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProducts_SOA.ColumnHeadersHeight = 34;
            dataGridViewProducts_SOA.Dock = DockStyle.Fill;
            dataGridViewProducts_SOA.Location = new Point(0, 49);
            dataGridViewProducts_SOA.Margin = new Padding(2);
            dataGridViewProducts_SOA.MultiSelect = false;
            dataGridViewProducts_SOA.Name = "dataGridViewProducts_SOA";
            dataGridViewProducts_SOA.RowHeadersVisible = false;
            dataGridViewProducts_SOA.RowHeadersWidth = 62;
            dataGridViewProducts_SOA.RowTemplate.Height = 22;
            dataGridViewProducts_SOA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts_SOA.Size = new Size(517, 414);
            dataGridViewProducts_SOA.TabIndex = 0;

            // 
            // panelAnalytics_SOA
            // 
            panelAnalytics_SOA.Controls.Add(chartTotals_SOA);
            panelAnalytics_SOA.Controls.Add(labelStats_SOA);
            panelAnalytics_SOA.Dock = DockStyle.Right;
            panelAnalytics_SOA.Location = new Point(517, 49);
            panelAnalytics_SOA.Margin = new Padding(2);
            panelAnalytics_SOA.MaximumSize = new Size(630, 0);
            panelAnalytics_SOA.MinimumSize = new Size(455, 0);
            panelAnalytics_SOA.Name = "panelAnalytics_SOA";
            panelAnalytics_SOA.Padding = new Padding(10, 9, 10, 9);
            panelAnalytics_SOA.Size = new Size(525, 414);
            panelAnalytics_SOA.TabIndex = 1;

            // 
            // chartTotals_SOA
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            chartArea1.AxisX.LabelStyle.Format = "0";
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "Main";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 96F;
            chartArea1.Position.Width = 96F;
            chartArea1.Position.X = 2F;
            chartArea1.Position.Y = 2F;

            chartTotals_SOA.ChartAreas.Add(chartArea1);
            chartTotals_SOA.Dock = DockStyle.Fill;
            chartTotals_SOA.Location = new Point(10, 63);
            chartTotals_SOA.Margin = new Padding(2);
            chartTotals_SOA.Name = "chartTotals_SOA";
            chartTotals_SOA.Padding = new Padding(7, 6, 7, 6);

            series1.ChartArea = "Main";
            series1.Font = new Font("Segoe UI", 8F);
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "N0";
            series1.Name = "Сумма";
            series1.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.MinMovingDistance = 12D;
            series1.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Top;

            chartTotals_SOA.Series.Add(series1);
            chartTotals_SOA.Size = new Size(505, 342);
            chartTotals_SOA.TabIndex = 1;

            // 
            // labelStats_SOA
            // 
            labelStats_SOA.AutoEllipsis = true;
            labelStats_SOA.Dock = DockStyle.Top;
            labelStats_SOA.Location = new Point(10, 9);
            labelStats_SOA.Margin = new Padding(2, 0, 2, 0);
            labelStats_SOA.Name = "labelStats_SOA";
            labelStats_SOA.Size = new Size(505, 54);
            labelStats_SOA.TabIndex = 0;
            labelStats_SOA.Text = "Статистика: нет данных";

            // 
            // panelProductsActions_SOA
            // 
            panelProductsActions_SOA.Controls.Add(tableBottom_SOA);
            panelProductsActions_SOA.Dock = DockStyle.Bottom;
            panelProductsActions_SOA.Location = new Point(0, 463);
            panelProductsActions_SOA.Margin = new Padding(2);
            panelProductsActions_SOA.Name = "panelProductsActions_SOA";
            panelProductsActions_SOA.Padding = new Padding(7, 6, 7, 6);
            panelProductsActions_SOA.Size = new Size(1042, 42);
            panelProductsActions_SOA.TabIndex = 2;

            // 
            // tableBottom_SOA
            // 
            tableBottom_SOA.ColumnCount = 2;
            tableBottom_SOA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableBottom_SOA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableBottom_SOA.Controls.Add(flowLeft_SOA, 0, 0);
            tableBottom_SOA.Controls.Add(flowSearch_SOA, 1, 0);
            tableBottom_SOA.Dock = DockStyle.Fill;
            tableBottom_SOA.Location = new Point(7, 6);
            tableBottom_SOA.Margin = new Padding(2);
            tableBottom_SOA.Name = "tableBottom_SOA";
            tableBottom_SOA.RowCount = 1;
            tableBottom_SOA.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableBottom_SOA.Size = new Size(1028, 30);
            tableBottom_SOA.TabIndex = 0;

            // 
            // flowLeft_SOA
            // 
            flowLeft_SOA.Controls.Add(buttonFillDemo_SOA);
            flowLeft_SOA.Controls.Add(buttonAdd_SOA);
            flowLeft_SOA.Controls.Add(buttonDelete_SOA);
            flowLeft_SOA.Controls.Add(labelFound_SOA);
            flowLeft_SOA.Dock = DockStyle.Fill;
            flowLeft_SOA.Location = new Point(2, 2);
            flowLeft_SOA.Margin = new Padding(2);
            flowLeft_SOA.Name = "flowLeft_SOA";
            flowLeft_SOA.Size = new Size(407, 26);
            flowLeft_SOA.TabIndex = 0;
            flowLeft_SOA.WrapContents = false;

            // 
            // buttonFillDemo_SOA
            // 
            buttonFillDemo_SOA.Location = new Point(0, 0);
            buttonFillDemo_SOA.Margin = new Padding(0, 0, 7, 0);
            buttonFillDemo_SOA.Name = "buttonFillDemo_SOA";
            buttonFillDemo_SOA.Size = new Size(77, 22);
            buttonFillDemo_SOA.TabIndex = 0;
            buttonFillDemo_SOA.Text = "Демо";
            buttonFillDemo_SOA.UseVisualStyleBackColor = true;
            buttonFillDemo_SOA.Click += buttonFillDemo_SOA_Click;

            //
            // buttonAdd_SOA
            // 
            buttonAdd_SOA.Location = new Point(84, 0);
            buttonAdd_SOA.Margin = new Padding(0, 0, 7, 0);
            buttonAdd_SOA.Name = "buttonAdd_SOA";
            buttonAdd_SOA.Size = new Size(77, 22);
            buttonAdd_SOA.TabIndex = 1;
            buttonAdd_SOA.Text = "Добавить";
            buttonAdd_SOA.UseVisualStyleBackColor = true;
            buttonAdd_SOA.Click += buttonAdd_SOA_Click;

            // 
            // buttonDelete_SOA
            // 
            buttonDelete_SOA.Location = new Point(168, 0);
            buttonDelete_SOA.Margin = new Padding(0, 0, 7, 0);
            buttonDelete_SOA.Name = "buttonDelete_SOA";
            buttonDelete_SOA.Size = new Size(77, 22);
            buttonDelete_SOA.TabIndex = 2;
            buttonDelete_SOA.Text = "Удалить";
            buttonDelete_SOA.UseVisualStyleBackColor = true;
            buttonDelete_SOA.Click += buttonDelete_SOA_Click;

            // 
            // labelFound_SOA
            // 
            labelFound_SOA.AutoSize = true;
            labelFound_SOA.Location = new Point(254, 0);
            labelFound_SOA.Margin = new Padding(2, 0, 2, 0);
            labelFound_SOA.Name = "labelFound_SOA";
            labelFound_SOA.Padding = new Padding(7, 4, 0, 0);
            labelFound_SOA.Size = new Size(98, 19);
            labelFound_SOA.TabIndex = 3;
            labelFound_SOA.Text = "Найдено: 0 из 0";

            // 
            // flowSearch_SOA
            // 
            flowSearch_SOA.Controls.Add(labelSearch_SOA);
            flowSearch_SOA.Controls.Add(textBoxSearch_SOA);
            flowSearch_SOA.Controls.Add(checkBoxInStock_SOA);
            flowSearch_SOA.Controls.Add(buttonResetFilters_SOA);
            flowSearch_SOA.Controls.Add(labelSort_SOA);
            flowSearch_SOA.Controls.Add(comboBoxSort_SOA);
            flowSearch_SOA.Dock = DockStyle.Fill;
            flowSearch_SOA.Location = new Point(413, 2);
            flowSearch_SOA.Margin = new Padding(2);
            flowSearch_SOA.Name = "flowSearch_SOA";
            flowSearch_SOA.Size = new Size(613, 26);
            flowSearch_SOA.TabIndex = 1;
            flowSearch_SOA.WrapContents = false;

            // 
            // labelSearch_SOA
            // 
            labelSearch_SOA.AutoSize = true;
            labelSearch_SOA.Location = new Point(2, 0);
            labelSearch_SOA.Margin = new Padding(2, 0, 2, 0);
            labelSearch_SOA.Name = "labelSearch_SOA";
            labelSearch_SOA.Padding = new Padding(0, 4, 4, 0);
            labelSearch_SOA.Size = new Size(49, 19);
            labelSearch_SOA.TabIndex = 0;
            labelSearch_SOA.Text = "Поиск:";

            // 
            // textBoxSearch_SOA
            // 
            textBoxSearch_SOA.Location = new Point(53, 2);
            textBoxSearch_SOA.Margin = new Padding(0, 2, 7, 0);
            textBoxSearch_SOA.Name = "textBoxSearch_SOA";
            textBoxSearch_SOA.Size = new Size(127, 23);
            textBoxSearch_SOA.TabIndex = 1;

            // 
            // checkBoxInStock_SOA
            // 
            checkBoxInStock_SOA.AutoSize = true;
            checkBoxInStock_SOA.Location = new Point(187, 0);
            checkBoxInStock_SOA.Margin = new Padding(0, 0, 7, 0);
            checkBoxInStock_SOA.Name = "checkBoxInStock_SOA";
            checkBoxInStock_SOA.Padding = new Padding(0, 3, 0, 0);
            checkBoxInStock_SOA.Size = new Size(84, 22);
            checkBoxInStock_SOA.TabIndex = 2;
            checkBoxInStock_SOA.Text = "В наличии";
            checkBoxInStock_SOA.UseVisualStyleBackColor = true;

            // 
            // buttonResetFilters_SOA
            // 
            buttonResetFilters_SOA.Location = new Point(278, 1);
            buttonResetFilters_SOA.Margin = new Padding(0, 1, 8, 0);
            buttonResetFilters_SOA.Name = "buttonResetFilters_SOA";
            buttonResetFilters_SOA.Size = new Size(66, 21);
            buttonResetFilters_SOA.TabIndex = 3;
            buttonResetFilters_SOA.Text = "Сброс";
            buttonResetFilters_SOA.UseVisualStyleBackColor = true;
            buttonResetFilters_SOA.Click += buttonResetFilters_SOA_Click;

            // 
            // labelSort_SOA
            // 
            labelSort_SOA.AutoSize = true;
            labelSort_SOA.Location = new Point(354, 0);
            labelSort_SOA.Margin = new Padding(2, 0, 2, 0);
            labelSort_SOA.Name = "labelSort_SOA";
            labelSort_SOA.Padding = new Padding(0, 4, 4, 0);
            labelSort_SOA.Size = new Size(44, 19);
            labelSort_SOA.TabIndex = 4;
            labelSort_SOA.Text = "Сорт.:";

            // 
            // comboBoxSort_SOA
            // 
            comboBoxSort_SOA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort_SOA.Location = new Point(400, 1);
            comboBoxSort_SOA.Margin = new Padding(0, 1, 0, 0);
            comboBoxSort_SOA.Name = "comboBoxSort_SOA";
            comboBoxSort_SOA.Size = new Size(141, 23);
            comboBoxSort_SOA.TabIndex = 5;

            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 527);
            Controls.Add(dataGridViewProducts_SOA);
            Controls.Add(panelAnalytics_SOA);
            Controls.Add(panelProductsActions_SOA);
            Controls.Add(statusStripMain_SOA);
            Controls.Add(toolStripMain_SOA);
            Controls.Add(menuMain_SOA);
            MainMenuStrip = menuMain_SOA;
            Margin = new Padding(2);
            MinimumSize = new Size(775, 376);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оптовая база";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;

            menuMain_SOA.ResumeLayout(false);
            menuMain_SOA.PerformLayout();
            toolStripMain_SOA.ResumeLayout(false);
            toolStripMain_SOA.PerformLayout();
            statusStripMain_SOA.ResumeLayout(false);
            statusStripMain_SOA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts_SOA).EndInit();
            panelAnalytics_SOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTotals_SOA).EndInit();
            panelProductsActions_SOA.ResumeLayout(false);
            tableBottom_SOA.ResumeLayout(false);
            flowLeft_SOA.ResumeLayout(false);
            flowLeft_SOA.PerformLayout();
            flowSearch_SOA.ResumeLayout(false);
            flowSearch_SOA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}