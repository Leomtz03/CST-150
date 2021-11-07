
namespace Activity15
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
            this.yearLbl = new System.Windows.Forms.Label();
            this.monthLbl = new System.Windows.Forms.Label();
            this.dayLbl = new System.Windows.Forms.Label();
            this.colorLbl = new System.Windows.Forms.Label();
            this.getBtn = new System.Windows.Forms.Button();
            this.yearCBO = new System.Windows.Forms.ComboBox();
            this.monthCBO = new System.Windows.Forms.ComboBox();
            this.dayCBO = new System.Windows.Forms.ComboBox();
            this.colorCBO = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // yearLbl
            // 
            this.yearLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(106, 68);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(107, 13);
            this.yearLbl.TabIndex = 0;
            this.yearLbl.Text = "Enter your birth year: ";
            // 
            // monthLbl
            // 
            this.monthLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthLbl.AutoSize = true;
            this.monthLbl.Location = new System.Drawing.Point(106, 98);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(116, 13);
            this.monthLbl.TabIndex = 1;
            this.monthLbl.Text = "Enter your birth month: ";
            // 
            // dayLbl
            // 
            this.dayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayLbl.AutoSize = true;
            this.dayLbl.Location = new System.Drawing.Point(106, 128);
            this.dayLbl.Name = "dayLbl";
            this.dayLbl.Size = new System.Drawing.Size(104, 13);
            this.dayLbl.TabIndex = 2;
            this.dayLbl.Text = "Enter your birth day: ";
            // 
            // colorLbl
            // 
            this.colorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colorLbl.AutoSize = true;
            this.colorLbl.Location = new System.Drawing.Point(106, 157);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(122, 13);
            this.colorLbl.TabIndex = 3;
            this.colorLbl.Text = "Enter your favorite color:";
            // 
            // getBtn
            // 
            this.getBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.getBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.getBtn.Location = new System.Drawing.Point(109, 207);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(287, 57);
            this.getBtn.TabIndex = 4;
            this.getBtn.Text = "Get Your Lucky Number";
            this.getBtn.UseVisualStyleBackColor = false;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // yearCBO
            // 
            this.yearCBO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCBO.FormattingEnabled = true;
            this.yearCBO.Location = new System.Drawing.Point(275, 65);
            this.yearCBO.Name = "yearCBO";
            this.yearCBO.Size = new System.Drawing.Size(121, 21);
            this.yearCBO.TabIndex = 5;
            this.yearCBO.SelectedIndexChanged += new System.EventHandler(this.yearCBO_SelectedIndexChanged);
            // 
            // monthCBO
            // 
            this.monthCBO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCBO.FormattingEnabled = true;
            this.monthCBO.Location = new System.Drawing.Point(275, 95);
            this.monthCBO.Name = "monthCBO";
            this.monthCBO.Size = new System.Drawing.Size(121, 21);
            this.monthCBO.TabIndex = 8;
            this.monthCBO.SelectedIndexChanged += new System.EventHandler(this.monthCBO_SelectedIndexChanged);
            // 
            // dayCBO
            // 
            this.dayCBO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCBO.FormattingEnabled = true;
            this.dayCBO.Location = new System.Drawing.Point(275, 125);
            this.dayCBO.Name = "dayCBO";
            this.dayCBO.Size = new System.Drawing.Size(121, 21);
            this.dayCBO.TabIndex = 9;
            // 
            // colorCBO
            // 
            this.colorCBO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colorCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorCBO.FormattingEnabled = true;
            this.colorCBO.Location = new System.Drawing.Point(275, 154);
            this.colorCBO.Name = "colorCBO";
            this.colorCBO.Size = new System.Drawing.Size(121, 21);
            this.colorCBO.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.getBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 305);
            this.Controls.Add(this.colorCBO);
            this.Controls.Add(this.dayCBO);
            this.Controls.Add(this.monthCBO);
            this.Controls.Add(this.yearCBO);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.colorLbl);
            this.Controls.Add(this.dayLbl);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.yearLbl);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.Label dayLbl;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.ComboBox yearCBO;
        private System.Windows.Forms.ComboBox monthCBO;
        private System.Windows.Forms.ComboBox dayCBO;
        private System.Windows.Forms.ComboBox colorCBO;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

