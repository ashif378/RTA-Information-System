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
    public partial class employee_service : Form
    {
        public employee_service()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LLR_form frm3 = new LLR_form();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LLR_renew_form frm4 = new LLR_renew_form();
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            permanent_form frm5 = new permanent_form();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parmanent_renew_form frm6 = new parmanent_renew_form();
            frm6.Show();
        }

        /*private void button5_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }*/

        private void button6_Click(object sender, EventArgs e)
        {
            /*Form1 frm1 = new Form1();
            frm1.Show();*/
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            challan frm8 = new challan();
            frm8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LLR_view frm9 = new LLR_view();
            frm9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LLR_renew_list frm12 = new LLR_renew_list();
            frm12.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            parma_lic_list frm10 = new parma_lic_list();
            frm10.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            parma_renew_lic frm11 = new parma_renew_lic();
            frm11.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            challan_view challan = new challan_view();
            challan.Show();
        }
    }
}
