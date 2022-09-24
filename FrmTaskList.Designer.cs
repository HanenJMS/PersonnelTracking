namespace PersonalTracking
{
    partial class FrmTaskList
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.StateTask = new System.Windows.Forms.ComboBox();
            this.TaskState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeliveryDate = new System.Windows.Forms.RadioButton();
            this.StartDate = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TaskFinish = new System.Windows.Forms.Label();
            this.TaskStart = new System.Windows.Forms.Label();
            this.TaskDate = new System.Windows.Forms.Label();
            this.PanelForAdmin = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonApprove = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelForAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PanelForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 270);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonClear);
            this.panel3.Controls.Add(this.ButtonSearch);
            this.panel3.Controls.Add(this.StateTask);
            this.panel3.Controls.Add(this.TaskState);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.TaskFinish);
            this.panel3.Controls.Add(this.TaskStart);
            this.panel3.Controls.Add(this.TaskDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(367, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 270);
            this.panel3.TabIndex = 2;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.Image = global::PersonalTracking.Properties.Resources.dust;
            this.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClear.Location = new System.Drawing.Point(216, 184);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(125, 68);
            this.ButtonClear.TabIndex = 4;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonClear.UseVisualStyleBackColor = true;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Image = global::PersonalTracking.Properties.Resources.loupe;
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSearch.Location = new System.Drawing.Point(60, 184);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(125, 68);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // StateTask
            // 
            this.StateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateTask.FormattingEnabled = true;
            this.StateTask.Location = new System.Drawing.Point(141, 129);
            this.StateTask.Name = "StateTask";
            this.StateTask.Size = new System.Drawing.Size(251, 33);
            this.StateTask.TabIndex = 2;
            // 
            // TaskState
            // 
            this.TaskState.AutoSize = true;
            this.TaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskState.Location = new System.Drawing.Point(18, 129);
            this.TaskState.Name = "TaskState";
            this.TaskState.Size = new System.Drawing.Size(117, 25);
            this.TaskState.TabIndex = 24;
            this.TaskState.Text = "Task State";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeliveryDate);
            this.groupBox1.Controls.Add(this.StartDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.AutoSize = true;
            this.DeliveryDate.Location = new System.Drawing.Point(7, 49);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(145, 24);
            this.DeliveryDate.TabIndex = 1;
            this.DeliveryDate.TabStop = true;
            this.DeliveryDate.Text = "Delivery Date";
            this.DeliveryDate.UseVisualStyleBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(7, 22);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(117, 24);
            this.StartDate.TabIndex = 0;
            this.StartDate.TabStop = true;
            this.StartDate.Text = "Start Date";
            this.StartDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(91, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(301, 26);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // TaskFinish
            // 
            this.TaskFinish.AutoSize = true;
            this.TaskFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskFinish.Location = new System.Drawing.Point(18, 89);
            this.TaskFinish.Name = "TaskFinish";
            this.TaskFinish.Size = new System.Drawing.Size(70, 25);
            this.TaskFinish.TabIndex = 19;
            this.TaskFinish.Text = "Finish";
            // 
            // TaskStart
            // 
            this.TaskStart.AutoSize = true;
            this.TaskStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskStart.Location = new System.Drawing.Point(18, 56);
            this.TaskStart.Name = "TaskStart";
            this.TaskStart.Size = new System.Drawing.Size(58, 25);
            this.TaskStart.TabIndex = 18;
            this.TaskStart.Text = "Start";
            // 
            // TaskDate
            // 
            this.TaskDate.AutoSize = true;
            this.TaskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDate.Location = new System.Drawing.Point(18, 9);
            this.TaskDate.Name = "TaskDate";
            this.TaskDate.Size = new System.Drawing.Size(111, 25);
            this.TaskDate.TabIndex = 17;
            this.TaskDate.Text = "Task Date";
            // 
            // PanelForAdmin
            // 
            this.PanelForAdmin.Controls.Add(this.CmbPosition);
            this.PanelForAdmin.Controls.Add(this.TextPosition);
            this.PanelForAdmin.Controls.Add(this.CmbDepartment);
            this.PanelForAdmin.Controls.Add(this.TextDepartment);
            this.PanelForAdmin.Controls.Add(this.TextBoxSurName);
            this.PanelForAdmin.Controls.Add(this.TxtSurName);
            this.PanelForAdmin.Controls.Add(this.TextBoxName);
            this.PanelForAdmin.Controls.Add(this.TxtName);
            this.PanelForAdmin.Controls.Add(this.TxtBoxUserNo);
            this.PanelForAdmin.Controls.Add(this.UserNo);
            this.PanelForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelForAdmin.Location = new System.Drawing.Point(0, 0);
            this.PanelForAdmin.Name = "PanelForAdmin";
            this.PanelForAdmin.Size = new System.Drawing.Size(367, 270);
            this.PanelForAdmin.TabIndex = 1;
            // 
            // CmbPosition
            // 
            this.CmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPosition.FormattingEnabled = true;
            this.CmbPosition.Location = new System.Drawing.Point(150, 192);
            this.CmbPosition.Name = "CmbPosition";
            this.CmbPosition.Size = new System.Drawing.Size(184, 33);
            this.CmbPosition.TabIndex = 4;
            // 
            // TextPosition
            // 
            this.TextPosition.AutoSize = true;
            this.TextPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPosition.Location = new System.Drawing.Point(21, 198);
            this.TextPosition.Name = "TextPosition";
            this.TextPosition.Size = new System.Drawing.Size(89, 25);
            this.TextPosition.TabIndex = 16;
            this.TextPosition.Text = "Position";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(150, 148);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(184, 33);
            this.CmbDepartment.TabIndex = 3;
            // 
            // TextDepartment
            // 
            this.TextDepartment.AutoSize = true;
            this.TextDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDepartment.Location = new System.Drawing.Point(21, 154);
            this.TextDepartment.Name = "TextDepartment";
            this.TextDepartment.Size = new System.Drawing.Size(123, 25);
            this.TextDepartment.TabIndex = 15;
            this.TextDepartment.Text = "Department";
            // 
            // TextBoxSurName
            // 
            this.TextBoxSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxSurName.Location = new System.Drawing.Point(125, 105);
            this.TextBoxSurName.Name = "TextBoxSurName";
            this.TextBoxSurName.Size = new System.Drawing.Size(209, 30);
            this.TextBoxSurName.TabIndex = 2;
            // 
            // TxtSurName
            // 
            this.TxtSurName.AutoSize = true;
            this.TxtSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurName.Location = new System.Drawing.Point(26, 110);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(102, 25);
            this.TxtSurName.TabIndex = 12;
            this.TxtSurName.Text = "SurName";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxName.Location = new System.Drawing.Point(125, 61);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(209, 30);
            this.TextBoxName.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(26, 66);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(68, 25);
            this.TxtName.TabIndex = 11;
            this.TxtName.Text = "Name";
            // 
            // TxtBoxUserNo
            // 
            this.TxtBoxUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBoxUserNo.Location = new System.Drawing.Point(125, 17);
            this.TxtBoxUserNo.Name = "TxtBoxUserNo";
            this.TxtBoxUserNo.Size = new System.Drawing.Size(209, 30);
            this.TxtBoxUserNo.TabIndex = 0;
            this.TxtBoxUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxUserNo_KeyPress);
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNo.Location = new System.Drawing.Point(26, 22);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(84, 25);
            this.UserNo.TabIndex = 10;
            this.UserNo.Text = "UserNo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonApprove);
            this.panel2.Controls.Add(this.ButtonClose);
            this.panel2.Controls.Add(this.ButtonUpdate);
            this.panel2.Controls.Add(this.ButtonDelete);
            this.panel2.Controls.Add(this.ButtonAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 136);
            this.panel2.TabIndex = 1;
            // 
            // ButtonApprove
            // 
            this.ButtonApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApprove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonApprove.Location = new System.Drawing.Point(100, 36);
            this.ButtonApprove.Name = "ButtonApprove";
            this.ButtonApprove.Size = new System.Drawing.Size(125, 68);
            this.ButtonApprove.TabIndex = 0;
            this.ButtonApprove.Text = "Approve";
            this.ButtonApprove.UseVisualStyleBackColor = true;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Image = global::PersonalTracking.Properties.Resources.close;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClose.Location = new System.Drawing.Point(693, 36);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(132, 68);
            this.ButtonClose.TabIndex = 4;
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
            this.ButtonUpdate.Location = new System.Drawing.Point(392, 36);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(125, 68);
            this.ButtonUpdate.TabIndex = 2;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Image = global::PersonalTracking.Properties.Resources.garbage;
            this.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDelete.Location = new System.Drawing.Point(537, 36);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(132, 68);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Image = global::PersonalTracking.Properties.Resources.AddMaleEmployee;
            this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonAdd.Location = new System.Drawing.Point(247, 36);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(125, 68);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(936, 281);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 687);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTaskList";
            this.Text = "Task List";
            this.Load += new System.EventHandler(this.FrmTaskList_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelForAdmin.ResumeLayout(false);
            this.PanelForAdmin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelForAdmin;
        private System.Windows.Forms.Button ButtonApprove;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextBoxSurName;
        private System.Windows.Forms.Label TxtSurName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.TextBox TxtBoxUserNo;
        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.Label TaskFinish;
        private System.Windows.Forms.Label TaskStart;
        private System.Windows.Forms.Label TaskDate;
        private System.Windows.Forms.ComboBox CmbPosition;
        private System.Windows.Forms.Label TextPosition;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label TextDepartment;
        private System.Windows.Forms.ComboBox StateTask;
        private System.Windows.Forms.Label TaskState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DeliveryDate;
        private System.Windows.Forms.RadioButton StartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSearch;
    }
}