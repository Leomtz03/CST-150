using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare lbs and kg variables.
                double lbs;
                double kg;
                double massValue;

                // Assign weightTextBox to lbs.
                // Assign a mass value to divide by.
                lbs = double.Parse(weightTextBox.Text);
                massValue = 2.2;

                // Convert the weight in lbs to kg.
                kg = lbs / massValue;

                // Display the convertion from lbs to kg.
                displayWeightTextBox.Text = kg.ToString("n3");
            }
            catch (Exception ex)
            {
                // Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
