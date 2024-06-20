namespace UserControls
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlClick = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.userControl31 = new UserControls.UserControl3();
            this.userControl21 = new UserControls.UserControl2();
            this.userControl11 = new UserControls.UserControl1();
            this.myPictureBox1 = new UserControls.MyPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.pnlClick);
            this.panel1.Controls.Add(this.myPictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 325);
            this.panel1.TabIndex = 0;
            // 
            // pnlClick
            // 
            this.pnlClick.BackColor = System.Drawing.Color.Teal;
            this.pnlClick.Location = new System.Drawing.Point(160, 95);
            this.pnlClick.Name = "pnlClick";
            this.pnlClick.Size = new System.Drawing.Size(11, 90);
            this.pnlClick.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Settings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Contacts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "My Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(117)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(177, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 34);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(285, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(88, 34);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(31, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.Home);
            this.panel3.Controls.Add(this.userControl31);
            this.panel3.Controls.Add(this.userControl21);
            this.panel3.Controls.Add(this.userControl11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(177, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 291);
            this.panel3.TabIndex = 2;
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(373, 291);
            this.Home.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl31.Location = new System.Drawing.Point(0, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(373, 291);
            this.userControl31.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(373, 291);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(373, 291);
            this.userControl11.TabIndex = 0;
            // 
            // myPictureBox1
            // 
            this.myPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("myPictureBox1.Image")));
            this.myPictureBox1.Location = new System.Drawing.Point(36, 12);
            this.myPictureBox1.Name = "myPictureBox1";
            this.myPictureBox1.Size = new System.Drawing.Size(100, 98);
            this.myPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBox1.TabIndex = 3;
            this.myPictureBox1.TabStop = false;
            this.myPictureBox1.Click += new System.EventHandler(this.myPictureBox1_Click);
            this.myPictureBox1.MouseHover += new System.EventHandler(this.myPictureBox1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 325);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MyPictureBox myPictureBox1;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.ToolTip toolTip1;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlClick;
        private System.Windows.Forms.Panel panel4;

    }
}

