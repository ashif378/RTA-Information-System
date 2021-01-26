using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTA_Information_System
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp_view emp = new emp_view();
            emp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employee_service frm2 = new employee_service();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emp_pass EmpPass = new emp_pass();
            EmpPass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_emp frm2 = new add_emp();
            frm2.Show();
        }
    }
}
