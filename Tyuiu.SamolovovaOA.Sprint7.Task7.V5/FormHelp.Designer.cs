namespace Tyuiu.SamolovovaOA.Sprint7.Task7.V5
{
    partial class FormHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            buttonHelp_SOA = new Button();
            labelHelp_SOA = new Label();
            SuspendLayout();
            // 
            // buttonHelp_SOA
            // 
            buttonHelp_SOA.Location = new Point(639, 878);
            buttonHelp_SOA.Name = "buttonHelp_SOA";
            buttonHelp_SOA.Size = new Size(132, 40);
            buttonHelp_SOA.TabIndex = 1;
            buttonHelp_SOA.Text = "Okey";
            buttonHelp_SOA.UseVisualStyleBackColor = true;
            buttonHelp_SOA.Click += buttonHelp_SOA_Click;
            // 
            // labelHelp_SOA
            // 
            labelHelp_SOA.Location = new Point(25, 9);
            labelHelp_SOA.Name = "labelHelp_SOA";
            labelHelp_SOA.Size = new Size(765, 866);
            labelHelp_SOA.TabIndex = 2;
            labelHelp_SOA.Text = resources.GetString("labelHelp_SOA.Text");
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 930);
            Controls.Add(labelHelp_SOA);
            Controls.Add(buttonHelp_SOA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство пользователя";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonHelp_SOA;
        private Label labelHelp_SOA;
    }
}