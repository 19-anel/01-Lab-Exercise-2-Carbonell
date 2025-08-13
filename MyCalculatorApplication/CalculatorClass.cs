using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorApplication
{
    public delegate T Formula<T>(T num1, T num2);
    internal class CalculatorClass
    {
        public Formula<double> formula;

        private Formula<double> _calculateEvent;
        public event Formula<double> CalculateEvent
        {
            add
            {
                _calculateEvent += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                _calculateEvent -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double GetSum(double a, double b)
        {
            return a + b;
        }

        public double GetDifference(double a, double b)
        {
            return a - b;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public double GetQuotient(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
