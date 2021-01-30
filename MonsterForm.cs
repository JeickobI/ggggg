﻿using System;
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
            label1.Text = name;
            if (name == "Грут")
            {
                label2.Text = "Не мусори в парке, иначе он придёт к тебе";
            }
            if (name == "Сопля")
            {
                label2.Text = "...";
            }
            if (name == "Чёрт")
            {             
                label2.Text = ",,,";
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
    }
}
