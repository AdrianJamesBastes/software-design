using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Recursive Power Function
        public double RecursivePower(double x, int n)
        {
            if (n == 0) return 1;
            if (n < 0) return 1 / RecursivePower(x, -n);
            return x * RecursivePower(x, n - 1);
        }

        private void btnCalculatePower_Click_1(object sender, EventArgs e)
        {
            double baseNumber;
            int exponent;

            if (double.TryParse(txtBase.Text, out baseNumber) && int.TryParse(txtExponent.Text, out exponent))
            {
                double result = RecursivePower(baseNumber, exponent);
                lblPowerResult.Text = $"{baseNumber}^{exponent} = {result}";
            }
            else
            {
                lblPowerResult.Text = "Invalid input! Enter a valid base and integer exponent.";
            }
        }
    }
}
