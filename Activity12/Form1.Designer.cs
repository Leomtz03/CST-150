
namespace Activity12
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.displayLbl = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // displayLbl
            // 
            this.displayLbl.BackColor = System.Drawing.Color.White;
            this.displayLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLbl.Location = new System.Drawing.Point(46, 84);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(327, 23);
            this.displayLbl.TabIndex = 0;
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Location = new System.Drawing.Point(46, 36);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 1;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(46, 154);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // countLbl
            // 
            this.countLbl.BackColor = System.Drawing.Color.White;
            this.countLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countLbl.Location = new System.Drawing.Point(303, 154);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(70, 23);
            this.countLbl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of words that end with the letters \"t\" or \"e\":";
            // 
            // Form1
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.displayLbl);
            this.Name = "Form1";
            this.Text = "Activity 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label displayLbl;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label label1;
    }
}

