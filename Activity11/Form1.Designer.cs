
namespace Activity11
{
    partial class Form1
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
            this.rollBtn = new System.Windows.Forms.Button();
            this.inputBtn = new System.Windows.Forms.TextBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollBtn
            // 
            this.rollBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rollBtn.AutoSize = true;
            this.rollBtn.BackColor = System.Drawing.Color.Yellow;
            this.rollBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBtn.ForeColor = System.Drawing.Color.Red;
            this.rollBtn.Location = new System.Drawing.Point(193, 69);
            this.rollBtn.Margin = new System.Windows.Forms.Padding(1);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(99, 39);
            this.rollBtn.TabIndex = 0;
            this.rollBtn.Text = "Roll";
            this.rollBtn.UseVisualStyleBackColor = false;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // inputBtn
            // 
            this.inputBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputBtn.Location = new System.Drawing.Point(101, 80);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(68, 20);
            this.inputBtn.TabIndex = 3;
            // 
            // countLbl
            // 
            this.countLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.countLbl.BackColor = System.Drawing.Color.White;
            this.countLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countLbl.Location = new System.Drawing.Point(295, 141);
            this.countLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(31, 19);
            this.countLbl.TabIndex = 4;
            this.countLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(34, 163);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(292, 108);
            this.listBox.TabIndex = 5;
            // 
            // instructionLbl
            // 
            this.instructionLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLbl.ForeColor = System.Drawing.Color.Gold;
            this.instructionLbl.Location = new System.Drawing.Point(67, 34);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(235, 19);
            this.instructionLbl.TabIndex = 6;
            this.instructionLbl.Text = "Enter a number between 4 and 20.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of rolls:";
            // 
            // Form1
            // 
            this.AcceptButton = this.rollBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(366, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.rollBtn);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.TextBox inputBtn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.Label label1;
    }
}

