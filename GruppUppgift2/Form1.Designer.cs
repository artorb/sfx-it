using System.Diagnostics.SymbolStore;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GruppUppgift2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbxresult = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbxresult);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.tbxSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 238);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sök poäng över";
            // 
            // lsbxresult
            // 
            this.lsbxresult.FormattingEnabled = true;
            this.lsbxresult.Location = new System.Drawing.Point(12, 85);
            this.lsbxresult.Name = "lsbxresult";
            this.lsbxresult.Size = new System.Drawing.Size(217, 147);
            this.lsbxresult.TabIndex = 7;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(154, 59);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Visa urval";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(63, 33);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(166, 20);
            this.tbxSearch.TabIndex = 6;
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Poäng";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(77, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(70, 20);
            this.tbxName.TabIndex = 0;
            this.tbxName.KeyPress += new KeyPressEventHandler(this.ValidateAlphabetic);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Namn";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Poäng";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(168, 51);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbxPoints
            // 
            this.tbxPoints.Location = new System.Drawing.Point(77, 51);
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.Size = new System.Drawing.Size(70, 20);
            this.tbxPoints.TabIndex = 6;
            this.tbxPoints.KeyPress += new KeyPressEventHandler(this.ValidateNumeric);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 339);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxName);
            this.Name = "Form1";
            this.Text = "Skyttetavling";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lsbxresult;

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPoints;

        #endregion
    }
}