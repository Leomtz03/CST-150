using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            // Declare a string variable to hold the full name.
            string fullName;
            string courseName;

            // Combine the names, with a space between them. Assign the result to the fullName variable.
            // Assign the courseTextBox result to courseName variable.
            fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
            courseName = courseTextBox.Text;

            // Display the fullName and courseName variable in the displayStudentLabel control.
            displayStudentLabel.Text = fullName + "\n" + courseName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBox controls.
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            courseTextBox.Text = "";
            displayStudentLabel.Text = "";

            // Set the focus to firstNameTextBox.
            firstNameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
