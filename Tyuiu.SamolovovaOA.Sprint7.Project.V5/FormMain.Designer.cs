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

        private System.Windows.Forms.MenuStrip menuMain_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuFile_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave_SOA;
        private System.Windows.Forms.ToolStripSeparator menuSeparator_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit_SOA;

        private System.Windows.Forms.ToolStripMenuItem menuHelp_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp_SOA;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout_SOA;

        private System.Windows.Forms.ToolStrip toolStripMain_SOA;
        private System.Windows.Forms.ToolStripButton toolButtonOpen_SOA;
        private System.Windows.Forms.ToolStripButton toolButtonSave_SOA;
        private System.Windows.Forms.ToolStripButton toolButtonRefresh_SOA;

        private System.Windows.Forms.StatusStrip statusStripMain_SOA;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo_SOA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()    
        {
            this.components = new System.ComponentModel.Container();

            menuMain_SOA = new System.Windows.Forms.MenuStrip();

            menuFile_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuItemOpen_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuItemSave_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuSeparator_SOA = new System.Windows.Forms.ToolStripSeparator();
            menuItemExit_SOA = new System.Windows.Forms.ToolStripMenuItem();

            menuHelp_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuItemHelp_SOA = new System.Windows.Forms.ToolStripMenuItem();
            menuItemAbout_SOA = new System.Windows.Forms.ToolStripMenuItem();

            menuMain_SOA.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                menuFile_SOA,
                menuHelp_SOA
            });

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
            menuHelp_SOA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                menuItemHelp_SOA,
                menuItemAbout_SOA
            });

            menuItemHelp_SOA.Text = "Руководство пользователя";
            menuItemHelp_SOA.Click += menuItemHelp_SOA_Click;

            menuItemAbout_SOA.Text = "О программе";
            menuItemAbout_SOA.Click += menuItemAbout_SOA_Click;

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

            statusStripMain_SOA = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabelInfo_SOA = new System.Windows.Forms.ToolStripStatusLabel();

            toolStripStatusLabelInfo_SOA.Text = "Статус";
            statusStripMain_SOA.Items.Add(toolStripStatusLabelInfo_SOA);

            this.Text = "Оптовая база";
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(statusStripMain_SOA);
            this.Controls.Add(toolStripMain_SOA);
            this.Controls.Add(menuMain_SOA);

            this.MainMenuStrip = menuMain_SOA;
        }
    }
}