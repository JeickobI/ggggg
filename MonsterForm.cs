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
    public partial class MonsterForm : Form
    {
        /// <summary>
        /// Выбранный монстр
        /// </summary>
        Monster currentMonstr;

        public MonsterForm(string name)
        {
            InitializeComponent();
            Text = name;
            label1.Text = name;

            foreach (Monster monstr in Form1.monsters)
            {
                if (monstr.name == name)
                {
                    currentMonstr = monstr;
                    labelChars.Text = "Характеристики:" + Environment.NewLine +
                        monstr.characteristics;

                    label2.Text = monstr.description;

                    string s = "Сила:" + monstr.power.ToString();

                    if (Form1.liked_monsters.Contains(monstr))
                        pictureBox2.Image = Properties.Resources.LikeOn;
                }
            }
            /*
            if (name == "Грут")
            {
                label2.Text = "Может пускать корни, и создавать непреодалимые препятствия из своих корней. Не мусори в парке, иначе он придёт к тебе";
            }
            if (name == "Сопля")
            {
                label2.Text = "Оставляет позади себя след из слизи";
            }
            if (name == "Чёрт")
            {
                label2.Text = "Злой и ненавидит думгая";
            }
            if (name == "Рогатый блёбик")
            {
                label2.Text = "Добрый и миленький блёбик";
            }
            if (name == "Глыбень")
            {
                label2.Text = "Живой камушек";
            }
            if (name == "Зубастик")
            {
                label2.Text = "Не подходи к нему, может покусать";
            }
            if (name == "Мумия")
            {
                label2.Text = "Просто старая мумия, ну а что вы хотели?";
            }
            if (name == "мошко-гусень")
            {
                label2.Text = "Противная летающая тварь";
            }
            if (name == "Гнилой")
            {
                label2.Text = "От этого красавчика воняет помойкой";
            }*/

            pictureBox1.Load("../../mutter/" + name + ".jpg");
        }


        private void MonsterForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Клик на лайк
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Form1.liked_monsters.Contains(currentMonstr))
            {
                pictureBox2.Image = Properties.Resources.LikeOff;
                Form1.liked_monsters.Remove(currentMonstr);
            }
            else
            {
                pictureBox2.Image = Properties.Resources.LikeOn;
                Form1.liked_monsters.Add(currentMonstr);
            }
        }
    }
}
