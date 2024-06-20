using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UserControl3 : UserControl
    {
        
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.x == 1)
            {
                button4.Text = "تشغيل الصوت";
                Form1.x = 0;
            }

            else
            {
                button4.Text = "إيقاف الصوت";
                Form1.x = 1;
            }
        }
    }
}
