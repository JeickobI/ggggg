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
        public static List<Monster> monsters = new List<Monster>();
        public Form1()
        {
            InitializeComponent();

            monsters.Add(new Monster { name = "Рогатый блёбик", power = 3, characteristics = "Спит" });
            monsters.Add(new Monster { name = "Зубастик", power = 4, characteristics = "Кусается" });
            monsters.Add(new Monster { name = "Грут", power = 6, characteristics = "Может отравить" });
            monsters.Add(new Monster { name = "Глыбень", power = 9, characteristics = "Кидается камнями" });
            monsters.Add(new Monster { name = "Гнилой", power = 1, characteristics = "Кусается" });

            int x = 10;
            int y = 50;
            for (int i = 0; i < 5; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Load("../../mutter/" + monsters[i].name + ".jpg");
                pb.Location = new Point(x, y);
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            MonsterForm m1 = new MonsterForm(pb.Tag.ToString());
            m1.Show();
        }
    }
}
