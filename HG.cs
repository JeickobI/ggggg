using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowsgh
{
    public partial class HG : Form
    {
        public HG()
        {
            InitializeComponent(); int x = 10;
            int y = 50;
            for (int i = 0; i < Form1.liked_monsters.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Load("../../mutter/" + Form1.liked_monsters[i].name + ".jpg");
                pb.Location = new Point(x, y);
                pb.Tag = Form1.liked_monsters[i].name;
                pb.Size = new Size(170, 170);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Click += new EventHandler(Form1.pictureBox1_Click);
                Controls.Add(pb);
                x += 180;
                if (x + 170 > Width)
                {
                    x = 10;
                    y += 180;
                }
            }
        }
    }
}
