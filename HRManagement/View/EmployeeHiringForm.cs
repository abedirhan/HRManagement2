using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Drawing.Text;
using HRManagement.View;

namespace HRManagement
{
    public partial class EmployeeHiringForm : Form
    {

        private OracleConnection conn = new OracleConnection();
        private OracleCommand cmd;
        private OracleDataAdapter da;
        private OracleCommandBuilder cb;
        private DataSet ds;

        //Connection set
        private void SetConnection()
        {
            String connectionString = ConfigurationManager
                .ConnectionStrings["HRManagement.Properties.Settings.ConnectionString"].ConnectionString;
            conn = new OracleConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e) { }
        }
        public EmployeeHiringForm()
        {
            this.SetConnection();
            InitializeComponent();

        }

        private void UpdateDataGrid()
        {

            string sql = "SELECT employees.first_name," +
            "employees.last_name," +
            "employees.email," +
            " employees.phone_number," +
            "employees.hire_date," +
            "  employees.job_id," +
            " employees.salary," +
           " employees.manager_id," +
           " employees.department_id," +
           " employees.employee_id," +
           " employees1.first_name AS Manager_FirstN," +
           "     employees1.last_name AS Manager_LastN," +
           "     comp214_f19_ers_25.jobs.job_title," +
           " comp214_f19_ers_25.jobs.job_id AS job_id1," +
           "     comp214_f19_ers_25.departments.department_name," +
           " comp214_f19_ers_25.departments.department_id AS department_id1" +
           "     FROM" +
           " employees" +
           "     INNER JOIN comp214_f19_ers_25.employees employees1 ON employees1.employee_id = employees.manager_id" +
           " INNER JOIN comp214_f19_ers_25.jobs ON comp214_f19_ers_25.jobs.job_id = employees.job_id" +
           " INNER JOIN comp214_f19_ers_25.departments ON comp214_f19_ers_25.departments.department_id = employees.department_id";
            cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            da = new OracleDataAdapter(cmd);
            cb = new OracleCommandBuilder(da);
            ds = new DataSet();

            da.Fill(ds);

            EmployeesDataGridView.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void EmployeeHiringForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.dataSet1.EMPLOYEES);
            // TODO: This line of code loads data into the 'dataSet1.DEPARTMENTS' table. You can move, or remove it, as needed.
            this.dEPARTMENTSTableAdapter.Fill(this.dataSet1.DEPARTMENTS);
            // TODO: This line of code loads data into the 'dataSet1.JOBS' table. You can move, or remove it, as needed.
            this.jOBSTableAdapter.Fill(this.dataSet1.JOBS);
            UpdateDataGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToInfo_Click(object sender, EventArgs e)
        {
            Program.Forms[FormEnum.MainForm].Show();
            Hide();

        }

        private void btnHireEmployee_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new OracleCommand("EMPLOYEE_HIRE_SP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_first_name", OracleDbType.Varchar2).Value = txtEmpName.Text;
            cmd.Parameters.Add("p_last_name", OracleDbType.Varchar2).Value = txtEmpName.Text;
            cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = txtEmpEmail.Text;
            cmd.Parameters.Add("p_salary", OracleDbType.Double).Value = txtEmpSalary.Text;


            int year = dateTimePicker.Value.Year;
            int month = dateTimePicker.Value.Month;
            int day = dateTimePicker.Value.Day;
            DateTime dateTime = new DateTime(year, month, day);

            cmd.Parameters.Add("p_hire_date", OracleDbType.Date).Value = dateTime;

            cmd.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = txtEmpPhone.Text;
            cmd.Parameters.Add("p_job_id", OracleDbType.Varchar2).Value = cmbJobId.SelectedIndex;
            cmd.Parameters.Add("p_manager_id", OracleDbType.Int32).Value = cmbManagerId.SelectedIndex;
            cmd.Parameters.Add("p_department_id", OracleDbType.Int32).Value = cmbDepartmentId.SelectedIndex;

            da = new OracleDataAdapter(cmd);
            try
            {

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                if (ex.Message.Substring(0,9)== "ORA-20202")
                {
                    lblError.Text = "Check Salary Range";
                }
            }
            da.Fill(ds);
            conn.Close();

        }
    }
}
