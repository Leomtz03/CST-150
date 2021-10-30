using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declared variables. All methods can use variables.
        string zero = 0.ToString();
        string letterX = "X";
        string letterO = "O";

        // Created list for controls.
        // Meant for DisplayPlayerName method.
        List<Control> controls = new List<Control>();

        public void TicTacToe()
        {
            // page 497
            // Created instance of random number.
            Random rand = new Random();

            // Declared constant variables.
            const int ROWS = 3;
            const int COLS = 3;

            // Declared two dimensional array.
            string[,] doubleArray = new string[ROWS, COLS];

            // Added controls to controls list.
            // Meant for DisplayPlayerName method.
            controls.Add(lbl1);
            controls.Add(lbl2);
            controls.Add(lbl3);
            controls.Add(lbl4);
            controls.Add(lbl5);
            controls.Add(lbl6);
            controls.Add(lbl7);
            controls.Add(lbl8);
            controls.Add(lbl9);

            // Used a for loop to iterate through each element.
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    // Assigned a random number to each element.
                    doubleArray[row, col] = rand.Next(2).ToString();

                    // If statement converts a number zero to letterO.
                    if (doubleArray[row, col] == zero)
                    {
                        doubleArray[row, col] = letterO;
                    }
                    // Otherwise, converts to letterX.
                    else
                    {
                        doubleArray[row, col] = letterX;
                    }

                    // Each control label is assigned an element and its value.
                    lbl1.Text = doubleArray[0, 0];
                    lbl2.Text = doubleArray[0, 1];
                    lbl3.Text = doubleArray[0, 2];
                    lbl4.Text = doubleArray[1, 0];
                    lbl5.Text = doubleArray[1, 1];
                    lbl6.Text = doubleArray[1, 2];
                    lbl7.Text = doubleArray[2, 0];
                    lbl8.Text = doubleArray[2, 1];
                    lbl9.Text = doubleArray[2, 2];

                }
            }
        }

        // Method checks for winner.
        // Each if statement checks for every possible way of winning in Tic-Tac-Toe.
        public string CheckForWinner()
        {
            // For example, if statement checks whether the top line has the same symbol.
            if (lbl1.Text == lbl2.Text && lbl2.Text == lbl3.Text)
            {
                if (lbl1.Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
                //winnerLbl.Text = "Player " + lbl1.Text.ToString() + " is winner!";
            }
            else if (lbl4.Text == lbl5.Text && lbl5.Text == lbl6.Text)
            {
                if (lbl4.Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
            }
            else if (lbl7.Text == lbl8.Text && lbl8.Text == lbl9.Text)
            {
                if (lbl7.Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
            }
            else if (lbl1.Text == lbl5.Text && lbl5.Text == lbl9.Text)
            {
                if (lbl1.Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
            }
            else if (lbl3.Text == lbl5.Text && lbl5.Text == lbl7.Text)
            {
                if (lbl3.Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
            }
            else if (lbl1.Text == lbl4.Text && lbl4.Text == lbl7.Text)
            {
                if (lbl1.Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
            }
            else if (lbl2.Text == lbl5.Text && lbl5.Text == lbl8.Text)
            {
                if (lbl2.Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
            }
            else if (lbl3.Text == lbl6.Text && lbl6.Text == lbl9.Text)
            {
                if (lbl3.Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
            }
            else
            {
                winnerLbl.Text = "Game is a Draw!";
            }
            return null;
        }

        // Method is under construction still.
        // Intended to create a method that would convert and display a letterO to "Y".
        // There by replacing the second set of if else statements in CheckForWinner().
        /*public string DisplayPlayerName()
        {
            string temp;
            string a;
            string b;

            /*for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i].Text == letterO)
                {
                    winnerLbl.Text = "Player Y is winner!";
                }
                else
                {
                    winnerLbl.Text = "Player X is winner!";
                }
            }
            return null;
        }*/

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            // On click event, called the methods below.
            TicTacToe();
            CheckForWinner();
        }
    }
}
