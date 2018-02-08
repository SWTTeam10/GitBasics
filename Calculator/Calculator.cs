using System;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }
    
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Der kan ikke divideres med 0"); 
            }
            else
            {
                return a / b;
            }
        }
    }
}
