using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RTA_Information_System
{
    public partial class home : Form
    {
        public home()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                employee_login frm13 = new employee_login();
                frm13.Show();
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            admin_login frm14 = new admin_login();
            frm14.Show();
        }
    }
}
