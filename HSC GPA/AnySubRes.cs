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

        public AnySubRes()
        {
            InitializeComponent();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.Physics1stTheory = float.Parse(Physics1stTheory.Text);
                gsub.Physics1stPractical = float.Parse(Physics1stPractical.Text);
                gsub.Physics1stMCQ = float.Parse(Physics1stMCQ.Text);
            }

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

        private void Button12_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.Physics2ndTheory = float.Parse(Physics2ndTheory.Text);
                gsub.Physics2ndPractical = float.Parse(Physics2ndPractical.Text);
                gsub.Physics2ndMCQ = float.Parse(Physics2ndMCQ.Text);
            }

            GetSubTotal gst = new GetSubTotal();
            gst.Physics2ndTotal = gsub.Physics2ndTheory + gsub.Physics2ndPractical + gsub.Physics2ndMCQ;
            {
                if (gst.Physics2ndTotal < 101)
                {
                    Physics2ndTotal.Text = gst.Physics2ndTotal.ToString();
                    if (gst.Physics2ndTotal <= 32)
                    {
                        Physics2ndTotalPointbox.Text = "0";
                        Physics2ndTotalGradebox.Text = "F";
                    }

                    if (gst.Physics2ndTotal >= 33 && gst.Physics2ndTotal <= 39)
                    {
                        Physics2ndTotalPointbox.Text = "1";
                        Physics2ndTotalGradebox.Text = "D";
                    }

                    if (gst.Physics2ndTotal >= 40 && gst.Physics2ndTotal <= 49)
                    {
                        Physics2ndTotalPointbox.Text = "2";
                        Physics2ndTotalGradebox.Text = "C";
                    }

                    if (gst.Physics2ndTotal >= 50 && gst.Physics2ndTotal <= 59)
                    {
                        Physics2ndTotalPointbox.Text = "3";
                        Physics2ndTotalGradebox.Text = "B";
                    }

                    if (gst.Physics2ndTotal >= 60 && gst.Physics2ndTotal <= 69)
                    {
                        Physics2ndTotalPointbox.Text = "3.5";
                        Physics2ndTotalGradebox.Text = "A-";
                    }

                    if (gst.Physics2ndTotal >= 70 && gst.Physics2ndTotal <= 79)
                    {
                        Physics2ndTotalPointbox.Text = "4";
                        Physics2ndTotalGradebox.Text = "A";
                    }

                    if (gst.Physics2ndTotal >= 80 && gst.Physics2ndTotal <= 100)
                    {
                        Physics2ndTotalPointbox.Text = "5";
                        Physics2ndTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Physics 2nd Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.Chemistry1stTheory = float.Parse(Chemistry1stTheory.Text);
                gsub.Chemistry1stPractical = float.Parse(Chemistry1stPractical.Text);
                gsub.Chemistry1stMCQ = float.Parse(Chemistry1stMCQ.Text);
            }
           
            GetSubTotal gst = new GetSubTotal();
            gst.Chemistry1stTotal = gsub.Chemistry1stTheory + gsub.Chemistry1stPractical + gsub.Chemistry1stMCQ;
            {
                if (gst.Chemistry1stTotal < 101)
                {
                    Chemistry1stTotal.Text = gst.Chemistry1stTotal.ToString();
                    if (gst.Chemistry1stTotal <= 32)
                    {
                        Chemistry1stTotalPointbox.Text = "0";
                        Chemistry1stTotalGradebox.Text = "F";
                    }

                    if (gst.Chemistry1stTotal >= 33 && gst.Chemistry1stTotal <= 39)
                    {
                        Chemistry1stTotalPointbox.Text = "1";
                        Chemistry1stTotalGradebox.Text = "D";
                    }

                    if (gst.Chemistry1stTotal >= 40 && gst.Chemistry1stTotal <= 49)
                    {
                        Chemistry1stTotalPointbox.Text = "2";
                        Chemistry1stTotalGradebox.Text = "C";
                    }

                    if (gst.Chemistry1stTotal >= 50 && gst.Chemistry1stTotal <= 59)
                    {
                        Chemistry1stTotalPointbox.Text = "3";
                        Chemistry1stTotalGradebox.Text = "B";
                    }

                    if (gst.Chemistry1stTotal >= 60 && gst.Chemistry1stTotal <= 69)
                    {
                        Chemistry1stTotalPointbox.Text = "3.5";
                        Chemistry1stTotalGradebox.Text = "A-";
                    }

                    if (gst.Chemistry1stTotal >= 70 && gst.Chemistry1stTotal <= 79)
                    {
                        Chemistry1stTotalPointbox.Text = "4";
                        Chemistry1stTotalGradebox.Text = "A";
                    }

                    if (gst.Chemistry1stTotal >= 80 && gst.Chemistry1stTotal <= 100)
                    {
                        Chemistry1stTotalPointbox.Text = "5";
                        Chemistry1stTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Chemistry 1st Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.Chemistry2ndTheory = float.Parse(Chemistry2ndTheory.Text);
                gsub.Chemistry2ndPractical = float.Parse(Chemistry2ndPractical.Text);
                gsub.Chemistry2ndMCQ = float.Parse(Chemistry2ndMCQ.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.Chemistry2ndTotal = gsub.Chemistry2ndTheory + gsub.Chemistry2ndPractical + gsub.Chemistry2ndMCQ;
            {
                if (gst.Chemistry2ndTotal < 101)
                {
                    Chemistry2ndTotal.Text = gst.Chemistry2ndTotal.ToString();
                    if (gst.Chemistry2ndTotal <= 32)
                    {
                        Chemistry2ndTotalPointbox.Text = "0";
                        Chemistry2ndTotalGradebox.Text = "F";
                    }

                    if (gst.Chemistry2ndTotal >= 33 && gst.Chemistry2ndTotal <= 39)
                    {
                        Chemistry2ndTotalPointbox.Text = "1";
                        Chemistry2ndTotalGradebox.Text = "D";
                    }

                    if (gst.Chemistry2ndTotal >= 40 && gst.Chemistry2ndTotal <= 49)
                    {
                        Chemistry2ndTotalPointbox.Text = "2";
                        Chemistry2ndTotalGradebox.Text = "C";
                    }

                    if (gst.Chemistry2ndTotal >= 50 && gst.Chemistry2ndTotal <= 59)
                    {
                        Chemistry2ndTotalPointbox.Text = "3";
                        Chemistry2ndTotalGradebox.Text = "B";
                    }

                    if (gst.Chemistry2ndTotal >= 60 && gst.Chemistry2ndTotal <= 69)
                    {
                        Chemistry2ndTotalPointbox.Text = "3.5";
                        Chemistry2ndTotalGradebox.Text = "A-";
                    }

                    if (gst.Chemistry2ndTotal >= 70 && gst.Chemistry2ndTotal <= 79)
                    {
                        Chemistry2ndTotalPointbox.Text = "4";
                        Chemistry2ndTotalGradebox.Text = "A";
                    }

                    if (gst.Chemistry2ndTotal >= 80 && gst.Chemistry2ndTotal <= 100)
                    {
                        Chemistry2ndTotalPointbox.Text = "5";
                        Chemistry2ndTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Chemistry 2nd Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }


        }

        private void Button7_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.HigherMath1stTheory = float.Parse(HM1stTheory.Text);
                gsub.HigherMath1stPractical = float.Parse(HM1stPractical.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.HigherMath1stTotal = gsub.HigherMath1stTheory + gsub.HigherMath1stPractical;
            {
                if (gst.HigherMath1stTotal < 101)
                {
                    HM1stTotal.Text = gst.HigherMath1stTotal.ToString();
                    if (gst.HigherMath1stTotal <= 32)
                    {
                        HM1stTotalPointbox.Text = "0";
                        HM1stTotalGradebox.Text = "F";
                    }

                    if (gst.HigherMath1stTotal >= 33 && gst.HigherMath1stTotal <= 39)
                    {
                        HM1stTotalPointbox.Text = "1";
                        HM1stTotalGradebox.Text = "D";
                    }

                    if (gst.HigherMath1stTotal >= 40 && gst.HigherMath1stTotal <= 49)
                    {
                        HM1stTotalPointbox.Text = "2";
                        HM1stTotalGradebox.Text = "C";
                    }

                    if (gst.HigherMath1stTotal >= 50 && gst.HigherMath1stTotal <= 59)
                    {
                        HM1stTotalPointbox.Text = "3";
                        HM1stTotalGradebox.Text = "B";
                    }

                    if (gst.HigherMath1stTotal >= 60 && gst.HigherMath1stTotal <= 69)
                    {
                        HM1stTotalPointbox.Text = "3.5";
                        HM1stTotalGradebox.Text = "A-";
                    }

                    if (gst.HigherMath1stTotal >= 70 && gst.HigherMath1stTotal <= 79)
                    {
                        HM1stTotalPointbox.Text = "4";
                        HM1stTotalGradebox.Text = "A";
                    }

                    if (gst.HigherMath1stTotal >= 80 && gst.HigherMath1stTotal <= 100)
                    {
                        HM1stTotalPointbox.Text = "5";
                        HM1stTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Higher Mathematics 1st Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.HigherMath2ndTheory = float.Parse(HM2ndTheory.Text);
                gsub.HigherMath2ndPractical = float.Parse(HM2ndPractical.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.HigherMath2ndTotal = gsub.HigherMath2ndTheory + gsub.HigherMath2ndPractical;
            {
                if (gst.HigherMath2ndTotal < 101)
                {
                    HM2ndTotal.Text = gst.HigherMath2ndTotal.ToString();
                    if (gst.HigherMath2ndTotal <= 32)
                    {
                        HM2ndTotalPointbox.Text = "0";
                        HM2ndTotalGradebox.Text = "F";
                    }

                    if (gst.HigherMath2ndTotal >= 33 && gst.HigherMath2ndTotal <= 39)
                    {
                        HM2ndTotalPointbox.Text = "1";
                        HM2ndTotalGradebox.Text = "D";
                    }

                    if (gst.HigherMath2ndTotal >= 40 && gst.HigherMath2ndTotal <= 49)
                    {
                        HM2ndTotalPointbox.Text = "2";
                        HM2ndTotalGradebox.Text = "C";
                    }

                    if (gst.HigherMath2ndTotal >= 50 && gst.HigherMath2ndTotal <= 59)
                    {
                        HM2ndTotalPointbox.Text = "3";
                        HM2ndTotalGradebox.Text = "B";
                    }

                    if (gst.HigherMath2ndTotal >= 60 && gst.HigherMath2ndTotal <= 69)
                    {
                        HM2ndTotalPointbox.Text = "3.5";
                        HM2ndTotalGradebox.Text = "A-";
                    }

                    if (gst.HigherMath2ndTotal >= 70 && gst.HigherMath2ndTotal <= 79)
                    {
                        HM2ndTotalPointbox.Text = "4";
                        HM2ndTotalGradebox.Text = "A";
                    }

                    if (gst.HigherMath2ndTotal >= 80 && gst.HigherMath2ndTotal <= 100)
                    {
                        HM2ndTotalPointbox.Text = "5";
                        HM2ndTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Higher Mathematics 2nd Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.Biology1stTheory = float.Parse(Biology1stTheory.Text);
                gsub.Biology1stPractical = float.Parse(Biology1stPractical.Text);
                gsub.Biology1stMCQ = float.Parse(Biology1stMCQ.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.Biology1stTotal = gsub.Biology1stTheory + gsub.Biology1stPractical + gsub.Biology1stMCQ;
            {
                if (gst.Biology1stTotal < 101)
                {
                    Biology1stTotal.Text = gst.Biology1stTotal.ToString();
                    if (gst.Biology1stTotal <= 32)
                    {
                        Biology1stTotalPointbox.Text = "0";
                        Biology1stTotalGradebox.Text = "F";
                    }

                    if (gst.Biology1stTotal >= 33 && gst.Biology1stTotal <= 39)
                    {
                        Biology1stTotalPointbox.Text = "1";
                        Biology1stTotalGradebox.Text = "D";
                    }

                    if (gst.Biology1stTotal >= 40 && gst.Biology1stTotal <= 49)
                    {
                        Biology1stTotalPointbox.Text = "2";
                        Biology1stTotalGradebox.Text = "C";
                    }

                    if (gst.Biology1stTotal >= 50 && gst.Biology1stTotal <= 59)
                    {
                        Biology1stTotalPointbox.Text = "3";
                        Biology1stTotalGradebox.Text = "B";
                    }

                    if (gst.Biology1stTotal >= 60 && gst.Biology1stTotal <= 69)
                    {
                        Biology1stTotalPointbox.Text = "3.5";
                        Biology1stTotalGradebox.Text = "A-";
                    }

                    if (gst.Biology1stTotal >= 70 && gst.Biology1stTotal <= 79)
                    {
                        Biology1stTotalPointbox.Text = "4";
                        Biology1stTotalGradebox.Text = "A";
                    }

                    if (gst.Biology1stTotal >= 80 && gst.Biology1stTotal <= 100)
                    {
                        Biology1stTotalPointbox.Text = "5";
                        Biology1stTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Biology 1st Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }


            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.Biology2ndTheory = float.Parse(Biology2ndTheory.Text);
                gsub.Biology2ndPractical = float.Parse(Biology2ndPractical.Text);
                gsub.Biology2ndMCQ = float.Parse(Biology2ndMCQ.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.Biology2ndTotal = gsub.Biology2ndTheory + gsub.Biology2ndPractical + gsub.Biology2ndMCQ;
            {
                if (gst.Biology2ndTotal < 101)
                {
                    Biology2ndTotal.Text = gst.Biology2ndTotal.ToString();
                    if (gst.Biology2ndTotal <= 32)
                    {
                        Biology2ndTotalPointbox.Text = "0";
                        Biology2ndTotalGradebox.Text = "F";
                    }

                    if (gst.Biology2ndTotal >= 33 && gst.Biology2ndTotal <= 39)
                    {
                        Biology2ndTotalPointbox.Text = "1";
                        Biology2ndTotalGradebox.Text = "D";
                    }

                    if (gst.Biology2ndTotal >= 40 && gst.Biology2ndTotal <= 49)
                    {
                        Biology2ndTotalPointbox.Text = "2";
                        Biology2ndTotalGradebox.Text = "C";
                    }

                    if (gst.Biology2ndTotal >= 50 && gst.Biology2ndTotal <= 59)
                    {
                        Biology2ndTotalPointbox.Text = "3";
                        Biology2ndTotalGradebox.Text = "B";
                    }

                    if (gst.Biology2ndTotal >= 60 && gst.Biology2ndTotal <= 69)
                    {
                        Biology2ndTotalPointbox.Text = "3.5";
                        Biology2ndTotalGradebox.Text = "A-";
                    }

                    if (gst.Biology2ndTotal >= 70 && gst.Biology2ndTotal <= 79)
                    {
                        Biology2ndTotalPointbox.Text = "4";
                        Biology2ndTotalGradebox.Text = "A";
                    }

                    if (gst.Biology2ndTotal >= 80 && gst.Biology2ndTotal <= 100)
                    {
                        Biology2ndTotalPointbox.Text = "5";
                        Biology2ndTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Biology 2nd Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.Bangla1stTheory = float.Parse(Bangla1stTheory.Text);
                gsub.Bangla1stMCQ = float.Parse(Bangla1stMCQ.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            {

                gst.Bangla1stTotal = gsub.Bangla1stTheory + gsub.Bangla1stMCQ;
                {
                    if (gst.Bangla1stTotal < 101)
                    {
                        Bangla1stTotal.Text = gst.Bangla1stTotal.ToString();
                        if (gst.Bangla1stTotal <= 32)
                        {
                            Bangla1stTotalPointbox.Text = "0";
                            Bangla1stTotalGradebox.Text = "F";
                        }
                        if (gst.Bangla1stTotal >= 33 && gst.Bangla1stTotal <= 39)
                        {
                            Bangla1stTotalPointbox.Text = "1";
                            Bangla1stTotalGradebox.Text = "D";
                        }

                        if (gst.Bangla1stTotal >= 40 && gst.Bangla1stTotal <= 49)
                        {
                            Bangla1stTotalPointbox.Text = "2";
                            Bangla1stTotalGradebox.Text = "C";
                        }

                        if (gst.Bangla1stTotal >= 50 && gst.Bangla1stTotal <= 59)
                        {
                            Bangla1stTotalPointbox.Text = "3";
                            Bangla1stTotalGradebox.Text = "B";
                        }

                        if (gst.Bangla1stTotal >= 60 && gst.Bangla1stTotal <= 69)
                        {
                            Bangla1stTotalPointbox.Text = "3.5";
                            Bangla1stTotalGradebox.Text = "A-";
                        }

                        if (gst.Bangla1stTotal >= 70 && gst.Bangla1stTotal <= 79)
                        {
                            Bangla1stTotalPointbox.Text = "4";
                            Bangla1stTotalGradebox.Text = "A";
                        }

                        if (gst.Bangla1stTotal >= 80 && gst.Bangla1stTotal <= 100)
                        {
                            Bangla1stTotalPointbox.Text = "5";
                            Bangla1stTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    else
                    {
                        MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Bangla 1st Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }


                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.Bangla2ndTheory = float.Parse(Bangla2ndTheory.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.Bangla2ndTotal = gsub.Bangla2ndTheory;
            {
                if (gst.Bangla2ndTotal < 101)
                {
                    Bangla2ndTotal.Text = gst.Bangla2ndTotal.ToString();
                    if (gst.Bangla2ndTotal <= 32)
                    {
                        Bangla2ndTotalPointbox.Text = "0";
                        Bangla2ndTotalGradebox.Text = "F";
                    }

                    if (gst.Bangla2ndTotal >= 33 && gst.Bangla2ndTotal <= 39)
                    {
                        Bangla2ndTotalPointbox.Text = "1";
                        Bangla2ndTotalGradebox.Text = "D";
                    }

                    if (gst.Bangla2ndTotal >= 40 && gst.Bangla2ndTotal <= 49)
                    {
                        Bangla2ndTotalPointbox.Text = "2";
                        Bangla2ndTotalGradebox.Text = "C";
                    }

                    if (gst.Bangla2ndTotal >= 50 && gst.Bangla2ndTotal <= 59)
                    {
                        Bangla2ndTotalPointbox.Text = "3";
                        Bangla2ndTotalGradebox.Text = "B";
                    }

                    if (gst.Bangla2ndTotal >= 60 && gst.Bangla2ndTotal <= 69)
                    {
                        Bangla2ndTotalPointbox.Text = "3.5";
                        Bangla2ndTotalGradebox.Text = "A-";
                    }

                    if (gst.Bangla2ndTotal >= 70 && gst.Bangla2ndTotal <= 79)
                    {
                        Bangla2ndTotalPointbox.Text = "4";
                        Bangla2ndTotalGradebox.Text = "A";
                    }

                    if (gst.Bangla2ndTotal >= 80 && gst.Bangla2ndTotal <= 100)
                    {
                        Bangla2ndTotalPointbox.Text = "5";
                        Bangla2ndTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Bangla 2nd Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.English1stPaper = float.Parse(English1stPaper.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.English1stPaperTotal = gsub.English1stPaper;
            {
                if (gst.English1stPaperTotal < 101)
                {
                    English1stTotal.Text = gst.English1stPaperTotal.ToString();
                    if (gst.English1stPaperTotal <= 32)
                    {
                        English1stTotalPointbox.Text = "0";
                        English1stTotalGradebox.Text = "F";
                    }

                    if (gst.English1stPaperTotal >= 33 && gst.English1stPaperTotal <= 39)
                    {
                        English1stTotalPointbox.Text = "1";
                        English1stTotalGradebox.Text = "D";
                    }

                    if (gst.English1stPaperTotal >= 40 && gst.English1stPaperTotal <= 49)
                    {
                        English1stTotalPointbox.Text = "2";
                        English1stTotalGradebox.Text = "C";
                    }

                    if (gst.English1stPaperTotal >= 50 && gst.English1stPaperTotal <= 59)
                    {
                        English1stTotalPointbox.Text = "3";
                        English1stTotalGradebox.Text = "B";
                    }

                    if (gst.English1stPaperTotal >= 60 && gst.English1stPaperTotal <= 69)
                    {
                        English1stTotalPointbox.Text = "3.5";
                        English1stTotalGradebox.Text = "A-";
                    }

                    if (gst.English1stPaperTotal >= 70 && gst.English1stPaperTotal <= 79)
                    {
                        English1stTotalPointbox.Text = "4";
                        English1stTotalGradebox.Text = "A";
                    }

                    if (gst.English1stPaperTotal >= 80 && gst.English1stPaperTotal <= 100)
                    {
                        English1stTotalPointbox.Text = "5";
                        English1stTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "English 1st Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.English2ndPaper = float.Parse(English2ndPaper.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.English2ndPaperTotal = gsub.English2ndPaper;
            {
                if (gst.English2ndPaperTotal < 101)
                {
                    English2ndTotal.Text = gst.English2ndPaperTotal.ToString();
                    if (gst.English2ndPaperTotal <= 32)
                    {
                        English2ndTotalPointbox.Text = "0";
                        English2ndTotalGradebox.Text = "F";
                    }

                    if (gst.English2ndPaperTotal >= 33 && gst.English2ndPaperTotal <= 39)
                    {
                        English2ndTotalPointbox.Text = "1";
                        English2ndTotalGradebox.Text = "D";
                    }

                    if (gst.English2ndPaperTotal >= 40 && gst.English2ndPaperTotal <= 49)
                    {
                        English2ndTotalPointbox.Text = "2";
                        English2ndTotalGradebox.Text = "C";
                    }

                    if (gst.English2ndPaperTotal >= 50 && gst.English2ndPaperTotal <= 59)
                    {
                        English2ndTotalPointbox.Text = "3";
                        English2ndTotalGradebox.Text = "B";
                    }

                    if (gst.English2ndPaperTotal >= 60 && gst.English2ndPaperTotal <= 69)
                    {
                        English2ndTotalPointbox.Text = "3.5";
                        English2ndTotalGradebox.Text = "A-";
                    }

                    if (gst.English2ndPaperTotal >= 70 && gst.English2ndPaperTotal <= 79)
                    {
                        English2ndTotalPointbox.Text = "4";
                        English2ndTotalGradebox.Text = "A";
                    }

                    if (gst.English2ndPaperTotal >= 80 && gst.English2ndPaperTotal <= 100)
                    {
                        English2ndTotalPointbox.Text = "5";
                        English2ndTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "English 2nd Paper Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            GetSubTPM gsub = new GetSubTPM();
            {
                gsub.ICTTheory = float.Parse(ICTTheory.Text);
                gsub.ICTPractical = float.Parse(ICTPractical.Text);
                gsub.ICTMCQ = float.Parse(ICTMCQ.Text);
            }
            GetSubTotal gst = new GetSubTotal();
            gst.ICTTotal = gsub.ICTTheory + gsub.ICTPractical + gsub.ICTMCQ;
            {
                if (gst.ICTTotal < 101)
                {
                    ICTTotal.Text = gst.ICTTotal.ToString();
                    if (gst.ICTTotal <= 32)
                    {
                        ICTTotalPointbox.Text = "0";
                        ICTTotalGradebox.Text = "F";
                    }

                    if (gst.ICTTotal >= 33 && gst.ICTTotal <= 39)
                    {
                        ICTTotalPointbox.Text = "1";
                        ICTTotalGradebox.Text = "D";
                    }

                    if (gst.ICTTotal >= 40 && gst.ICTTotal <= 49)
                    {
                        ICTTotalPointbox.Text = "2";
                        ICTTotalGradebox.Text = "C";
                    }

                    if (gst.ICTTotal >= 50 && gst.ICTTotal <= 59)
                    {
                        ICTTotalPointbox.Text = "3";
                        ICTTotalGradebox.Text = "B";
                    }

                    if (gst.ICTTotal >= 60 && gst.ICTTotal <= 69)
                    {
                        ICTTotalPointbox.Text = "3.5";
                        ICTTotalGradebox.Text = "A-";
                    }

                    if (gst.ICTTotal >= 70 && gst.ICTTotal <= 79)
                    {
                        ICTTotalPointbox.Text = "4";
                        ICTTotalGradebox.Text = "A";
                    }

                    if (gst.ICTTotal >= 80 && gst.ICTTotal <= 100)
                    {
                        ICTTotalPointbox.Text = "5";
                        ICTTotalGradebox.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "ICT Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }
    }
}
