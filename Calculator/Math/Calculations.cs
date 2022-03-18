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
                default:
                return Convert.ToString(currNumber);
            }
        }


    }
}