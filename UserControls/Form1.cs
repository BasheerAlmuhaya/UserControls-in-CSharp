using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace UserControls
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;
        public static int x = 1;

        public Form1()
        {
            InitializeComponent();
            sp = new SoundPlayer();
            sp.SoundLocation = Application.StartupPath + "\\2.wav";
            sp.Load();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
            pnlClick.Visible = true;
            Button btn = (Button)sender;
            pnlClick.Top = btn.Top;
            pnlClick.Height = btn.Height;

            if (x == 1)
            sp.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            pnlClick.Visible = true;
            Button btn = (Button)sender;
            pnlClick.Top = btn.Top;
            pnlClick.Height = btn.Height;

            if (x == 1)
            sp.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl31.BringToFront();
            pnlClick.Visible = true;
            Button btn = (Button)sender;
            pnlClick.Top = btn.Top;
            pnlClick.Height = btn.Height;
            
            if(x==1)
            sp.Play();
        }

        private void myPictureBox1_Click(object sender, EventArgs e)
        {
            Home.BringToFront();
        }

        private void myPictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.myPictureBox1,"Home");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlClick.Visible = false;
            //this.WindowState = FormWindowState.Maximized;

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

       

        
    }
}
