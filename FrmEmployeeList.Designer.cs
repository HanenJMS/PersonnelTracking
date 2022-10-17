namespace PersonalTracking
{
    partial class FrmEmployeeList
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
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonClear);
            this.panel1.Controls.Add(this.ButtonSearch);
            this.panel1.Controls.Add(this.CmbPosition);
            this.panel1.Controls.Add(this.TextPosition);
            this.panel1.Controls.Add(this.CmbDepartment);
            this.panel1.Controls.Add(this.TextDepartment);
            this.panel1.Controls.Add(this.TextBoxSurName);
            this.panel1.Controls.Add(this.TxtSurName);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.TxtBoxUserNo);
            this.panel1.Controls.Add(this.UserNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 180);
            this.panel1.TabIndex = 0;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.Image = global::PersonalTracking.Properties.Resources.dust;
            this.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClear.Location = new System.Drawing.Point(513, 97);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(125, 68);
            this.ButtonClear.TabIndex = 6;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonClear.UseVisualStyleBackColor = true;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Image = global::PersonalTracking.Properties.Resources.loupe;
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSearch.Location = new System.Drawing.Point(357, 97);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(125, 68);
            this.ButtonSearch.TabIndex = 5;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // CmbPosition
            // 
            this.CmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPosition.FormattingEnabled = true;
            this.CmbPosition.Location = new System.Drawing.Point(481, 47);
            this.CmbPosition.Name = "CmbPosition";
            this.CmbPosition.Size = new System.Drawing.Size(184, 33);
            this.CmbPosition.TabIndex = 4;
            // 
            // TextPosition
            // 
            this.TextPosition.AutoSize = true;
            this.TextPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPosition.Location = new System.Drawing.Point(352, 53);
            this.TextPosition.Name = "TextPosition";
            this.TextPosition.Size = new System.Drawing.Size(89, 25);
            this.TextPosition.TabIndex = 10;
            this.TextPosition.Text = "Position";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(481, 3);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(184, 33);
            this.CmbDepartment.TabIndex = 3;
            // 
            // TextDepartment
            // 
            this.TextDepartment.AutoSize = true;
            this.TextDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDepartment.Location = new System.Drawing.Point(352, 9);
            this.TextDepartment.Name = "TextDepartment";
            this.TextDepartment.Size = new System.Drawing.Size(123, 25);
            this.TextDepartment.TabIndex = 8;
            this.TextDepartment.Text = "Department";
            // 
            // TextBoxSurName
            // 
            this.TextBoxSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxSurName.Location = new System.Drawing.Point(111, 92);
            this.TextBoxSurName.Name = "TextBoxSurName";
            this.TextBoxSurName.Size = new System.Drawing.Size(209, 30);
            this.TextBoxSurName.TabIndex = 2;
            // 
            // TxtSurName
            // 
            this.TxtSurName.AutoSize = true;
            this.TxtSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurName.Location = new System.Drawing.Point(12, 97);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(102, 25);
            this.TxtSurName.TabIndex = 6;
            this.TxtSurName.Text = "SurName";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxName.Location = new System.Drawing.Point(111, 48);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(209, 30);
            this.TextBoxName.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(12, 53);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(68, 25);
            this.TxtName.TabIndex = 4;
            this.TxtName.Text = "Name";
            // 
            // TxtBoxUserNo
            // 
            this.TxtBoxUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxUserNo.Location = new System.Drawing.Point(111, 4);
            this.TxtBoxUserNo.Name = "TxtBoxUserNo";
            this.TxtBoxUserNo.Size = new System.Drawing.Size(209, 30);
            this.TxtBoxUserNo.TabIndex = 0;
            this.TxtBoxUserNo.TextChanged += new System.EventHandler(this.TxtBoxUserNo_TextChanged);
            this.TxtBoxUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserNo_KeyPress);
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNo.Location = new System.Drawing.Point(12, 9);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(84, 25);
            this.UserNo.TabIndex = 2;
            this.UserNo.Text = "UserNo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonClose);
            this.panel2.Controls.Add(this.ButtonUpdate);
            this.panel2.Controls.Add(this.ButtonDelete);
            this.panel2.Controls.Add(this.ButtonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 147);
            this.panel2.TabIndex = 2;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Image = global::PersonalTracking.Properties.Resources.close;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClose.Location = new System.Drawing.Point(513, 38);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(132, 68);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.Image = global::PersonalTracking.Properties.Resources.turnover;
            this.ButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonUpdate.Location = new System.Drawing.Point(212, 38);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(125, 68);
            this.ButtonUpdate.TabIndex = 1;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Image = global::PersonalTracking.Properties.Resources.garbage;
            this.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDelete.Location = new System.Drawing.Point(357, 38);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(132, 68);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Image = global::PersonalTracking.Properties.Resources.AddMaleEmployee;
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonAdd.Location = new System.Drawing.Point(67, 38);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(125, 68);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TxtBoxUserNo;
        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.TextBox TextBoxSurName;
        private System.Windows.Forms.Label TxtSurName;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ComboBox CmbPosition;
        private System.Windows.Forms.Label TextPosition;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label TextDepartment;
    }
}