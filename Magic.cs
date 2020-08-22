using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectGame
{
    class Magic
    {
        public string Direction;
        public int Speed = 20;
        PictureBox MagicPow = new PictureBox();
        Timer time = new Timer();
        public int MagicLeft;
        public int MagicTop;

        public void MagicHit(Form form)
        {
            MagicPow.BackColor = System.Drawing.Color.Yellow;
            MagicPow.Size = new System.Drawing.Size(6, 6);
            MagicPow.Tag = "magic";
            MagicPow.Left = MagicLeft;
            MagicPow.Top = MagicTop;
            MagicPow.BringToFront();
            form.Controls.Add(MagicPow);
            time.Interval = Speed;
            time.Tick += new EventHandler(TimeTick);
            time.Start();
        }

        public void TimeTick(object sender, EventArgs e)
        {
            if (Direction == "right")
                MagicPow.Left += Speed;
            if (Direction == "left")
                MagicPow.Left -= Speed;
            if (Direction == "down")
                MagicPow.Top += Speed;
            if (Direction == "up")
                MagicPow.Top -= Speed;
            if (MagicPow.Left < 10 
                || MagicPow.Left > Form1.width 
                || MagicPow.Top < 5
                || MagicPow.Top > Form1.height)
            {
                time.Stop();
                time.Dispose();
                MagicPow.Dispose();
                time = null;
                MagicPow = null;
            }
        }
    }
}
