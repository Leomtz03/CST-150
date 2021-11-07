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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Declare initialized variables.
            int x = 0;
            int y = 0;

            // Create Graphics instance in panel1 object.
            Graphics g = panel1.CreateGraphics();
            // Create initialized Pen instance.
            Pen p = new Pen(Color.Black);

            // Create initialized SolidBrush instance.
            // Used DrawEllipse function to create circle.
            // Used FillEllipse function to add fill color to circle.
            SolidBrush sb = new SolidBrush(Color.Yellow);
            g.DrawEllipse(p, x - 0, y - 0, 100, 100);
            g.FillEllipse(sb, x - 0, y - 0, 100, 100);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Assigned SetValueForText from Form1 to numDisplayLbl.
            numDisplayLbl.Text = Form1.SetValueForText.ToString();
        }
    }
}
