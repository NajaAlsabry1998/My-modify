﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftWare_Engineering
{
    public partial class LevelQ2_3 : Form
    {
       
        public LevelQ2_3()
        {
            InitializeComponent();
        }

        private void ANSWER3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BOK_Click(object sender, EventArgs e)
        {
            if (ANSWER1.Checked == true && ANSWER2.Checked == false && ANSWER3.Checked == false)
            {
                Function.counter++;

                COUNTER.Text = Function.counter.ToString();


            }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == true && ANSWER3.Checked == false)
            {
                Function.counter++;

                COUNTER.Text = Function.counter.ToString();
            }
            else if (ANSWER1.Checked == false && ANSWER2.Checked == false && ANSWER3.Checked == true)
            {
                star();
                MessageBox.Show(" The Level Two has been completed ");
                Levels L = new Levels();
                L.Show();
                this.Hide();
                L.level_3.Enabled = true;
            }
        }
        public void star()
        {

            STAR1.ImageIndex = 1;
            STAR2.ImageIndex = 1;
            STAR3.ImageIndex = 1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

            Function.Undo();
            this.Hide();
        }
    }
}
