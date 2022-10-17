namespace PersonalTracking
{
    partial class FrmPositionList
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
            this.DataPositionList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataPositionList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataPositionList
            // 
            this.DataPositionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPositionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPositionList.Location = new System.Drawing.Point(0, 0);
            this.DataPositionList.Name = "DataPositionList";
            this.DataPositionList.RowHeadersWidth = 51;
            this.DataPositionList.RowTemplate.Height = 24;
            this.DataPositionList.Size = new System.Drawing.Size(677, 294);
            this.DataPositionList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonClose);
            this.panel1.Controls.Add(this.ButtonUpdate);
            this.panel1.Controls.Add(this.ButtonDelete);
            this.panel1.Controls.Add(this.ButtonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 150);
            this.panel1.TabIndex = 1;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Image = global::PersonalTracking.Properties.Resources.close;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClose.Location = new System.Drawing.Point(491, 43);
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
            this.ButtonUpdate.Location = new System.Drawing.Point(190, 43);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(125, 68);
            this.ButtonUpdate.TabIndex = 1;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Image = global::PersonalTracking.Properties.Resources.garbage;
            this.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDelete.Location = new System.Drawing.Point(335, 43);
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
            this.ButtonAdd.Location = new System.Drawing.Point(45, 43);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(125, 68);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FrmPositionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataPositionList);
            this.Name = "FrmPositionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPositionList";
            this.Load += new System.EventHandler(this.FrmPositionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPositionList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataPositionList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAdd;
    }
}