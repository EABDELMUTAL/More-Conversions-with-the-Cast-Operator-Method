using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace More_Conversions_with_the_Cast_Operator_Method
{
    public partial class castOperatorForm : Form
    {
        public castOperatorForm()
        {
            InitializeComponent();
        }

        private void castOperatorForm_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            moneyNumberTextBox.Text = "";
            outputWholeNumberLabel.Text = "";
        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            int wholeNumber;
            decimal moneyNumber = 4500m;
            wholeNumber = (int)moneyNumber;
            outputWholeNumberLabel.Text = wholeNumber.ToString();
        }
    }
}
