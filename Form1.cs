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

        }

        string initialCount = "32";

        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_2.Text = (Convert.ToInt32(lbl_2.Text) - 1).ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lbl_2.Text = initialCount;
        }
    }
}
