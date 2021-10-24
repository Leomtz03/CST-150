
namespace Activity9
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
            this.executeBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.num1Lbl = new System.Windows.Forms.Label();
            this.num2Lbl = new System.Windows.Forms.Label();
            this.num3Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(245, 141);
            this.executeBtn.Margin = new System.Windows.Forms.Padding(7);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(175, 51);
            this.executeBtn.TabIndex = 0;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLbl.Location = new System.Drawing.Point(294, 489);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(607, 254);
            this.resultLbl.TabIndex = 3;
            // 
            // num1Lbl
            // 
            this.num1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num1Lbl.Location = new System.Drawing.Point(260, 220);
            this.num1Lbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.num1Lbl.Name = "num1Lbl";
            this.num1Lbl.Size = new System.Drawing.Size(145, 61);
            this.num1Lbl.TabIndex = 4;
            // 
            // num2Lbl
            // 
            this.num2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num2Lbl.Location = new System.Drawing.Point(260, 307);
            this.num2Lbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.num2Lbl.Name = "num2Lbl";
            this.num2Lbl.Size = new System.Drawing.Size(145, 61);
            this.num2Lbl.TabIndex = 5;
            // 
            // num3Lbl
            // 
            this.num3Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num3Lbl.Location = new System.Drawing.Point(260, 389);
            this.num3Lbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.num3Lbl.Name = "num3Lbl";
            this.num3Lbl.Size = new System.Drawing.Size(145, 61);
            this.num3Lbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.executeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 775);
            this.Controls.Add(this.num3Lbl);
            this.Controls.Add(this.num2Lbl);
            this.Controls.Add(this.num1Lbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.executeBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label num1Lbl;
        private System.Windows.Forms.Label num2Lbl;
        private System.Windows.Forms.Label num3Lbl;
    }
}

