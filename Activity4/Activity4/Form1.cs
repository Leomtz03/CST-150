using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int secondsInput;
            int seconds;
            int minutes;
            int hours;
            int days;
            int remainder;

            if (int.TryParse(inputTextBox.Text, out secondsInput))
            {
                if (secondsInput >= 60 && secondsInput < 3600)
                {
                    minutes = secondsInput / 60;
                    seconds = secondsInput % 60;
                    MessageBox.Show(minutes + " minutes" + " " + seconds + " seconds");
                }
                else if (secondsInput >= 3600 && secondsInput < 86400)
                {
                    hours = secondsInput / 3600;
                    remainder = secondsInput % 3600;
                    minutes = remainder / 60;
                    seconds = remainder % 60;
                    MessageBox.Show(hours + " hours" + " " + minutes + " minutes" + " " + seconds + " seconds");
                }
                else if (secondsInput >= 86400)
                {
                    days = secondsInput / 86400;
                    remainder = secondsInput % 86400;
                    hours = remainder / 3600;
                    remainder = remainder % 3600;
                    minutes = remainder / 60;
                    seconds = remainder % 60;
                    MessageBox.Show(days + " days" + " " + hours + " hours" + " " + minutes +  " minutes" + " " + seconds + " seconds");
                }
                else
                {
                    MessageBox.Show("Enter an integer higher than 60 seconds.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
        }
    }
}
