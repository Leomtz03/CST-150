using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // RJ Code Advance
            // Remove the form title.
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        // RJ Code Advance
        // Add drag form method.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Method to calculate calories from fat.
        private int FatCalories(int fatGrams)
        {
            return fatGrams * 9;
        }

        // Method to calculate calories from carbohydrates.
        private int CarbCalories(int carbGrams)
        {
            return carbGrams * 4;
        }

        private void Calculate()
        {
            // Declared variables.
            int fatCalories = 0;
            int carbCalories = 0;

            // Try to convert input to int and assign to fatGrams.
            if (int.TryParse(fatTextBox.Text, out int fatGrams))
            {
                // The fatGrams value is passed when the FatCalories method is called.
                fatCalories = FatCalories(fatGrams);

                // Try to convert input to int and assign to carbGrams.
                if (int.TryParse(carbTextBox.Text, out int carbGrams))
                {
                    // The carbGrams value is passed when the CarbCalories method is called.
                    carbCalories = CarbCalories(carbGrams);
                }
                else
                {
                    // Display error message.
                    MessageBox.Show("Invalid entry. Enter an integer for carbohydrates.");
                }
            }
            else
            {
                // Display error message.
                MessageBox.Show("Invalid entry. Enter an integer for fat.");
            }

            // There was input and everything was calculated, there will be a display result.
            if (fatCalories > 0 && carbCalories > 0)
            {
                displayLabel.Text = "Each gram of fat yields 9 calories. Based on the your daily intake of fat in grams, " + 
                fatCalories + " are calories." + " Each gram of carbohydrates yields 4 calories. " + 
                "Based on your daily intake of carbohydrate in grams, " + carbCalories + " calories";
            }
            else
            {
                // Nothing is displayed.
            }
            
        }

        // Method to clear input boxes.
        private void reset()
        {
            fatTextBox.Text = " ";
            carbTextBox.Text = " ";
            displayLabel.Text = " ";
        }

        // Method Calculate() is called.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        // RJ Code Advance
        // Add the mousedown event
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // RJ Code Advance
        // Add close method.
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // RJ Code Advance
        // Add normal and maximize method.
        private void buttonMax_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // RJ Code Advance
        // Add minimize method.
        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
