using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace HSC_GPA
{
    public partial class Home : Form 
    {
        
        public Home()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr intPtr, int u, int p, int w);

        private void ovres(object ObjPanel)
        {
            if (this.panelDock.Controls.Count > 0)
            {
                this.panelDock.Controls.RemoveAt(0);
            }
                Form fm = ObjPanel as Form;
                fm.TopLevel = false;
                fm.Dock = DockStyle.Fill;
                this.panelDock.Controls.Add(fm);
                this.panelDock.Tag = fm;
                fm.Show();
        }

        private void SubjectToatal(object PanelDock)
        {
            if(this.panelDock.Controls.Count > 0)
            {
                this.panelDock.Controls.RemoveAt(0);
            }
            Form pd = PanelDock as Form;
            pd.TopLevel = false;
            pd.Dock = DockStyle.Fill;
            this.panelDock.Controls.Add(pd);
            this.panelDock.Tag = pd ;
            pd.Show();

        }

        private void ParticularSubject(object ps)
        {
            if(this.panelDock.Controls.Count > 0)
            {
                this.panelDock.Controls.RemoveAt(0);
            }
            Form psw = ps as Form ;
            psw.TopLevel = false;
            psw.Dock = DockStyle.Fill;
            this.panelDock.Controls.Add(psw);
            this.panelDock.Tag = psw;
            psw.Show();
        }
        private void insub(object InSub)
        {
            if(this.panelDock.Controls.Count > 0)
            {
                this.panelDock.Controls.RemoveAt(0);
            }
            Form insb = InSub as Form;
            insb.TopLevel = false;
            insb.Dock = DockStyle.Fill;
            this.panelDock.Controls.Add(insb);
            this.panelDock.Tag = insb;
            insb.Show();
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
            //this.Hide();
            //Form1 fm = new Form1();
            //fm.Show();
            ovres(new Form1());

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Individual_Result ir = new Individual_Result();
            //ir.Show();
            SubjectToatal(new Individual_Result());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //SubBothPapers sbp = new SubBothPapers();
            //sbp.Show();
            insub(new SubBothPapers());
            
        }
        private void menucollapsemain()
        {
            if (panel2.Width == 176)
            {
                panel2.Width = 40;
            }
            else
            {
                panel2.Width = 176;
            }
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            menucollapsemain();
        }
       
       
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            ParticularSubject(new AnySubRes());
        }

        private void Contact(object contact)
        {
            if(this.panelDock.Controls.Count > 0)
            {
                this.panelDock.Controls.RemoveAt(0);
            }
            Form cntct = contact as Form;
            cntct.TopLevel = false;
            cntct.Dock = DockStyle.Fill;
            this.panelDock.Controls.Add(cntct);
            this.panelDock.Tag = cntct;
            cntct.Show();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Contact(new Contact());
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void PictureBox5_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
            
        //    //pictureBox5.Visible = true ;
        //    //pictureBox6.Visible = false;
        //}

        //private void PictureBox6_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    //pictureBox6.Visible = true;
        //    //pictureBox5.Visible = false;
        //}

        private void PictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightSteelBlue;
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        //private void PictureBox5_MouseHover(object sender, EventArgs e)
        //{
        //    pictureBox5.BackColor = Color.LightSteelBlue;
        //}

        //private void PictureBox5_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBox5.BackColor = Color.Transparent;
        //}

        //private void PictureBox6_MouseHover(object sender, EventArgs e)
        //{
        //    pictureBox6.BackColor = Color.LightSteelBlue;
        //}

        //private void PictureBox6_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBox6.BackColor = Color.Transparent;
        //}

        private void PictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.LightSteelBlue;
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightSteelBlue;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void InsHome(object insHome)
        {
            if(this.panelDock.Controls.Count > 0)
            {
                this.panelDock.Controls.RemoveAt(0);
            }
            Form inshome = insHome as Form;
            inshome.TopLevel = false;
            inshome.Dock = DockStyle.Fill;
            this.panelDock.Controls.Add(inshome);
            this.panelDock.Tag = inshome;
            inshome.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            InsHome(new Instructions_Home());
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Contact(new Contact());
        }

        private void About(object about)
        {
            if (this.panelDock.Controls.Count > 0)
            {
                this.panelDock.Controls.RemoveAt(0);
            }
            Form abt = about as Form;
            abt.TopLevel = false;
            abt.Dock = DockStyle.Fill;
            this.panelDock.Controls.Add(abt);
            this.panelDock.Tag = abt;
            abt.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            About(new About());
        }
    }
}
