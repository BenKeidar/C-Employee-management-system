namespace EmployeeManager
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpPositionS = new System.Windows.Forms.RichTextBox();
            this.SalaryBox = new System.Windows.Forms.RichTextBox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.WorkedD = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpNameS = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIDS = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("David", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1279, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManager.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(1249, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManager.Properties.Resources.salary;
            this.pictureBox1.Location = new System.Drawing.Point(23, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpPositionS);
            this.panel1.Controls.Add(this.SalaryBox);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.WorkedD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpNameS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpIDS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 719);
            this.panel1.TabIndex = 12;
            // 
            // EmpPositionS
            // 
            this.EmpPositionS.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpPositionS.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpPositionS.Location = new System.Drawing.Point(346, 265);
            this.EmpPositionS.Name = "EmpPositionS";
            this.EmpPositionS.ReadOnly = true;
            this.EmpPositionS.Size = new System.Drawing.Size(170, 33);
            this.EmpPositionS.TabIndex = 27;
            this.EmpPositionS.Text = "";
            // 
            // SalaryBox
            // 
            this.SalaryBox.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalaryBox.ForeColor = System.Drawing.Color.DarkGray;
            this.SalaryBox.Location = new System.Drawing.Point(679, 205);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(464, 245);
            this.SalaryBox.TabIndex = 26;
            this.SalaryBox.Text = "";
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Fetch Data";
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.Location = new System.Drawing.Point(808, 68);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(114, 53);
            this.bunifuThinButton23.TabIndex = 25;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Print";
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton22.Location = new System.Drawing.Point(265, 397);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(114, 53);
            this.bunifuThinButton22.TabIndex = 24;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Calculate";
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(402, 397);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(114, 53);
            this.bunifuThinButton21.TabIndex = 23;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(130, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employee Position";
            // 
            // WorkedD
            // 
            this.WorkedD.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkedD.ForeColor = System.Drawing.Color.SteelBlue;
            this.WorkedD.Location = new System.Drawing.Point(346, 323);
            this.WorkedD.Name = "WorkedD";
            this.WorkedD.Size = new System.Drawing.Size(170, 33);
            this.WorkedD.TabIndex = 11;
            this.WorkedD.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(130, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Worked days";
            // 
            // EmpNameS
            // 
            this.EmpNameS.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpNameS.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpNameS.Location = new System.Drawing.Point(346, 205);
            this.EmpNameS.Name = "EmpNameS";
            this.EmpNameS.ReadOnly = true;
            this.EmpNameS.Size = new System.Drawing.Size(170, 33);
            this.EmpNameS.TabIndex = 9;
            this.EmpNameS.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(130, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Name";
            // 
            // EmpIDS
            // 
            this.EmpIDS.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpIDS.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpIDS.Location = new System.Drawing.Point(609, 78);
            this.EmpIDS.Name = "EmpIDS";
            this.EmpIDS.Size = new System.Drawing.Size(170, 33);
            this.EmpIDS.TabIndex = 7;
            this.EmpIDS.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(430, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salary";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1317, 863);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Label label4;
        private RichTextBox WorkedD;
        private Label label5;
        private RichTextBox EmpNameS;
        private Label label3;
        private RichTextBox EmpIDS;
        private Label label1;
        private Label label2;
        private RichTextBox SalaryBox;
        private RichTextBox EmpPositionS;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}