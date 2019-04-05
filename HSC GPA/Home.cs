using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_GPA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Individual_Result ir = new Individual_Result();
            ir.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubBothPapers sbp = new SubBothPapers();
            sbp.Show();
            
        }
    }
}
