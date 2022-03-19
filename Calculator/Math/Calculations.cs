using System;
using System.Collections.Generic;

namespace Calculator.Math {
    public class Calculations{
        //Numbers and bools to check if it is already calculating something or if it fresh
        public double currNumber = 0;
        public double newNumber = 0;
        public bool calculatedNumber = false;
        public string requestedCalc;
        //Finds the prober symbol to display
        public bool CheckValidNumber(string input)
        {
            try
            {
                Convert.ToDouble(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        public string checkSymbol(){
            switch (requestedCalc)
            {
                case "addition":
                    return "+";
                case "subtraction":
                    return "-";
                case "multiplication":
                    return "x";
                case "division":
                    return "/";
                case "sqr":
                    return "^2";
                case "sqrt":
                    return "√";
                case "oneDiv":
                    return "1/";
                default:
                    return "";
            }
        }
        //Performs actual calculations
        public void Addition(){
            currNumber += newNumber;
            calculatedNumber = true;
        }
        public void Subtraction()
        {
            currNumber -= newNumber;
            calculatedNumber = true;
        }
        public void Multiplication(){
            currNumber *= newNumber;
            calculatedNumber = true;
        }
        public void Division()
        {
            currNumber /= newNumber;
            calculatedNumber = true;
        }
        public void Sqr()
        {
            currNumber = System.Math.Pow(currNumber, 2.0);
            calculatedNumber = true;
        }
        public void Sqrt()
        {
            currNumber = System.Math.Sqrt(currNumber);
            calculatedNumber = true;
        }
        public void Pct()
        {
            newNumber += newNumber/ 100;
            calculatedNumber = true;
        }
        public void OneDiv()
        {
            currNumber = 1/currNumber;
        }
        //Compares requested calculation with possible methods
        public string PerformCalculation(){
            switch (requestedCalc){
                case "addition":
                    Addition();
               return Convert.ToString(currNumber);
                case "subtraction":
                    Subtraction();
                    return Convert.ToString(currNumber);
                case "multiplication":
                    Multiplication();
                return Convert.ToString(currNumber);
                case "division":
                    Division();
                    return Convert.ToString(currNumber);
                case "sqr":
                    Sqr();
                    return Convert.ToString(currNumber);
                case "sqrt":
                    Sqrt();
                    return Convert.ToString(currNumber);
                case "Pct":
                    Pct();
                    return Convert.ToString(currNumber);
                case "oneDiv":
                    OneDiv();
                    return Convert.ToString(currNumber);
                default:
                    return Convert.ToString(currNumber);
            }
        }


    }
}