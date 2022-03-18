using System;
using System.Collections.Generic;

namespace Calculator.Math {
    public class Calculations{
        public double currNumber = 0;
        public double newNumber = 0;
        public bool calculatedNumber = false;
        public string requestedCalc;

        public double PerformCalculation()
        {
            if(requestedCalc == "addition")
            {
                Addition();
                return currNumber;
            }else
            {
                return -6.9;
            }
        }

        public void Addition(){
            currNumber += newNumber;
            calculatedNumber = true;
            }
    }
}