namespace HRManagement.View
{
    partial class JobSearchForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNextToInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(571, 512);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNextToInfo
            // 
            this.btnNextToInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnNextToInfo.ForeColor = System.Drawing.Color.White;
            this.btnNextToInfo.Location = new System.Drawing.Point(674, 512);
            this.btnNextToInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextToInfo.Name = "btnNextToInfo";
            this.btnNextToInfo.Size = new System.Drawing.Size(99, 38);
            this.btnNextToInfo.TabIndex = 2;
            this.btnNextToInfo.Text = "Back";
            this.btnNextToInfo.UseVisualStyleBackColor = false;
            this.btnNextToInfo.Click += new System.EventHandler(this.btnNextToInfo_Click);
            // 
            // JobSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextToInfo);
            this.Name = "JobSearchForm";
            this.Text = "JobSearchForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNextToInfo;
    }
}