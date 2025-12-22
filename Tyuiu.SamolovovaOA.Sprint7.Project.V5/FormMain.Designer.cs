namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        #endregion
        // Menu
        private MenuStrip menuMain_SOA;
        private ToolStripMenuItem menuFile_SOA;
        private ToolStripMenuItem menuItemOpen_SOA;
        private ToolStripMenuItem menuItemSave_SOA;
        private ToolStripSeparator menuSeparator_SOA;
        private ToolStripMenuItem menuItemExit_SOA;

        private ToolStripMenuItem menuHelp_SOA;
        private ToolStripMenuItem menuItemHelp_SOA;
        private ToolStripMenuItem menuItemAbout_SOA;

        // Toolbar
        private ToolStrip toolStripMain_SOA;
        private ToolStripButton toolButtonOpen_SOA;
        private ToolStripButton toolButtonSave_SOA;
        private ToolStripButton toolButtonRefresh_SOA;

        // Status
        private StatusStrip statusStripMain_SOA;
        private ToolStripStatusLabel toolStripStatusLabelInfo_SOA;

        // Grid
        private DataGridView dataGridViewProducts_SOA;

        // Bottom panel layout
        private Panel panelProductsActions_SOA;
        private TableLayoutPanel tableBottom_SOA;

        // Left group (buttons + found label)
        private FlowLayoutPanel flowLeft_SOA;
        private Button buttonFillDemo_SOA;
        private Button buttonAdd_SOA;
        private Button buttonDelete_SOA;
        private Label labelFound_SOA;

        // Right group (search)
        private FlowLayoutPanel flowSearch_SOA;
        private Label labelSearch_SOA;
        private TextBox textBoxSearch_SOA;
        private CheckBox checkBoxInStock_SOA;
        private Button buttonResetFilters_SOA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // ===== MENU =====
            menuMain_SOA = new MenuStrip();
            menuFile_SOA = new ToolStripMenuItem();
            menuItemOpen_SOA = new ToolStripMenuItem();
            menuItemSave_SOA = new ToolStripMenuItem();
            menuSeparator_SOA = new ToolStripSeparator();
            menuItemExit_SOA = new ToolStripMenuItem();

            menuHelp_SOA = new ToolStripMenuItem();
            menuItemHelp_SOA = new ToolStripMenuItem();
            menuItemAbout_SOA = new ToolStripMenuItem();

            menuMain_SOA.Items.AddRange(new ToolStripItem[] { menuFile_SOA, menuHelp_SOA });

            menuFile_SOA.Text = "Файл";
            menuFile_SOA.DropDownItems.AddRange(new ToolStripItem[]
            {
                menuItemOpen_SOA,
                menuItemSave_SOA,
                menuSeparator_SOA,
                menuItemExit_SOA
            });

            menuItemOpen_SOA.Text = "Открыть";
            menuItemOpen_SOA.Click += toolButtonOpen_SOA_Click;

            menuItemSave_SOA.Text = "Сохранить";
            menuItemSave_SOA.Click += toolButtonSave_SOA_Click;

            menuItemExit_SOA.Text = "Выход";
            menuItemExit_SOA.Click += menuItemExit_SOA_Click;

            menuHelp_SOA.Text = "Справка";
            menuHelp_SOA.DropDownItems.AddRange(new ToolStripItem[] { menuItemHelp_SOA, menuItemAbout_SOA });

            menuItemHelp_SOA.Text = "Руководство пользователя";
            menuItemHelp_SOA.Click += menuItemHelp_SOA_Click;

            menuItemAbout_SOA.Text = "О программе";
            menuItemAbout_SOA.Click += menuItemAbout_SOA_Click;

            menuMain_SOA.Dock = DockStyle.Top;

            // ===== TOOLSTRIP =====
            toolStripMain_SOA = new ToolStrip();
            toolButtonOpen_SOA = new ToolStripButton();
            toolButtonSave_SOA = new ToolStripButton();
            toolButtonRefresh_SOA = new ToolStripButton();

            toolStripMain_SOA.Items.AddRange(new ToolStripItem[]
            { toolButtonOpen_SOA,
                toolButtonSave_SOA,
                toolButtonRefresh_SOA
            });

            toolButtonOpen_SOA.Text = "Открыть";
            toolButtonOpen_SOA.Click += toolButtonOpen_SOA_Click;

            toolButtonSave_SOA.Text = "Сохранить";
            toolButtonSave_SOA.Click += toolButtonSave_SOA_Click;

            toolButtonRefresh_SOA.Text = "Обновить";
            toolButtonRefresh_SOA.Click += toolButtonRefresh_SOA_Click;

            toolStripMain_SOA.Dock = DockStyle.Top;

            // ===== STATUSSTRIP =====
            statusStripMain_SOA = new StatusStrip();
            toolStripStatusLabelInfo_SOA = new ToolStripStatusLabel();
            toolStripStatusLabelInfo_SOA.Text = "Статус";
            statusStripMain_SOA.Items.Add(toolStripStatusLabelInfo_SOA);
            statusStripMain_SOA.Dock = DockStyle.Bottom;

            // ===== GRID =====
            dataGridViewProducts_SOA = new DataGridView();
            dataGridViewProducts_SOA.Name = "dataGridViewProducts_SOA";
            dataGridViewProducts_SOA.Dock = DockStyle.Fill;
            dataGridViewProducts_SOA.MultiSelect = false;
            dataGridViewProducts_SOA.RowHeadersVisible = false;
            dataGridViewProducts_SOA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewProducts_SOA.AllowUserToAddRows = false;
            dataGridViewProducts_SOA.AllowUserToResizeRows = false;
            dataGridViewProducts_SOA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewProducts_SOA.RowTemplate.Height = 22;
            dataGridViewProducts_SOA.BorderStyle = BorderStyle.None;
            dataGridViewProducts_SOA.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProducts_SOA.BackgroundColor = SystemColors.Window;

            // ===== BOTTOM PANEL =====
            panelProductsActions_SOA = new Panel();
            panelProductsActions_SOA.Name = "panelProductsActions_SOA";
            panelProductsActions_SOA.Dock = DockStyle.Bottom;
            panelProductsActions_SOA.Height = 60;
            panelProductsActions_SOA.Padding = new Padding(10, 10, 10, 10);

            // Table layout: 2 columns (left / right)
            tableBottom_SOA = new TableLayoutPanel();
            tableBottom_SOA.Name = "tableBottom_SOA";
            tableBottom_SOA.Dock = DockStyle.Fill;
            tableBottom_SOA.ColumnCount = 2;
            tableBottom_SOA.RowCount = 1;
            tableBottom_SOA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableBottom_SOA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableBottom_SOA.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Left flow
            flowLeft_SOA = new FlowLayoutPanel();
            flowLeft_SOA.Name = "flowLeft_SOA";
            flowLeft_SOA.Dock = DockStyle.Fill;
            flowLeft_SOA.FlowDirection = FlowDirection.LeftToRight;
            flowLeft_SOA.WrapContents = false;
            flowLeft_SOA.AutoSize = false;

            buttonFillDemo_SOA = new Button();
            buttonFillDemo_SOA.Name = "buttonFillDemo_SOA";
            buttonFillDemo_SOA.Text = "Демо";
            buttonFillDemo_SOA.Width = 110;
            buttonFillDemo_SOA.Height = 36;
            buttonFillDemo_SOA.Click += buttonFillDemo_SOA_Click;

            buttonAdd_SOA = new Button();
            buttonAdd_SOA.Name = "buttonAdd_SOA";
            buttonAdd_SOA.Text = "Добавить";
            buttonAdd_SOA.Width = 110;
            buttonAdd_SOA.Height = 36;
            buttonAdd_SOA.Click += buttonAdd_SOA_Click;

            buttonDelete_SOA = new Button();
            buttonDelete_SOA.Name = "buttonDelete_SOA";
            buttonDelete_SOA.Text = "Удалить";
            buttonDelete_SOA.Width = 110;
            buttonDelete_SOA.Height = 36;
            buttonDelete_SOA.Click += buttonDelete_SOA_Click;

            labelFound_SOA = new Label();
            labelFound_SOA.Name = "labelFound_SOA";
            labelFound_SOA.AutoSize = true;
            labelFound_SOA.Padding = new Padding(10, 7, 0, 0);
            labelFound_SOA.Text = "Найдено: 0 из 0";

            flowLeft_SOA.Controls.Add(buttonFillDemo_SOA);
            flowLeft_SOA.Controls.Add(buttonAdd_SOA);
            flowLeft_SOA.Controls.Add(buttonDelete_SOA);
            flowLeft_SOA.Controls.Add(labelFound_SOA);

            // Right flow (search)
            flowSearch_SOA = new FlowLayoutPanel();
            flowSearch_SOA.Name = "flowSearch_SOA";
            flowSearch_SOA.Dock = DockStyle.Fill;
            flowSearch_SOA.FlowDirection = FlowDirection.LeftToRight;
            flowSearch_SOA.WrapContents = false;
            flowSearch_SOA.AutoSize = false;
            flowSearch_SOA.Anchor = AnchorStyles.Right;
            flowSearch_SOA.Padding = new Padding(0, 0, 0, 0);

            labelSearch_SOA = new Label();
            labelSearch_SOA.Name = "labelSearch_SOA";
            labelSearch_SOA.AutoSize = true;
            labelSearch_SOA.Text = "Поиск:";
            labelSearch_SOA.Padding = new Padding(0, 7, 6, 0);

            textBoxSearch_SOA = new TextBox();
            textBoxSearch_SOA.Name = "textBoxSearch_SOA";
            textBoxSearch_SOA.Width = 200;

            checkBoxInStock_SOA = new CheckBox();
            checkBoxInStock_SOA.Name = "checkBoxInStock_SOA";
            checkBoxInStock_SOA.Text = "В наличии";
            checkBoxInStock_SOA.AutoSize = true;
            checkBoxInStock_SOA.Padding = new Padding(10, 4, 0, 0);

            buttonResetFilters_SOA = new Button();
            buttonResetFilters_SOA.Name = "buttonResetFilters_SOA";
            buttonResetFilters_SOA.Text = "Сброс";
            buttonResetFilters_SOA.Width = 90;
            buttonResetFilters_SOA.Height = 30;
            buttonResetFilters_SOA.Margin = new Padding(10, 0, 0, 0);
            buttonResetFilters_SOA.Click += buttonResetFilters_SOA_Click;

            flowSearch_SOA.Controls.Add(labelSearch_SOA);
            flowSearch_SOA.Controls.Add(textBoxSearch_SOA);
            flowSearch_SOA.Controls.Add(checkBoxInStock_SOA);
            flowSearch_SOA.Controls.Add(buttonResetFilters_SOA);

            // Put into table
            tableBottom_SOA.Controls.Add(flowLeft_SOA, 0, 0);
            tableBottom_SOA.Controls.Add(flowSearch_SOA, 1, 0);

            panelProductsActions_SOA.Controls.Add(tableBottom_SOA);

            // ===== FORM =====
            Text = "Оптовая база";
            ClientSize = new Size(1000, 600);
            MinimumSize = new Size(900, 550);
            StartPosition = FormStartPosition.CenterScreen;

            Controls.Add(dataGridViewProducts_SOA);
            Controls.Add(panelProductsActions_SOA);
            Controls.Add(statusStripMain_SOA);
            Controls.Add(toolStripMain_SOA);
            Controls.Add(menuMain_SOA);

            MainMenuStrip = menuMain_SOA;

            Load += FormMain_Load;
        }
    }
}