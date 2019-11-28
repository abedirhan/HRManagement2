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
            this.components = new System.ComponentModel.Container();
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBackToInfo = new System.Windows.Forms.Button();
            this.employeeInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.JobInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ManagerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DepartmentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmpLName = new System.Windows.Forms.Label();
            this.txtEmpLName = new System.Windows.Forms.TextBox();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.lblEmpPhone = new System.Windows.Forms.Label();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.lblEmpHireDate = new System.Windows.Forms.Label();
            this.lblEmpSalary = new System.Windows.Forms.Label();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.cmbDepartmentId = new System.Windows.Forms.ComboBox();
            this.cmbDepartmentName = new System.Windows.Forms.ComboBox();
            this.lblJobId = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.cmbJobId = new System.Windows.Forms.ComboBox();
            this.cmbJobTitle = new System.Windows.Forms.ComboBox();
            this.M = new System.Windows.Forms.Label();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.cmbManagerId = new System.Windows.Forms.ComboBox();
            this.cmbManagerName = new System.Windows.Forms.ComboBox();
            this.lblManagerLName = new System.Windows.Forms.Label();
            this.cmbManagerLName = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new HRManagement.DataSet1();
            this.jOBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOBSTableAdapter = new HRManagement.DataSet1TableAdapters.JOBSTableAdapter();
            this.dEPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSTableAdapter = new HRManagement.DataSet1TableAdapters.DEPARTMENTSTableAdapter();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new HRManagement.DataSet1TableAdapters.EMPLOYEESTableAdapter();
            this.btnHireEmployee = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.employeeInfoGroupBox.SuspendLayout();
            this.JobInfoGroupBox.SuspendLayout();
            this.ManagerInfoGroupBox.SuspendLayout();
            this.DepartmentInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGridView.Location = new System.Drawing.Point(4, 343);
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.RowTemplate.Height = 33;
            this.EmployeesDataGridView.Size = new System.Drawing.Size(778, 171);
            this.EmployeesDataGridView.TabIndex = 0;
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
            // btnBackToInfo
            // 
            this.btnBackToInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnBackToInfo.ForeColor = System.Drawing.Color.White;
            this.btnBackToInfo.Location = new System.Drawing.Point(677, 519);
            this.btnBackToInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToInfo.Name = "btnBackToInfo";
            this.btnBackToInfo.Size = new System.Drawing.Size(99, 38);
            this.btnBackToInfo.TabIndex = 4;
            this.btnBackToInfo.Text = "Back";
            this.btnBackToInfo.UseVisualStyleBackColor = false;
            this.btnBackToInfo.Click += new System.EventHandler(this.btnBackToInfo_Click);
            // 
            // employeeInfoGroupBox
            // 
            this.employeeInfoGroupBox.Controls.Add(this.dateTimePicker);
            this.employeeInfoGroupBox.Controls.Add(this.txtEmpSalary);
            this.employeeInfoGroupBox.Controls.Add(this.lblEmpSalary);
            this.employeeInfoGroupBox.Controls.Add(this.lblEmpHireDate);
            this.employeeInfoGroupBox.Controls.Add(this.txtEmpPhone);
            this.employeeInfoGroupBox.Controls.Add(this.lblEmpPhone);
            this.employeeInfoGroupBox.Controls.Add(this.txtEmpEmail);
            this.employeeInfoGroupBox.Controls.Add(this.lblEmpEmail);
            this.employeeInfoGroupBox.Controls.Add(this.txtEmpLName);
            this.employeeInfoGroupBox.Controls.Add(this.lblEmpLName);
            this.employeeInfoGroupBox.Controls.Add(this.txtEmpName);
            this.employeeInfoGroupBox.Controls.Add(this.lblEmpName);
            this.employeeInfoGroupBox.Location = new System.Drawing.Point(10, 4);
            this.employeeInfoGroupBox.Name = "employeeInfoGroupBox";
            this.employeeInfoGroupBox.Size = new System.Drawing.Size(772, 100);
            this.employeeInfoGroupBox.TabIndex = 5;
            this.employeeInfoGroupBox.TabStop = false;
            this.employeeInfoGroupBox.Text = "Employee Info";
            // 
            // JobInfoGroupBox
            // 
            this.JobInfoGroupBox.Controls.Add(this.cmbJobTitle);
            this.JobInfoGroupBox.Controls.Add(this.cmbJobId);
            this.JobInfoGroupBox.Controls.Add(this.lblJobId);
            this.JobInfoGroupBox.Controls.Add(this.lblJobTitle);
            this.JobInfoGroupBox.Location = new System.Drawing.Point(10, 111);
            this.JobInfoGroupBox.Name = "JobInfoGroupBox";
            this.JobInfoGroupBox.Size = new System.Drawing.Size(772, 71);
            this.JobInfoGroupBox.TabIndex = 5;
            this.JobInfoGroupBox.TabStop = false;
            this.JobInfoGroupBox.Text = "Job Info";
            // 
            // ManagerInfoGroupBox
            // 
            this.ManagerInfoGroupBox.Controls.Add(this.cmbManagerLName);
            this.ManagerInfoGroupBox.Controls.Add(this.cmbManagerName);
            this.ManagerInfoGroupBox.Controls.Add(this.lblManagerLName);
            this.ManagerInfoGroupBox.Controls.Add(this.cmbManagerId);
            this.ManagerInfoGroupBox.Controls.Add(this.M);
            this.ManagerInfoGroupBox.Controls.Add(this.lblManagerID);
            this.ManagerInfoGroupBox.Location = new System.Drawing.Point(10, 189);
            this.ManagerInfoGroupBox.Name = "ManagerInfoGroupBox";
            this.ManagerInfoGroupBox.Size = new System.Drawing.Size(772, 71);
            this.ManagerInfoGroupBox.TabIndex = 5;
            this.ManagerInfoGroupBox.TabStop = false;
            this.ManagerInfoGroupBox.Text = "Manager Info";
            // 
            // DepartmentInfoGroupBox
            // 
            this.DepartmentInfoGroupBox.Controls.Add(this.cmbDepartmentName);
            this.DepartmentInfoGroupBox.Controls.Add(this.cmbDepartmentId);
            this.DepartmentInfoGroupBox.Controls.Add(this.lblDepartmentName);
            this.DepartmentInfoGroupBox.Controls.Add(this.lblDepartmentId);
            this.DepartmentInfoGroupBox.Location = new System.Drawing.Point(10, 266);
            this.DepartmentInfoGroupBox.Name = "DepartmentInfoGroupBox";
            this.DepartmentInfoGroupBox.Size = new System.Drawing.Size(772, 71);
            this.DepartmentInfoGroupBox.TabIndex = 5;
            this.DepartmentInfoGroupBox.TabStop = false;
            this.DepartmentInfoGroupBox.Text = "Department Info";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpName.Location = new System.Drawing.Point(26, 28);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(82, 18);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "First  Name:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(106, 24);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(143, 24);
            this.txtEmpName.TabIndex = 1;
            // 
            // lblEmpLName
            // 
            this.lblEmpLName.AutoSize = true;
            this.lblEmpLName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpLName.Location = new System.Drawing.Point(30, 58);
            this.lblEmpLName.Name = "lblEmpLName";
            this.lblEmpLName.Size = new System.Drawing.Size(76, 18);
            this.lblEmpLName.TabIndex = 0;
            this.lblEmpLName.Text = "Last Name:";
            // 
            // txtEmpLName
            // 
            this.txtEmpLName.Location = new System.Drawing.Point(106, 54);
            this.txtEmpLName.Name = "txtEmpLName";
            this.txtEmpLName.Size = new System.Drawing.Size(143, 24);
            this.txtEmpLName.TabIndex = 1;
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpEmail.Location = new System.Drawing.Point(291, 27);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(46, 18);
            this.lblEmpEmail.TabIndex = 0;
            this.lblEmpEmail.Text = "Email:";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(335, 24);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(150, 24);
            this.txtEmpEmail.TabIndex = 1;
            // 
            // lblEmpPhone
            // 
            this.lblEmpPhone.AutoSize = true;
            this.lblEmpPhone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpPhone.Location = new System.Drawing.Point(285, 57);
            this.lblEmpPhone.Name = "lblEmpPhone";
            this.lblEmpPhone.Size = new System.Drawing.Size(52, 18);
            this.lblEmpPhone.TabIndex = 0;
            this.lblEmpPhone.Text = "Phone:";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(335, 54);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(150, 24);
            this.txtEmpPhone.TabIndex = 1;
            // 
            // lblEmpHireDate
            // 
            this.lblEmpHireDate.AutoSize = true;
            this.lblEmpHireDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpHireDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpHireDate.Location = new System.Drawing.Point(500, 28);
            this.lblEmpHireDate.Name = "lblEmpHireDate";
            this.lblEmpHireDate.Size = new System.Drawing.Size(70, 18);
            this.lblEmpHireDate.TabIndex = 0;
            this.lblEmpHireDate.Text = "Hire Date:";
            // 
            // lblEmpSalary
            // 
            this.lblEmpSalary.AutoSize = true;
            this.lblEmpSalary.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSalary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpSalary.Location = new System.Drawing.Point(521, 55);
            this.lblEmpSalary.Name = "lblEmpSalary";
            this.lblEmpSalary.Size = new System.Drawing.Size(49, 18);
            this.lblEmpSalary.TabIndex = 0;
            this.lblEmpSalary.Text = "Salary:";
            this.lblEmpSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(567, 51);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(170, 24);
            this.txtEmpSalary.TabIndex = 1;
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.AutoSize = true;
            this.lblDepartmentId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartmentId.Location = new System.Drawing.Point(6, 31);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(102, 18);
            this.lblDepartmentId.TabIndex = 0;
            this.lblDepartmentId.Text = "Department Id:";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartmentName.Location = new System.Drawing.Point(255, 31);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(82, 18);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Dept Name:";
            // 
            // cmbDepartmentId
            // 
            this.cmbDepartmentId.DataSource = this.dEPARTMENTSBindingSource;
            this.cmbDepartmentId.DisplayMember = "DEPARTMENT_ID";
            this.cmbDepartmentId.FormattingEnabled = true;
            this.cmbDepartmentId.Location = new System.Drawing.Point(106, 25);
            this.cmbDepartmentId.Name = "cmbDepartmentId";
            this.cmbDepartmentId.Size = new System.Drawing.Size(143, 23);
            this.cmbDepartmentId.TabIndex = 2;
            // 
            // cmbDepartmentName
            // 
            this.cmbDepartmentName.DataSource = this.dEPARTMENTSBindingSource;
            this.cmbDepartmentName.DisplayMember = "DEPARTMENT_NAME";
            this.cmbDepartmentName.FormattingEnabled = true;
            this.cmbDepartmentName.Location = new System.Drawing.Point(335, 25);
            this.cmbDepartmentName.Name = "cmbDepartmentName";
            this.cmbDepartmentName.Size = new System.Drawing.Size(150, 23);
            this.cmbDepartmentName.TabIndex = 2;
            // 
            // lblJobId
            // 
            this.lblJobId.AutoSize = true;
            this.lblJobId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblJobId.Location = new System.Drawing.Point(58, 27);
            this.lblJobId.Name = "lblJobId";
            this.lblJobId.Size = new System.Drawing.Size(48, 18);
            this.lblJobId.TabIndex = 0;
            this.lblJobId.Text = "Job Id:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblJobTitle.Location = new System.Drawing.Point(273, 27);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(64, 18);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // cmbJobId
            // 
            this.cmbJobId.DataSource = this.jOBSBindingSource;
            this.cmbJobId.DisplayMember = "JOB_ID";
            this.cmbJobId.FormattingEnabled = true;
            this.cmbJobId.Location = new System.Drawing.Point(106, 27);
            this.cmbJobId.Name = "cmbJobId";
            this.cmbJobId.Size = new System.Drawing.Size(143, 23);
            this.cmbJobId.TabIndex = 2;
            // 
            // cmbJobTitle
            // 
            this.cmbJobTitle.DataSource = this.jOBSBindingSource;
            this.cmbJobTitle.DisplayMember = "JOB_TITLE";
            this.cmbJobTitle.FormattingEnabled = true;
            this.cmbJobTitle.Location = new System.Drawing.Point(335, 27);
            this.cmbJobTitle.Name = "cmbJobTitle";
            this.cmbJobTitle.Size = new System.Drawing.Size(150, 23);
            this.cmbJobTitle.TabIndex = 2;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.M.Location = new System.Drawing.Point(258, 31);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(79, 18);
            this.M.TabIndex = 0;
            this.M.Text = "First Name:";
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblManagerID.Location = new System.Drawing.Point(14, 32);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(91, 18);
            this.lblManagerID.TabIndex = 0;
            this.lblManagerID.Text = "Manager E Id:";
            // 
            // cmbManagerId
            // 
            this.cmbManagerId.DataSource = this.eMPLOYEESBindingSource;
            this.cmbManagerId.DisplayMember = "EMPLOYEE_ID";
            this.cmbManagerId.FormattingEnabled = true;
            this.cmbManagerId.Location = new System.Drawing.Point(106, 28);
            this.cmbManagerId.Name = "cmbManagerId";
            this.cmbManagerId.Size = new System.Drawing.Size(143, 23);
            this.cmbManagerId.TabIndex = 2;
            this.cmbManagerId.ValueMember = "MANAGER_ID";
            // 
            // cmbManagerName
            // 
            this.cmbManagerName.DataSource = this.eMPLOYEESBindingSource;
            this.cmbManagerName.DisplayMember = "FIRST_NAME";
            this.cmbManagerName.FormattingEnabled = true;
            this.cmbManagerName.Location = new System.Drawing.Point(335, 28);
            this.cmbManagerName.Name = "cmbManagerName";
            this.cmbManagerName.Size = new System.Drawing.Size(150, 23);
            this.cmbManagerName.TabIndex = 2;
            // 
            // lblManagerLName
            // 
            this.lblManagerLName.AutoSize = true;
            this.lblManagerLName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerLName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblManagerLName.Location = new System.Drawing.Point(499, 33);
            this.lblManagerLName.Name = "lblManagerLName";
            this.lblManagerLName.Size = new System.Drawing.Size(76, 18);
            this.lblManagerLName.TabIndex = 0;
            this.lblManagerLName.Text = "Last Name:";
            // 
            // cmbManagerLName
            // 
            this.cmbManagerLName.DataSource = this.eMPLOYEESBindingSource;
            this.cmbManagerLName.DisplayMember = "LAST_NAME";
            this.cmbManagerLName.FormattingEnabled = true;
            this.cmbManagerLName.Location = new System.Drawing.Point(567, 28);
            this.cmbManagerLName.Name = "cmbManagerLName";
            this.cmbManagerLName.Size = new System.Drawing.Size(170, 23);
            this.cmbManagerLName.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOBSBindingSource
            // 
            this.jOBSBindingSource.DataMember = "JOBS";
            this.jOBSBindingSource.DataSource = this.dataSet1;
            // 
            // jOBSTableAdapter
            // 
            this.jOBSTableAdapter.ClearBeforeFill = true;
            // 
            // dEPARTMENTSBindingSource
            // 
            this.dEPARTMENTSBindingSource.DataMember = "DEPARTMENTS";
            this.dEPARTMENTSBindingSource.DataSource = this.dataSet1;
            // 
            // dEPARTMENTSTableAdapter
            // 
            this.dEPARTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.dataSet1;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // btnHireEmployee
            // 
            this.btnHireEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.btnHireEmployee.ForeColor = System.Drawing.Color.White;
            this.btnHireEmployee.Location = new System.Drawing.Point(426, 519);
            this.btnHireEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnHireEmployee.Name = "btnHireEmployee";
            this.btnHireEmployee.Size = new System.Drawing.Size(144, 38);
            this.btnHireEmployee.TabIndex = 3;
            this.btnHireEmployee.Text = "Hire Employee";
            this.btnHireEmployee.UseVisualStyleBackColor = false;
            this.btnHireEmployee.Click += new System.EventHandler(this.btnHireEmployee_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(567, 24);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblError.Location = new System.Drawing.Point(4, 522);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(417, 33);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error Display Screen";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeHiringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.DepartmentInfoGroupBox);
            this.Controls.Add(this.ManagerInfoGroupBox);
            this.Controls.Add(this.JobInfoGroupBox);
            this.Controls.Add(this.employeeInfoGroupBox);
            this.Controls.Add(this.btnHireEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBackToInfo);
            this.Controls.Add(this.EmployeesDataGridView);
            this.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeHiringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Hire Form";
            this.Load += new System.EventHandler(this.EmployeeHiringForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.employeeInfoGroupBox.ResumeLayout(false);
            this.employeeInfoGroupBox.PerformLayout();
            this.JobInfoGroupBox.ResumeLayout(false);
            this.JobInfoGroupBox.PerformLayout();
            this.ManagerInfoGroupBox.ResumeLayout(false);
            this.ManagerInfoGroupBox.PerformLayout();
            this.DepartmentInfoGroupBox.ResumeLayout(false);
            this.DepartmentInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesDataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBackToInfo;
        private System.Windows.Forms.GroupBox employeeInfoGroupBox;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Label lblEmpSalary;
        private System.Windows.Forms.Label lblEmpHireDate;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.Label lblEmpPhone;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.TextBox txtEmpLName;
        private System.Windows.Forms.Label lblEmpLName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.GroupBox JobInfoGroupBox;
        private System.Windows.Forms.ComboBox cmbJobTitle;
        private System.Windows.Forms.ComboBox cmbJobId;
        private System.Windows.Forms.Label lblJobId;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.GroupBox ManagerInfoGroupBox;
        private System.Windows.Forms.ComboBox cmbManagerLName;
        private System.Windows.Forms.ComboBox cmbManagerName;
        private System.Windows.Forms.Label lblManagerLName;
        private System.Windows.Forms.ComboBox cmbManagerId;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.GroupBox DepartmentInfoGroupBox;
        private System.Windows.Forms.ComboBox cmbDepartmentName;
        private System.Windows.Forms.ComboBox cmbDepartmentId;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentId;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource jOBSBindingSource;
        private DataSet1TableAdapters.JOBSTableAdapter jOBSTableAdapter;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private DataSet1TableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private DataSet1TableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.Button btnHireEmployee;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblError;
    }
}

