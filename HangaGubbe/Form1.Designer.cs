using System.Windows.Forms;

namespace HangaGubbeUppg
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
            this.tbxSvar = new System.Windows.Forms.TextBox();
            this.tbxVisa = new System.Windows.Forms.TextBox();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxGubbe = new System.Windows.Forms.PictureBox();
            this.pbxMark = new System.Windows.Forms.PictureBox();
            this.tbnBörjaOm = new System.Windows.Forms.Button();
            this.checkHardM = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbxGubbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbxMark)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSvar
            // 
            this.tbxSvar.Location = new System.Drawing.Point(149, 15);
            this.tbxSvar.MaxLength = 6;
            this.tbxSvar.Name = "tbxSvar";
            this.tbxSvar.Size = new System.Drawing.Size(93, 20);
            this.tbxSvar.TabIndex = 0;
            this.tbxSvar.TextChanged += new System.EventHandler(this.tbxSvar_TextChanged);
            this.tbxSvar.KeyPress += new KeyPressEventHandler(this.ValidateLowerCase);
            // 
            // tbxVisa
            // 
            this.tbxVisa.Enabled = false;
            this.tbxVisa.Location = new System.Drawing.Point(92, 299);
            this.tbxVisa.Name = "tbxVisa";
            this.tbxVisa.ReadOnly = true;
            this.tbxVisa.Size = new System.Drawing.Size(213, 20);
            this.tbxVisa.TabIndex = 1;
            // 
            // tbxGissa
            // 
            this.tbxGissa.Enabled = false;
            this.tbxGissa.Location = new System.Drawing.Point(149, 325);
            this.tbxGissa.MaxLength = 1;
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(93, 20);
            this.tbxGissa.TabIndex = 2;
            this.tbxGissa.TextChanged += new System.EventHandler(this.tbxGissa_TextChanged);
            this.tbxGissa.KeyPress += new KeyPressEventHandler(this.ValidateLowerCase);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pbxGubbe);
            this.panel1.Controls.Add(this.pbxMark);
            this.panel1.Location = new System.Drawing.Point(92, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 241);
            this.panel1.TabIndex = 3;
            // 
            // pbxGubbe
            // 
            this.pbxGubbe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pbxGubbe.Image = ((System.Drawing.Image) (resources.GetObject("pbxGubbe.Image")));
            this.pbxGubbe.Location = new System.Drawing.Point(75, 41);
            this.pbxGubbe.Name = "pbxGubbe";
            this.pbxGubbe.Size = new System.Drawing.Size(64, 64);
            this.pbxGubbe.TabIndex = 1;
            this.pbxGubbe.TabStop = false;
            // 
            // pbxMark
            // 
            this.pbxMark.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbxMark.Location = new System.Drawing.Point(0, 205);
            this.pbxMark.Name = "pbxMark";
            this.pbxMark.Size = new System.Drawing.Size(213, 36);
            this.pbxMark.TabIndex = 0;
            this.pbxMark.TabStop = false;
            // 
            // tbnBörjaOm
            // 
            this.tbnBörjaOm.Location = new System.Drawing.Point(314, 42);
            this.tbnBörjaOm.Name = "tbnBörjaOm";
            this.tbnBörjaOm.Size = new System.Drawing.Size(75, 23);
            this.tbnBörjaOm.TabIndex = 5;
            this.tbnBörjaOm.Text = "Börja om";
            this.tbnBörjaOm.UseVisualStyleBackColor = true;
            this.tbnBörjaOm.Click += new System.EventHandler(this.tbnBörjaOm_Click);
            // 
            // checkHardM
            // 
            this.checkHardM.Location = new System.Drawing.Point(311, 82);
            this.checkHardM.Name = "checkHardM";
            this.checkHardM.Size = new System.Drawing.Size(104, 24);
            this.checkHardM.TabIndex = 6;
            this.checkHardM.Text = "Svårt läge";
            this.checkHardM.UseVisualStyleBackColor = true;
            this.checkHardM.CheckedChanged += new System.EventHandler(this.checkHardM_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 356);
            this.Controls.Add(this.checkHardM);
            this.Controls.Add(this.tbnBörjaOm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxGissa);
            this.Controls.Add(this.tbxVisa);
            this.Controls.Add(this.tbxSvar);
            this.Name = "Form1";
            this.Text = "Hänga Gubbe";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pbxGubbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbxMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox checkHardM;

        private System.Windows.Forms.Button tbnBörjaOm;

        private System.Windows.Forms.PictureBox pbxGubbe;

        private System.Windows.Forms.PictureBox pbxMark;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox tbxVisa;
        private System.Windows.Forms.TextBox tbxGissa;

        private System.Windows.Forms.TextBox tbxSvar;

        #endregion
    }
}