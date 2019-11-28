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
    public partial class JobSearchForm : Form
    {
        public JobSearchForm()
        {
            InitializeComponent();
        }

        private void btnNextToInfo_Click(object sender, EventArgs e)
        {
            Program.Forms[FormEnum.MainForm].Show();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
