using System;
using System.Collections.Generic;

namespace Calculator.Math {
    public class Calculations{
        public double currNumber = 0;
        public double newNumber = 0;
        public bool calculatedNumber = false;
        public string requestedCalc;

        public string checkSymbol() {
            if (requestedCalc == "addition"){
                return "+";
            }
            else {
                return "";
            }
        }
        public string PerformCalculation(){
            if(requestedCalc == "addition"){
                Addition();
                return Convert.ToString(currNumber);
            }else{
                return Convert.ToString(currNumber);
            }
        }

        public void Addition(){
            currNumber += newNumber;
            calculatedNumber = true;
            }
    }
}