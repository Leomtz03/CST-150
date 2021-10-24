using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            Activity9 execute = new Activity9();

            resultLbl.Text = execute.Average(2.3, 2.5, 6.2, 7.6, 8.2).ToString();
        }

        class Activity9
        {
            // 1. Write a method that takes two integers and displays their sum.
            public int Add(int num1, int num2)
            {
                return (num1 + num2);
            }


            // 2. Write a method that takes five doubles and returns their average.
            public double Average(double num1, double num2, double num3, double num4, double num5)
            {
                return ((num1 + num2 + num3 + num4 + num5) / 5);
            }

            // 3. Write a method that returns the sum of two randomly generated integers.
            public int Sum()
            {
                int num1;
                int num2;
                int value;

                Random rand = new Random();
                num1 = rand.Next(0, 10);
                num2 = rand.Next(0, 10);
                value = num1 + num2;

                return value;
            }

            // 4. Write a method that takes three integers and returns true if their sum is
            // divisible by 3, false otherwise.
            public Boolean Divisibleby3(int num1, int num2, int num3)
            {
                if (num1 % 3 == 0)
                {
                    return true;
                }
                if (num2 % 3 == 0)
                {
                    return true;
                }
                if (num3 % 3 == 0)
                {
                    return true;
                }
                return false;
            }

            // 5. Write a method that takes two strings and displays the string that has fewer characters.
            public string compareStrings(string str1, string str2)
            {
                if (str1.Length < str2.Length)
                {
                    return str2;
                }
                else
                {
                    return str1;
                }
            }

            // 6. Write a method that takes an array of doubles and returns the largest value in the array.
            public double largestValue()
            {
                double[] myArray = { 2.0, 4.0, 7.5, 6.5 };

                double maxValue = myArray.Max();

                return maxValue;
            }

            // 7. Write a method that generates and returns an array of fifty integer values.
            public string fiftyIntegers()
            {
                Random rand = new Random();

                int[] myArray = new int[50];

                int num = 0;

                for (int i = 0; i < 50; i++)
                {
                    // Optional method of generating random numbers.
                    //myArray[i] = rand.Next(0, 10);
                    myArray[i] = num + 1;
                    num++;
                }

                return string.Join(", ", myArray);
            }

            // 8. Write a method that takes two bool variables and returns true if they have the same
            // value, false otherwise.
            public Boolean StringBoolean(int num1, int num2)
            {
                if (num1 == num2)
                {
                    return true;
                }
                return false;
            }

            // 9. Write a method that takes an int and a double and returns their product.
            public double Product(int num1, double num2)
            {
                double product = (double)num1 * num2;

                return product;
            }

            // 10. Write a method that takes a two-dimensional array of integers and returns the
            // the average of the entries.
            public decimal TwoDimensionalArray()
            {
                const int ROWS = 3;
                const int COLS = 4;
                int[,] numbers = { { 1, 2, 3, 4},
                                {5, 6, 7, 8},
                                {9, 10 , 11, 12}
                              };

                decimal sum = 0.0m;
                decimal average = 0.0m;

                for (int col = 0; col < COLS; col++)
                {
                    for (int row = 0; row < ROWS; row++)
                    {
                        sum += numbers[row, col];
                        average = sum / numbers.Length;
                    }

                }
                return average;
            }
        }
    }
}
