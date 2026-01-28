namespace Tyuiu.SamolovovaOA.Sprint7.Task7.V5
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonDone_SOA = new Button();
            pictureBoxPhoto_SOA = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_SOA).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_SOA
            // 
            buttonDone_SOA.Location = new Point(608, 390);
            buttonDone_SOA.Name = "buttonDone_SOA";
            buttonDone_SOA.Size = new Size(151, 37);
            buttonDone_SOA.TabIndex = 8;
            buttonDone_SOA.Text = "Okey";
            buttonDone_SOA.UseVisualStyleBackColor = true;
            buttonDone_SOA.Click += buttonDone_SOA_Click;
            // 
            // pictureBoxPhoto_SOA
            // 
            pictureBoxPhoto_SOA.Image = (Image)resources.GetObject("pictureBoxPhoto_SOA.Image");
            pictureBoxPhoto_SOA.Location = new Point(20, 24);
            pictureBoxPhoto_SOA.Name = "pictureBoxPhoto_SOA";
            pictureBoxPhoto_SOA.Size = new Size(300, 392);
            pictureBoxPhoto_SOA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto_SOA.TabIndex = 6;
            pictureBoxPhoto_SOA.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(347, 28);
            label1.Name = "label1";
            label1.Size = new Size(428, 359);
            label1.TabIndex = 9;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonDone_SOA);
            Controls.Add(pictureBoxPhoto_SOA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_SOA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_SOA;
        private PictureBox pictureBoxPhoto_SOA;
        private Label label1;
    }
}