using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Function
    {
        public static double calculum;
        public static bool operators = false;
        public static bool results = false;
        public static bool addiction = false;
        public static bool subtraction = false;
        public static bool multiplication = false;
        public static bool division = false;
        public static bool firstClickOp = false;

        public static void NumberClick(string number)
        {
            if (operators == false || results == true)
            {
                Calculator.textResult.Text += number;

                Calculator.textOperation.Text += number;
            }
            else
            {
                Calculator.textResult.Text = "";
                Calculator.textResult.Text += number;

                Calculator.textOperation.Text += number;

                results = true;
            }
        }

        public static void Operation(string operation)
        {
            switch (Calculator.textOperation.Text)
            {
                case "":
                    firstClickOp = true;
                    operators = false;
                    break;
                default:
                    firstClickOp = false;
                    break;
            }

            if (operators == false && firstClickOp == false)
            {
                calculum = double.Parse(Calculator.textOperation.Text);
                Calculator.textResult.Text = "";
                Calculator.textOperation.Text += operation;

                operators = true;
            }
            else if (operators == true)
            {
                Calculator.textOperation.Text = OperationCalculum(operation);
                Calculator.textResult.Text = Calculator.textOperation.Text;
                calculum = double.Parse(Calculator.textOperation.Text);
                Calculator.textOperation.Text += operation;

                results = false;
            }

            OperationCheck(operation);
        }

        private static string OperationCalculum(string operation)
        {
            switch (operation)
            {
                case "+":
                    return Convert.ToString(calculum + double.Parse(Calculator.textResult.Text));
                    break;
                case "-":
                    return Convert.ToString(calculum - double.Parse(Calculator.textResult.Text));
                    break;
                case "x":
                    return Convert.ToString(calculum * double.Parse(Calculator.textResult.Text));
                    break;
                case "÷":
                    return Convert.ToString(calculum / double.Parse(Calculator.textResult.Text));
                    break;
                default:
                    return Calculator.textResult.Text;
                    break;
            }
        }

        public static void OperationCheck(string operation)
        {
            switch (operation)
            {
                case "+":
                    addiction = true;
                    subtraction = false;
                    multiplication = false;
                    division = false;
                    break;
                case "-":
                    addiction = false;
                    subtraction = true;
                    multiplication = false;
                    division = false;
                    break;
                case "x":
                    addiction = false;
                    subtraction = false;
                    multiplication = true;
                    division = false;
                    break;
                case "÷":
                    addiction = false;
                    subtraction = false;
                    multiplication = false;
                    division = true;
                    break;
                default: results = false; break;
            }
        }

        public static void Equals()
        {
            if (addiction == true)
            {
                Calculator.textResult.Text = Convert.ToString(calculum + double.Parse(Calculator.textResult.Text));

                calculum = double.Parse(Calculator.textResult.Text);

                results = false;
                operators = false;
            }
            else if (subtraction == true)
            {
                Calculator.textOperation.Text = Convert.ToString(calculum - double.Parse(Calculator.textResult.Text));
                Calculator.textResult.Text = Calculator.textOperation.Text;
                calculum = double.Parse(Calculator.textOperation.Text);

                results = false;
                operators = false;
            }
            else if (multiplication == true)
            {
                Calculator.textOperation.Text = Convert.ToString(calculum * double.Parse(Calculator.textResult.Text));
                Calculator.textResult.Text = Calculator.textOperation.Text;
                calculum = double.Parse(Calculator.textOperation.Text);

                results = false;
                operators = false;
            }
            else if (division == true)
            {
                Calculator.textOperation.Text = Convert.ToString(calculum / double.Parse(Calculator.textResult.Text));
                Calculator.textResult.Text = Calculator.textOperation.Text;
                calculum = double.Parse(Calculator.textOperation.Text);

                results = false;
                operators = false;
            }
        }
    }
}
