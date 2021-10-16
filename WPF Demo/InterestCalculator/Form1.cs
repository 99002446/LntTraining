using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(principalTextBox.Text))
            {
               MessageBox.Show( "Principal should not be left blank!");
            }
            if (string.IsNullOrWhiteSpace(ratetextbox.Text))
            {
                MessageBox.Show("Rate should not be left blank!");
            }
            if (string.IsNullOrWhiteSpace(periodtextbox.Text))
            {
                MessageBox.Show("Period should not be left blank!");
            }

            interesttextbox.ReadOnly = true;
            amounttextbox.ReadOnly = true;
            var principal = double.Parse(principalTextBox.Text);
            var rate = double.Parse(ratetextbox.Text);
            var period = double.Parse(periodtextbox.Text);
            var interest = (principal * rate * period) / 1200;
            var amount = principal + interest;
            interesttextbox.Text = interest.ToString();
            amounttextbox.Text = amount.ToString();
        }
    }
}
