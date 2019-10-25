using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    abstract class OperatorClass
    {
        public abstract double Berekenen(double number1, double number2);
    }

    class Optellen : OperatorClass
    {
        public override double Berekenen(double number1, double number2)
        {
            double resultaat = number1 + number2;
            return resultaat;
        }
    }

    class Aftrekken : OperatorClass
    {
        public override double Berekenen(double number1, double number2)
        {
            double resultaat = number1 - number2;
            return resultaat;
        }
    }

    class Vermenigvuldigen : OperatorClass
    {
        public override double Berekenen(double number1, double number2)
        {
            double resultaat = number1 * number2;
            return resultaat;
        }
    }

    class Delen : OperatorClass
    {
        public override double Berekenen(double number1, double number2)
        {
            double resultaat = number1 / number2;
            return resultaat;
        }
    }
}
