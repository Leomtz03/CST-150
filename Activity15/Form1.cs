using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15
{
    public partial class Form1 : Form
    {
        // Static method to set CalculateLuckyNumber value.
        public static int SetValueForText = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Displays data on load.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Declare variables.
            int startYear = 2022;
            int minusYear = 1;

            // For loop to create 100 years.
            for (int i = 0; i < 100; i++)
            {
                int year = startYear - minusYear;
                yearCBO.Items.Add(year);
                startYear--;
            }

            // Adding items to the color combo box.
            colorCBO.Items.Add("Yellow");
            colorCBO.Items.Add("Red");
            colorCBO.Items.Add("Blue");
            colorCBO.Items.Add("Orange");
            colorCBO.Items.Add("Brown");
            colorCBO.Items.Add("Black");
            colorCBO.Items.Add("Green");
            colorCBO.Items.Add("Gray");
            colorCBO.Items.Add("Purple");

        }

        public void DisplayMonths()
        {
            // Adding items to month combo box.
            monthCBO.Items.Add("January");
            monthCBO.Items.Add("February");
            monthCBO.Items.Add("March");
            monthCBO.Items.Add("April");
            monthCBO.Items.Add("May");
            monthCBO.Items.Add("June");
            monthCBO.Items.Add("July");
            monthCBO.Items.Add("August");
            monthCBO.Items.Add("September");
            monthCBO.Items.Add("October");
            monthCBO.Items.Add("November");
            monthCBO.Items.Add("December");
        }
        public void DisplayDays()
        {
            // Declare variables and values.
            int year = int.Parse(yearCBO.Text);
            string monthInput = monthCBO.Text;
            var feb = "February";

            // Create HashSet of type string with months that have 31 days.
            var month = new HashSet<string> { "January", "March", "May", "July", "August", "October", "December" };

            // If HashSet contains combo box selection, it displays 31 days.
            if (month.Contains(monthInput))
            {
                // For loop to create 31 days.
                for (int i = 0; i < 31; i++)
                {
                    int day = i + 1;
                    dayCBO.Items.Add(day);
                }
            }
            // If combo box selection matches var feb, it executes statements below.
            else if (String.Equals(monthInput, feb))
            {
                // If selected year is a leap year, it displays 29 days.
                if (DateTime.IsLeapYear(year))
                {
                    // For loop to create 29 days.
                    for (int i = 0; i < 29; i++)
                    {
                        int day = i + 1;
                        dayCBO.Items.Add(day);
                    }
                }
                // If selected year is not a leap year, it displays 28 days.
                else
                {
                    // For loop to create 28 days.
                    for (int i = 0; i < 28; i++)
                    {
                        int day = i + 1;
                        dayCBO.Items.Add(day);
                    }
                }
            }
            // If combo box selection is not in HashSet or matches var feb, it displays 30 days.
            else
            {
                // For loop to create 30 days.
                for (int i = 0; i < 30; i++)
                {
                    int day = i + 1;
                    dayCBO.Items.Add(day);
                }
            }
        }

        public int GetMonthValue()
        {
            // Declare initialized variables.
            var month = monthCBO.Text;
            int monthVal = 0;

            // If and else if statements determine whether month value matches string.
            // If so, returns monthVal respectively.
            if (month.Equals("January"))
            {
                monthVal = 5;
                return monthVal;

            }
            else if (month.Equals("February"))
            {
                monthVal = 6;
                return monthVal;

            }
            else if (month.Equals("March"))
            {
                monthVal = 7;
                return monthVal;

            }
            else if (month.Equals("April"))
            {
                monthVal = 8;
                return monthVal;

            }
            else if (month.Equals("May"))
            {
                monthVal = 9;
                return monthVal;

            }
            else if (month.Equals("June"))
            {
                monthVal = 10;
                return monthVal;

            }
            else if (month.Equals("July"))
            {
                monthVal = 11;
                return monthVal;

            }
            else if (month.Equals("August"))
            {
                monthVal = 12;
                return monthVal;

            }
            else if (month.Equals("September"))
            {
                monthVal = 13;
                return monthVal;

            }
            else if (month.Equals("October"))
            {
                monthVal = 14;
                return monthVal;

            }
            else if (month.Equals("November"))
            {
                monthVal = 15;
                return monthVal;

            }
            else if (month.Equals("December"))
            {
                monthVal = 16;
                return monthVal;

            }
            // Returns monthVal value for method.
            return monthVal;
        }

        public int GetColorValue()
        {
            // Declare initialized variable.
            var colorInput = colorCBO.Text;

            // Created HashSet of type string for colors.
            var colorValue1 = new HashSet<string> { "Yellow", "Blue", "Brown", "Green", "Purple" };
            var colorValue2 = new HashSet<string> { "Red", "Orange", "Black", "Gray" }; // Based on code, this statement is unneccessary.

            // Declared variable.
            int colorVal;

            // If statement determines if HashSet contains selected color.
            // If so, returns set value.
            if (colorValue1.Contains(colorInput))
            {
                colorVal = 1;
            }
            // Else statement returns set value if HashSet does not contain selected color.
            else
            {
                colorVal = 2;
            }
            return colorVal;
        }

        public int CalculateLuckyNumber()
        {
            // Converted year input to int.
            if (int.TryParse(yearCBO.Text, out int yearVal)) { }

            // Converted day input to int.
            if (int.TryParse(dayCBO.Text, out int dayVal)) { }

            // Performed calculation to determine lucky number.
            int result = (((yearVal / GetMonthValue()) / dayVal) * GetColorValue());

            // Returns result value for method.
            return result;
        }

        private void monthCBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On month selection change, it clears the available days from daysCBO and
            // displays new days for the respective month.
            dayCBO.Items.Clear();
            DisplayDays();
        }

        private void yearCBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            // On year selection change, it clears the available months from monthCBO and
            // displays months again.
            monthCBO.Items.Clear();
            DisplayMonths();
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            // Value for CalculateLuckyNumber() is set to SetValueForText.
            // This in turn is used to pass value to another form.
            SetValueForText = CalculateLuckyNumber();

            // Create instance of Form2. Used to show form2 on click.
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
