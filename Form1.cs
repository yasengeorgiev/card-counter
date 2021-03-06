﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //8 decks
            //all cards: 416 (4*13*8)

        }

        string initialCount = "32";
        string initialCountForTens = "128";

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_2.Text = (Convert.ToInt32(lbl_2.Text) - 1).ToString();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_3.Text = (Convert.ToInt32(lbl_3.Text) - 1).ToString();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_4.Text = (Convert.ToInt32(lbl_4.Text) - 1).ToString();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_5.Text = (Convert.ToInt32(lbl_5.Text) - 1).ToString();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_6.Text = (Convert.ToInt32(lbl_6.Text) - 1).ToString();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_7.Text = (Convert.ToInt32(lbl_7.Text) - 1).ToString();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_8.Text = (Convert.ToInt32(lbl_8.Text) - 1).ToString();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_9.Text = (Convert.ToInt32(lbl_9.Text) - 1).ToString();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            lbl_10.Text = (Convert.ToInt32(lbl_10.Text) - 1).ToString();
        }

        private void btn_ace_Click(object sender, EventArgs e)
        {
            lbl_ace.Text = (Convert.ToInt32(lbl_ace.Text) - 1).ToString();
        }

        //method for resetting the label values
        private void resetLabels(Label lbl)
        {
            //setting the count of cards to 128 (all 10s, jacks, queens, kings)
            if (lbl.Name == "lbl_10")
            {
                lbl.Text = initialCountForTens;
            }
            //setting the count of cards to 32
            else
            {
                lbl.Text = initialCount;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control lbl in this.Controls)
            {
                if (lbl is Label)
                {
                    resetLabels((Label)lbl);
                }
            }

        }
    }
}
