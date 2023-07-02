namespace SqlTest
{
    partial class SqlTest
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
            BtnConOpen = new Button();
            BtnConClose = new Button();
            BtnConCheck = new Button();
            LblState = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnConOpen
            // 
            BtnConOpen.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConOpen.Location = new Point(31, 271);
            BtnConOpen.Name = "BtnConOpen";
            BtnConOpen.Size = new Size(222, 47);
            BtnConOpen.TabIndex = 1;
            BtnConOpen.Text = "Open Connection";
            BtnConOpen.UseVisualStyleBackColor = true;
            BtnConOpen.Click += BtnConOpen_Click;
            // 
            // BtnConClose
            // 
            BtnConClose.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConClose.Location = new Point(31, 324);
            BtnConClose.Name = "BtnConClose";
            BtnConClose.Size = new Size(222, 47);
            BtnConClose.TabIndex = 2;
            BtnConClose.Text = "Close Connection";
            BtnConClose.UseVisualStyleBackColor = true;
            BtnConClose.Click += BtnConClose_Click;
            // 
            // BtnConCheck
            // 
            BtnConCheck.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConCheck.Location = new Point(31, 377);
            BtnConCheck.Name = "BtnConCheck";
            BtnConCheck.Size = new Size(222, 47);
            BtnConCheck.TabIndex = 3;
            BtnConCheck.Text = "Check Connection";
            BtnConCheck.UseVisualStyleBackColor = true;
            BtnConCheck.Click += BtnConCheck_Click;
            // 
            // LblState
            // 
            LblState.AutoSize = true;
            LblState.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblState.ForeColor = Color.Red;
            LblState.Location = new Point(23, 216);
            LblState.Name = "LblState";
            LblState.Size = new Size(238, 32);
            LblState.TabIndex = 1;
            LblState.Text = "Connection is Close";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LblState);
            panel1.Controls.Add(BtnConCheck);
            panel1.Controls.Add(BtnConOpen);
            panel1.Controls.Add(BtnConClose);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 450);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NoConn;
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // SqlTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(282, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "SqlTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL Baglanti Test";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnConOpen;
        private Button BtnConClose;
        private Button BtnConCheck;
        private Label LblState;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}