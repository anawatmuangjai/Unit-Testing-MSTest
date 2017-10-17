using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public class Calculator
    {
        public static int PlusTwoNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        public static int MinusTwoNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }

        public static int MultiplyTwoNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        public static int DevideTwoNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            return result;
        }
    }
}
