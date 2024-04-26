using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            Function.NumberClick("0");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            Function.NumberClick("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Function.NumberClick("2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            Function.NumberClick("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            Function.NumberClick("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Function.NumberClick("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            Function.NumberClick("6");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            Function.NumberClick("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            Function.NumberClick("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            Function.NumberClick("9");
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textResult.Text += ".";

            textOperation.Text += ".";
        }

        private void buttonAdiction_Click(object sender, EventArgs e)
        {
            Function.Operation("+");
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            Function.Operation("-");
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            Function.Operation("x");
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Function.Operation("÷");
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Function.Equals();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textOperation.Text = "";
            textResult.Text = "";
        }
    }
}
