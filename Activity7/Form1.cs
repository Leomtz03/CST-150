using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare variable outside of if statement to use TryParse.
            int terms;

            // Use TryParse to see if input value is convertable to int.
            if (int.TryParse(inputTextBox.Text, out terms))
            {
                //Declare Variables
                // result variable has to be initiated so that
                // result.ToString() has something to convert.
                double result = 0;
                int four = 4;
                double plusOrMinus = 1; // Alternate sign
                
                // For loop will calculate next sequence.
                for (int i = 0; i < terms; i++)
                {
                    result += (plusOrMinus * four / (i * 2 + 1));
                    plusOrMinus *= -1;
                }
                
                // Display result.
                displayLabel.Text = ("Approximate value of pi after " + terms + " terms" +
                    "\n= " + result.ToString());
            }
            else
            {
                MessageBox.Show("Invalid entry.");
            }
        }
    }
}
