using System;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }
    
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            
            Accumulator= a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator =  a * b;
            return Accumulator;
        }

        public double Power(double a, double b)
        {
            Accumulator= Math.Pow(a, b);
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Der kan ikke divideres med 0"); 
            }
            else
            {
                Accumulator= a / b;
                return Accumulator;
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
