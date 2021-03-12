using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowsgh
{
    public struct Monster
    {
        public string name;
        public int power;
        public string characteristics;

        public PictureBox picture;
    }
    public partial class Form1 : Form
    {
        public Monster[] monsters = new Monster[9];
        public Form1()
        {
            InitializeComponent();

            monsters[0] = new Monster { name = "Рогатый блёбик", power = 3, characteristics = "Спит" };
            monsters[1] = new Monster { name = "Зубастик", power = 4, characteristics = "Кусается" };
            monsters[2] = new Monster { name = "Грут", power = 6, characteristics = "Может отравить" };
            monsters[3] = new Monster { name = "Глыбень", power = 9, characteristics = "Кидается камнями" };
            monsters[4] = new Monster { name = "Гнилой", power = 1, characteristics = "Кусается" };

            int x = 10;
            int y = 50;
            for (int i = 0; i < 4; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Load("../../mutter/" + monsters[i].name + ".jpg");
                pb.Location = new Point(x, 68);
                pb.Tag = monsters[i].name;
                pb.Size = new Size(170, 170);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Click += new System.EventHandler(pictureBox1_Click);
                Controls.Add(pb);
                x += 180;
                if (x + 170 > Width)
                {
                    x = 10;
                    y += 180;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            MonsterForm m1 = new MonsterForm(pb.Tag.ToString());
            m1.Show();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MonsterForm m1 = new MonsterForm("Грут");
            m1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MonsterForm m1 = new MonsterForm("Чёрт");
            m1.Show();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MonsterForm m1 = new MonsterForm("Глыбень");
            m1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MonsterForm m1 = new MonsterForm("Мумия");
            m1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MonsterForm m1 = new MonsterForm("Мошко-гусень");
            m1.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MonsterForm m1 = new MonsterForm("Гнилой");
            m1.Show();
        }
    }
}
