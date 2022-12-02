namespace EmployeeManager
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmpDOB = new System.Windows.Forms.DateTimePicker();
            this.EmpGender = new System.Windows.Forms.ComboBox();
            this.EmpEducation = new System.Windows.Forms.ComboBox();
            this.EmpPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpPhone = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpID = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manage Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpGV);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.EmpDOB);
            this.panel1.Controls.Add(this.EmpGender);
            this.panel1.Controls.Add(this.EmpEducation);
            this.panel1.Controls.Add(this.EmpPosition);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 719);
            this.panel1.TabIndex = 8;
            // 
            // EmpGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmpGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpGV.ColumnHeadersHeight = 25;
            this.EmpGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpGV.Location = new System.Drawing.Point(463, 109);
            this.EmpGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpGV.Name = "EmpGV";
            this.EmpGV.RowHeadersVisible = false;
            this.EmpGV.RowHeadersWidth = 51;
            this.EmpGV.RowTemplate.Height = 25;
            this.EmpGV.Size = new System.Drawing.Size(803, 535);
            this.EmpGV.TabIndex = 26;
            this.EmpGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.EmpGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpGV.ThemeStyle.HeaderStyle.Height = 25;
            this.EmpGV.ThemeStyle.ReadOnly = false;
            this.EmpGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpGV.ThemeStyle.RowsStyle.Height = 25;
            this.EmpGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.EmpGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmpGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGV_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManager.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(1249, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.bunifuThinButton23.ButtonText = "Update";
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.Location = new System.Drawing.Point(161, 476);
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
            this.bunifuThinButton22.ButtonText = "Delete";
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton22.Location = new System.Drawing.Point(296, 476);
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
            this.bunifuThinButton21.ButtonText = "Add";
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Green;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(24, 476);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(114, 53);
            this.bunifuThinButton21.TabIndex = 23;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // EmpDOB
            // 
            this.EmpDOB.Location = new System.Drawing.Point(240, 395);
            this.EmpDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpDOB.Name = "EmpDOB";
            this.EmpDOB.Size = new System.Drawing.Size(170, 27);
            this.EmpDOB.TabIndex = 22;
            // 
            // EmpGender
            // 
            this.EmpGender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpGender.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpGender.FormattingEnabled = true;
            this.EmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGender.Location = new System.Drawing.Point(240, 353);
            this.EmpGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.Size = new System.Drawing.Size(170, 30);
            this.EmpGender.TabIndex = 20;
            // 
            // EmpEducation
            // 
            this.EmpEducation.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpEducation.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpEducation.FormattingEnabled = true;
            this.EmpEducation.Items.AddRange(new object[] {
            "None",
            "B.Sc ",
            "M.Sc",
            "BA",
            "MA",
            "BBA",
            "MBA",
            "BTech",
            "MTech"});
            this.EmpEducation.Location = new System.Drawing.Point(240, 312);
            this.EmpEducation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpEducation.Name = "EmpEducation";
            this.EmpEducation.Size = new System.Drawing.Size(170, 30);
            this.EmpEducation.TabIndex = 19;
            // 
            // EmpPosition
            // 
            this.EmpPosition.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpPosition.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpPosition.FormattingEnabled = true;
            this.EmpPosition.Items.AddRange(new object[] {
            "Manager",
            "Senior Developer",
            "Junior Developer",
            "HR",
            "Accountant",
            "Receptionist"});
            this.EmpPosition.Location = new System.Drawing.Point(240, 269);
            this.EmpPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpPosition.Name = "EmpPosition";
            this.EmpPosition.Size = new System.Drawing.Size(170, 30);
            this.EmpPosition.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(24, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Employee DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(24, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(24, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Employee Education";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(24, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Employee Position";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpPhone.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpPhone.Location = new System.Drawing.Point(240, 229);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Size = new System.Drawing.Size(170, 33);
            this.EmpPhone.TabIndex = 13;
            this.EmpPhone.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(24, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employee Phone";
            // 
            // EmpAddress
            // 
            this.EmpAddress.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpAddress.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpAddress.Location = new System.Drawing.Point(240, 189);
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.Size = new System.Drawing.Size(170, 33);
            this.EmpAddress.TabIndex = 11;
            this.EmpAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(24, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee Address";
            // 
            // EmpName
            // 
            this.EmpName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpName.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpName.Location = new System.Drawing.Point(240, 149);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(170, 33);
            this.EmpName.TabIndex = 9;
            this.EmpName.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(24, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Name";
            // 
            // EmpID
            // 
            this.EmpID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpID.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpID.Location = new System.Drawing.Point(240, 109);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(170, 33);
            this.EmpID.TabIndex = 7;
            this.EmpID.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(24, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManager.Properties.Resources.employee_icon_white;
            this.pictureBox1.Location = new System.Drawing.Point(23, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("David", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1279, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 28);
            this.label10.TabIndex = 10;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Employee
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
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label1;
        private DateTimePicker EmpDOB;
        private ComboBox EmpGender;
        private ComboBox EmpEducation;
        private ComboBox EmpPosition;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private RichTextBox EmpPhone;
        private Label label4;
        private RichTextBox EmpAddress;
        private Label label5;
        private RichTextBox EmpName;
        private Label label3;
        private RichTextBox EmpID;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView EmpGV;
        private Label label10;
    }
}