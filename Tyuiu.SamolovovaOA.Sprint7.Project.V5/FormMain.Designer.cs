namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code
        #endregion

        // Menu
        private System.Windows.Forms.MenuStrip menuMain_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuFile_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave_SOA;
        private System.Windows.Forms.ToolStripSeparator menuSeparator_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit_SOA;

        private System.Windows.Forms.ToolStripMenuItem menuHelp_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout_SOA;

        // Toolbar
        private System.Windows.Forms.ToolStrip toolStripMain_SOA;
        private System.Windows.Forms.ToolStripButton toolButtonOpen_SOA;
        private System.Windows.Forms.ToolStripButton toolButtonSave_SOA;
        private System.Windows.Forms.ToolStripButton toolButtonRefresh_SOA;

        // Status
        private System.Windows.Forms.StatusStrip statusStripMain_SOA;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo_SOA;

        // Grid
        private System.Windows.Forms.DataGridView dataGridViewProducts_SOA;

        // Bottom panel layout
        private System.Windows.Forms.Panel panelProductsActions_SOA;
        private System.Windows.Forms.TableLayoutPanel tableBottom_SOA;

        // Left group (buttons + found label)
        private System.Windows.Forms.FlowLayoutPanel flowLeft_SOA;
        private System.Windows.Forms.Button buttonFillDemo_SOA;
        private System.Windows.Forms.Button buttonAdd_SOA;
        private System.Windows.Forms.Button buttonDelete_SOA;
        private System.Windows.Forms.Label labelFound_SOA;

        // Right group (search)
        private System.Windows.Forms.FlowLayoutPanel flowSearch_SOA;
        private System.Windows.Forms.Label labelSearch_SOA;
        private System.Windows.Forms.TextBox textBoxSearch_SOA;
        private System.Windows.Forms.CheckBox checkBoxInStock_SOA;
        private System.Windows.Forms.Button buttonResetFilters_SOA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ===== MENU =====
            menuMain_SOA = new System.Windows.Forms.MenuStrip();
            menuFile_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuItemOpen_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuItemSave_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuSeparator_SOA = new System.Windows.Forms.ToolStripSeparator();
            menuItemExit_SOA = new System.Windows.Forms.ToolStripMenuItem();

            menuHelp_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuItemHelp_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuItemAbout_SOA = new System.Windows.Forms.ToolStripMenuItem();

            menuMain_SOA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuFile_SOA, menuHelp_SOA });

            menuFile_SOA.Text = "Файл";
            menuFile_SOA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
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
            menuHelp_SOA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItemHelp_SOA, menuItemAbout_SOA });

            menuItemHelp_SOA.Text = "Руководство пользователя";
            menuItemHelp_SOA.Click += menuItemHelp_SOA_Click;

            menuItemAbout_SOA.Text = "О программе";
            menuItemAbout_SOA.Click += menuItemAbout_SOA_Click;

            menuMain_SOA.Dock = System.Windows.Forms.DockStyle.Top;

            // ===== TOOLSTRIP =====
            toolStripMain_SOA = new System.Windows.Forms.ToolStrip();
            toolButtonOpen_SOA = new System.Windows.Forms.ToolStripButton();
            toolButtonSave_SOA = new System.Windows.Forms.ToolStripButton();
            toolButtonRefresh_SOA = new System.Windows.Forms.ToolStripButton();

            toolStripMain_SOA.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                toolButtonOpen_SOA,
                toolButtonSave_SOA,
                toolButtonRefresh_SOA
            });

            toolButtonOpen_SOA.Text = "Открыть";
            toolButtonOpen_SOA.Click += toolButtonOpen_SOA_Click;

            toolButtonSave_SOA.Text = "Сохранить";
            toolButtonSave_SOA.Click += toolButtonSave_SOA_Click;

            toolButtonRefresh_SOA.Text = "Обновить";
            toolButtonRefresh_SOA.Click += toolButtonRefresh_SOA_Click;

            toolStripMain_SOA.Dock = System.Windows.Forms.DockStyle.Top;

            // ===== STATUSSTRIP =====
            statusStripMain_SOA = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabelInfo_SOA = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabelInfo_SOA.Text = "Статус";
            statusStripMain_SOA.Items.Add(toolStripStatusLabelInfo_SOA);
            statusStripMain_SOA.Dock = System.Windows.Forms.DockStyle.Bottom;

            // ===== GRID =====
            dataGridViewProducts_SOA = new System.Windows.Forms.DataGridView();
            dataGridViewProducts_SOA.Name = "dataGridViewProducts_SOA";
            dataGridViewProducts_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewProducts_SOA.MultiSelect = false;
            dataGridViewProducts_SOA.RowHeadersVisible = false;
            dataGridViewProducts_SOA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            dataGridViewProducts_SOA.AllowUserToAddRows = false;
            dataGridViewProducts_SOA.AllowUserToResizeRows = false;
            dataGridViewProducts_SOA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            dataGridViewProducts_SOA.RowTemplate.Height = 22;
            dataGridViewProducts_SOA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewProducts_SOA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProducts_SOA.BackgroundColor = System.Drawing.SystemColors.Window;

            // ===== BOTTOM PANEL =====
            panelProductsActions_SOA = new System.Windows.Forms.Panel();
            panelProductsActions_SOA.Name = "panelProductsActions_SOA";
            panelProductsActions_SOA.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelProductsActions_SOA.Height = 64;
            panelProductsActions_SOA.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);

            // Table layout: 2 columns (left / right)
            tableBottom_SOA = new System.Windows.Forms.TableLayoutPanel();
            tableBottom_SOA.Name = "tableBottom_SOA";
            tableBottom_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            tableBottom_SOA.ColumnCount = 2;
            tableBottom_SOA.RowCount = 1;
            tableBottom_SOA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            tableBottom_SOA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableBottom_SOA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

            // Left flow
            flowLeft_SOA = new System.Windows.Forms.FlowLayoutPanel();
            flowLeft_SOA.Name = "flowLeft_SOA";
            flowLeft_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLeft_SOA.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowLeft_SOA.WrapContents = false;
            flowLeft_SOA.AutoSize = false;

            buttonFillDemo_SOA = new System.Windows.Forms.Button();
            buttonFillDemo_SOA.Name = "buttonFillDemo_SOA";
            buttonFillDemo_SOA.Text = "Демо";
            buttonFillDemo_SOA.Width = 110;
            buttonFillDemo_SOA.Height = 38;
            buttonFillDemo_SOA.Click += buttonFillDemo_SOA_Click;

            buttonAdd_SOA = new System.Windows.Forms.Button();
            buttonAdd_SOA.Name = "buttonAdd_SOA";
            buttonAdd_SOA.Text = "Добавить";
            buttonAdd_SOA.Width = 110;
            buttonAdd_SOA.Height = 38;
            buttonAdd_SOA.Click += buttonAdd_SOA_Click;

            buttonDelete_SOA = new System.Windows.Forms.Button();
            buttonDelete_SOA.Name = "buttonDelete_SOA";
            buttonDelete_SOA.Text = "Удалить";
            buttonDelete_SOA.Width = 110;
            buttonDelete_SOA.Height = 38;
            buttonDelete_SOA.Click += buttonDelete_SOA_Click;

            labelFound_SOA = new System.Windows.Forms.Label();
            labelFound_SOA.Name = "labelFound_SOA";
            labelFound_SOA.AutoSize = true;
            labelFound_SOA.Padding = new System.Windows.Forms.Padding(10, 9, 0, 0);
            labelFound_SOA.Text = "Найдено: 0 из 0";

            flowLeft_SOA.Controls.Add(buttonFillDemo_SOA);
            flowLeft_SOA.Controls.Add(buttonAdd_SOA);
            flowLeft_SOA.Controls.Add(buttonDelete_SOA);
            flowLeft_SOA.Controls.Add(labelFound_SOA);

            // Right flow (search)
            flowSearch_SOA = new System.Windows.Forms.FlowLayoutPanel();
            flowSearch_SOA.Name = "flowSearch_SOA";
            flowSearch_SOA.Dock = System.Windows.Forms.DockStyle.Fill;
            flowSearch_SOA.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowSearch_SOA.WrapContents = false;
            flowSearch_SOA.AutoSize = false;

            labelSearch_SOA = new System.Windows.Forms.Label();
            labelSearch_SOA.Name = "labelSearch_SOA";
            labelSearch_SOA.AutoSize = true;
            labelSearch_SOA.Text = "Поиск:";
            labelSearch_SOA.Padding = new System.Windows.Forms.Padding(0, 9, 6, 0);

            textBoxSearch_SOA = new System.Windows.Forms.TextBox();
            textBoxSearch_SOA.Name = "textBoxSearch_SOA";
            textBoxSearch_SOA.Width = 200;
            textBoxSearch_SOA.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);

            checkBoxInStock_SOA = new System.Windows.Forms.CheckBox();
            checkBoxInStock_SOA.Name = "checkBoxInStock_SOA";
            checkBoxInStock_SOA.Text = "В наличии";
            checkBoxInStock_SOA.AutoSize = true;
            checkBoxInStock_SOA.Margin = new System.Windows.Forms.Padding(10, 8, 0, 0);

            buttonResetFilters_SOA = new System.Windows.Forms.Button();
            buttonResetFilters_SOA.Name = "buttonResetFilters_SOA";
            buttonResetFilters_SOA.Text = "Сброс";
            buttonResetFilters_SOA.Width = 90;
            buttonResetFilters_SOA.Height = 32;
            buttonResetFilters_SOA.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
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
            this.Text = "Оптовая база";
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(dataGridViewProducts_SOA);
            this.Controls.Add(panelProductsActions_SOA);
            this.Controls.Add(statusStripMain_SOA);
            this.Controls.Add(toolStripMain_SOA);
            this.Controls.Add(menuMain_SOA);

            this.MainMenuStrip = menuMain_SOA;
            this.Load += FormMain_Load;
        }
    }
}