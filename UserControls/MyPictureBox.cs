﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace UserControls
{
    class MyPictureBox : PictureBox
    {
        public MyPictureBox()
        { 
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(gp);

            base.OnPaint(pe);
            pe.Graphics.DrawEllipse(new Pen(Color.Teal, 5), 0, 0, ClientSize.Width,ClientSize.Height);
        }
    }

}
