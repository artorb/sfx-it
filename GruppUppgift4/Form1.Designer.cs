using System.Windows.Forms;

namespace GruppUppgift4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInitExercise = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.tbxRep = new System.Windows.Forms.TextBox();
            this.tbxSet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchWeight = new System.Windows.Forms.Button();
            this.tbxSearchWeight = new System.Windows.Forms.TextBox();
            this.tbxSearchExercise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxInitExercise);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxWeight);
            this.groupBox1.Controls.Add(this.tbxRep);
            this.groupBox1.Controls.Add(this.tbxSet);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg in övning";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(144, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vikt";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(77, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rep";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set";
            // 
            // tbxInitExercise
            // 
            this.tbxInitExercise.Location = new System.Drawing.Point(6, 36);
            this.tbxInitExercise.Name = "tbxInitExercise";
            this.tbxInitExercise.Size = new System.Drawing.Size(203, 20);
            this.tbxInitExercise.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Övning";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Location = new System.Drawing.Point(144, 62);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(65, 20);
            this.tbxWeight.TabIndex = 3;
            this.tbxWeight.KeyPress += new KeyPressEventHandler(this.ValidateNumeric);
            // 
            // tbxRep
            // 
            this.tbxRep.Location = new System.Drawing.Point(77, 62);
            this.tbxRep.Name = "tbxRep";
            this.tbxRep.Size = new System.Drawing.Size(61, 20);
            this.tbxRep.TabIndex = 2;
            this.tbxRep.KeyPress += new KeyPressEventHandler(this.ValidateNumeric);
            // 
            // tbxSet
            // 
            this.tbxSet.Location = new System.Drawing.Point(6, 62);
            this.tbxSet.Name = "tbxSet";
            this.tbxSet.Size = new System.Drawing.Size(61, 20);
            this.tbxSet.TabIndex = 1;
            this.tbxSet.KeyPress += new KeyPressEventHandler(this.ValidateNumeric);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchWeight);
            this.groupBox2.Controls.Add(this.tbxSearchWeight);
            this.groupBox2.Controls.Add(this.tbxSearchExercise);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(233, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sök på övning";
            // 
            // btnSearchWeight
            // 
            this.btnSearchWeight.Location = new System.Drawing.Point(6, 62);
            this.btnSearchWeight.Name = "btnSearchWeight";
            this.btnSearchWeight.Size = new System.Drawing.Size(141, 23);
            this.btnSearchWeight.TabIndex = 10;
            this.btnSearchWeight.Text = "Total vikt ->";
            this.btnSearchWeight.UseVisualStyleBackColor = true;
            this.btnSearchWeight.Click += new System.EventHandler(this.btnSearchWeight_Click);
            // 
            // tbxSearchWeight
            // 
            this.tbxSearchWeight.Location = new System.Drawing.Point(153, 62);
            this.tbxSearchWeight.Name = "tbxSearchWeight";
            this.tbxSearchWeight.ReadOnly = true;
            this.tbxSearchWeight.Size = new System.Drawing.Size(110, 20);
            this.tbxSearchWeight.TabIndex = 10;
            // 
            // tbxSearchExercise
            // 
            this.tbxSearchExercise.Location = new System.Drawing.Point(6, 36);
            this.tbxSearchExercise.Name = "tbxSearchExercise";
            this.tbxSearchExercise.Size = new System.Drawing.Size(257, 20);
            this.tbxSearchExercise.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Övning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 177);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Styrketräning";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnSearchWeight;
        private System.Windows.Forms.TextBox tbxSearchWeight;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSearchExercise;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox tbxInitExercise;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox tbxSet;
        private System.Windows.Forms.TextBox tbxRep;
        private System.Windows.Forms.TextBox tbxWeight;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}