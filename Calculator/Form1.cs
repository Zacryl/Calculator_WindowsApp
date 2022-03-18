using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "0";
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "1";
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "2";
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "3";
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "4";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "5";
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "9";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Window_Click(object sender, EventArgs e)
        {

        }
    }
}
