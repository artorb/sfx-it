using System.Windows.Forms;

namespace SekventielUppgift2
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
            this.btnSeqSök = new System.Windows.Forms.Button();
            this.btnBlanda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSökVal = new System.Windows.Forms.TextBox();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sökt valör:";
            // 
            // btnSeqSök
            // 
            this.btnSeqSök.Location = new System.Drawing.Point(46, 317);
            this.btnSeqSök.Name = "btnSeqSök";
            this.btnSeqSök.Size = new System.Drawing.Size(127, 23);
            this.btnSeqSök.TabIndex = 1;
            this.btnSeqSök.Text = "Sekventiell Sökning";
            this.btnSeqSök.UseVisualStyleBackColor = true;
            this.btnSeqSök.Click += new System.EventHandler(this.btnSeqSök_Click);
            // 
            // btnBlanda
            // 
            this.btnBlanda.Location = new System.Drawing.Point(216, 317);
            this.btnBlanda.Name = "btnBlanda";
            this.btnBlanda.Size = new System.Drawing.Size(75, 23);
            this.btnBlanda.TabIndex = 3;
            this.btnBlanda.Text = "Blanda";
            this.btnBlanda.UseVisualStyleBackColor = true;
            this.btnBlanda.Click += new System.EventHandler(this.btnBlanda_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Index:";
            // 
            // tbxSökVal
            // 
            this.tbxSökVal.Location = new System.Drawing.Point(129, 55);
            this.tbxSökVal.Name = "tbxSökVal";
            this.tbxSökVal.Size = new System.Drawing.Size(100, 20);
            this.tbxSökVal.TabIndex = 4;
            this.tbxSökVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validate);
            // 
            // tbxIndex
            // 
            this.tbxIndex.Location = new System.Drawing.Point(129, 93);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.ReadOnly = true;
            this.tbxIndex.Size = new System.Drawing.Size(100, 20);
            this.tbxIndex.TabIndex = 5;
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx1.Location = new System.Drawing.Point(22, 150);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(75, 102);
            this.pbx1.TabIndex = 6;
            this.pbx1.TabStop = false;
            this.pbx1.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx1_Paint);
            // 
            // pbx2
            // 
            this.pbx2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx2.Location = new System.Drawing.Point(118, 150);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(75, 102);
            this.pbx2.TabIndex = 7;
            this.pbx2.TabStop = false;
            this.pbx2.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx2_Paint);
            // 
            // pbx4
            // 
            this.pbx4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx4.Location = new System.Drawing.Point(313, 150);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(75, 102);
            this.pbx4.TabIndex = 9;
            this.pbx4.TabStop = false;
            this.pbx4.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx4_Paint);
            // 
            // pbx3
            // 
            this.pbx3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx3.Location = new System.Drawing.Point(216, 150);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(75, 102);
            this.pbx3.TabIndex = 8;
            this.pbx3.TabStop = false;
            this.pbx3.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx3_Paint);
            // 
            // pbx8
            // 
            this.pbx8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx8.Location = new System.Drawing.Point(688, 150);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(75, 102);
            this.pbx8.TabIndex = 14;
            this.pbx8.TabStop = false;
            this.pbx8.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx8_Paint);
            // 
            // pbx7
            // 
            this.pbx7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx7.Location = new System.Drawing.Point(593, 150);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(75, 102);
            this.pbx7.TabIndex = 12;
            this.pbx7.TabStop = false;
            this.pbx7.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx7_Paint);
            // 
            // pbx6
            // 
            this.pbx6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx6.Location = new System.Drawing.Point(500, 150);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(75, 102);
            this.pbx6.TabIndex = 11;
            this.pbx6.TabStop = false;
            this.pbx6.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx6_Paint);
            // 
            // pbx5
            // 
            this.pbx5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx5.Location = new System.Drawing.Point(408, 150);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(75, 102);
            this.pbx5.TabIndex = 10;
            this.pbx5.TabStop = false;
            this.pbx5.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx5_Paint);
            // 
            // pbx9
            // 
            this.pbx9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx9.Location = new System.Drawing.Point(788, 150);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(75, 102);
            this.pbx9.TabIndex = 15;
            this.pbx9.TabStop = false;
            this.pbx9.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx9_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 378);
            this.Controls.Add(this.pbx9);
            this.Controls.Add(this.pbx8);
            this.Controls.Add(this.pbx7);
            this.Controls.Add(this.pbx6);
            this.Controls.Add(this.pbx5);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.tbxIndex);
            this.Controls.Add(this.tbxSökVal);
            this.Controls.Add(this.btnBlanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSeqSök);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sekventiell Sökning";
            ((System.ComponentModel.ISupportInitialize) (this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pbx9;

        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx5;

        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx3;

        private System.Windows.Forms.PictureBox pbx1;

        private System.Windows.Forms.TextBox tbxSökVal;
        private System.Windows.Forms.TextBox tbxIndex;

        private System.Windows.Forms.Button btnBlanda;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnSeqSök;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}