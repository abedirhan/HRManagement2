using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagement.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHireNewEmployee_Click(object sender, EventArgs e)
        {
            Program.Forms[FormEnum.EmployeeHiringForm].Show();
            Hide();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            Program.Forms[FormEnum.EmpEditForm].Show();
            Hide();
        }

        private void btnCreateNewJob_Click(object sender, EventArgs e)
        {
            Program.Forms[FormEnum.JobForm].Show();
            Hide();
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            Program.Forms[FormEnum.JobForm].Show();
            Hide();

        }

        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            Program.Forms[FormEnum.JobSearchForm].Show();
            Hide();
        }
    }
}
