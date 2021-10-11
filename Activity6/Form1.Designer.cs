
namespace Activity6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.convertButton = new System.Windows.Forms.Button();
            this.displayWeightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.yourWeightLabel = new System.Windows.Forms.Label();
            this.weightLbsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.Pink;
            this.convertButton.Location = new System.Drawing.Point(188, 122);
            this.convertButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(72, 23);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // displayWeightTextBox
            // 
            this.displayWeightTextBox.Location = new System.Drawing.Point(177, 81);
            this.displayWeightTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.displayWeightTextBox.Name = "displayWeightTextBox";
            this.displayWeightTextBox.Size = new System.Drawing.Size(58, 20);
            this.displayWeightTextBox.TabIndex = 8;
            // 
            // weightTextBox
            // 
            this.weightTextBox.BackColor = System.Drawing.Color.White;
            this.weightTextBox.Location = new System.Drawing.Point(177, 54);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(58, 20);
            this.weightTextBox.TabIndex = 7;
            // 
            // yourWeightLabel
            // 
            this.yourWeightLabel.AutoSize = true;
            this.yourWeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.yourWeightLabel.Location = new System.Drawing.Point(38, 82);
            this.yourWeightLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.yourWeightLabel.Name = "yourWeightLabel";
            this.yourWeightLabel.Size = new System.Drawing.Size(92, 13);
            this.yourWeightLabel.TabIndex = 6;
            this.yourWeightLabel.Text = "Your weight in kg:";
            // 
            // weightLbsLabel
            // 
            this.weightLbsLabel.AutoSize = true;
            this.weightLbsLabel.BackColor = System.Drawing.Color.Transparent;
            this.weightLbsLabel.Location = new System.Drawing.Point(38, 57);
            this.weightLbsLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.weightLbsLabel.Name = "weightLbsLabel";
            this.weightLbsLabel.Size = new System.Drawing.Size(119, 13);
            this.weightLbsLabel.TabIndex = 5;
            this.weightLbsLabel.Text = "Enter your weight in lbs:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.weightLbsLabel);
            this.groupBox1.Controls.Add(this.displayWeightTextBox);
            this.groupBox1.Controls.Add(this.convertButton);
            this.groupBox1.Controls.Add(this.weightTextBox);
            this.groupBox1.Controls.Add(this.yourWeightLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weight Converter";
            // 
            // Form1
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(353, 227);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Activity 6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox displayWeightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label yourWeightLabel;
        private System.Windows.Forms.Label weightLbsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

