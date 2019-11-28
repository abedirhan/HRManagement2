using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRManagement.View;

namespace HRManagement
{
   public static class Program
    {
        public static Dictionary<FormEnum, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormEnum, Form>();
            Forms.Add(FormEnum.MainForm, new MainForm());
            Forms.Add(FormEnum.EmpEditForm, new EmpEditForm());
            Forms.Add(FormEnum.JobForm, new JobForm());
            Forms.Add(FormEnum.JobSearchForm, new JobSearchForm());
            Forms.Add(FormEnum.EmployeeHiringForm, new EmployeeHiringForm());

            Application.Run(new MainForm());
        }
    }
}
