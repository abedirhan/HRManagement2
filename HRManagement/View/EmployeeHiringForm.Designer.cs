namespace HRManagement
{
    partial class EmployeeHiringForm
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
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.BtnIncreaseSal = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtUpdateValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNextToInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGridView.Location = new System.Drawing.Point(4, 346);
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.RowTemplate.Height = 33;
            this.EmployeesDataGridView.Size = new System.Drawing.Size(778, 168);
            this.EmployeesDataGridView.TabIndex = 0;
            // 
            // BtnIncreaseSal
            // 
            this.BtnIncreaseSal.Location = new System.Drawing.Point(12, 269);
            this.BtnIncreaseSal.Name = "BtnIncreaseSal";
            this.BtnIncreaseSal.Size = new System.Drawing.Size(119, 71);
            this.BtnIncreaseSal.TabIndex = 1;
            this.BtnIncreaseSal.Text = "Increase";
            this.BtnIncreaseSal.UseVisualStyleBackColor = true;
            this.BtnIncreaseSal.Click += new System.EventHandler(this.BtnIncreaseSal_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(137, 269);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(171, 71);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Update Table";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtUpdateValue
            // 
            this.TxtUpdateValue.Location = new System.Drawing.Point(184, 118);
            this.TxtUpdateValue.Name = "TxtUpdateValue";
            this.TxtUpdateValue.Size = new System.Drawing.Size(335, 24);
            this.TxtUpdateValue.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(574, 519);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNextToInfo
            // 
            this.btnNextToInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnNextToInfo.ForeColor = System.Drawing.Color.White;
            this.btnNextToInfo.Location = new System.Drawing.Point(677, 519);
            this.btnNextToInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextToInfo.Name = "btnNextToInfo";
            this.btnNextToInfo.Size = new System.Drawing.Size(99, 38);
            this.btnNextToInfo.TabIndex = 4;
            this.btnNextToInfo.Text = "Back";
            this.btnNextToInfo.UseVisualStyleBackColor = false;
            this.btnNextToInfo.Click += new System.EventHandler(this.btnNextToInfo_Click);
            // 
            // EmployeeHiringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextToInfo);
            this.Controls.Add(this.TxtUpdateValue);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnIncreaseSal);
            this.Controls.Add(this.EmployeesDataGridView);
            this.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeHiringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Hire Form";
            this.Load += new System.EventHandler(this.EmployeeHiringForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesDataGridView;
        private System.Windows.Forms.Button BtnIncreaseSal;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtUpdateValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNextToInfo;
    }
}

