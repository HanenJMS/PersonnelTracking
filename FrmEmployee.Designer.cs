namespace PersonalTracking
{
    partial class FrmEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChAdmin = new System.Windows.Forms.CheckBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.TxtUserNo = new System.Windows.Forms.TextBox();
            this.UserNo = new System.Windows.Forms.Label();
            this.TextBoxSurName = new System.Windows.Forms.TextBox();
            this.TxtSurName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.Label();
            this.TextBoxImagePath = new System.Windows.Forms.TextBox();
            this.ImagePath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonBrowsw = new System.Windows.Forms.Button();
            this.TextboxSalary = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.CmbPosition = new System.Windows.Forms.ComboBox();
            this.TextPosition = new System.Windows.Forms.Label();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.TextDepartment = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChAdmin);
            this.panel1.Controls.Add(this.TextBoxPassword);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.ButtonCheck);
            this.panel1.Controls.Add(this.TxtUserNo);
            this.panel1.Controls.Add(this.UserNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 100);
            this.panel1.TabIndex = 0;
            // 
            // ChAdmin
            // 
            this.ChAdmin.AutoSize = true;
            this.ChAdmin.Location = new System.Drawing.Point(640, 9);
            this.ChAdmin.Name = "ChAdmin";
            this.ChAdmin.Size = new System.Drawing.Size(80, 20);
            this.ChAdmin.TabIndex = 3;
            this.ChAdmin.Text = "Is Admin";
            this.ChAdmin.UseVisualStyleBackColor = true;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxPassword.Location = new System.Drawing.Point(387, 35);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(209, 30);
            this.TextBoxPassword.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(382, 7);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 25);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password";
            // 
            // TxtUserNo
            // 
            this.TxtUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserNo.Location = new System.Drawing.Point(27, 35);
            this.TxtUserNo.Name = "TxtUserNo";
            this.TxtUserNo.Size = new System.Drawing.Size(209, 30);
            this.TxtUserNo.TabIndex = 0;
            this.TxtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserNo_KeyPress);
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNo.Location = new System.Drawing.Point(22, 9);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(84, 25);
            this.UserNo.TabIndex = 2;
            this.UserNo.Text = "UserNo";
            // 
            // TextBoxSurName
            // 
            this.TextBoxSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxSurName.Location = new System.Drawing.Point(139, 154);
            this.TextBoxSurName.Name = "TextBoxSurName";
            this.TextBoxSurName.Size = new System.Drawing.Size(209, 30);
            this.TextBoxSurName.TabIndex = 1;
            // 
            // TxtSurName
            // 
            this.TxtSurName.AutoSize = true;
            this.TxtSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurName.Location = new System.Drawing.Point(10, 159);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(102, 25);
            this.TxtSurName.TabIndex = 12;
            this.TxtSurName.Text = "SurName";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxName.Location = new System.Drawing.Point(139, 110);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(209, 30);
            this.TextBoxName.TabIndex = 0;
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(10, 115);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(68, 25);
            this.TxtName.TabIndex = 11;
            this.TxtName.Text = "Name";
            // 
            // TextBoxImagePath
            // 
            this.TextBoxImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxImagePath.Location = new System.Drawing.Point(139, 198);
            this.TextBoxImagePath.Name = "TextBoxImagePath";
            this.TextBoxImagePath.Size = new System.Drawing.Size(209, 30);
            this.TextBoxImagePath.TabIndex = 2;
            // 
            // ImagePath
            // 
            this.ImagePath.AutoSize = true;
            this.ImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePath.Location = new System.Drawing.Point(10, 203);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.Size = new System.Drawing.Size(121, 25);
            this.ImagePath.TabIndex = 10;
            this.ImagePath.Text = "Image Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonBrowsw
            // 
            this.ButtonBrowsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBrowsw.Location = new System.Drawing.Point(354, 198);
            this.ButtonBrowsw.Name = "ButtonBrowsw";
            this.ButtonBrowsw.Size = new System.Drawing.Size(114, 30);
            this.ButtonBrowsw.TabIndex = 3;
            this.ButtonBrowsw.Text = "Browse";
            this.ButtonBrowsw.UseVisualStyleBackColor = true;
            this.ButtonBrowsw.Click += new System.EventHandler(this.ButtonBrowsw_Click);
            // 
            // TextboxSalary
            // 
            this.TextboxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextboxSalary.Location = new System.Drawing.Point(139, 258);
            this.TextboxSalary.Name = "TextboxSalary";
            this.TextboxSalary.Size = new System.Drawing.Size(209, 30);
            this.TextboxSalary.TabIndex = 4;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(10, 258);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(74, 25);
            this.Salary.TabIndex = 15;
            this.Salary.Text = "Salary";
            // 
            // CmbPosition
            // 
            this.CmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPosition.FormattingEnabled = true;
            this.CmbPosition.Location = new System.Drawing.Point(139, 348);
            this.CmbPosition.Name = "CmbPosition";
            this.CmbPosition.Size = new System.Drawing.Size(209, 33);
            this.CmbPosition.TabIndex = 6;
            // 
            // TextPosition
            // 
            this.TextPosition.AutoSize = true;
            this.TextPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPosition.Location = new System.Drawing.Point(10, 354);
            this.TextPosition.Name = "TextPosition";
            this.TextPosition.Size = new System.Drawing.Size(89, 25);
            this.TextPosition.TabIndex = 19;
            this.TextPosition.Text = "Position";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(139, 304);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(209, 33);
            this.CmbDepartment.TabIndex = 5;
            this.CmbDepartment.SelectedIndexChanged += new System.EventHandler(this.CmbDepartment_SelectedIndexChanged);
            // 
            // TextDepartment
            // 
            this.TextDepartment.AutoSize = true;
            this.TextDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDepartment.Location = new System.Drawing.Point(10, 310);
            this.TextDepartment.Name = "TextDepartment";
            this.TextDepartment.Size = new System.Drawing.Size(123, 25);
            this.TextDepartment.TabIndex = 18;
            this.TextDepartment.Text = "Department";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.Location = new System.Drawing.Point(10, 396);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(91, 25);
            this.Birthday.TabIndex = 20;
            this.Birthday.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 396);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(139, 449);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 123);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Image = global::PersonalTracking.Properties.Resources.close;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClose.Location = new System.Drawing.Point(430, 612);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(125, 75);
            this.ButtonClose.TabIndex = 10;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Image = global::PersonalTracking.Properties.Resources.floppy_disk;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSave.Location = new System.Drawing.Point(266, 612);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(137, 75);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(507, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 306);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheck.Image = global::PersonalTracking.Properties.Resources.loupe;
            this.ButtonCheck.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCheck.Location = new System.Drawing.Point(242, 0);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(125, 62);
            this.ButtonCheck.TabIndex = 1;
            this.ButtonCheck.Text = "Check";
            this.ButtonCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonCheck.UseVisualStyleBackColor = true;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 726);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.CmbPosition);
            this.Controls.Add(this.TextPosition);
            this.Controls.Add(this.CmbDepartment);
            this.Controls.Add(this.TextDepartment);
            this.Controls.Add(this.TextboxSalary);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.ButtonBrowsw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxSurName);
            this.Controls.Add(this.TxtSurName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TextBoxImagePath);
            this.Controls.Add(this.ImagePath);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtUserNo;
        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.CheckBox ChAdmin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.TextBox TextBoxSurName;
        private System.Windows.Forms.Label TxtSurName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.TextBox TextBoxImagePath;
        private System.Windows.Forms.Label ImagePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonBrowsw;
        private System.Windows.Forms.TextBox TextboxSalary;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.ComboBox CmbPosition;
        private System.Windows.Forms.Label TextPosition;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label TextDepartment;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSave;
    }
}