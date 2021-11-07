
namespace Activity15
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diplayLbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numDisplayLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diplayLbl1
            // 
            this.diplayLbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.diplayLbl1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diplayLbl1.ForeColor = System.Drawing.Color.Lime;
            this.diplayLbl1.Location = new System.Drawing.Point(112, 58);
            this.diplayLbl1.Name = "diplayLbl1";
            this.diplayLbl1.Size = new System.Drawing.Size(183, 34);
            this.diplayLbl1.TabIndex = 0;
            this.diplayLbl1.Text = "Your lucky";
            this.diplayLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(112, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "number is";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.numDisplayLbl);
            this.panel1.Location = new System.Drawing.Point(140, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 121);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numDisplayLbl
            // 
            this.numDisplayLbl.BackColor = System.Drawing.Color.Yellow;
            this.numDisplayLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDisplayLbl.Location = new System.Drawing.Point(25, 28);
            this.numDisplayLbl.Name = "numDisplayLbl";
            this.numDisplayLbl.Size = new System.Drawing.Size(52, 45);
            this.numDisplayLbl.TabIndex = 3;
            this.numDisplayLbl.Text = "17";
            this.numDisplayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(413, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diplayLbl1);
            this.Name = "Form2";
            this.Text = "Your Results!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label diplayLbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label numDisplayLbl;
    }
}