namespace PersonalTracking
{
    partial class FrmTask
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbPosition = new System.Windows.Forms.ComboBox();
            this.TextPosition = new System.Windows.Forms.Label();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.TextDepartment = new System.Windows.Forms.Label();
            this.TextBoxSurName = new System.Windows.Forms.TextBox();
            this.TxtSurName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.Label();
            this.TxtBoxUserNo = new System.Windows.Forms.TextBox();
            this.UserNo = new System.Windows.Forms.Label();
            this.StateTask = new System.Windows.Forms.ComboBox();
            this.TaskState = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxContent = new System.Windows.Forms.TextBox();
            this.LabelContent = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(552, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 637);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CmbPosition);
            this.panel2.Controls.Add(this.TextPosition);
            this.panel2.Controls.Add(this.CmbDepartment);
            this.panel2.Controls.Add(this.TextDepartment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 198);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 439);
            this.dataGridView1.TabIndex = 2;
            // 
            // CmbPosition
            // 
            this.CmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPosition.FormattingEnabled = true;
            this.CmbPosition.Location = new System.Drawing.Point(39, 122);
            this.CmbPosition.Name = "CmbPosition";
            this.CmbPosition.Size = new System.Drawing.Size(184, 33);
            this.CmbPosition.TabIndex = 1;
            // 
            // TextPosition
            // 
            this.TextPosition.AutoSize = true;
            this.TextPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPosition.Location = new System.Drawing.Point(34, 94);
            this.TextPosition.Name = "TextPosition";
            this.TextPosition.Size = new System.Drawing.Size(89, 25);
            this.TextPosition.TabIndex = 14;
            this.TextPosition.Text = "Position";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(39, 47);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(184, 33);
            this.CmbDepartment.TabIndex = 0;
            // 
            // TextDepartment
            // 
            this.TextDepartment.AutoSize = true;
            this.TextDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDepartment.Location = new System.Drawing.Point(34, 19);
            this.TextDepartment.Name = "TextDepartment";
            this.TextDepartment.Size = new System.Drawing.Size(123, 25);
            this.TextDepartment.TabIndex = 13;
            this.TextDepartment.Text = "Department";
            // 
            // TextBoxSurName
            // 
            this.TextBoxSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxSurName.Location = new System.Drawing.Point(156, 102);
            this.TextBoxSurName.Name = "TextBoxSurName";
            this.TextBoxSurName.ReadOnly = true;
            this.TextBoxSurName.Size = new System.Drawing.Size(214, 30);
            this.TextBoxSurName.TabIndex = 9;
            // 
            // TxtSurName
            // 
            this.TxtSurName.AutoSize = true;
            this.TxtSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurName.Location = new System.Drawing.Point(12, 107);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(102, 25);
            this.TxtSurName.TabIndex = 12;
            this.TxtSurName.Text = "SurName";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxName.Location = new System.Drawing.Point(156, 58);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.ReadOnly = true;
            this.TextBoxName.Size = new System.Drawing.Size(214, 30);
            this.TextBoxName.TabIndex = 8;
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(12, 63);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(68, 25);
            this.TxtName.TabIndex = 11;
            this.TxtName.Text = "Name";
            // 
            // TxtBoxUserNo
            // 
            this.TxtBoxUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxUserNo.Location = new System.Drawing.Point(156, 14);
            this.TxtBoxUserNo.Name = "TxtBoxUserNo";
            this.TxtBoxUserNo.ReadOnly = true;
            this.TxtBoxUserNo.Size = new System.Drawing.Size(214, 30);
            this.TxtBoxUserNo.TabIndex = 7;
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNo.Location = new System.Drawing.Point(12, 19);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(84, 25);
            this.UserNo.TabIndex = 10;
            this.UserNo.Text = "UserNo";
            // 
            // StateTask
            // 
            this.StateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateTask.FormattingEnabled = true;
            this.StateTask.Location = new System.Drawing.Point(156, 151);
            this.StateTask.Name = "StateTask";
            this.StateTask.Size = new System.Drawing.Size(214, 33);
            this.StateTask.TabIndex = 0;
            // 
            // TaskState
            // 
            this.TaskState.AutoSize = true;
            this.TaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskState.Location = new System.Drawing.Point(12, 151);
            this.TaskState.Name = "TaskState";
            this.TaskState.Size = new System.Drawing.Size(117, 25);
            this.TaskState.TabIndex = 26;
            this.TaskState.Text = "Task State";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTitle.Location = new System.Drawing.Point(120, 223);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(214, 30);
            this.TextBoxTitle.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(26, 223);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(54, 25);
            this.LabelTitle.TabIndex = 28;
            this.LabelTitle.Text = "Title";
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContent.Location = new System.Drawing.Point(120, 265);
            this.TextBoxContent.Multiline = true;
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.Size = new System.Drawing.Size(362, 236);
            this.TextBoxContent.TabIndex = 2;
            // 
            // LabelContent
            // 
            this.LabelContent.AutoSize = true;
            this.LabelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContent.Location = new System.Drawing.Point(26, 268);
            this.LabelContent.Name = "LabelContent";
            this.LabelContent.Size = new System.Drawing.Size(88, 25);
            this.LabelContent.TabIndex = 30;
            this.LabelContent.Text = "Content";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Location = new System.Drawing.Point(284, 541);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(125, 54);
            this.ButtonClose.TabIndex = 4;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(120, 541);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(137, 54);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 637);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxContent);
            this.Controls.Add(this.LabelContent);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.StateTask);
            this.Controls.Add(this.TaskState);
            this.Controls.Add(this.TextBoxSurName);
            this.Controls.Add(this.TxtSurName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtBoxUserNo);
            this.Controls.Add(this.UserNo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTask";
            this.Text = "Tasks";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CmbPosition;
        private System.Windows.Forms.Label TextPosition;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label TextDepartment;
        private System.Windows.Forms.TextBox TextBoxSurName;
        private System.Windows.Forms.Label TxtSurName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.TextBox TxtBoxUserNo;
        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.ComboBox StateTask;
        private System.Windows.Forms.Label TaskState;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxContent;
        private System.Windows.Forms.Label LabelContent;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSave;
    }
}