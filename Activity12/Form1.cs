using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Method gets selected file from user.
        public void GetFileName(out string selectedFile)
        {
            // If user selects ok button, filename is assigned to selectedFile.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialog.FileName;
            }
            else
            {
                selectedFile = "";
            }
        }

        // Method passes the filename into streamreader.
        public void GetInputFromFile(string filename)
        {
            try
            {
                // Declared variable.
                string phrase;

                // Used StreamReader to read filename.
                StreamReader inputFile = File.OpenText(filename);

                // While input has not reached the end, it will continue reading file.
                while (!inputFile.EndOfStream)
                {
                    // input is assigned to phrase variable.
                    phrase = inputFile.ReadLine();
                    displayLbl.Text = phrase;
                }
                // input file is closed.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Catch Error
                MessageBox.Show(ex.Message);
            }
        }
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            // Declared variable.
            string filename;

            // Methods are called and passed filename as argument.
            GetFileName(out filename);
            GetInputFromFile(filename);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Instance of Search class is created.
            Search mySearch = new Search();

            // Return is displayed in control label.
            countLbl.Text = mySearch.SearchPhrase(displayLbl.Text);
        }
    }
}
