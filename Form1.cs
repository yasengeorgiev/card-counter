using System;
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
            calculateChances();
            //8 decks
            //all cards: 416 (4*13*8)
            //lbl_remaining_cards.Text = "416";
        }

        //public int card2 = 32;

        string initialCount = "32";
        string initialCountForTens = "128";
        double allCards = 416;
        double card_2 = 32;
        double card_3 = 32;
        double card_4 = 32;
        double card_5 = 32;
        double card_6 = 32;
        double card_7 = 32;
        double card_8 = 32;
        double card_9 = 32;
        double card_ace = 32;
        double card_10 = 128;

        //this method calculates the remaining number of cards of specific kind (for example all the aces)
        private double dealingCards(double card)
        {
            card -= 1;
            allCards--;
            lbl_remaining_cards.Text = allCards.ToString();
            return card;
        } 

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_2.Text = dealingCards(card_2).ToString();
            card_2--;
            calculateChances();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_3.Text = dealingCards(card_3).ToString();
            card_3--;
            calculateChances();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_4.Text = dealingCards(card_4).ToString();
            card_4--;
            calculateChances();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_5.Text = dealingCards(card_5).ToString();
            card_5--;
            calculateChances();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_6.Text = dealingCards(card_6).ToString();
            card_6--;
            calculateChances();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_7.Text = dealingCards(card_7).ToString();
            card_7--;
            calculateChances();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_8.Text = dealingCards(card_8).ToString();
            card_8--;
            calculateChances();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_9.Text = dealingCards(card_9).ToString();
            card_9--;
            calculateChances();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            lbl_10.Text = dealingCards(card_10).ToString();
            card_10--;
            calculateChances();
        }

        private void btn_ace_Click(object sender, EventArgs e)
        {
            lbl_ace.Text = dealingCards(card_ace).ToString();
            card_ace--;
            calculateChances();
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

        // this method is going to calculate what are the chances for a certain card to be dealt
        private void calculateChances()
        {
            lbl_chances_2.Text = Math.Round(((card_2 / allCards) * 100), 2).ToString();
            lbl_chances_3.Text = Math.Round(((card_3 / allCards) * 100), 2).ToString();
            lbl_chances_4.Text = Math.Round(((card_4 / allCards) * 100), 2).ToString();
            lbl_chances_5.Text = Math.Round(((card_5 / allCards) * 100), 2).ToString();
            lbl_chances_6.Text = Math.Round(((card_6 / allCards) * 100), 2).ToString();
            lbl_chances_7.Text = Math.Round(((card_7 / allCards) * 100), 2).ToString();
            lbl_chances_8.Text = Math.Round(((card_8 / allCards) * 100), 2).ToString();
            lbl_chances_9.Text = Math.Round(((card_9 / allCards) * 100), 2).ToString();
            lbl_chances_ace.Text = Math.Round(((card_ace / allCards) * 100), 2).ToString();
            lbl_chances_10.Text = Math.Round(((card_10 / allCards) * 100), 2).ToString();
        }
    }
}
