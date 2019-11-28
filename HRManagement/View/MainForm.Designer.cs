namespace HRManagement.View
{
    partial class MainForm
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
            this.LblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHireNewEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateNewJob = new System.Windows.Forms.Button();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnSearchJob = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblWelcome.Location = new System.Drawing.Point(238, 16);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(483, 58);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Hr APPLICATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LblWelcome);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 95);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 70);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(536, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "© 2019 Copyright, All rights reserved®";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HRManagement.Properties.Resources.download_human_resources_management_human_resource_png_image_human_resource_png_1000_907;
            this.pictureBox3.Location = new System.Drawing.Point(322, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(440, 340);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRManagement.Properties.Resources.apptech;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HRManagement.Properties.Resources.LogoN;
            this.pictureBox2.Location = new System.Drawing.Point(3, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnHireNewEmployee
            // 
            this.btnHireNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHireNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnHireNewEmployee.Font = new System.Drawing.Font("Corbel", 19F);
            this.btnHireNewEmployee.ForeColor = System.Drawing.Color.White;
            this.btnHireNewEmployee.Location = new System.Drawing.Point(6, 128);
            this.btnHireNewEmployee.Name = "btnHireNewEmployee";
            this.btnHireNewEmployee.Size = new System.Drawing.Size(278, 41);
            this.btnHireNewEmployee.TabIndex = 5;
            this.btnHireNewEmployee.Text = "Hire New Employee";
            this.btnHireNewEmployee.UseVisualStyleBackColor = false;
            this.btnHireNewEmployee.Click += new System.EventHandler(this.btnHireNewEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnEditEmployee.Font = new System.Drawing.Font("Corbel", 19F);
            this.btnEditEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEditEmployee.Location = new System.Drawing.Point(6, 175);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(278, 41);
            this.btnEditEmployee.TabIndex = 6;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnExit.Font = new System.Drawing.Font("Corbel", 19F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(6, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(278, 41);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateNewJob
            // 
            this.btnCreateNewJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNewJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnCreateNewJob.Font = new System.Drawing.Font("Corbel", 19F);
            this.btnCreateNewJob.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewJob.Location = new System.Drawing.Point(6, 222);
            this.btnCreateNewJob.Name = "btnCreateNewJob";
            this.btnCreateNewJob.Size = new System.Drawing.Size(278, 41);
            this.btnCreateNewJob.TabIndex = 6;
            this.btnCreateNewJob.Text = "Create a New Job";
            this.btnCreateNewJob.UseVisualStyleBackColor = false;
            this.btnCreateNewJob.Click += new System.EventHandler(this.btnCreateNewJob_Click);
            // 
            // btnEditJob
            // 
            this.btnEditJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnEditJob.Font = new System.Drawing.Font("Corbel", 19F);
            this.btnEditJob.ForeColor = System.Drawing.Color.White;
            this.btnEditJob.Location = new System.Drawing.Point(6, 269);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(278, 41);
            this.btnEditJob.TabIndex = 6;
            this.btnEditJob.Text = "Edit Job";
            this.btnEditJob.UseVisualStyleBackColor = false;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnSearchJob
            // 
            this.btnSearchJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnSearchJob.Font = new System.Drawing.Font("Corbel", 19F);
            this.btnSearchJob.ForeColor = System.Drawing.Color.White;
            this.btnSearchJob.Location = new System.Drawing.Point(6, 316);
            this.btnSearchJob.Name = "btnSearchJob";
            this.btnSearchJob.Size = new System.Drawing.Size(278, 41);
            this.btnSearchJob.TabIndex = 6;
            this.btnSearchJob.Text = "Search Job Title";
            this.btnSearchJob.UseVisualStyleBackColor = false;
            this.btnSearchJob.Click += new System.EventHandler(this.btnSearchJob_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.btnSearchJob);
            this.Controls.Add(this.btnEditJob);
            this.Controls.Add(this.btnCreateNewJob);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHireNewEmployee);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnHireNewEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateNewJob;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnSearchJob;
    }
}