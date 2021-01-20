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
        public MonsterForm(string name)
        {
            InitializeComponent();
            Text = name;
            if (name == "Грут")
            {
                pictureBox1.Load("../../mutter/Грут.bmp");
                label1.Text = "cfgcfg";
            }
            if (name == "Гру2т")
            {
                label1.Text = "cfydfgyfu";
            }
        }

        private void MonsterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
