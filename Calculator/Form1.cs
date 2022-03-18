using System;
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

        //A lot of repeating - Make a method that cleans up code by removing repetition
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
            //Look into string.Split method to implement this
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
            calculations.calculatedNumber = false;
            calculations.requestedCalc = "";
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (lbl_Window.Text.Length != 0)
            {
                lbl_Window.Text = lbl_Window.Text.Remove(lbl_Window.Text.Length - 1);
            }
        }
        private void btn_Neg_Click(object sender, EventArgs e)
        {
            if (calculations.CheckValidNumber(lbl_Window.Text))
            {
                calculations.currNumber = Convert.ToDouble(lbl_Window.Text);
                calculations.calculatedNumber = true;
                calculations.currNumber = -calculations.currNumber;
                lbl_Window.Text = Convert.ToString(calculations.currNumber);
            }
        }
        //Every button that calls a calculation makes the current number typed = the first number while it sets calculatedNumber = true
        //so the software knows the next input is a new number and to start using history.
        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (calculations.CheckValidNumber(lbl_Window.Text))
            {
                calculations.currNumber = Convert.ToDouble(lbl_Window.Text);
                calculations.calculatedNumber = true;
                calculations.requestedCalc = "addition";
                lbl_PreviousCalcWindow.Text = lbl_Window.Text + calculations.checkSymbol();
                lbl_Window.Text = "";
            }
        }
        private void btn_X_Click(object sender, EventArgs e)
        {
            if (calculations.CheckValidNumber(lbl_Window.Text))
            {
                //Add this to the universal method call I will add later before continueing
                if (calculations.calculatedNumber)
                {
                    calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
                    lbl_Window.Text = calculations.PerformCalculation();
                }
                    calculations.currNumber = Convert.ToDouble(lbl_Window.Text);
                    calculations.calculatedNumber = true;
                    calculations.requestedCalc = "multiplication";
                    lbl_PreviousCalcWindow.Text = lbl_Window.Text + calculations.checkSymbol();
                    lbl_Window.Text = "";
            }
        }

        private void btn_PowerTwo_Click(object sender, EventArgs e)
        {
            if (calculations.CheckValidNumber(lbl_Window.Text))
            {
                calculations.currNumber = Convert.ToDouble(lbl_Window.Text);
                calculations.calculatedNumber = true;
                calculations.requestedCalc = "sqr";
                lbl_PreviousCalcWindow.Text = calculations.currNumber + calculations.checkSymbol() + "=";
                lbl_Window.Text = calculations.PerformCalculation();
            }
        }
        private void btn_Minus_Click(object sender, EventArgs e)
        {

            if (calculations.CheckValidNumber(lbl_Window.Text))
            {
                calculations.currNumber = Convert.ToDouble(lbl_Window.Text);
                calculations.calculatedNumber = true;
                calculations.requestedCalc = "subtraction";
                lbl_PreviousCalcWindow.Text = lbl_Window.Text + calculations.checkSymbol();
                lbl_Window.Text = "";
            }
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            if (calculations.CheckValidNumber(lbl_Window.Text))
            {
                calculations.currNumber = Convert.ToDouble(lbl_Window.Text);
                calculations.calculatedNumber = true;
                calculations.requestedCalc = "division";
                lbl_PreviousCalcWindow.Text = lbl_Window.Text + calculations.checkSymbol();
                lbl_Window.Text = "";
            }
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            if (calculations.CheckValidNumber(lbl_Window.Text)){
                calculations.currNumber = Convert.ToDouble(lbl_Window.Text);
                calculations.calculatedNumber = true;
                calculations.requestedCalc = "sqrt";
                lbl_PreviousCalcWindow.Text = calculations.checkSymbol() + calculations.currNumber + "=";
                lbl_Window.Text = calculations.PerformCalculation();
            }
        }
        private void btn_Pct_Click(object sender, EventArgs e)
        {
            //Not sure how to implement this atm with my code
            //if (calculations.calculatedNumber) {
              //  calculations.newNumber = Convert.ToDouble(lbl_Window.Text);
                //calculations.requestedCalc = "pct";
                //lbl_PreviousCalcWindow.Text = lbl_Window.Text + calculations.checkSymbol();
                //lbl_Window.Text = "";
            //}
        }
        private void btn_Equal_Click(object sender, EventArgs e)
        {
            if (calculations.requestedCalc == "sqr")
            {
                lbl_PreviousCalcWindow.Text = calculations.currNumber + calculations.checkSymbol() + "=";
                lbl_Window.Text = calculations.PerformCalculation();
            }
            else if (calculations.requestedCalc == "sqrt")
            {
                lbl_PreviousCalcWindow.Text = calculations.checkSymbol() + calculations.currNumber + "=";
                lbl_Window.Text = calculations.PerformCalculation();
            }
            else if (calculations.calculatedNumber)
            {
                lbl_PreviousCalcWindow.Text = calculations.currNumber + calculations.checkSymbol() + calculations.newNumber + "=";
                lbl_Window.Text = calculations.PerformCalculation();

            }
            else
            {
                lbl_Window.Text = lbl_Window.Text;
            }
        }

        private void lbl_output_Click(object sender, EventArgs e)
        {
            lbl_output.Text = Convert.ToString(calculations.currNumber);
        }
    }
}
