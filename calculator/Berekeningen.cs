using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Berekeningen
    {
        private List<string> getallenString = new List<string>();
        private List<double> intString = new List<double>();
        private List<OperatorClass> operators = new List<OperatorClass>();
        private string toevoegen = "";

        public void Cijfers(string inputCijfer)
        {
            toevoegen += inputCijfer;
        }
        public void Operator(string inputOperator)
        {
            if (getallenString.Count == 0 && toevoegen == "")
            {
                getallenString.Add("0");
            }
            if (inputOperator == "+")
            {
                operators.Add(new Optellen());
            }
            else if (inputOperator == "-")
            {
                operators.Add(new Aftrekken());
            }
            else if (inputOperator == "/")
            {
                operators.Add(new Delen());
            }
            else if (inputOperator == "*")
            {
                operators.Add(new Vermenigvuldigen());
            }
            if (toevoegen != "")
            {
                getallenString.Add(toevoegen);
            }
            toevoegen = "";
        }

        public string Berekenen()
        {
            getallenString.Add(toevoegen);
            toevoegen = "";
            double returnText = 0;
            for (int i = 0; i < getallenString.Count; i++)
            {
                //intString.Add(Convert.ToInt32(getallenString[i]));
                double.TryParse(getallenString[i], out double number);
                intString.Add(number);
            }
            for (int i = 0; i < operators.Count; i++)
            {
                intString[i+1] = operators[i].Berekenen(intString[i], intString[i+1]);
                returnText = intString[i + 1];
            }
            getallenString.Clear();
            intString.Clear();
            operators.Clear();
            toevoegen = returnText.ToString();
            return returnText.ToString();
        }

        public string ClearEverything()
        {
            getallenString.Clear();
            intString.Clear();
            operators.Clear();
            toevoegen = "";
            return toevoegen;
        }

        public string Backspace(string inputText)
        {
            string nieuweText = "";
            if (inputText.Length > 0)
            {
                nieuweText = inputText.Remove(inputText.Length - 1);
            }
            if (toevoegen.Length > 0)
            {
                toevoegen = toevoegen.Remove(toevoegen.Length - 1);
            }
            return nieuweText;
        }
    }
}
