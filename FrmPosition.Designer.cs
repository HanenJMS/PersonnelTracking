namespace PersonalTracking
{
    partial class FrmPosition
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
            this.TextPosition = new System.Windows.Forms.Label();
            this.TextBoxPosition = new System.Windows.Forms.TextBox();
            this.TextDepartment = new System.Windows.Forms.Label();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextPosition
            // 
            this.TextPosition.AutoSize = true;
            this.TextPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPosition.Location = new System.Drawing.Point(21, 34);
            this.TextPosition.Name = "TextPosition";
            this.TextPosition.Size = new System.Drawing.Size(89, 25);
            this.TextPosition.TabIndex = 0;
            this.TextPosition.Text = "Position";
            // 
            // TextBoxPosition
            // 
            this.TextBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPosition.Location = new System.Drawing.Point(178, 34);
            this.TextBoxPosition.Name = "TextBoxPosition";
            this.TextBoxPosition.Size = new System.Drawing.Size(184, 30);
            this.TextBoxPosition.TabIndex = 0;
            // 
            // TextDepartment
            // 
            this.TextDepartment.AutoSize = true;
            this.TextDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDepartment.Location = new System.Drawing.Point(21, 93);
            this.TextDepartment.Name = "TextDepartment";
            this.TextDepartment.Size = new System.Drawing.Size(123, 25);
            this.TextDepartment.TabIndex = 2;
            this.TextDepartment.Text = "Department";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(178, 85);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(184, 33);
            this.CmbDepartment.TabIndex = 1;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Location = new System.Drawing.Point(205, 146);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(125, 54);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(41, 146);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(137, 54);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 236);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.CmbDepartment);
            this.Controls.Add(this.TextDepartment);
            this.Controls.Add(this.TextBoxPosition);
            this.Controls.Add(this.TextPosition);
            this.Name = "FrmPosition";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.FrmPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextPosition;
        private System.Windows.Forms.TextBox TextBoxPosition;
        private System.Windows.Forms.Label TextDepartment;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSave;
    }
}