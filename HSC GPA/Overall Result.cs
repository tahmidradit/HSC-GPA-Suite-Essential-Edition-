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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetSubTPM gsub = new GetSubTPM();
                {
                    gsub.Bangla1stTheory = float.Parse(Bangla1stTheory.Text);
                    gsub.Bangla1stMCQ = float.Parse(Bangla1stMCQ.Text);

                    gsub.Bangla2ndTheory = float.Parse(Bangla2ndTheory.Text);


                    gsub.Biology1stTheory = float.Parse(Biology1stTheory.Text);
                    gsub.Biology1stPractical = float.Parse(Biology1stPractical.Text);
                    gsub.Biology1stMCQ = float.Parse(Biology1stMCQ.Text);

                    gsub.Biology2ndTheory = float.Parse(Biology2ndTheory.Text);
                    gsub.Biology2ndPractical = float.Parse(Biology2ndPractical.Text);
                    gsub.Biology2ndMCQ = float.Parse(Biology2ndMCQ.Text);

                    gsub.Chemistry1stTheory = float.Parse(Chemistry1stTheory.Text);
                    gsub.Chemistry1stPractical = float.Parse(Chemistry1stPractical.Text);
                    gsub.Chemistry1stMCQ = float.Parse(Chemistry1stMCQ.Text);

                    gsub.Chemistry2ndTheory = float.Parse(Chemistry2ndTheory.Text);
                    gsub.Chemistry2ndPractical = float.Parse(Chemistry2ndPractical.Text);
                    gsub.Chemistry2ndMCQ = float.Parse(Chemistry2ndMCQ.Text);

                    gsub.English1stPaper = float.Parse(English1stPaper.Text);
                    gsub.English2ndPaper = float.Parse(English2ndPaper.Text);

                    gsub.HigherMath1stTheory = float.Parse(HM1stTheory.Text);
                    gsub.HigherMath1stPractical = float.Parse(HM1stPractical.Text);

                    gsub.HigherMath2ndTheory = float.Parse(HM2ndTheory.Text);
                    gsub.HigherMath2ndPractical = float.Parse(HM2ndPractical.Text);

                    gsub.Physics1stTheory = float.Parse(Physics1stTheory.Text);
                    gsub.Physics1stPractical = float.Parse(Physics1stPractical.Text);
                    gsub.Physics1stMCQ = float.Parse(Physics1stMCQ.Text);

                    gsub.Physics2ndTheory = float.Parse(Physics2ndTheory.Text);
                    gsub.Physics2ndPractical = float.Parse(Physics2ndPractical.Text);
                    gsub.Physics2ndMCQ = float.Parse(Physics2ndMCQ.Text);

                    gsub.ICTTheory = float.Parse(ICTTheory.Text);
                    gsub.ICTPractical = float.Parse(ICTPractical.Text);
                    gsub.ICTMCQ = float.Parse(ICTMCQ.Text);
                }
                GetSubTotal gst = new GetSubTotal();
                {
                    gst.Bangla1stTotal = gsub.Bangla1stTheory + gsub.Bangla1stMCQ;
                    {
                        if(gst.Bangla1stTotal < 101 )
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
                            MessageBox.Show("Inputs exceed 100 marks in total.Re-input please ! ", "Bangla 1st Paper Validation",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        }

                        
                    }
                    gst.Bangla2ndTotal = gsub.Bangla2ndTheory;
                    {
                        if(gst.Bangla2ndTotal < 101)
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


                //>>> OUTPUT Individual Totals >>>


                //Bangla1stTotal.Text = gst.Bangla1stTotal.ToString();
                //Bangla2ndTotal.Text = gst.Bangla2ndTotal.ToString();

                //Biology1stTotal.Text = gst.Biology1stTotal.ToString();
                //Biology2ndTotal.Text = gst.Biology2ndTotal.ToString();

                //Chemistry1stTotal.Text = gst.Chemistry1stTotal.ToString();
                //Chemistry2ndTotal.Text = gst.Chemistry2ndTotal.ToString();

                //English1stTotal.Text = gst.English1stPaperTotal.ToString();
                //English2ndTotal.Text = gst.English2ndPaperTotal.ToString();

                //HM1stTotal.Text = gst.HigherMath1stTotal.ToString();
                //HM2ndTotal.Text = gst.HigherMath2ndTotal.ToString();

                //ICTTotal.Text = gst.ICTTotal.ToString();

                //Physics1stTotal.Text = gst.Physics1stTotal.ToString();
                //Physics2ndTotal.Text = gst.Physics2ndTotal.ToString();






                //>>> OUTPUT Individual Totals >>>

                //>>>>>>>>>>>>>>>>>

                SubjectTotal st = new SubjectTotal();
                {
                    st.BanglaSubTotal = gst.Bangla1stTotal + gst.Bangla2ndTotal;
                    {
                        if (st.BanglaSubTotal / 2 <= 32)
                        {
                            BanglaSubjectTotalPointbox.Text = "0";
                            BanglaSubjectTotalGradebox.Text = "F";
                        }

                        if (st.BanglaSubTotal / 2 >= 33 && st.BanglaSubTotal / 2 <= 39)
                        {
                            BanglaSubjectTotalPointbox.Text = "1";
                            BanglaSubjectTotalGradebox.Text = "D";
                        }

                        if (st.BanglaSubTotal / 2 >= 40 && st.BanglaSubTotal / 2 <= 49)
                        {
                            BanglaSubjectTotalPointbox.Text = "2";
                            BanglaSubjectTotalGradebox.Text = "C";
                        }

                        if (st.BanglaSubTotal / 2 >= 50 && st.BanglaSubTotal / 2 <= 59)
                        {
                            BanglaSubjectTotalPointbox.Text = "3";
                            BanglaSubjectTotalGradebox.Text = "B";
                        }

                        if (st.BanglaSubTotal / 2 >= 60 && st.BanglaSubTotal / 2 <= 69)
                        {
                            BanglaSubjectTotalPointbox.Text = "3.5";
                            BanglaSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.BanglaSubTotal / 2 >= 70 && st.BanglaSubTotal / 2 <= 79)
                        {
                            BanglaSubjectTotalPointbox.Text = "4";
                            BanglaSubjectTotalGradebox.Text = "A";
                        }

                        if (st.BanglaSubTotal / 2 >= 80 && st.BanglaSubTotal / 2 <= 100)
                        {
                            BanglaSubjectTotalPointbox.Text = "5";
                            BanglaSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.BiologySubTotal = gst.Biology1stTotal + gst.Biology2ndTotal;
                    {
                        if (st.BiologySubTotal / 2 <= 32)
                        {
                            BiologySubjectTotalPointbox.Text = "0";
                            BiologySubjectTotalGradebox.Text = "F";
                        }

                        if (st.BiologySubTotal / 2 >= 33 && st.BiologySubTotal / 2 <= 39)
                        {
                            BiologySubjectTotalPointbox.Text = "1";
                            BiologySubjectTotalGradebox.Text = "D";
                        }

                        if (st.BiologySubTotal / 2 >= 40 && st.BiologySubTotal / 2 <= 49)
                        {
                            BiologySubjectTotalPointbox.Text = "2";
                            BiologySubjectTotalGradebox.Text = "C";
                        }

                        if (st.BiologySubTotal / 2 >= 50 && st.BiologySubTotal / 2 <= 59)
                        {
                            BiologySubjectTotalPointbox.Text = "3";
                            BiologySubjectTotalGradebox.Text = "B";
                        }

                        if (st.BiologySubTotal / 2 >= 60 && st.BiologySubTotal / 2 <= 69)
                        {
                            BiologySubjectTotalPointbox.Text = "3.5";
                            BiologySubjectTotalGradebox.Text = "A-";
                        }

                        if (st.BiologySubTotal / 2 >= 70 && st.BiologySubTotal / 2 <= 79)
                        {
                            BiologySubjectTotalPointbox.Text = "4";
                            BiologySubjectTotalGradebox.Text = "A";
                        }

                        if (st.BiologySubTotal / 2 >= 80 && st.BiologySubTotal / 2 <= 100)
                        {
                            BiologySubjectTotalPointbox.Text = "5";
                            BiologySubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.ChemistrySubTotal = gst.Chemistry1stTotal + gst.Chemistry2ndTotal;
                    {
                        if (st.ChemistrySubTotal / 2 <= 32)
                        {
                            ChemistrySubjectTotalPointbox.Text = "0";
                            ChemistrySubjectTotalGradebox.Text = "F";
                        }

                        if (st.ChemistrySubTotal / 2 >= 33 && st.ChemistrySubTotal / 2 <= 39)
                        {
                            ChemistrySubjectTotalPointbox.Text = "1";
                            ChemistrySubjectTotalGradebox.Text = "D";
                        }

                        if (st.ChemistrySubTotal / 2 >= 40 && st.ChemistrySubTotal / 2 <= 49)
                        {
                            ChemistrySubjectTotalPointbox.Text = "2";
                            ChemistrySubjectTotalGradebox.Text = "C";
                        }

                        if (st.ChemistrySubTotal / 2 >= 50 && st.ChemistrySubTotal / 2 <= 59)
                        {
                            ChemistrySubjectTotalPointbox.Text = "3";
                            ChemistrySubjectTotalGradebox.Text = "B";
                        }

                        if (st.ChemistrySubTotal / 2 >= 60 && st.ChemistrySubTotal / 2 <= 69)
                        {
                            ChemistrySubjectTotalPointbox.Text = "3.5";
                            ChemistrySubjectTotalGradebox.Text = "A-";
                        }

                        if (st.ChemistrySubTotal / 2 >= 70 && st.ChemistrySubTotal / 2 <= 79)
                        {
                            ChemistrySubjectTotalPointbox.Text = "4";
                            ChemistrySubjectTotalGradebox.Text = "A";
                        }

                        if (st.ChemistrySubTotal / 2 >= 80 && st.ChemistrySubTotal / 2 <= 100)
                        {
                            ChemistrySubjectTotalPointbox.Text = "5";
                            ChemistrySubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.EnglishSubTotal = gst.English1stPaperTotal + gst.English2ndPaperTotal;
                    {
                        if (st.EnglishSubTotal / 2 <= 32)
                        {
                            EnglishSubjectTotalPointbox.Text = "0";
                            EnglishSubjectTotalGradebox.Text = "F";
                        }

                        if (st.EnglishSubTotal / 2 >= 33 && st.EnglishSubTotal / 2 <= 39)
                        {
                            EnglishSubjectTotalPointbox.Text = "1";
                            EnglishSubjectTotalGradebox.Text = "D";
                        }

                        if (st.EnglishSubTotal / 2 >= 40 && st.EnglishSubTotal / 2 <= 49)
                        {
                            EnglishSubjectTotalPointbox.Text = "2";
                            EnglishSubjectTotalGradebox.Text = "C";
                        }

                        if (st.EnglishSubTotal / 2 >= 50 && st.EnglishSubTotal / 2 <= 59)
                        {
                            EnglishSubjectTotalPointbox.Text = "3";
                            EnglishSubjectTotalGradebox.Text = "B";
                        }

                        if (st.EnglishSubTotal / 2 >= 60 && st.EnglishSubTotal / 2 <= 69)
                        {
                            EnglishSubjectTotalPointbox.Text = "3.5";
                            EnglishSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.EnglishSubTotal / 2 >= 70 && st.EnglishSubTotal / 2 <= 79)
                        {
                            EnglishSubjectTotalPointbox.Text = "4";
                            EnglishSubjectTotalGradebox.Text = "A";
                        }

                        if (st.EnglishSubTotal / 2 >= 80 && st.EnglishSubTotal / 2 <= 100)
                        {
                            EnglishSubjectTotalPointbox.Text = "5";
                            EnglishSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.HigherMathSubTotal = gst.HigherMath1stTotal + gst.HigherMath2ndTotal;
                    {
                        if (st.HigherMathSubTotal / 2 <= 32)
                        {
                            HMSubjectTotalPointbox.Text = "0";
                            HMSubjectTotalGradebox.Text = "F";
                        }

                        if (st.HigherMathSubTotal / 2 >= 33 && st.HigherMathSubTotal / 2 <= 39)
                        {
                            HMSubjectTotalPointbox.Text = "1";
                            HMSubjectTotalGradebox.Text = "D";
                        }

                        if (st.HigherMathSubTotal / 2 >= 40 && st.HigherMathSubTotal / 2 <= 49)
                        {
                            HMSubjectTotalPointbox.Text = "2";
                            HMSubjectTotalGradebox.Text = "C";
                        }

                        if (st.HigherMathSubTotal / 2 >= 50 && st.HigherMathSubTotal / 2 <= 59)
                        {
                            HMSubjectTotalPointbox.Text = "3";
                            HMSubjectTotalGradebox.Text = "B";
                        }

                        if (st.HigherMathSubTotal / 2 >= 60 && st.HigherMathSubTotal / 2 <= 69)
                        {
                            HMSubjectTotalPointbox.Text = "3.5";
                            HMSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.HigherMathSubTotal / 2 >= 70 && st.HigherMathSubTotal / 2 <= 79)
                        {
                            HMSubjectTotalPointbox.Text = "4";
                            HMSubjectTotalGradebox.Text = "A";
                        }

                        if (st.HigherMathSubTotal / 2 >= 80 && st.HigherMathSubTotal / 2 <= 100)
                        {
                            HMSubjectTotalPointbox.Text = "5";
                            HMSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.ICTSubTotal = gst.ICTTotal;
                    {
                        if (st.ICTSubTotal <= 32)
                        {
                            ICTSubjectTotalPointbox.Text = "0";
                            ICTSubjectTotalGradebox.Text = "F";
                        }

                        if (st.ICTSubTotal >= 33 && st.ICTSubTotal <= 39)
                        {
                            ICTSubjectTotalPointbox.Text = "1";
                            ICTSubjectTotalGradebox.Text = "D";
                        }

                        if (st.ICTSubTotal >= 40 && st.ICTSubTotal <= 49)
                        {
                            ICTSubjectTotalPointbox.Text = "2";
                            ICTSubjectTotalGradebox.Text = "C";
                        }

                        if (st.ICTSubTotal >= 50 && st.ICTSubTotal <= 59)
                        {
                            ICTSubjectTotalPointbox.Text = "3";
                            ICTSubjectTotalGradebox.Text = "B";
                        }

                        if (st.ICTSubTotal >= 60 && st.ICTSubTotal <= 69)
                        {
                            ICTSubjectTotalPointbox.Text = "3.5";
                            ICTSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.ICTSubTotal >= 70 && st.ICTSubTotal <= 79)
                        {
                            ICTSubjectTotalPointbox.Text = "4";
                            ICTSubjectTotalGradebox.Text = "A";
                        }

                        if (st.ICTSubTotal >= 80 && st.ICTSubTotal <= 100)
                        {
                            ICTSubjectTotalPointbox.Text = "5";
                            ICTSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.PhysicsSubTotal = gst.Physics1stTotal + gst.Physics2ndTotal;
                    {
                        if (st.PhysicsSubTotal / 2 <= 32)
                        {
                            PhysicsSubjectTotalPointbox.Text = "0";
                            PhysicsSubjectTotalGradebox.Text = "F";
                        }

                        if (st.PhysicsSubTotal / 2 >= 33 && st.PhysicsSubTotal / 2 <= 39)
                        {
                            PhysicsSubjectTotalPointbox.Text = "1";
                            PhysicsSubjectTotalGradebox.Text = "D";
                        }

                        if (st.PhysicsSubTotal / 2 >= 40 && st.PhysicsSubTotal / 2 <= 49)
                        {
                            PhysicsSubjectTotalPointbox.Text = "2";
                            PhysicsSubjectTotalGradebox.Text = "C";
                        }

                        if (st.PhysicsSubTotal / 2 >= 50 && st.PhysicsSubTotal / 2 <= 59)
                        {
                            PhysicsSubjectTotalPointbox.Text = "3";
                            PhysicsSubjectTotalGradebox.Text = "B";
                        }

                        if (st.PhysicsSubTotal / 2 >= 60 && st.PhysicsSubTotal / 2 <= 69)
                        {
                            PhysicsSubjectTotalPointbox.Text = "3.5";
                            PhysicsSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.PhysicsSubTotal / 2 >= 70 && st.PhysicsSubTotal / 2 <= 79)
                        {
                            PhysicsSubjectTotalPointbox.Text = "4";
                            PhysicsSubjectTotalGradebox.Text = "A";
                        }

                        if (st.PhysicsSubTotal / 2 >= 80 && st.PhysicsSubTotal / 2 <= 100)
                        {
                            PhysicsSubjectTotalPointbox.Text = "5";
                            PhysicsSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                }


                ///>>> OUTPUT Subject Total >>>

                BanglaSubTotal.Text = st.BanglaSubTotal.ToString();
                BiologySubTotal.Text = st.BiologySubTotal.ToString();
                ChemistrySubTotal.Text = st.ChemistrySubTotal.ToString();
                EnglishSubTotal.Text = st.EnglishSubTotal.ToString();
                HMSubTotal.Text = st.HigherMathSubTotal.ToString();
                ICTSubTotal.Text = st.ICTSubTotal.ToString();
                PhysicsSubTotal.Text = st.PhysicsSubTotal.ToString();

                ///>>> OUTPUT Subject Total >>>

                SubAve sa = new SubAve();
                {
                    sa.BanglaSubAverage = st.BanglaSubTotal / 2;
                    {
                        if (sa.BanglaSubAverage <= 32)
                        {
                            BanglaAveragePointbox.Text = "0";
                            BanglaAverageGradebox.Text = "F";
                        }

                        if (sa.BanglaSubAverage >= 33 && sa.BanglaSubAverage <= 39)
                        {
                            BanglaAveragePointbox.Text = "1";
                            BanglaAverageGradebox.Text = "D";
                        }

                        if (sa.BanglaSubAverage >= 40 && sa.BanglaSubAverage <= 49)
                        {
                            BanglaAveragePointbox.Text = "2";
                            BanglaAverageGradebox.Text = "C";
                        }

                        if (sa.BanglaSubAverage >= 50 && sa.BanglaSubAverage <= 59)
                        {
                            BanglaAveragePointbox.Text = "3";
                            BanglaAverageGradebox.Text = "B";
                        }

                        if (sa.BanglaSubAverage >= 60 && sa.BanglaSubAverage <= 69)
                        {
                            BanglaAveragePointbox.Text = "3.5";
                            BanglaAverageGradebox.Text = "A-";
                        }

                        if (sa.BanglaSubAverage >= 70 && sa.BanglaSubAverage <= 79)
                        {
                            BanglaAveragePointbox.Text = "4";
                            BanglaAverageGradebox.Text = "A";
                        }

                        if (sa.BanglaSubAverage >= 80 && sa.BanglaSubAverage <= 100)
                        {
                            BanglaAveragePointbox.Text = "5";
                            BanglaAverageGradebox.Text = "A+";
                        }
                        else { }
                    }

                    sa.BiologySubAverage = st.BiologySubTotal / 2;
                    {
                        if (sa.BiologySubAverage <= 32)
                        {
                            BiologyAveragePointbox.Text = "0";
                            BiologyAverageGradebox.Text = "F";
                        }

                        if (sa.BiologySubAverage >= 33 && sa.BiologySubAverage <= 39)
                        {
                            BiologyAveragePointbox.Text = "1";
                            BiologyAverageGradebox.Text = "D";
                        }

                        if (sa.BiologySubAverage >= 40 && sa.BiologySubAverage <= 49)
                        {
                            BiologyAveragePointbox.Text = "2";
                            BiologyAverageGradebox.Text = "C";
                        }

                        if (sa.BiologySubAverage >= 50 && sa.BiologySubAverage <= 59)
                        {
                            BiologyAveragePointbox.Text = "3";
                            BiologyAverageGradebox.Text = "B";
                        }

                        if (sa.BiologySubAverage >= 60 && sa.BiologySubAverage <= 69)
                        {
                            BiologyAveragePointbox.Text = "3.5";
                            BiologyAverageGradebox.Text = "A-";
                        }

                        if (sa.BiologySubAverage >= 70 && sa.BiologySubAverage <= 79)
                        {
                            BiologyAveragePointbox.Text = "4";
                            BiologyAverageGradebox.Text = "A";
                        }

                        if (sa.BiologySubAverage >= 80 && sa.BiologySubAverage <= 100)
                        {
                            BiologyAveragePointbox.Text = "5";
                            BiologyAverageGradebox.Text = "A+";
                        }
                    }
                    sa.ChemistrySubAverage = st.ChemistrySubTotal / 2;
                    {
                        if (sa.ChemistrySubAverage <= 32)
                        {
                            ChemistryAveragePointbox.Text = "0";
                            ChemistryAverageGradebox.Text = "F";
                        }

                        if (sa.ChemistrySubAverage >= 33 && sa.ChemistrySubAverage <= 39)
                        {
                            ChemistryAveragePointbox.Text = "1";
                            ChemistryAverageGradebox.Text = "D";
                        }

                        if (sa.ChemistrySubAverage >= 40 && sa.ChemistrySubAverage <= 49)
                        {
                            ChemistryAveragePointbox.Text = "2";
                            ChemistryAverageGradebox.Text = "C";
                        }

                        if (sa.ChemistrySubAverage >= 50 && sa.ChemistrySubAverage <= 59)
                        {
                            ChemistryAveragePointbox.Text = "3";
                            ChemistryAverageGradebox.Text = "B";
                        }

                        if (sa.ChemistrySubAverage >= 60 && sa.ChemistrySubAverage <= 69)
                        {
                            ChemistryAveragePointbox.Text = "3.5";
                            ChemistryAverageGradebox.Text = "A-";
                        }

                        if (sa.ChemistrySubAverage >= 70 && sa.ChemistrySubAverage <= 79)
                        {
                            ChemistryAveragePointbox.Text = "4";
                            ChemistryAverageGradebox.Text = "A";
                        }

                        if (sa.ChemistrySubAverage >= 80 && sa.ChemistrySubAverage <= 100)
                        {
                            ChemistryAveragePointbox.Text = "5";
                            ChemistryAverageGradebox.Text = "A+";
                        }
                    }
                    sa.EnglishSubAverage = st.EnglishSubTotal / 2;
                    {
                        if (sa.EnglishSubAverage <= 32)
                        {
                            EnglishAveragePointbox.Text = "0";
                            EnglishAverageGradebox.Text = "F";
                        }

                        if (sa.EnglishSubAverage >= 33 && sa.EnglishSubAverage <= 39)
                        {
                            EnglishAveragePointbox.Text = "1";
                            EnglishAverageGradebox.Text = "D";
                        }

                        if (sa.EnglishSubAverage >= 40 && sa.EnglishSubAverage <= 49)
                        {
                            EnglishAveragePointbox.Text = "2";
                            EnglishAverageGradebox.Text = "C";
                        }

                        if (sa.EnglishSubAverage >= 50 && sa.EnglishSubAverage <= 59)
                        {
                            EnglishAveragePointbox.Text = "3";
                            EnglishAverageGradebox.Text = "B";
                        }

                        if (sa.EnglishSubAverage >= 60 && sa.EnglishSubAverage <= 69)
                        {
                            EnglishAveragePointbox.Text = "3.5";
                            EnglishAverageGradebox.Text = "A-";
                        }

                        if (sa.EnglishSubAverage >= 70 && sa.EnglishSubAverage <= 79)
                        {
                            EnglishAveragePointbox.Text = "4";
                            EnglishAverageGradebox.Text = "A";
                        }

                        if (sa.EnglishSubAverage >= 80 && sa.EnglishSubAverage <= 100)
                        {
                            EnglishAveragePointbox.Text = "5";
                            EnglishAverageGradebox.Text = "A+";
                        }
                    }

                    sa.HigherMathSubAverage = st.HigherMathSubTotal / 2;
                    {
                        if (sa.HigherMathSubAverage <= 32)
                        {
                            HMAveragePointbox.Text = "0";
                            HMAverageGradebox.Text = "F";
                        }

                        if (sa.HigherMathSubAverage >= 33 && sa.HigherMathSubAverage <= 39)
                        {
                            HMAveragePointbox.Text = "1";
                            HMAverageGradebox.Text = "D";
                        }

                        if (sa.HigherMathSubAverage >= 40 && sa.HigherMathSubAverage <= 49)
                        {
                            HMAveragePointbox.Text = "2";
                            HMAverageGradebox.Text = "C";
                        }

                        if (sa.HigherMathSubAverage >= 50 && sa.HigherMathSubAverage <= 59)
                        {
                            HMAveragePointbox.Text = "3";
                            HMAverageGradebox.Text = "B";
                        }

                        if (sa.HigherMathSubAverage >= 60 && sa.HigherMathSubAverage <= 69)
                        {
                            HMAveragePointbox.Text = "3.5";
                            HMAverageGradebox.Text = "A-";
                        }

                        if (sa.HigherMathSubAverage >= 70 && sa.HigherMathSubAverage <= 79)
                        {
                            HMAveragePointbox.Text = "4";
                            HMAverageGradebox.Text = "A";
                        }

                        if (sa.HigherMathSubAverage >= 80 && sa.HigherMathSubAverage <= 100)
                        {
                            HMAveragePointbox.Text = "5";
                            HMAverageGradebox.Text = "A+";
                        }
                    }
                    sa.ICTSubAverage = st.ICTSubTotal;
                    {
                        if (sa.ICTSubAverage <= 32)
                        {
                            ICTAveragePointbox.Text = "0";
                            ICTAverageGradebox.Text = "F";
                        }

                        if (sa.ICTSubAverage >= 33 && sa.ICTSubAverage <= 39)
                        {
                            ICTAveragePointbox.Text = "1";
                            ICTAverageGradebox.Text = "D";
                        }

                        if (sa.ICTSubAverage >= 40 && sa.ICTSubAverage <= 49)
                        {
                            ICTAveragePointbox.Text = "2";
                            ICTAverageGradebox.Text = "C";
                        }

                        if (sa.ICTSubAverage >= 50 && sa.ICTSubAverage <= 59)
                        {
                            ICTAveragePointbox.Text = "3";
                            ICTAverageGradebox.Text = "B";
                        }

                        if (sa.ICTSubAverage >= 60 && sa.ICTSubAverage <= 69)
                        {
                            ICTAveragePointbox.Text = "3.5";
                            ICTAverageGradebox.Text = "A-";
                        }

                        if (sa.ICTSubAverage >= 70 && sa.ICTSubAverage <= 79)
                        {
                            ICTAveragePointbox.Text = "4";
                            ICTAverageGradebox.Text = "A";
                        }

                        if (sa.ICTSubAverage >= 80 && sa.ICTSubAverage <= 100)
                        {
                            ICTAveragePointbox.Text = "5";
                            ICTAverageGradebox.Text = "A+";
                        }
                    }
                    sa.PhysicsSubAverage = st.PhysicsSubTotal / 2;
                    {
                        if (sa.PhysicsSubAverage <= 32)
                        {
                            PhysicsAveragePointbox.Text = "0";
                            PhysicsAverageGradebox.Text = "F";
                        }

                        if (sa.PhysicsSubAverage >= 33 && sa.PhysicsSubAverage <= 39)
                        {
                            PhysicsAveragePointbox.Text = "1";
                            PhysicsAverageGradebox.Text = "D";
                        }

                        if (sa.PhysicsSubAverage >= 40 && sa.PhysicsSubAverage <= 49)
                        {
                            PhysicsAveragePointbox.Text = "2";
                            PhysicsAverageGradebox.Text = "C";
                        }

                        if (sa.PhysicsSubAverage >= 50 && sa.PhysicsSubAverage <= 59)
                        {
                            PhysicsAveragePointbox.Text = "3";
                            PhysicsAverageGradebox.Text = "B";
                        }

                        if (sa.PhysicsSubAverage >= 60 && sa.PhysicsSubAverage <= 69)
                        {
                            PhysicsAveragePointbox.Text = "3.5";
                            PhysicsAverageGradebox.Text = "A-";
                        }

                        if (sa.PhysicsSubAverage >= 70 && sa.PhysicsSubAverage <= 79)
                        {
                            PhysicsAveragePointbox.Text = "4";
                            PhysicsAverageGradebox.Text = "A";
                        }

                        if (sa.PhysicsSubAverage >= 80 && sa.PhysicsSubAverage <= 100)
                        {
                            PhysicsAveragePointbox.Text = "5";
                            PhysicsAverageGradebox.Text = "A+";
                        }
                    }
                }

             BanglaSubAverage.Text = sa.BanglaSubAverage.ToString();
             BiologySubAverage.Text = sa.BiologySubAverage.ToString();
             ChemistrySubAverage.Text = sa.ChemistrySubAverage.ToString();
             EnglishSubAverage.Text = sa.EnglishSubAverage.ToString();
             HMSubAverage.Text = sa.HigherMathSubAverage.ToString();
             ICTSubAverage.Text = sa.ICTSubAverage.ToString();
             PhysicsSubAverage.Text = sa.PhysicsSubAverage.ToString();
              
             GetFinalResult gfr = new GetFinalResult();
             { 
             gfr.BanglaFinalResult = float.Parse(BanglaAveragePointbox.Text);
             gfr.BiologyFinalResult = float.Parse(BiologyAveragePointbox.Text);
             gfr.ChemistryFinalResult = float.Parse(ChemistryAveragePointbox.Text);
             gfr.EnglishFinalResult = float.Parse(EnglishAveragePointbox.Text);
             gfr.HigherMathFinalResult = float.Parse(HMAveragePointbox.Text);
             gfr.ICTFinalResult = float.Parse(ICTAveragePointbox.Text);
             gfr.PhysicsFinalResult = float.Parse(PhysicsAveragePointbox.Text);
             }
             float AverageTotal = gfr.BanglaFinalResult + gfr.BiologyFinalResult + gfr.ChemistryFinalResult + gfr.EnglishFinalResult + gfr.HigherMathFinalResult + gfr.ICTFinalResult + gfr.PhysicsFinalResult;
             float GPA = (AverageTotal - 2) / 6;
             FinalResultbox.Text = GPA.ToString();
               
            }
            catch
            {
            MessageBox.Show("One or more parameters exceed 100 marks in 'Individual Totals' or the input boxes may remain empty & unable to find out the overall result or the result is incorrect.\nPlease input again ! If doesn't work, please re-enter marks.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Bangla1stTheory.Text = ""; Bangla1stMCQ.Text = ""; Bangla2ndTheory.Text = ""; Biology1stTheory.Text = "";Biology1stPractical.Text = ""; Biology1stMCQ.Text = ""; Biology2ndTheory.Text = ""; Biology2ndPractical.Text = "";Biology2ndMCQ.Text = "";Chemistry1stTheory.Text = "";Chemistry1stPractical.Text = "";Chemistry1stMCQ.Text = "";Chemistry2ndTheory.Text = "";Chemistry2ndPractical.Text = "";Chemistry2ndMCQ.Text = "";English1stPaper.Text = "";English2ndPaper.Text = "";HM1stTheory.Text = "";HM1stPractical.Text = "";HM2ndTheory.Text = "";HM2ndPractical.Text = "";
            Physics1stTheory.Text = "";Physics1stPractical.Text = "";Physics1stMCQ.Text = "";Physics2ndTheory.Text = "";Physics2ndPractical.Text = "";Physics2ndMCQ.Text = "";ICTTheory.Text = "";ICTPractical.Text = "";ICTMCQ.Text = "";
            Bangla1stTotalPointbox.Text = ""; Bangla1stTotalGradebox.Text = ""; Bangla2ndTotalPointbox.Text = "";
            Bangla2ndTotalGradebox.Text = ""; Biology1stTotalPointbox.Text = ""; Biology1stTotalGradebox.Text = ""; Biology2ndTotalPointbox.Text = ""; Biology2ndTotalGradebox.Text = ""; Chemistry1stTotalPointbox.Text = "";
            Chemistry1stTotalGradebox.Text = ""; Chemistry2ndTotalPointbox.Text = ""; Chemistry2ndTotalGradebox.Text = "";
            English1stTotalPointbox.Text = ""; English1stTotalGradebox.Text = ""; English2ndTotalPointbox.Text = ""; English2ndTotalGradebox.Text = ""; HM1stTotalPointbox.Text = ""; HM1stTotalGradebox.Text = ""; HM2ndTotalPointbox.Text = ""; HM2ndTotalGradebox.Text = ""; ICTTotalPointbox.Text = ""; ICTTotalGradebox.Text = ""; Physics1stTotalPointbox.Text = ""; Physics1stTotalGradebox.Text = ""; Physics2ndTotalPointbox.Text = "";
            Physics2ndTotalGradebox.Text = ""; BanglaSubjectTotalPointbox.Text = ""; BanglaSubjectTotalGradebox.Text = "";
            BiologySubjectTotalPointbox.Text = ""; BiologySubjectTotalGradebox.Text = ""; ChemistrySubjectTotalPointbox.Text = ""; ChemistrySubjectTotalGradebox.Text = ""; EnglishSubjectTotalPointbox.Text = ""; EnglishSubjectTotalGradebox.Text = ""; HMSubjectTotalPointbox.Text = ""; HMSubjectTotalGradebox.Text = ""; ICTSubjectTotalPointbox.Text = ""; ICTSubjectTotalGradebox.Text = ""; PhysicsSubjectTotalPointbox.Text = ""; PhysicsSubjectTotalGradebox.Text = ""; BanglaAveragePointbox.Text = ""; BanglaAverageGradebox.Text = ""; BiologyAveragePointbox.Text = ""; BiologyAverageGradebox.Text = ""; ChemistryAveragePointbox.Text = ""; ChemistryAverageGradebox.Text = ""; EnglishAveragePointbox.Text = ""; EnglishAverageGradebox.Text = ""; HMAveragePointbox.Text = ""; HMAverageGradebox.Text = ""; ICTAveragePointbox.Text = ""; ICTAverageGradebox.Text = ""; PhysicsAveragePointbox.Text = ""; PhysicsAverageGradebox.Text = "";
            Bangla1stTotal.Text = "";Bangla2ndTotal.Text = "";Biology1stTotal.Text = "";Biology2ndTotal.Text = "";Chemistry1stTotal.Text = "";
            Chemistry2ndTotal.Text = "";English1stTotal.Text = "";English2ndTotal.Text = "";HM1stTotal.Text = "";HM2ndTotal.Text = "";ICTTotal.Text = "";
            Physics1stTotal.Text = "";Physics2ndTotal.Text = ""; FinalResultbox.Text = ""; BanglaSubAverage.Text = "";
            BiologySubAverage.Text = "";ChemistrySubAverage.Text = "";EnglishSubAverage.Text = ""; HMSubAverage.Text = "";ICTSubAverage.Text = "";
            PhysicsSubAverage.Text = ""; BanglaSubTotal.Text = "";BiologySubTotal.Text = "";ChemistrySubTotal.Text = "";EnglishSubTotal.Text = "";
            HMSubTotal.Text = "";ICTSubTotal.Text = ""; PhysicsSubTotal.Text = "";

        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetSubTPM gsub = new GetSubTPM();
                {
                    gsub.Bangla1stTheory = float.Parse(Bangla1stTheory.Text);
                    gsub.Bangla1stMCQ = float.Parse(Bangla1stMCQ.Text);

                    gsub.Bangla2ndTheory = float.Parse(Bangla2ndTheory.Text);


                    gsub.Biology1stTheory = float.Parse(Biology1stTheory.Text);
                    gsub.Biology1stPractical = float.Parse(Biology1stPractical.Text);
                    gsub.Biology1stMCQ = float.Parse(Biology1stMCQ.Text);

                    gsub.Biology2ndTheory = float.Parse(Biology2ndTheory.Text);
                    gsub.Biology2ndPractical = float.Parse(Biology2ndPractical.Text);
                    gsub.Biology2ndMCQ = float.Parse(Biology2ndMCQ.Text);

                    gsub.Chemistry1stTheory = float.Parse(Chemistry1stTheory.Text);
                    gsub.Chemistry1stPractical = float.Parse(Chemistry1stPractical.Text);
                    gsub.Chemistry1stMCQ = float.Parse(Chemistry1stMCQ.Text);

                    gsub.Chemistry2ndTheory = float.Parse(Chemistry2ndTheory.Text);
                    gsub.Chemistry2ndPractical = float.Parse(Chemistry2ndPractical.Text);
                    gsub.Chemistry2ndMCQ = float.Parse(Chemistry2ndMCQ.Text);

                    gsub.English1stPaper = float.Parse(English1stPaper.Text);
                    gsub.English2ndPaper = float.Parse(English2ndPaper.Text);

                    gsub.HigherMath1stTheory = float.Parse(HM1stTheory.Text);
                    gsub.HigherMath1stPractical = float.Parse(HM1stPractical.Text);

                    gsub.HigherMath2ndTheory = float.Parse(HM2ndTheory.Text);
                    gsub.HigherMath2ndPractical = float.Parse(HM2ndPractical.Text);

                    gsub.Physics1stTheory = float.Parse(Physics1stTheory.Text);
                    gsub.Physics1stPractical = float.Parse(Physics1stPractical.Text);
                    gsub.Physics1stMCQ = float.Parse(Physics1stMCQ.Text);

                    gsub.Physics2ndTheory = float.Parse(Physics2ndTheory.Text);
                    gsub.Physics2ndPractical = float.Parse(Physics2ndPractical.Text);
                    gsub.Physics2ndMCQ = float.Parse(Physics2ndMCQ.Text);

                    gsub.ICTTheory = float.Parse(ICTTheory.Text);
                    gsub.ICTPractical = float.Parse(ICTPractical.Text);
                    gsub.ICTMCQ = float.Parse(ICTMCQ.Text);
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


                //>>> OUTPUT Individual Totals >>>


                //Bangla1stTotal.Text = gst.Bangla1stTotal.ToString();
                //Bangla2ndTotal.Text = gst.Bangla2ndTotal.ToString();

                //Biology1stTotal.Text = gst.Biology1stTotal.ToString();
                //Biology2ndTotal.Text = gst.Biology2ndTotal.ToString();

                //Chemistry1stTotal.Text = gst.Chemistry1stTotal.ToString();
                //Chemistry2ndTotal.Text = gst.Chemistry2ndTotal.ToString();

                //English1stTotal.Text = gst.English1stPaperTotal.ToString();
                //English2ndTotal.Text = gst.English2ndPaperTotal.ToString();

                //HM1stTotal.Text = gst.HigherMath1stTotal.ToString();
                //HM2ndTotal.Text = gst.HigherMath2ndTotal.ToString();

                //ICTTotal.Text = gst.ICTTotal.ToString();

                //Physics1stTotal.Text = gst.Physics1stTotal.ToString();
                //Physics2ndTotal.Text = gst.Physics2ndTotal.ToString();






                //>>> OUTPUT Individual Totals >>>

                //>>>>>>>>>>>>>>>>>

                SubjectTotal st = new SubjectTotal();
                {
                    st.BanglaSubTotal = gst.Bangla1stTotal + gst.Bangla2ndTotal;
                    {
                        if (st.BanglaSubTotal / 2 <= 32)
                        {
                            BanglaSubjectTotalPointbox.Text = "0";
                            BanglaSubjectTotalGradebox.Text = "F";
                        }

                        if (st.BanglaSubTotal / 2 >= 33 && st.BanglaSubTotal / 2 <= 39)
                        {
                            BanglaSubjectTotalPointbox.Text = "1";
                            BanglaSubjectTotalGradebox.Text = "D";
                        }

                        if (st.BanglaSubTotal / 2 >= 40 && st.BanglaSubTotal / 2 <= 49)
                        {
                            BanglaSubjectTotalPointbox.Text = "2";
                            BanglaSubjectTotalGradebox.Text = "C";
                        }

                        if (st.BanglaSubTotal / 2 >= 50 && st.BanglaSubTotal / 2 <= 59)
                        {
                            BanglaSubjectTotalPointbox.Text = "3";
                            BanglaSubjectTotalGradebox.Text = "B";
                        }

                        if (st.BanglaSubTotal / 2 >= 60 && st.BanglaSubTotal / 2 <= 69)
                        {
                            BanglaSubjectTotalPointbox.Text = "3.5";
                            BanglaSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.BanglaSubTotal / 2 >= 70 && st.BanglaSubTotal / 2 <= 79)
                        {
                            BanglaSubjectTotalPointbox.Text = "4";
                            BanglaSubjectTotalGradebox.Text = "A";
                        }

                        if (st.BanglaSubTotal / 2 >= 80 && st.BanglaSubTotal / 2 <= 100)
                        {
                            BanglaSubjectTotalPointbox.Text = "5";
                            BanglaSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.BiologySubTotal = gst.Biology1stTotal + gst.Biology2ndTotal;
                    {
                        if (st.BiologySubTotal / 2 <= 32)
                        {
                            BiologySubjectTotalPointbox.Text = "0";
                            BiologySubjectTotalGradebox.Text = "F";
                        }

                        if (st.BiologySubTotal / 2 >= 33 && st.BiologySubTotal / 2 <= 39)
                        {
                            BiologySubjectTotalPointbox.Text = "1";
                            BiologySubjectTotalGradebox.Text = "D";
                        }

                        if (st.BiologySubTotal / 2 >= 40 && st.BiologySubTotal / 2 <= 49)
                        {
                            BiologySubjectTotalPointbox.Text = "2";
                            BiologySubjectTotalGradebox.Text = "C";
                        }

                        if (st.BiologySubTotal / 2 >= 50 && st.BiologySubTotal / 2 <= 59)
                        {
                            BiologySubjectTotalPointbox.Text = "3";
                            BiologySubjectTotalGradebox.Text = "B";
                        }

                        if (st.BiologySubTotal / 2 >= 60 && st.BiologySubTotal / 2 <= 69)
                        {
                            BiologySubjectTotalPointbox.Text = "3.5";
                            BiologySubjectTotalGradebox.Text = "A-";
                        }

                        if (st.BiologySubTotal / 2 >= 70 && st.BiologySubTotal / 2 <= 79)
                        {
                            BiologySubjectTotalPointbox.Text = "4";
                            BiologySubjectTotalGradebox.Text = "A";
                        }

                        if (st.BiologySubTotal / 2 >= 80 && st.BiologySubTotal / 2 <= 100)
                        {
                            BiologySubjectTotalPointbox.Text = "5";
                            BiologySubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.ChemistrySubTotal = gst.Chemistry1stTotal + gst.Chemistry2ndTotal;
                    {
                        if (st.ChemistrySubTotal / 2 <= 32)
                        {
                            ChemistrySubjectTotalPointbox.Text = "0";
                            ChemistrySubjectTotalGradebox.Text = "F";
                        }

                        if (st.ChemistrySubTotal / 2 >= 33 && st.ChemistrySubTotal / 2 <= 39)
                        {
                            ChemistrySubjectTotalPointbox.Text = "1";
                            ChemistrySubjectTotalGradebox.Text = "D";
                        }

                        if (st.ChemistrySubTotal / 2 >= 40 && st.ChemistrySubTotal / 2 <= 49)
                        {
                            ChemistrySubjectTotalPointbox.Text = "2";
                            ChemistrySubjectTotalGradebox.Text = "C";
                        }

                        if (st.ChemistrySubTotal / 2 >= 50 && st.ChemistrySubTotal / 2 <= 59)
                        {
                            ChemistrySubjectTotalPointbox.Text = "3";
                            ChemistrySubjectTotalGradebox.Text = "B";
                        }

                        if (st.ChemistrySubTotal / 2 >= 60 && st.ChemistrySubTotal / 2 <= 69)
                        {
                            ChemistrySubjectTotalPointbox.Text = "3.5";
                            ChemistrySubjectTotalGradebox.Text = "A-";
                        }

                        if (st.ChemistrySubTotal / 2 >= 70 && st.ChemistrySubTotal / 2 <= 79)
                        {
                            ChemistrySubjectTotalPointbox.Text = "4";
                            ChemistrySubjectTotalGradebox.Text = "A";
                        }

                        if (st.ChemistrySubTotal / 2 >= 80 && st.ChemistrySubTotal / 2 <= 100)
                        {
                            ChemistrySubjectTotalPointbox.Text = "5";
                            ChemistrySubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.EnglishSubTotal = gst.English1stPaperTotal + gst.English2ndPaperTotal;
                    {
                        if (st.EnglishSubTotal / 2 <= 32)
                        {
                            EnglishSubjectTotalPointbox.Text = "0";
                            EnglishSubjectTotalGradebox.Text = "F";
                        }

                        if (st.EnglishSubTotal / 2 >= 33 && st.EnglishSubTotal / 2 <= 39)
                        {
                            EnglishSubjectTotalPointbox.Text = "1";
                            EnglishSubjectTotalGradebox.Text = "D";
                        }

                        if (st.EnglishSubTotal / 2 >= 40 && st.EnglishSubTotal / 2 <= 49)
                        {
                            EnglishSubjectTotalPointbox.Text = "2";
                            EnglishSubjectTotalGradebox.Text = "C";
                        }

                        if (st.EnglishSubTotal / 2 >= 50 && st.EnglishSubTotal / 2 <= 59)
                        {
                            EnglishSubjectTotalPointbox.Text = "3";
                            EnglishSubjectTotalGradebox.Text = "B";
                        }

                        if (st.EnglishSubTotal / 2 >= 60 && st.EnglishSubTotal / 2 <= 69)
                        {
                            EnglishSubjectTotalPointbox.Text = "3.5";
                            EnglishSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.EnglishSubTotal / 2 >= 70 && st.EnglishSubTotal / 2 <= 79)
                        {
                            EnglishSubjectTotalPointbox.Text = "4";
                            EnglishSubjectTotalGradebox.Text = "A";
                        }

                        if (st.EnglishSubTotal / 2 >= 80 && st.EnglishSubTotal / 2 <= 100)
                        {
                            EnglishSubjectTotalPointbox.Text = "5";
                            EnglishSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.HigherMathSubTotal = gst.HigherMath1stTotal + gst.HigherMath2ndTotal;
                    {
                        if (st.HigherMathSubTotal / 2 <= 32)
                        {
                            HMSubjectTotalPointbox.Text = "0";
                            HMSubjectTotalGradebox.Text = "F";
                        }

                        if (st.HigherMathSubTotal / 2 >= 33 && st.HigherMathSubTotal / 2 <= 39)
                        {
                            HMSubjectTotalPointbox.Text = "1";
                            HMSubjectTotalGradebox.Text = "D";
                        }

                        if (st.HigherMathSubTotal / 2 >= 40 && st.HigherMathSubTotal / 2 <= 49)
                        {
                            HMSubjectTotalPointbox.Text = "2";
                            HMSubjectTotalGradebox.Text = "C";
                        }

                        if (st.HigherMathSubTotal / 2 >= 50 && st.HigherMathSubTotal / 2 <= 59)
                        {
                            HMSubjectTotalPointbox.Text = "3";
                            HMSubjectTotalGradebox.Text = "B";
                        }

                        if (st.HigherMathSubTotal / 2 >= 60 && st.HigherMathSubTotal / 2 <= 69)
                        {
                            HMSubjectTotalPointbox.Text = "3.5";
                            HMSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.HigherMathSubTotal / 2 >= 70 && st.HigherMathSubTotal / 2 <= 79)
                        {
                            HMSubjectTotalPointbox.Text = "4";
                            HMSubjectTotalGradebox.Text = "A";
                        }

                        if (st.HigherMathSubTotal / 2 >= 80 && st.HigherMathSubTotal / 2 <= 100)
                        {
                            HMSubjectTotalPointbox.Text = "5";
                            HMSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.ICTSubTotal = gst.ICTTotal;
                    {
                        if (st.ICTSubTotal <= 32)
                        {
                            ICTSubjectTotalPointbox.Text = "0";
                            ICTSubjectTotalGradebox.Text = "F";
                        }

                        if (st.ICTSubTotal >= 33 && st.ICTSubTotal <= 39)
                        {
                            ICTSubjectTotalPointbox.Text = "1";
                            ICTSubjectTotalGradebox.Text = "D";
                        }

                        if (st.ICTSubTotal >= 40 && st.ICTSubTotal <= 49)
                        {
                            ICTSubjectTotalPointbox.Text = "2";
                            ICTSubjectTotalGradebox.Text = "C";
                        }

                        if (st.ICTSubTotal >= 50 && st.ICTSubTotal <= 59)
                        {
                            ICTSubjectTotalPointbox.Text = "3";
                            ICTSubjectTotalGradebox.Text = "B";
                        }

                        if (st.ICTSubTotal >= 60 && st.ICTSubTotal <= 69)
                        {
                            ICTSubjectTotalPointbox.Text = "3.5";
                            ICTSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.ICTSubTotal >= 70 && st.ICTSubTotal <= 79)
                        {
                            ICTSubjectTotalPointbox.Text = "4";
                            ICTSubjectTotalGradebox.Text = "A";
                        }

                        if (st.ICTSubTotal >= 80 && st.ICTSubTotal <= 100)
                        {
                            ICTSubjectTotalPointbox.Text = "5";
                            ICTSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                    st.PhysicsSubTotal = gst.Physics1stTotal + gst.Physics2ndTotal;
                    {
                        if (st.PhysicsSubTotal / 2 <= 32)
                        {
                            PhysicsSubjectTotalPointbox.Text = "0";
                            PhysicsSubjectTotalGradebox.Text = "F";
                        }

                        if (st.PhysicsSubTotal / 2 >= 33 && st.PhysicsSubTotal / 2 <= 39)
                        {
                            PhysicsSubjectTotalPointbox.Text = "1";
                            PhysicsSubjectTotalGradebox.Text = "D";
                        }

                        if (st.PhysicsSubTotal / 2 >= 40 && st.PhysicsSubTotal / 2 <= 49)
                        {
                            PhysicsSubjectTotalPointbox.Text = "2";
                            PhysicsSubjectTotalGradebox.Text = "C";
                        }

                        if (st.PhysicsSubTotal / 2 >= 50 && st.PhysicsSubTotal / 2 <= 59)
                        {
                            PhysicsSubjectTotalPointbox.Text = "3";
                            PhysicsSubjectTotalGradebox.Text = "B";
                        }

                        if (st.PhysicsSubTotal / 2 >= 60 && st.PhysicsSubTotal / 2 <= 69)
                        {
                            PhysicsSubjectTotalPointbox.Text = "3.5";
                            PhysicsSubjectTotalGradebox.Text = "A-";
                        }

                        if (st.PhysicsSubTotal / 2 >= 70 && st.PhysicsSubTotal / 2 <= 79)
                        {
                            PhysicsSubjectTotalPointbox.Text = "4";
                            PhysicsSubjectTotalGradebox.Text = "A";
                        }

                        if (st.PhysicsSubTotal / 2 >= 80 && st.PhysicsSubTotal / 2 <= 100)
                        {
                            PhysicsSubjectTotalPointbox.Text = "5";
                            PhysicsSubjectTotalGradebox.Text = "A+";
                        }
                        else { }
                    }
                }


                ///>>> OUTPUT Subject Total >>>

                BanglaSubTotal.Text = st.BanglaSubTotal.ToString();
                BiologySubTotal.Text = st.BiologySubTotal.ToString();
                ChemistrySubTotal.Text = st.ChemistrySubTotal.ToString();
                EnglishSubTotal.Text = st.EnglishSubTotal.ToString();
                HMSubTotal.Text = st.HigherMathSubTotal.ToString();
                ICTSubTotal.Text = st.ICTSubTotal.ToString();
                PhysicsSubTotal.Text = st.PhysicsSubTotal.ToString();

                ///>>> OUTPUT Subject Total >>>

                SubAve sa = new SubAve();
                {
                    sa.BanglaSubAverage = st.BanglaSubTotal / 2;
                    {
                        if (sa.BanglaSubAverage <= 32)
                        {
                            BanglaAveragePointbox.Text = "0";
                            BanglaAverageGradebox.Text = "F";
                        }

                        if (sa.BanglaSubAverage >= 33 && sa.BanglaSubAverage <= 39)
                        {
                            BanglaAveragePointbox.Text = "1";
                            BanglaAverageGradebox.Text = "D";
                        }

                        if (sa.BanglaSubAverage >= 40 && sa.BanglaSubAverage <= 49)
                        {
                            BanglaAveragePointbox.Text = "2";
                            BanglaAverageGradebox.Text = "C";
                        }

                        if (sa.BanglaSubAverage >= 50 && sa.BanglaSubAverage <= 59)
                        {
                            BanglaAveragePointbox.Text = "3";
                            BanglaAverageGradebox.Text = "B";
                        }

                        if (sa.BanglaSubAverage >= 60 && sa.BanglaSubAverage <= 69)
                        {
                            BanglaAveragePointbox.Text = "3.5";
                            BanglaAverageGradebox.Text = "A-";
                        }

                        if (sa.BanglaSubAverage >= 70 && sa.BanglaSubAverage <= 79)
                        {
                            BanglaAveragePointbox.Text = "4";
                            BanglaAverageGradebox.Text = "A";
                        }

                        if (sa.BanglaSubAverage >= 80 && sa.BanglaSubAverage <= 100)
                        {
                            BanglaAveragePointbox.Text = "5";
                            BanglaAverageGradebox.Text = "A+";
                        }
                        else { }
                    }

                    sa.BiologySubAverage = st.BiologySubTotal / 2;
                    {
                        if (sa.BiologySubAverage <= 32)
                        {
                            BiologyAveragePointbox.Text = "0";
                            BiologyAverageGradebox.Text = "F";
                        }

                        if (sa.BiologySubAverage >= 33 && sa.BiologySubAverage <= 39)
                        {
                            BiologyAveragePointbox.Text = "1";
                            BiologyAverageGradebox.Text = "D";
                        }

                        if (sa.BiologySubAverage >= 40 && sa.BiologySubAverage <= 49)
                        {
                            BiologyAveragePointbox.Text = "2";
                            BiologyAverageGradebox.Text = "C";
                        }

                        if (sa.BiologySubAverage >= 50 && sa.BiologySubAverage <= 59)
                        {
                            BiologyAveragePointbox.Text = "3";
                            BiologyAverageGradebox.Text = "B";
                        }

                        if (sa.BiologySubAverage >= 60 && sa.BiologySubAverage <= 69)
                        {
                            BiologyAveragePointbox.Text = "3.5";
                            BiologyAverageGradebox.Text = "A-";
                        }

                        if (sa.BiologySubAverage >= 70 && sa.BiologySubAverage <= 79)
                        {
                            BiologyAveragePointbox.Text = "4";
                            BiologyAverageGradebox.Text = "A";
                        }

                        if (sa.BiologySubAverage >= 80 && sa.BiologySubAverage <= 100)
                        {
                            BiologyAveragePointbox.Text = "5";
                            BiologyAverageGradebox.Text = "A+";
                        }
                    }
                    sa.ChemistrySubAverage = st.ChemistrySubTotal / 2;
                    {
                        if (sa.ChemistrySubAverage <= 32)
                        {
                            ChemistryAveragePointbox.Text = "0";
                            ChemistryAverageGradebox.Text = "F";
                        }

                        if (sa.ChemistrySubAverage >= 33 && sa.ChemistrySubAverage <= 39)
                        {
                            ChemistryAveragePointbox.Text = "1";
                            ChemistryAverageGradebox.Text = "D";
                        }

                        if (sa.ChemistrySubAverage >= 40 && sa.ChemistrySubAverage <= 49)
                        {
                            ChemistryAveragePointbox.Text = "2";
                            ChemistryAverageGradebox.Text = "C";
                        }

                        if (sa.ChemistrySubAverage >= 50 && sa.ChemistrySubAverage <= 59)
                        {
                            ChemistryAveragePointbox.Text = "3";
                            ChemistryAverageGradebox.Text = "B";
                        }

                        if (sa.ChemistrySubAverage >= 60 && sa.ChemistrySubAverage <= 69)
                        {
                            ChemistryAveragePointbox.Text = "3.5";
                            ChemistryAverageGradebox.Text = "A-";
                        }

                        if (sa.ChemistrySubAverage >= 70 && sa.ChemistrySubAverage <= 79)
                        {
                            ChemistryAveragePointbox.Text = "4";
                            ChemistryAverageGradebox.Text = "A";
                        }

                        if (sa.ChemistrySubAverage >= 80 && sa.ChemistrySubAverage <= 100)
                        {
                            ChemistryAveragePointbox.Text = "5";
                            ChemistryAverageGradebox.Text = "A+";
                        }
                    }
                    sa.EnglishSubAverage = st.EnglishSubTotal / 2;
                    {
                        if (sa.EnglishSubAverage <= 32)
                        {
                            EnglishAveragePointbox.Text = "0";
                            EnglishAverageGradebox.Text = "F";
                        }

                        if (sa.EnglishSubAverage >= 33 && sa.EnglishSubAverage <= 39)
                        {
                            EnglishAveragePointbox.Text = "1";
                            EnglishAverageGradebox.Text = "D";
                        }

                        if (sa.EnglishSubAverage >= 40 && sa.EnglishSubAverage <= 49)
                        {
                            EnglishAveragePointbox.Text = "2";
                            EnglishAverageGradebox.Text = "C";
                        }

                        if (sa.EnglishSubAverage >= 50 && sa.EnglishSubAverage <= 59)
                        {
                            EnglishAveragePointbox.Text = "3";
                            EnglishAverageGradebox.Text = "B";
                        }

                        if (sa.EnglishSubAverage >= 60 && sa.EnglishSubAverage <= 69)
                        {
                            EnglishAveragePointbox.Text = "3.5";
                            EnglishAverageGradebox.Text = "A-";
                        }

                        if (sa.EnglishSubAverage >= 70 && sa.EnglishSubAverage <= 79)
                        {
                            EnglishAveragePointbox.Text = "4";
                            EnglishAverageGradebox.Text = "A";
                        }

                        if (sa.EnglishSubAverage >= 80 && sa.EnglishSubAverage <= 100)
                        {
                            EnglishAveragePointbox.Text = "5";
                            EnglishAverageGradebox.Text = "A+";
                        }
                    }

                    sa.HigherMathSubAverage = st.HigherMathSubTotal / 2;
                    {
                        if (sa.HigherMathSubAverage <= 32)
                        {
                            HMAveragePointbox.Text = "0";
                            HMAverageGradebox.Text = "F";
                        }

                        if (sa.HigherMathSubAverage >= 33 && sa.HigherMathSubAverage <= 39)
                        {
                            HMAveragePointbox.Text = "1";
                            HMAverageGradebox.Text = "D";
                        }

                        if (sa.HigherMathSubAverage >= 40 && sa.HigherMathSubAverage <= 49)
                        {
                            HMAveragePointbox.Text = "2";
                            HMAverageGradebox.Text = "C";
                        }

                        if (sa.HigherMathSubAverage >= 50 && sa.HigherMathSubAverage <= 59)
                        {
                            HMAveragePointbox.Text = "3";
                            HMAverageGradebox.Text = "B";
                        }

                        if (sa.HigherMathSubAverage >= 60 && sa.HigherMathSubAverage <= 69)
                        {
                            HMAveragePointbox.Text = "3.5";
                            HMAverageGradebox.Text = "A-";
                        }

                        if (sa.HigherMathSubAverage >= 70 && sa.HigherMathSubAverage <= 79)
                        {
                            HMAveragePointbox.Text = "4";
                            HMAverageGradebox.Text = "A";
                        }

                        if (sa.HigherMathSubAverage >= 80 && sa.HigherMathSubAverage <= 100)
                        {
                            HMAveragePointbox.Text = "5";
                            HMAverageGradebox.Text = "A+";
                        }
                    }
                    sa.ICTSubAverage = st.ICTSubTotal;
                    {
                        if (sa.ICTSubAverage <= 32)
                        {
                            ICTAveragePointbox.Text = "0";
                            ICTAverageGradebox.Text = "F";
                        }

                        if (sa.ICTSubAverage >= 33 && sa.ICTSubAverage <= 39)
                        {
                            ICTAveragePointbox.Text = "1";
                            ICTAverageGradebox.Text = "D";
                        }

                        if (sa.ICTSubAverage >= 40 && sa.ICTSubAverage <= 49)
                        {
                            ICTAveragePointbox.Text = "2";
                            ICTAverageGradebox.Text = "C";
                        }

                        if (sa.ICTSubAverage >= 50 && sa.ICTSubAverage <= 59)
                        {
                            ICTAveragePointbox.Text = "3";
                            ICTAverageGradebox.Text = "B";
                        }

                        if (sa.ICTSubAverage >= 60 && sa.ICTSubAverage <= 69)
                        {
                            ICTAveragePointbox.Text = "3.5";
                            ICTAverageGradebox.Text = "A-";
                        }

                        if (sa.ICTSubAverage >= 70 && sa.ICTSubAverage <= 79)
                        {
                            ICTAveragePointbox.Text = "4";
                            ICTAverageGradebox.Text = "A";
                        }

                        if (sa.ICTSubAverage >= 80 && sa.ICTSubAverage <= 100)
                        {
                            ICTAveragePointbox.Text = "5";
                            ICTAverageGradebox.Text = "A+";
                        }
                    }
                    sa.PhysicsSubAverage = st.PhysicsSubTotal / 2;
                    {
                        if (sa.PhysicsSubAverage <= 32)
                        {
                            PhysicsAveragePointbox.Text = "0";
                            PhysicsAverageGradebox.Text = "F";
                        }

                        if (sa.PhysicsSubAverage >= 33 && sa.PhysicsSubAverage <= 39)
                        {
                            PhysicsAveragePointbox.Text = "1";
                            PhysicsAverageGradebox.Text = "D";
                        }

                        if (sa.PhysicsSubAverage >= 40 && sa.PhysicsSubAverage <= 49)
                        {
                            PhysicsAveragePointbox.Text = "2";
                            PhysicsAverageGradebox.Text = "C";
                        }

                        if (sa.PhysicsSubAverage >= 50 && sa.PhysicsSubAverage <= 59)
                        {
                            PhysicsAveragePointbox.Text = "3";
                            PhysicsAverageGradebox.Text = "B";
                        }

                        if (sa.PhysicsSubAverage >= 60 && sa.PhysicsSubAverage <= 69)
                        {
                            PhysicsAveragePointbox.Text = "3.5";
                            PhysicsAverageGradebox.Text = "A-";
                        }

                        if (sa.PhysicsSubAverage >= 70 && sa.PhysicsSubAverage <= 79)
                        {
                            PhysicsAveragePointbox.Text = "4";
                            PhysicsAverageGradebox.Text = "A";
                        }

                        if (sa.PhysicsSubAverage >= 80 && sa.PhysicsSubAverage <= 100)
                        {
                            PhysicsAveragePointbox.Text = "5";
                            PhysicsAverageGradebox.Text = "A+";
                        }
                    }
                }

                BanglaSubAverage.Text = sa.BanglaSubAverage.ToString();
                BiologySubAverage.Text = sa.BiologySubAverage.ToString();
                ChemistrySubAverage.Text = sa.ChemistrySubAverage.ToString();
                EnglishSubAverage.Text = sa.EnglishSubAverage.ToString();
                HMSubAverage.Text = sa.HigherMathSubAverage.ToString();
                ICTSubAverage.Text = sa.ICTSubAverage.ToString();
                PhysicsSubAverage.Text = sa.PhysicsSubAverage.ToString();

                GetFinalResult gfr = new GetFinalResult();
                {
                    gfr.BanglaFinalResult = float.Parse(BanglaAveragePointbox.Text);
                    gfr.BiologyFinalResult = float.Parse(BiologyAveragePointbox.Text);
                    gfr.ChemistryFinalResult = float.Parse(ChemistryAveragePointbox.Text);
                    gfr.EnglishFinalResult = float.Parse(EnglishAveragePointbox.Text);
                    gfr.HigherMathFinalResult = float.Parse(HMAveragePointbox.Text);
                    gfr.ICTFinalResult = float.Parse(ICTAveragePointbox.Text);
                    gfr.PhysicsFinalResult = float.Parse(PhysicsAveragePointbox.Text);
                }
                float AverageTotal = gfr.BanglaFinalResult + gfr.BiologyFinalResult + gfr.ChemistryFinalResult + gfr.EnglishFinalResult + gfr.HigherMathFinalResult + gfr.ICTFinalResult + gfr.PhysicsFinalResult;
                float GPA = (AverageTotal - 2) / 6;
                FinalResultbox.Text = GPA.ToString();

            }
            catch
            {
                MessageBox.Show("One or more parameters exceed 100 marks in 'Individual Totals' or the input boxes may remain empty & unable to find out the overall result or the result is incorrect.\nPlease input again ! If doesn't work, please re-enter marks.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bangla1stTheory.Text = ""; Bangla1stMCQ.Text = ""; Bangla2ndTheory.Text = ""; Biology1stTheory.Text = ""; Biology1stPractical.Text = ""; Biology1stMCQ.Text = ""; Biology2ndTheory.Text = ""; Biology2ndPractical.Text = ""; Biology2ndMCQ.Text = ""; Chemistry1stTheory.Text = ""; Chemistry1stPractical.Text = ""; Chemistry1stMCQ.Text = ""; Chemistry2ndTheory.Text = ""; Chemistry2ndPractical.Text = ""; Chemistry2ndMCQ.Text = ""; English1stPaper.Text = ""; English2ndPaper.Text = ""; HM1stTheory.Text = ""; HM1stPractical.Text = ""; HM2ndTheory.Text = ""; HM2ndPractical.Text = "";
            Physics1stTheory.Text = ""; Physics1stPractical.Text = ""; Physics1stMCQ.Text = ""; Physics2ndTheory.Text = ""; Physics2ndPractical.Text = ""; Physics2ndMCQ.Text = ""; ICTTheory.Text = ""; ICTPractical.Text = ""; ICTMCQ.Text = "";
            Bangla1stTotalPointbox.Text = ""; Bangla1stTotalGradebox.Text = ""; Bangla2ndTotalPointbox.Text = "";
            Bangla2ndTotalGradebox.Text = ""; Biology1stTotalPointbox.Text = ""; Biology1stTotalGradebox.Text = ""; Biology2ndTotalPointbox.Text = ""; Biology2ndTotalGradebox.Text = ""; Chemistry1stTotalPointbox.Text = "";
            Chemistry1stTotalGradebox.Text = ""; Chemistry2ndTotalPointbox.Text = ""; Chemistry2ndTotalGradebox.Text = "";
            English1stTotalPointbox.Text = ""; English1stTotalGradebox.Text = ""; English2ndTotalPointbox.Text = ""; English2ndTotalGradebox.Text = ""; HM1stTotalPointbox.Text = ""; HM1stTotalGradebox.Text = ""; HM2ndTotalPointbox.Text = ""; HM2ndTotalGradebox.Text = ""; ICTTotalPointbox.Text = ""; ICTTotalGradebox.Text = ""; Physics1stTotalPointbox.Text = ""; Physics1stTotalGradebox.Text = ""; Physics2ndTotalPointbox.Text = "";
            Physics2ndTotalGradebox.Text = ""; BanglaSubjectTotalPointbox.Text = ""; BanglaSubjectTotalGradebox.Text = "";
            BiologySubjectTotalPointbox.Text = ""; BiologySubjectTotalGradebox.Text = ""; ChemistrySubjectTotalPointbox.Text = ""; ChemistrySubjectTotalGradebox.Text = ""; EnglishSubjectTotalPointbox.Text = ""; EnglishSubjectTotalGradebox.Text = ""; HMSubjectTotalPointbox.Text = ""; HMSubjectTotalGradebox.Text = ""; ICTSubjectTotalPointbox.Text = ""; ICTSubjectTotalGradebox.Text = ""; PhysicsSubjectTotalPointbox.Text = ""; PhysicsSubjectTotalGradebox.Text = ""; BanglaAveragePointbox.Text = ""; BanglaAverageGradebox.Text = ""; BiologyAveragePointbox.Text = ""; BiologyAverageGradebox.Text = ""; ChemistryAveragePointbox.Text = ""; ChemistryAverageGradebox.Text = ""; EnglishAveragePointbox.Text = ""; EnglishAverageGradebox.Text = ""; HMAveragePointbox.Text = ""; HMAverageGradebox.Text = ""; ICTAveragePointbox.Text = ""; ICTAverageGradebox.Text = ""; PhysicsAveragePointbox.Text = ""; PhysicsAverageGradebox.Text = "";
            Bangla1stTotal.Text = ""; Bangla2ndTotal.Text = ""; Biology1stTotal.Text = ""; Biology2ndTotal.Text = ""; Chemistry1stTotal.Text = "";
            Chemistry2ndTotal.Text = ""; English1stTotal.Text = ""; English2ndTotal.Text = ""; HM1stTotal.Text = ""; HM2ndTotal.Text = ""; ICTTotal.Text = "";
            Physics1stTotal.Text = ""; Physics2ndTotal.Text = ""; FinalResultbox.Text = ""; BanglaSubAverage.Text = "";
            BiologySubAverage.Text = ""; ChemistrySubAverage.Text = ""; EnglishSubAverage.Text = ""; HMSubAverage.Text = ""; ICTSubAverage.Text = "";
            PhysicsSubAverage.Text = ""; BanglaSubTotal.Text = ""; BiologySubTotal.Text = ""; ChemistrySubTotal.Text = ""; EnglishSubTotal.Text = "";
            HMSubTotal.Text = ""; ICTSubTotal.Text = ""; PhysicsSubTotal.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HSC GPA Suite v.1.1 Essential Edition freeware is offered and developed by Tahmid Radit.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Physics1stTheory_KD(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Physics1stPractical.Focus();
            }
            if(e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                HM1stTheory.Focus();
            }
        }

        private void Physics1stPractical_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Physics1stMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                HM1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Physics1stTheory.Focus();
            }
        }

        private void Physics1stMCQ_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Physics1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                HM1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Physics2ndTheory.Focus();
            }
        }

        private void Physics2ndTheory_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Physics2ndPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                HM2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Physics1stMCQ.Focus();
            }
        }

        private void Physics2ndPractical_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Physics2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                HM2ndPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Physics2ndMCQ.Focus();
            }
        }

        private void Physics2ndMCQ_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Physics2ndPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Chemistry1stTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                HM2ndPractical.Focus();
            }
        }

        private void Chemistry1stTheory_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Physics2ndMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Chemistry1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                English1stPaper.Focus();
            }
        }

        private void Chemistry1stPractical_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Chemistry1stTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Chemistry1stMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                English2ndPaper.Focus();
            }
        }

        private void Chemistry1stMCQ_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Chemistry1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Chemistry2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                English2ndPaper.Focus();
            }
        }

        private void Chemistry2ndTheory_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Chemistry1stMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                ICTTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Chemistry2ndPractical.Focus();
            }
        }

        private void Chemistry2ndPractical_KD(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                ICTPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Chemistry2ndMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Chemistry2ndTheory.Focus();
            }


        }

        private void Chemistry2ndMCQ_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Chemistry2ndPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                ICTMCQ.Focus();
            }

        }

        private void HM1stTheory_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Physics1stTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Bangla1stTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                HM1stPractical.Focus();
            }
        }

        private void HM1stPractical_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Physics1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Bangla1stMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                HM2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                HM1stTheory.Focus();
            }

        }

        private void HM2ndTheory_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Bangla2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                HM1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Physics2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                HM2ndPractical.Focus();
            }
        }

        private void HM2ndPractical_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Bangla2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                HM2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Physics2ndMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                English1stPaper.Focus();
            }
        }

        private void English1stPaper_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Biology1stTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                HM2ndPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Chemistry1stTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                English2ndPaper.Focus();
            }
        }

        private void English2ndPaper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Biology1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                English1stPaper.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Chemistry1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                ICTTheory.Focus();
            }
        }

        private void ICTTheory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Biology2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                English2ndPaper.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Chemistry2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                ICTPractical.Focus();
            }
        }

        private void ICTPractical_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Biology2ndPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                ICTTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Chemistry2ndPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                ICTMCQ.Focus();
            }
        }

        private void ICTMCQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                Biology2ndMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                ICTPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                Chemistry2ndMCQ.Focus();
            }
            
        }

        private void Bangla1stTheory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                HM1stTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Bangla1stMCQ.Focus();
            }
        }

        private void Bangla1stMCQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                HM1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Bangla2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Bangla1stTheory.Focus();
            }
        }

        private void Bangla2ndTheory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                HM2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Biology1stTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Bangla1stMCQ.Focus();
            }
        }

        private void Biology1stTheory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                English1stPaper.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Biology1stPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Bangla2ndTheory.Focus();
            }
        }

        private void Biology1stPractical_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                English2ndPaper.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Biology1stMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Biology1stTheory.Focus();
            }
        }

        private void Biology1stMCQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                English2ndPaper.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Biology2ndTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Biology1stPractical.Focus();
            }
        }

        private void Biology2ndTheory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                ICTTheory.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Biology2ndPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Biology1stMCQ.Focus();
            }
        }

        private void Biology2ndPractical_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                ICTPractical.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                Biology2ndMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Biology2ndTheory.Focus();
            }
        }

        private void Biology2ndMCQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                ICTMCQ.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                SubmitButton.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                Biology2ndPractical.Focus();
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Input all of the boxed before submit.\n2.Please be sure that you've made the correct input.\n3.Use arrow key to move from one textbox to another textbox.\n4.Feel free to let the developer to know the bugs.\n***Thank you for using the software.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tahmid Radit\nJunior C# Developer,Android Developer,ASP.NET MVC Web Application Developer.\nFeel free to mail me at tahmidradit@yahoo.com\nLinkedIn : https://bit.ly/2TWyGaL ", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
