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

    public partial class AnySubRes : Form
    {
        GetSubTotal gst = new GetSubTotal();
        public AnySubRes()
        {
            InitializeComponent();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            gsub.Physics1stTheory = float.Parse(Physics1stTheory.Text);
            gsub.Physics1stPractical = float.Parse(Physics1stPractical.Text);
            gsub.Physics1stMCQ = float.Parse(Physics1stMCQ.Text);

            GetSubTotal gst = new GetSubTotal();
            gst.Physics1stTotal = gsub.Physics1stTheory + gsub.Physics1stPractical + gsub.Physics1stMCQ;
            {
                if (gst.Physics1stTotal < 101)
                {
                    Physics1stTotal.Text = gst.Physics1stTotal.ToString();
                    if (gst.Physics1stTotal <= 32)
                    {
                        Physics1stTotalPointbox.Text = "0";
                        Physics1stTotalGradebox.Text = "F";
                    }

                    if (gst.Physics1stTotal >= 33 && gst.Physics1stTotal <= 39)
                    {
                        Physics1stTotalPointbox.Text = "1";
                        Physics1stTotalGradebox.Text = "D";
                    }

                    if (gst.Physics1stTotal >= 40 && gst.Physics1stTotal <= 49)
                    {
                        Physics1stTotalPointbox.Text = "2";
                        Physics1stTotalGradebox.Text = "C";
                    }

                    if (gst.Physics1stTotal >= 50 && gst.Physics1stTotal <= 59)
                    {
                        Physics1stTotalPointbox.Text = "3";
                        Physics1stTotalGradebox.Text = "B";
                    }

                    if (gst.Physics1stTotal >= 60 && gst.Physics1stTotal <= 69)
                    {
                        Physics1stTotalPointbox.Text = "3.5";
                        Physics1stTotalGradebox.Text = "A-";
                    }

                    if (gst.Physics1stTotal >= 70 && gst.Physics1stTotal <= 79)
                    {
                        Physics1stTotalPointbox.Text = "4";
                        Physics1stTotalGradebox.Text = "A";
                    }

                    if (gst.Physics1stTotal >= 80 && gst.Physics1stTotal <= 100)
                    {
                        Physics1stTotalPointbox.Text = "5";
                        Physics1stTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Physics 1st Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }
    }
}
