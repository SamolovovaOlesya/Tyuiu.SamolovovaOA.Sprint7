namespace Tyuiu.SamolovovaOA.Sprint7.Task7.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuMain_SOA = new MenuStrip();
            menuFile_SOA = new ToolStripMenuItem();
            menuItemOpen_SOA = new ToolStripMenuItem();
            menuItemSave_SOA = new ToolStripMenuItem();
            menuSeparator_SOA = new ToolStripSeparator();
            menuItemExit_SOA = new ToolStripMenuItem();
            menuHelp_SOA = new ToolStripMenuItem();
            menuItemHelp_SOA = new ToolStripMenuItem();
            menuItemAbout_SOA = new ToolStripMenuItem();
            toolStripButtonRefresh_SOA = new ToolStripMenuItem();
            statusStripMain_SOA = new StatusStrip();
            toolStripStatusLabelInfo_SOA = new ToolStripStatusLabel();
            panelProductsActions_SOA = new Panel();
            tableBottom_SOA = new TableLayoutPanel();
            flowLeft_SOA = new FlowLayoutPanel();
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
            splitContainer_SOA = new SplitContainer();
            dataGridViewProducts_SOA = new DataGridView();
            chartTotals_SOA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            openFileDialogProducts_SOA = new OpenFileDialog();
            saveFileDialogProducts_SOA = new SaveFileDialog();
            menuMain_SOA.SuspendLayout();
            statusStripMain_SOA.SuspendLayout();
            panelProductsActions_SOA.SuspendLayout();
            tableBottom_SOA.SuspendLayout();
            flowLeft_SOA.SuspendLayout();
            flowSearch_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_SOA).BeginInit();
            splitContainer_SOA.Panel1.SuspendLayout();
            splitContainer_SOA.Panel2.SuspendLayout();
            splitContainer_SOA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts_SOA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTotals_SOA).BeginInit();
            SuspendLayout();
            // 
            // menuMain_SOA
            // 
            menuMain_SOA.ImageScalingSize = new Size(24, 24);
            menuMain_SOA.Items.AddRange(new ToolStripItem[] { menuFile_SOA, menuHelp_SOA, toolStripButtonRefresh_SOA });
            menuMain_SOA.Location = new Point(0, 0);
            menuMain_SOA.Name = "menuMain_SOA";
            menuMain_SOA.Padding = new Padding(4, 1, 0, 1);
            menuMain_SOA.Size = new Size(1541, 31);
            menuMain_SOA.TabIndex = 7;
            // 
            // menuFile_SOA
            // 
            menuFile_SOA.DropDownItems.AddRange(new ToolStripItem[] { menuItemOpen_SOA, menuItemSave_SOA, menuSeparator_SOA, menuItemExit_SOA });
            menuFile_SOA.Name = "menuFile_SOA";
            menuFile_SOA.Size = new Size(69, 29);
            menuFile_SOA.Text = "Файл";
            // 
            // menuItemOpen_SOA
            // 
            menuItemOpen_SOA.Name = "menuItemOpen_SOA";
            menuItemOpen_SOA.Size = new Size(200, 34);
            menuItemOpen_SOA.Text = "Открыть";
            menuItemOpen_SOA.Click += menuItemOpen_SOA_Click;
            // 
            // menuItemSave_SOA
            // 
            menuItemSave_SOA.Name = "menuItemSave_SOA";
            menuItemSave_SOA.Size = new Size(200, 34);
            menuItemSave_SOA.Text = "Сохранить";
            menuItemSave_SOA.Click += menuItemSave_SOA_Click;
            // 
            // menuSeparator_SOA
            // 
            menuSeparator_SOA.Name = "menuSeparator_SOA";
            menuSeparator_SOA.Size = new Size(197, 6);
            // 
            // menuItemExit_SOA
            // 
            menuItemExit_SOA.Name = "menuItemExit_SOA";
            menuItemExit_SOA.Size = new Size(200, 34);
            menuItemExit_SOA.Text = "Выход";
            menuItemExit_SOA.Click += menuItemExit_SOA_Click;
            // 
            // menuHelp_SOA
            // 
            menuHelp_SOA.DropDownItems.AddRange(new ToolStripItem[] { menuItemHelp_SOA, menuItemAbout_SOA });
            menuHelp_SOA.Name = "menuHelp_SOA";
            menuHelp_SOA.Size = new Size(97, 29);
            menuHelp_SOA.Text = "Справка";
            // 
            // menuItemHelp_SOA
            // 
            menuItemHelp_SOA.Name = "menuItemHelp_SOA";
            menuItemHelp_SOA.Size = new Size(336, 34);
            menuItemHelp_SOA.Text = "Руководство пользователя";
            menuItemHelp_SOA.Click += menuItemHelp_SOA_Click;
            // 
            // menuItemAbout_SOA
            // 
            menuItemAbout_SOA.Name = "menuItemAbout_SOA";
            menuItemAbout_SOA.Size = new Size(336, 34);
            menuItemAbout_SOA.Text = "О программе";
            menuItemAbout_SOA.Click += menuItemAbout_SOA_Click;
            // 
            // toolStripButtonRefresh_SOA
            // 
            toolStripButtonRefresh_SOA.Name = "toolStripButtonRefresh_SOA";
            toolStripButtonRefresh_SOA.Size = new Size(109, 29);
            toolStripButtonRefresh_SOA.Text = "Обновить";
            toolStripButtonRefresh_SOA.Click += toolStripButtonRefresh_SOA_Click;
            // 
            // statusStripMain_SOA
            // 
            statusStripMain_SOA.ImageScalingSize = new Size(24, 24);
            statusStripMain_SOA.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo_SOA });
            statusStripMain_SOA.Location = new Point(0, 875);
            statusStripMain_SOA.Name = "statusStripMain_SOA";
            statusStripMain_SOA.Padding = new Padding(1, 0, 10, 0);
            statusStripMain_SOA.Size = new Size(1541, 32);
            statusStripMain_SOA.TabIndex = 8;
            // 
            // toolStripStatusLabelInfo_SOA
            // 
            toolStripStatusLabelInfo_SOA.Name = "toolStripStatusLabelInfo_SOA";
            toolStripStatusLabelInfo_SOA.Size = new Size(70, 25);
            toolStripStatusLabelInfo_SOA.Text = "Готово";
            // 
            // panelProductsActions_SOA
            // 
            panelProductsActions_SOA.Controls.Add(tableBottom_SOA);
            panelProductsActions_SOA.Dock = DockStyle.Bottom;
            panelProductsActions_SOA.Location = new Point(0, 821);
            panelProductsActions_SOA.Margin = new Padding(2);
            panelProductsActions_SOA.Name = "panelProductsActions_SOA";
            panelProductsActions_SOA.Padding = new Padding(7, 6, 7, 6);
            panelProductsActions_SOA.Size = new Size(1541, 54);
            panelProductsActions_SOA.TabIndex = 9;
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
            tableBottom_SOA.Size = new Size(1527, 42);
            tableBottom_SOA.TabIndex = 0;
            // 
            // flowLeft_SOA
            // 
            flowLeft_SOA.Controls.Add(buttonAdd_SOA);
            flowLeft_SOA.Controls.Add(buttonDelete_SOA);
            flowLeft_SOA.Controls.Add(labelFound_SOA);
            flowLeft_SOA.Dock = DockStyle.Fill;
            flowLeft_SOA.Location = new Point(2, 2);
            flowLeft_SOA.Margin = new Padding(2);
            flowLeft_SOA.Name = "flowLeft_SOA";
            flowLeft_SOA.Size = new Size(606, 38);
            flowLeft_SOA.TabIndex = 0;
            flowLeft_SOA.WrapContents = false;
            // 
            // buttonAdd_SOA
            // 
            buttonAdd_SOA.Location = new Point(0, 0);
            buttonAdd_SOA.Margin = new Padding(0, 0, 7, 0);
            buttonAdd_SOA.Name = "buttonAdd_SOA";
            buttonAdd_SOA.Size = new Size(101, 38);
            buttonAdd_SOA.TabIndex = 1;
            buttonAdd_SOA.Text = "Добавить";
            buttonAdd_SOA.UseVisualStyleBackColor = true;
            buttonAdd_SOA.Click += buttonAdd_SOA_Click;
            // 
            // buttonDelete_SOA
            // 
            buttonDelete_SOA.Location = new Point(108, 0);
            buttonDelete_SOA.Margin = new Padding(0, 0, 7, 0);
            buttonDelete_SOA.Name = "buttonDelete_SOA";
            buttonDelete_SOA.Size = new Size(87, 38);
            buttonDelete_SOA.TabIndex = 2;
            buttonDelete_SOA.Text = "Удалить";
            buttonDelete_SOA.UseVisualStyleBackColor = true;
            buttonDelete_SOA.Click += buttonDelete_SOA_Click;
            // 
            // labelFound_SOA
            // 
            labelFound_SOA.AutoSize = true;
            labelFound_SOA.Location = new Point(204, 0);
            labelFound_SOA.Margin = new Padding(2, 0, 2, 0);
            labelFound_SOA.Name = "labelFound_SOA";
            labelFound_SOA.Padding = new Padding(7, 4, 0, 0);
            labelFound_SOA.Size = new Size(148, 29);
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
            flowSearch_SOA.Location = new Point(612, 2);
            flowSearch_SOA.Margin = new Padding(2);
            flowSearch_SOA.Name = "flowSearch_SOA";
            flowSearch_SOA.Size = new Size(913, 38);
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
            labelSearch_SOA.Size = new Size(71, 29);
            labelSearch_SOA.TabIndex = 0;
            labelSearch_SOA.Text = "Поиск:";
            // 
            // textBoxSearch_SOA
            // 
            textBoxSearch_SOA.Location = new Point(75, 2);
            textBoxSearch_SOA.Margin = new Padding(0, 2, 7, 0);
            textBoxSearch_SOA.Name = "textBoxSearch_SOA";
            textBoxSearch_SOA.Size = new Size(127, 31);
            textBoxSearch_SOA.TabIndex = 1;
            textBoxSearch_SOA.TextChanged += textBoxSearch_SOA_TextChanged;
            // 
            // checkBoxInStock_SOA
            // 
            checkBoxInStock_SOA.AutoSize = true;
            checkBoxInStock_SOA.Location = new Point(209, 0);
            checkBoxInStock_SOA.Margin = new Padding(0, 0, 7, 0);
            checkBoxInStock_SOA.Name = "checkBoxInStock_SOA";
            checkBoxInStock_SOA.Padding = new Padding(0, 3, 0, 0);
            checkBoxInStock_SOA.Size = new Size(121, 32);
            checkBoxInStock_SOA.TabIndex = 2;
            checkBoxInStock_SOA.Text = "В наличии";
            checkBoxInStock_SOA.UseVisualStyleBackColor = true;
            checkBoxInStock_SOA.CheckedChanged += checkBoxInStock_SOA_CheckedChanged;
            // 
            // buttonResetFilters_SOA
            // 
            buttonResetFilters_SOA.Location = new Point(337, 1);
            buttonResetFilters_SOA.Margin = new Padding(0, 1, 8, 0);
            buttonResetFilters_SOA.Name = "buttonResetFilters_SOA";
            buttonResetFilters_SOA.Size = new Size(80, 37);
            buttonResetFilters_SOA.TabIndex = 3;
            buttonResetFilters_SOA.Text = "Сброс";
            buttonResetFilters_SOA.UseVisualStyleBackColor = true;
            buttonResetFilters_SOA.Click += buttonResetFilters_SOA_Click;
            // 
            // labelSort_SOA
            // 
            labelSort_SOA.AutoSize = true;
            labelSort_SOA.Location = new Point(427, 0);
            labelSort_SOA.Margin = new Padding(2, 0, 2, 0);
            labelSort_SOA.Name = "labelSort_SOA";
            labelSort_SOA.Padding = new Padding(0, 4, 4, 0);
            labelSort_SOA.Size = new Size(64, 29);
            labelSort_SOA.TabIndex = 4;
            labelSort_SOA.Text = "Сорт.:";
            // 
            // comboBoxSort_SOA
            // 
            comboBoxSort_SOA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort_SOA.Items.AddRange(new object[] { "Без сортировки", "Код (A-Z)", "Код (Z-A)", "Цена ↑", "Цена ↓", "Количество ↑", "Количество ↓", "Сумма ↑", "Сумма ↓" });
            comboBoxSort_SOA.Location = new Point(493, 1);
            comboBoxSort_SOA.Margin = new Padding(0, 1, 0, 0);
            comboBoxSort_SOA.Name = "comboBoxSort_SOA";
            comboBoxSort_SOA.Size = new Size(169, 33);
            comboBoxSort_SOA.TabIndex = 5;
            // 
            // splitContainer_SOA
            // 
            splitContainer_SOA.Dock = DockStyle.Fill;
            splitContainer_SOA.Location = new Point(0, 31);
            splitContainer_SOA.Name = "splitContainer_SOA";
            // 
            // splitContainer_SOA.Panel1
            // 
            splitContainer_SOA.Panel1.Controls.Add(dataGridViewProducts_SOA);
            // 
            // splitContainer_SOA.Panel2
            // 
            splitContainer_SOA.Panel2.Controls.Add(chartTotals_SOA);
            splitContainer_SOA.Size = new Size(1541, 790);
            splitContainer_SOA.SplitterDistance = 904;
            splitContainer_SOA.TabIndex = 10;
            // 
            // dataGridViewProducts_SOA
            // 
            dataGridViewProducts_SOA.AllowUserToAddRows = false;
            dataGridViewProducts_SOA.AllowUserToResizeRows = false;
            dataGridViewProducts_SOA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts_SOA.BackgroundColor = SystemColors.Window;
            dataGridViewProducts_SOA.BorderStyle = BorderStyle.None;
            dataGridViewProducts_SOA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProducts_SOA.ColumnHeadersHeight = 34;
            dataGridViewProducts_SOA.Dock = DockStyle.Fill;
            dataGridViewProducts_SOA.Location = new Point(0, 0);
            dataGridViewProducts_SOA.Margin = new Padding(2);
            dataGridViewProducts_SOA.MultiSelect = false;
            dataGridViewProducts_SOA.Name = "dataGridViewProducts_SOA";
            dataGridViewProducts_SOA.RowHeadersVisible = false;
            dataGridViewProducts_SOA.RowHeadersWidth = 62;
            dataGridViewProducts_SOA.RowTemplate.Height = 22;
            dataGridViewProducts_SOA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts_SOA.Size = new Size(904, 790);
            dataGridViewProducts_SOA.TabIndex = 1;
            dataGridViewProducts_SOA.CellEndEdit += dataGridViewProducts_SOA_CellEndEdit;
            // 
            // chartTotals_SOA
            // 
            chartArea1.Name = "ChartArea1";
            chartTotals_SOA.ChartAreas.Add(chartArea1);
            chartTotals_SOA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartTotals_SOA.Legends.Add(legend1);
            chartTotals_SOA.Location = new Point(0, 0);
            chartTotals_SOA.Name = "chartTotals_SOA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTotals_SOA.Series.Add(series1);
            chartTotals_SOA.Size = new Size(633, 790);
            chartTotals_SOA.TabIndex = 0;
            chartTotals_SOA.Text = "chart1";
            // 
            // openFileDialogProducts_SOA
            // 
            openFileDialogProducts_SOA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 907);
            Controls.Add(splitContainer_SOA);
            Controls.Add(panelProductsActions_SOA);
            Controls.Add(statusStripMain_SOA);
            Controls.Add(menuMain_SOA);
            Name = "FormMain";
            Text = "Спринт 7 | Таск 7 | Вариант 5 | Самоловова О.А.";
            WindowState = FormWindowState.Maximized;
            menuMain_SOA.ResumeLayout(false);
            menuMain_SOA.PerformLayout();
            statusStripMain_SOA.ResumeLayout(false);
            statusStripMain_SOA.PerformLayout();
            panelProductsActions_SOA.ResumeLayout(false);
            tableBottom_SOA.ResumeLayout(false);
            flowLeft_SOA.ResumeLayout(false);
            flowLeft_SOA.PerformLayout();
            flowSearch_SOA.ResumeLayout(false);
            flowSearch_SOA.PerformLayout();
            splitContainer_SOA.Panel1.ResumeLayout(false);
            splitContainer_SOA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_SOA).EndInit();
            splitContainer_SOA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts_SOA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTotals_SOA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuMain_SOA;
        private ToolStripMenuItem menuFile_SOA;
        private ToolStripMenuItem menuItemOpen_SOA;
        private ToolStripMenuItem menuItemSave_SOA;
        private ToolStripSeparator menuSeparator_SOA;
        private ToolStripMenuItem menuItemExit_SOA;
        private ToolStripMenuItem menuHelp_SOA;
        private ToolStripMenuItem menuItemHelp_SOA;
        private ToolStripMenuItem menuItemAbout_SOA;
        private StatusStrip statusStripMain_SOA;
        private ToolStripStatusLabel toolStripStatusLabelInfo_SOA;
        private Panel panelProductsActions_SOA;
        private TableLayoutPanel tableBottom_SOA;
        private FlowLayoutPanel flowLeft_SOA;
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
        private SplitContainer splitContainer_SOA;
        private DataGridView dataGridViewProducts_SOA;
        private ToolStripMenuItem toolStripButtonRefresh_SOA;
        private OpenFileDialog openFileDialogProducts_SOA;
        private SaveFileDialog saveFileDialogProducts_SOA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotals_SOA;
    }
}
