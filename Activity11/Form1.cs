using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            // Created an instance of Dice class
            Dice dice = new Dice();

            // Used a try catch for the input
            try
            {
                // Verified conversion of input to int.
                if (int.TryParse(inputBtn.Text, out int input))
                {
                    // Verified input was between 4 and 20.
                    if (input >= 4 && input <= 20)
                    {
                        // Declared how many sides each dice had.
                        dice.SetSides();
                        //dice1Lbl.Text = dice.SetSides().ToString();

                        // Created two dice withn an array.
                        int[] myDice = new int[2];

                        //Created list if displaying in label control.
                        //List<string> rollList = new List<string>();

                        // Declared variable which will keep count of rolls.
                        int count = 0;

                        // Used do while loop for continuous roll until snake eyes.
                        do
                        {
                            // Used for loop to roll a random number for each die.
                            for (int i = 0; i < myDice.Length; i++)
                            {
                                myDice[i] = dice.RollDie();
                            }

                            //dice1Lbl.Text = myDice[0].ToString();
                            //dice2Lbl.Text = myDice[1].ToString();

                            // Variable holds label and value for each roll.
                            string eachRoll = "Dice 1 is " + "'" + myDice[0].ToString() + "'" +
                                " and " + "Dice 2 is " + "'"+ myDice[1].ToString() + "'" + ".";

                            // Adding one to count.
                            count++;

                            // Adding each roll to list box.
                            listBox.Items.Add(eachRoll);

                            // Code to display in label control.
                            //rollList.Add(eachRoll);
                            //displayLbl.Text = string.Join("\n", rollList);

                            // Displays
                            countLbl.Text = count.ToString();

                        // Statements will execute unless you roll snake eyes.    
                        } while (!(dice.SnakeEyes(myDice[0], myDice[1])));
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add focus on inputTextbox on load.
            inputBtn.Focus();
        }
    }
}
