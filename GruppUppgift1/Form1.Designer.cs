using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp3
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
            this.tbxDays = new System.Windows.Forms.TextBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbxResult = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tbxSearchName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxDays
            // 
            this.tbxDays.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxDays.Location = new System.Drawing.Point(90, 71);
            this.tbxDays.Name = "tbxDays";
            this.tbxDays.Size = new System.Drawing.Size(73, 20);
            this.tbxDays.TabIndex = 2;
            this.tbxDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(169, 71);
            this.bookButton.Name = "bookButton";
            this.bookButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookButton.Size = new System.Drawing.Size(40, 20);
            this.bookButton.TabIndex = 3;
            this.bookButton.Text = "Boka";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kund";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Antal dagar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbxResult);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.tbxSearchName);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(16, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök kund";
            // 
            // lsbxResult
            // 
            this.lsbxResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lsbxResult.FormattingEnabled = true;
            this.lsbxResult.Location = new System.Drawing.Point(6, 47);
            this.lsbxResult.Name = "lsbxResult";
            this.lsbxResult.Size = new System.Drawing.Size(190, 69);
            this.lsbxResult.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(151, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchButton.Size = new System.Drawing.Size(40, 20);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Söka";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tbxSearchName
            // 
            this.tbxSearchName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxSearchName.Location = new System.Drawing.Point(71, 23);
            this.tbxSearchName.Name = "tbxSearchName";
            this.tbxSearchName.Size = new System.Drawing.Size(73, 20);
            this.tbxSearchName.TabIndex = 3;
            this.tbxSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateAlphabetic);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 21);
            this.label.TabIndex = 0;
            this.label.Text = "Namn";
            // 
            // tbxDestination
            // 
            this.tbxDestination.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxDestination.Location = new System.Drawing.Point(90, 47);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(73, 20);
            this.tbxDestination.TabIndex = 10;
            this.tbxDestination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateAlphabetic);
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxCustomerName.Location = new System.Drawing.Point(90, 24);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(73, 20);
            this.tbxCustomerName.TabIndex = 11;
            this.tbxCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateAlphabetic);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(230, 229);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.tbxDestination);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.tbxDays);
            this.Name = "Form1";
            this.Text = "Resebokning";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lsbxResult;

        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.TextBox tbxCustomerName;

        private System.Windows.Forms.Button searchButton;

        private System.Windows.Forms.TextBox tbxSearchName;

        private System.Windows.Forms.Label label;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button bookButton;

        private System.Windows.Forms.TextBox tbxDays;

        #endregion
    }
}