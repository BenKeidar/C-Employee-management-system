namespace EmployeeManager
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.UIDbox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PASSbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(181, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "EmployEasy";
            // 
            // UIDbox
            // 
            this.UIDbox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UIDbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.UIDbox.Location = new System.Drawing.Point(291, 93);
            this.UIDbox.Name = "UIDbox";
            this.UIDbox.Size = new System.Drawing.Size(170, 29);
            this.UIDbox.TabIndex = 2;
            this.UIDbox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManager.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(74, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(181, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(182, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(267, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(367, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PASSbox
            // 
            this.PASSbox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PASSbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.PASSbox.Location = new System.Drawing.Point(291, 138);
            this.PASSbox.Name = "PASSbox";
            this.PASSbox.Size = new System.Drawing.Size(170, 29);
            this.PASSbox.TabIndex = 10;
            this.PASSbox.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("David", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(492, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PASSbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UIDbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox UIDbox;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox PASSbox;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
    }
}