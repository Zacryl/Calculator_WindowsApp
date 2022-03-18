﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Math;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Math.Calculations calculations = new Math.Calculations();
        public Calculator()
        {
            InitializeComponent();
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "0";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "1";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "2";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "3";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "4";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "5";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "6";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "7";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "8";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += "9";
            if (calculations.calculatedNumber)
            {
                calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
            }
        }
        
        private void btn_Com_Click(object sender, EventArgs e)
        {
            lbl_Window.Text += ".";
        }


        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            lbl_Window.Text = "";
            lbl_PreviousCalcWindow.Text = "";
            calculations.currNumber = 0;
            calculations.newNumber = 0;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            calculations.currNumber +=  Convert.ToDouble(lbl_Window.Text);
            calculations.calculatedNumber = true;
            calculations.requestedCalc = "addition";
            lbl_PreviousCalcWindow.Text = lbl_Window.Text + calculations.checkSymbol();
            lbl_Window.Text = "";
        }
        private void btn_PowerTwo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (lbl_Window.Text.Length != 0) {
                lbl_Window.Text = lbl_Window.Text.Remove(lbl_Window.Text.Length - 1);
            }
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            if (calculations.calculatedNumber){
                lbl_PreviousCalcWindow.Text = calculations.currNumber + calculations.checkSymbol() + calculations.newNumber;
            }else{
            }
                lbl_Window.Text = calculations.PerformCalculation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
