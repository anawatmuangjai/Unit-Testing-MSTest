using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Library;

namespace Calculator.Windows
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(TextBoxFirstNumber.Text);
            int secondNumber = Convert.ToInt32(TextBoxSecondNumber.Text);
            var result = Library.Calculator.PlusTwoNumber(firstNumber, secondNumber);
            TextBoxResult.Text = result.ToString();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(TextBoxFirstNumber.Text);
            int secondNumber = Convert.ToInt32(TextBoxSecondNumber.Text);
            var result = Library.Calculator.MinusTwoNumber(firstNumber, secondNumber);
            TextBoxResult.Text = result.ToString();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(TextBoxFirstNumber.Text);
            int secondNumber = Convert.ToInt32(TextBoxSecondNumber.Text);
            var result = Library.Calculator.MultiplyTwoNumber(firstNumber, secondNumber);
            TextBoxResult.Text = result.ToString();
        }

        private void ButtonDevide_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(TextBoxFirstNumber.Text);
            int secondNumber = Convert.ToInt32(TextBoxSecondNumber.Text);
            var result = Library.Calculator.DevideTwoNumber(firstNumber, secondNumber);
            TextBoxResult.Text = result.ToString();
        }
    }
}
