using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity5
{
    public partial class Form1 : Form
    {
        List<String> words = new List<string>();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Declare a StreamWriter variable.
                    StreamReader inputFile;
                    
                    // Open file from Debug folder for now.
                    inputFile = File.OpenText("test.txt");

                    // Read text from file.
                    string text = inputFile.ReadToEnd();

                    // Assign all text to be displayed in richTextBox control.
                    richTextBox.Text = text;
                
                    // Close file.
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    // Display an error message.
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // The operation was canceled.
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Declare a StreamWriter variable.
                    StreamWriter outputFile;

                    // Allow the user to create and name a file and get a StreamWriter object.
                    outputFile = File.CreateText(saveFile.FileName);
                    
                    // Write the text from richTextBox to the file.
                    outputFile.WriteLine(richTextBox.Text);

                    // Close the file.
                    outputFile.Close();
                }
                catch (Exception ex)
                {
                    // Display an error Message.
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // The operation was canceled.
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            // Assign richTextBox text a variable.
            string text = richTextBox.Text;

            // Convert all text to lowercase.
            string lowerText = text.ToLower();

            // Assign lowercase text back to richTextBox.
            richTextBox.Text = lowerText;
            
            // Display statistics in detailedListBox.
            detailedListBox.Items.Add("File text is converted to lowercase: " + lowerText);
            
            // Find the first and last word alphabetically.
            // Use a space delimiter to separate all words and create a words array.
            String[] words = lowerText.Split(' ');
            
            // Convert the word array to a wordList.
            List<String> wordList = words.ToList();

            // Sort the wordList.
            wordList.Sort();

            // Add items to the detailedListBox.
            detailedListBox.Items.Add("If sorted alphabetically, " + "'" + wordList.First() + "'" + " is the first word.");
            detailedListBox.Items.Add("If sorted alphabetically, " + "'" + wordList.Last() + "'" + " is the last word.");

            // Find the longest word.
            // Declare variables.
            string longestWord;
            int currentCount = 0;

            // Use a foreach loop to perform an action for each word in the wordList.
            foreach (string word in wordList)
            {
                // if statement checks if the current word has a higher count than the currentCount. If so,
                // the word count replaces the currentCount. currentCount is then compared with the next
                // word count until the longest word is found.
                if (word.Length > currentCount)
                {
                    longestWord = word;
                    currentCount = word.Length;

                    // Displays the longest word.
                    detailedListBox.Items.Add("The word " + "'" + longestWord + "'" + " is the longest word in this sentence.");
                }
            }

            // Find the word with the most vowels.
            // Declare variables.
            int wordVowelCount = 0;
            int vowelCount = 0;
            string mostVowels;

            // Use a foreach loop to perform an action for each word in the wordList.
            foreach (string word in wordList)
            {
                // Declared variables
                int total = 0;
                // Created a char Hash map for all the vowels and assigned it to a variable.
                var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };


                // Used a for loop to iterate through each character of the word.
                for (int i = 0; i < word.Length; i++)
                {
                    // If letter is a vowel, 1 count is added to the total.
                    if (vowels.Contains(word[i]))
                    {
                        wordVowelCount = total++;

                    }
                    
                }
                if (wordVowelCount > vowelCount)
                {
                    mostVowels = word;
                    vowelCount = wordVowelCount;

                    // Display the word with the most vowels.
                    detailedListBox.Items.Add("'" + mostVowels + "'" + " is the word with the most vowels.");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            richTextBox.Text = " ";
            detailedListBox.Items.Clear();
        }
    }
}
