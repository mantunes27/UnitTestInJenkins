using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            // Bug for demo purposes
            // return a + b;
            return a * b; 
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Divide(int value, int by)
        {
            if (value > 100)
            {
                throw new ArgumentOutOfRangeException("by"); // bug demo
            }

            return value / by;
        }
        static void Main(string[] args)
        {
            
        }
    }

    public class NameJoiner
    {
        public string Join(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }

 

    
}
