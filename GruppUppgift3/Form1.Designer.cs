using System.Diagnostics.SymbolStore;
using System.Windows.Forms;

namespace GruppUppgift3
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
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHastigheter = new System.Windows.Forms.Button();
            this.btnTider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lsbxResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tid (min)";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(97, 65);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(100, 20);
            this.tbxTime.TabIndex = 1;
            this.tbxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(203, 63);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Registrera";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(97, 39);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(100, 20);
            this.tbxDistance.TabIndex = 4;
            this.tbxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sträcka (km)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHastigheter);
            this.groupBox1.Controls.Add(this.btnTider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxSearch);
            this.groupBox1.Controls.Add(this.lsbxResult);
            this.groupBox1.Location = new System.Drawing.Point(13, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök på sträcka";
            // 
            // btnHastigheter
            // 
            this.btnHastigheter.Location = new System.Drawing.Point(123, 83);
            this.btnHastigheter.Name = "btnHastigheter";
            this.btnHastigheter.Size = new System.Drawing.Size(124, 23);
            this.btnHastigheter.TabIndex = 7;
            this.btnHastigheter.Text = "Visa alla hastigheter";
            this.btnHastigheter.UseVisualStyleBackColor = true;
            this.btnHastigheter.Click += new System.EventHandler(this.btnHastigheter_Click);
            // 
            // btnTider
            // 
            this.btnTider.Location = new System.Drawing.Point(123, 54);
            this.btnTider.Name = "btnTider";
            this.btnTider.Size = new System.Drawing.Size(124, 23);
            this.btnTider.TabIndex = 6;
            this.btnTider.Text = "Visa alla tider";
            this.btnTider.UseVisualStyleBackColor = true;
            this.btnTider.Click += new System.EventHandler(this.btnTider_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sträcka (km)";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(90, 28);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(157, 20);
            this.tbxSearch.TabIndex = 6;
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // lsbxResult
            // 
            this.lsbxResult.FormattingEnabled = true;
            this.lsbxResult.Location = new System.Drawing.Point(6, 125);
            this.lsbxResult.Name = "lsbxResult";
            this.lsbxResult.Size = new System.Drawing.Size(241, 108);
            this.lsbxResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Löplogg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnTider;
        private System.Windows.Forms.Button btnHastigheter;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox tbxSearch;

        private System.Windows.Forms.ListBox lsbxResult;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDistance;

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTime;

        #endregion
    }
}