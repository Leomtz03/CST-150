
namespace Activity1
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.studentLabel = new System.Windows.Forms.Label();
            this.displayStudentLabel = new System.Windows.Forms.Label();
            this.showNameButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(49, 46);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Enter your first name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(49, 77);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Enter your last name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(177, 39);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(177, 70);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(49, 110);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(122, 13);
            this.courseLabel.TabIndex = 4;
            this.courseLabel.Text = "Enter your course name:";
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(177, 103);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseTextBox.TabIndex = 5;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(49, 164);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(102, 13);
            this.studentLabel.TabIndex = 6;
            this.studentLabel.Text = "Student Information:";
            // 
            // displayStudentLabel
            // 
            this.displayStudentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayStudentLabel.Location = new System.Drawing.Point(174, 157);
            this.displayStudentLabel.Name = "displayStudentLabel";
            this.displayStudentLabel.Size = new System.Drawing.Size(154, 97);
            this.displayStudentLabel.TabIndex = 7;
            // 
            // showNameButton
            // 
            this.showNameButton.Location = new System.Drawing.Point(52, 273);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(75, 23);
            this.showNameButton.TabIndex = 8;
            this.showNameButton.Text = "&Show Name";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(151, 273);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(253, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.showNameButton);
            this.groupBox1.Controls.Add(this.courseLabel);
            this.groupBox1.Controls.Add(this.displayStudentLabel);
            this.groupBox1.Controls.Add(this.courseTextBox);
            this.groupBox1.Controls.Add(this.studentLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 318);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Profile";
            // 
            // Form1
            // 
            this.AcceptButton = this.showNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(415, 340);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Student Profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label displayStudentLabel;
        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

