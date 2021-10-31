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

namespace Activity14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox.Items.Add("Landscape");
            listBox.Items.Add("MonaLisa");
            listBox.Items.Add("Museum");
            listBox.Items.Add("Beach");
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;

            DateTime currentDateTime = DateTime.Now;
            
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an image type.");
            }
            else
            {
                pictureBox.Image = myImageList.Images[index];

                if (radioButton1.Checked)
                {
                    this.BackColor = Color.LightSlateGray;
                }

                if (radioButton2.Checked)
                {
                    this.BackColor = Color.LightSkyBlue;
                }
                if (nameCheckBox.Checked)
                {
                    nameLbl.Text = listBox.SelectedItem.ToString();
                }

                if (dateCheckBox.Checked)
                {
                    dateLbl.Text = currentDateTime.ToString("d");
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            nameCheckBox.Checked = false;
            dateCheckBox.Checked = false;
            nameLbl.Text = "";
            dateLbl.Text = "";
        }
    }
}
