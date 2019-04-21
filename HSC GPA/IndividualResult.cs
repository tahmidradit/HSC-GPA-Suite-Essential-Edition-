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
    
    public partial class Individual_Result : Form
    {
        
        public Individual_Result()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetIndividualSub gis = new GetIndividualSub();
            try
            {

                gis.BanglaIndividual = float.Parse(BanglaIndiTotal.Text);
                SubjectTotal st = new SubjectTotal();
                st.BanglaSubTotal = gis.BanglaIndividual;
                if (st.BanglaSubTotal < 201)
                {
                    if (st.BanglaSubTotal / 2 <= 32)
                    {
                        BanglaIndiTotalPoint.Text = "0";
                        BanglaIndiTotalGrade.Text = "F";
                    }

                    if (st.BanglaSubTotal / 2 >= 33 && st.BanglaSubTotal / 2 <= 39)
                    {
                        BanglaIndiTotalPoint.Text = "1";
                        BanglaIndiTotalGrade.Text = "D";
                    }

                    if (st.BanglaSubTotal / 2 >= 40 && st.BanglaSubTotal / 2 <= 49)
                    {
                        BanglaIndiTotalPoint.Text = "2";
                        BanglaIndiTotalGrade.Text = "C";
                    }

                    if (st.BanglaSubTotal / 2 >= 50 && st.BanglaSubTotal / 2 <= 59)
                    {
                        BanglaIndiTotalPoint.Text = "3";
                        BanglaIndiTotalGrade.Text = "B";
                    }

                    if (st.BanglaSubTotal / 2 >= 60 && st.BanglaSubTotal / 2 <= 69)
                    {
                        BanglaIndiTotalPoint.Text = "3.5";
                        BanglaIndiTotalGrade.Text = "A-";
                    }

                    if (st.BanglaSubTotal / 2 >= 70 && st.BanglaSubTotal / 2 <= 79)
                    {
                        BanglaIndiTotalPoint.Text = "4";
                        BanglaIndiTotalGrade.Text = "A";
                    }

                    if (st.BanglaSubTotal / 2 >= 80 && st.BanglaSubTotal / 2 <= 100)
                    {
                        BanglaIndiTotalPoint.Text = "5";
                        BanglaIndiTotalGrade.Text = "A+";
                    }
                    else { }
                }
                else { MessageBox.Show("Inputs can't exceed 200 marks in total for Bangali !", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

            }
            catch
            {
                //MessageBox.Show("Unexpected error occured.You can't leave any fields empty or illegal characters entered !", "Stop_Bangali", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


            try
            {

                gis.BiologyIndividual = float.Parse(BiologyIndiTotal.Text);
                SubjectTotal st = new SubjectTotal();
                st.BiologySubTotal = gis.BiologyIndividual;
                if (st.BiologySubTotal < 201)
                {
                    if (st.BiologySubTotal / 2 <= 32)
                    {
                        BiologyIndiTotalPoint.Text = "0";
                        BiologyIndiTotalGrade.Text = "F";
                    }

                    if (st.BiologySubTotal / 2 >= 33 && st.BiologySubTotal / 2 <= 39)
                    {
                        BiologyIndiTotalPoint.Text = "1";
                        BiologyIndiTotalGrade.Text = "D";
                    }

                    if (st.BiologySubTotal / 2 >= 40 && st.BiologySubTotal / 2 <= 49)
                    {
                        BiologyIndiTotalPoint.Text = "2";
                        BiologyIndiTotalGrade.Text = "C";
                    }

                    if (st.BiologySubTotal / 2 >= 50 && st.BiologySubTotal / 2 <= 59)
                    {
                        BiologyIndiTotalPoint.Text = "3";
                        BiologyIndiTotalGrade.Text = "B";
                    }

                    if (st.BiologySubTotal / 2 >= 60 && st.BiologySubTotal / 2 <= 69)
                    {
                        BiologyIndiTotalPoint.Text = "3.5";
                        BiologyIndiTotalGrade.Text = "A-";
                    }

                    if (st.BiologySubTotal / 2 >= 70 && st.BiologySubTotal / 2 <= 79)
                    {
                        BiologyIndiTotalPoint.Text = "4";
                        BiologyIndiTotalGrade.Text = "A";
                    }

                    if (st.BiologySubTotal / 2 >= 80 && st.BiologySubTotal / 2 <= 100)
                    {
                        BiologyIndiTotalPoint.Text = "5";
                        BiologyIndiTotalGrade.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs can't exceed 200 marks in total for Biology !", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                //MessageBox.Show("Unexpected error occured.You can't leave any fields empty or illegal characters entered !", "Stop_Biology", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            try
            {
                
                gis.ChemistryIndividual = float.Parse(ChemistryIndiTotal.Text);
                SubjectTotal st = new SubjectTotal();
                st.ChemistrySubTotal = gis.ChemistryIndividual;
                if (st.ChemistrySubTotal < 201)
                {
                    if (st.ChemistrySubTotal / 2 <= 32)
                    {
                        ChemistryIndiTotalPoint.Text = "0";
                        ChemistryIndiTotalGrade.Text = "F";
                    }

                    if (st.ChemistrySubTotal / 2 >= 33 && st.ChemistrySubTotal / 2 <= 39)
                    {
                        ChemistryIndiTotalPoint.Text = "1";
                        ChemistryIndiTotalGrade.Text = "D";
                    }

                    if (st.ChemistrySubTotal / 2 >= 40 && st.ChemistrySubTotal / 2 <= 49)
                    {
                        ChemistryIndiTotalPoint.Text = "2";
                        ChemistryIndiTotalGrade.Text = "C";
                    }

                    if (st.ChemistrySubTotal / 2 >= 50 && st.ChemistrySubTotal / 2 <= 59)
                    {
                        ChemistryIndiTotalPoint.Text = "3";
                        ChemistryIndiTotalGrade.Text = "B";
                    }

                    if (st.ChemistrySubTotal / 2 >= 60 && st.ChemistrySubTotal / 2 <= 69)
                    {
                        ChemistryIndiTotalPoint.Text = "3.5";
                        ChemistryIndiTotalGrade.Text = "A-";
                    }

                    if (st.ChemistrySubTotal / 2 >= 70 && st.ChemistrySubTotal / 2 <= 79)
                    {
                        ChemistryIndiTotalPoint.Text = "4";
                        ChemistryIndiTotalGrade.Text = "A";
                    }

                    if (st.ChemistrySubTotal / 2 >= 80 && st.ChemistrySubTotal / 2 <= 100)
                    {
                        ChemistryIndiTotalPoint.Text = "5";
                        ChemistryIndiTotalGrade.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs can't exceed 200 marks in total for Chemistry !", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                //MessageBox.Show("Unexpected error occured.You can't leave any fields empty or illegal characters entered !", "Stop_Chemistry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            try
            {
                
                gis.EnglishIndividual = float.Parse(EnglishIndiTotal.Text);
                SubjectTotal st = new SubjectTotal();
                st.EnglishSubTotal = gis.EnglishIndividual;
                if (st.EnglishSubTotal < 201)
                {
                    if (st.EnglishSubTotal / 2 <= 32)
                    {
                        EnglishIndiTotalPoint.Text = "0";
                        EnglishIndiTotalGrade.Text = "F";
                    }

                    if (st.EnglishSubTotal / 2 >= 33 && st.EnglishSubTotal / 2 <= 39)
                    {
                        EnglishIndiTotalPoint.Text = "1";
                        EnglishIndiTotalGrade.Text = "D";
                    }

                    if (st.EnglishSubTotal / 2 >= 40 && st.EnglishSubTotal / 2 <= 49)
                    {
                        EnglishIndiTotalPoint.Text = "2";
                        EnglishIndiTotalGrade.Text = "C";
                    }

                    if (st.EnglishSubTotal / 2 >= 50 && st.EnglishSubTotal / 2 <= 59)
                    {
                        EnglishIndiTotalPoint.Text = "3";
                        EnglishIndiTotalGrade.Text = "B";
                    }

                    if (st.EnglishSubTotal / 2 >= 60 && st.EnglishSubTotal / 2 <= 69)
                    {
                        EnglishIndiTotalPoint.Text = "3.5";
                        EnglishIndiTotalGrade.Text = "A-";
                    }

                    if (st.EnglishSubTotal / 2 >= 70 && st.EnglishSubTotal / 2 <= 79)
                    {
                        EnglishIndiTotalPoint.Text = "4";
                        EnglishIndiTotalGrade.Text = "A";
                    }

                    if (st.EnglishSubTotal / 2 >= 80 && st.EnglishSubTotal / 2 <= 100)
                    {
                        EnglishIndiTotalPoint.Text = "5";
                        EnglishIndiTotalGrade.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs can't exceed 200 marks in total for English !", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                //MessageBox.Show("Unexpected error occured.You can't leave any fields empty or illegal characters entered !", "Stop_English", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            try
            {
               
                gis.HigherMathIndividual = float.Parse(HMIndiTotal.Text);
                SubjectTotal st = new SubjectTotal();
                st.HigherMathSubTotal = gis.HigherMathIndividual;
                if (st.HigherMathSubTotal < 201)
                {
                    if (st.HigherMathSubTotal / 2 <= 32)
                    {
                        HMIndiTotalPoint.Text = "0";
                        HMIndiTotalGrade.Text = "F";
                    }

                    if (st.HigherMathSubTotal / 2 >= 33 && st.HigherMathSubTotal / 2 <= 39)
                    {
                        HMIndiTotalPoint.Text = "1";
                        HMIndiTotalGrade.Text = "D";
                    }

                    if (st.HigherMathSubTotal / 2 >= 40 && st.HigherMathSubTotal / 2 <= 49)
                    {
                        HMIndiTotalPoint.Text = "2";
                        HMIndiTotalGrade.Text = "C";
                    }

                    if (st.HigherMathSubTotal / 2 >= 50 && st.HigherMathSubTotal / 2 <= 59)
                    {
                        HMIndiTotalPoint.Text = "3";
                        HMIndiTotalGrade.Text = "B";
                    }

                    if (st.HigherMathSubTotal / 2 >= 60 && st.HigherMathSubTotal / 2 <= 69)
                    {
                        HMIndiTotalPoint.Text = "3.5";
                        HMIndiTotalGrade.Text = "A-";
                    }

                    if (st.HigherMathSubTotal / 2 >= 70 && st.HigherMathSubTotal / 2 <= 79)
                    {
                        HMIndiTotalPoint.Text = "4";
                        HMIndiTotalGrade.Text = "A";
                    }

                    if (st.HigherMathSubTotal / 2 >= 80 && st.HigherMathSubTotal / 2 <= 100)
                    {
                        HMIndiTotalPoint.Text = "5";
                        HMIndiTotalGrade.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs can't exceed 200 marks in total for Higher Mathematics !", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                //MessageBox.Show("Unexpected error occured.You can't leave any fields empty or illegal characters entered !", "Stop_Higher Mathematics", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            try
            {
                
                gis.ICTSubIndividual = float.Parse(ICTIndiTotal.Text);
                SubjectTotal st = new SubjectTotal();
                st.ICTSubTotal = gis.ICTSubIndividual;
                if (st.ICTSubTotal < 201)
                {
                    if (st.ICTSubTotal <= 32)
                    {
                        ICTIndiTotalPoint.Text = "0";
                        ICTIndiTotalGrade.Text = "F";
                    }

                    if (st.ICTSubTotal >= 33 && st.ICTSubTotal <= 39)
                    {
                        ICTIndiTotalPoint.Text = "1";
                        ICTIndiTotalGrade.Text = "D";
                    }

                    if (st.ICTSubTotal >= 40 && st.ICTSubTotal <= 49)
                    {
                        ICTIndiTotalPoint.Text = "2";
                        ICTIndiTotalGrade.Text = "C";
                    }

                    if (st.ICTSubTotal >= 50 && st.ICTSubTotal <= 59)
                    {
                        ICTIndiTotalPoint.Text = "3";
                        ICTIndiTotalGrade.Text = "B";
                    }

                    if (st.ICTSubTotal >= 60 && st.ICTSubTotal <= 69)
                    {
                        ICTIndiTotalPoint.Text = "3.5";
                        ICTIndiTotalGrade.Text = "A-";
                    }

                    if (st.ICTSubTotal >= 70 && st.ICTSubTotal <= 79)
                    {
                        ICTIndiTotalPoint.Text = "4";
                        ICTIndiTotalGrade.Text = "A";
                    }

                    if (st.ICTSubTotal >= 80 && st.ICTSubTotal <= 100)
                    {
                        ICTIndiTotalPoint.Text = "5";
                        ICTIndiTotalGrade.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs can't exceed 200 marks in total for ICT !", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                //MessageBox.Show("Unexpected error occured.You can't leave any fields empty or illegal characters entered !", "Stop_ICT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


            try
            {
                
                gis.PhysicsIndividual = float.Parse(PhysicsIndiTotal.Text);
                SubjectTotal st = new SubjectTotal();
                st.PhysicsSubTotal = gis.PhysicsIndividual;
                if (st.PhysicsSubTotal < 201)
                {
                    if (st.PhysicsSubTotal / 2 <= 32)
                    {
                        PhysicsIndiTotalPoint.Text = "0";
                        PhysicsIndiTotalGrade.Text = "F";
                    }

                    if (st.PhysicsSubTotal / 2 >= 33 && st.PhysicsSubTotal / 2 <= 39)
                    {
                        PhysicsIndiTotalPoint.Text = "1";
                        PhysicsIndiTotalGrade.Text = "D";
                    }

                    if (st.PhysicsSubTotal / 2 >= 40 && st.PhysicsSubTotal / 2 <= 49)
                    {
                        PhysicsIndiTotalPoint.Text = "2";
                        PhysicsIndiTotalGrade.Text = "C";
                    }

                    if (st.PhysicsSubTotal / 2 >= 50 && st.PhysicsSubTotal / 2 <= 59)
                    {
                        PhysicsIndiTotalPoint.Text = "3";
                        PhysicsIndiTotalGrade.Text = "B";
                    }

                    if (st.PhysicsSubTotal / 2 >= 60 && st.PhysicsSubTotal / 2 <= 69)
                    {
                        PhysicsIndiTotalPoint.Text = "3.5";
                        PhysicsIndiTotalGrade.Text = "A-";
                    }

                    if (st.PhysicsSubTotal / 2 >= 70 && st.PhysicsSubTotal / 2 <= 79)
                    {
                        PhysicsIndiTotalPoint.Text = "4";
                        PhysicsIndiTotalGrade.Text = "A";
                    }

                    if (st.PhysicsSubTotal / 2 >= 80 && st.PhysicsSubTotal / 2 <= 100)
                    {
                        PhysicsIndiTotalPoint.Text = "5";
                        PhysicsIndiTotalGrade.Text = "A+";
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Inputs can't exceed 200 marks in total for Physics !", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                //MessageBox.Show("Unexpected error occured.You can't leave any fields empty or illegal characters entered !", "Stop_Physics", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            try
            {
                float IndiSubTotal = float.Parse(BanglaIndiTotalPoint.Text) + float.Parse(BiologyIndiTotalPoint.Text) + float.Parse(ChemistryIndiTotalPoint.Text) + float.Parse(EnglishIndiTotalPoint.Text) + float.Parse(HMIndiTotalPoint.Text) + float.Parse(ICTIndiTotalPoint.Text) + float.Parse(PhysicsIndiTotalPoint.Text);
                float avg = (IndiSubTotal - 2) / 6;
                IndividualResultBox.Text = avg.ToString();
            }
            catch
            {
                MessageBox.Show("Unexpected error occured.You can't leave any fields empty or illegal characters entered !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            

            

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(groupBox1.Width == 267)
            {
                groupBox1.Width = 170;
            }
            else
            {
                groupBox1.Width = 267 ;
            }
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BanglaIndiTotal.Text = ""; BanglaIndiTotalGrade.Text = ""; BanglaIndiTotalPoint.Text = "";
            BiologyIndiTotal.Text = "";BiologyIndiTotalGrade.Text = ""; BiologyIndiTotalPoint.Text = "";
            EnglishIndiTotal.Text = "";EnglishIndiTotalGrade.Text = ""; EnglishIndiTotalPoint.Text = "";
            ChemistryIndiTotal.Text = "";ChemistryIndiTotalGrade.Text = ""; ChemistryIndiTotalPoint.Text = "";
            PhysicsIndiTotal.Text = ""; PhysicsIndiTotalGrade.Text = ""; PhysicsIndiTotalPoint.Text = "";
            HMIndiTotal.Text = ""; HMIndiTotalGrade.Text = ""; HMIndiTotalPoint.Text = "";
            ICTIndiTotal.Text = "";ICTIndiTotalGrade.Text = ""; ICTIndiTotalPoint.Text = ""; IndividualResultBox.Text = "";
        }

        private void Button3_MouseHover(object sender, EventArgs e)
        {
          panelINS.Visible = true;
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
          panelINS.Visible = false;
        }

        
    }
}
