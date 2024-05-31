using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Cast_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int wholeNumber;
            double realNumber = 8.9;
            wholeNumber = (int)realNumber;
            outputWholeNumberLabel.Text = wholeNumber.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputWholeNumberLabel.Text = "";
            realNumberTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
