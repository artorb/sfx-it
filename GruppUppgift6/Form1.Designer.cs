using System.Drawing;
using System.Windows.Forms;

namespace GruppUppgift6
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxHair = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lsbxCrimes = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lsbxSearchRes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(121, 38);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxSex
            // 
            this.tbxSex.Location = new System.Drawing.Point(121, 64);
            this.tbxSex.Name = "tbxSex";
            this.tbxSex.Size = new System.Drawing.Size(100, 20);
            this.tbxSex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kön";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(121, 90);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 20);
            this.tbxAge.TabIndex = 5;
            this.tbxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ålder";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(121, 116);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(100, 20);
            this.tbxHeight.TabIndex = 7;
            this.tbxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Längd";
            // 
            // tbxHair
            // 
            this.tbxHair.Location = new System.Drawing.Point(121, 142);
            this.tbxHair.Name = "tbxHair";
            this.tbxHair.Size = new System.Drawing.Size(100, 20);
            this.tbxHair.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hårfärg";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gämingsman";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.lsbxCrimes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxSex);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxHair);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxAge);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 176);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ANMÄLAN";
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReg.Location = new System.Drawing.Point(227, 139);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(100, 23);
            this.btnReg.TabIndex = 14;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(227, 114);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 23);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Ändra markerad";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lsbxCrimes
            // 
            this.lsbxCrimes.FormattingEnabled = true;
            this.lsbxCrimes.Location = new System.Drawing.Point(227, 38);
            this.lsbxCrimes.Name = "lsbxCrimes";
            this.lsbxCrimes.Size = new System.Drawing.Size(100, 69);
            this.lsbxCrimes.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(227, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Brottmistanke";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(384, 50);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(100, 23);
            this.btnFetch.TabIndex = 15;
            this.btnFetch.Text = "<- Hämta vald";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(536, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Rensa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lsbxSearchRes
            // 
            this.lsbxSearchRes.FormattingEnabled = true;
            this.lsbxSearchRes.Location = new System.Drawing.Point(384, 83);
            this.lsbxSearchRes.Name = "lsbxSearchRes";
            this.lsbxSearchRes.Size = new System.Drawing.Size(252, 160);
            this.lsbxSearchRes.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(384, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 25);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(79, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "SÖKRESULTAT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbxSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 56);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SÖK";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(227, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sökord";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(67, 13);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(154, 20);
            this.tbxSearch.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 263);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lsbxSearchRes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxSearch;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.ListBox lsbxSearchRes;

        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Button btnFetch;


        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReg;

        private System.Windows.Forms.ListBox lsbxCrimes;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxHair;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxHeight;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSex;

        private System.Windows.Forms.TextBox tbxName;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}