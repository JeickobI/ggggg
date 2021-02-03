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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
