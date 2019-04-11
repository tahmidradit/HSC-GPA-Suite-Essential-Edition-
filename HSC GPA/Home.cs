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
            this.Hide();
            SubBothPapers sbp = new SubBothPapers();
            sbp.Show();
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(panel2.Width == 176 )
            {
                panel2.Width = 40;
            }
            else
            
                panel2.Width = 176;
            
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

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
