﻿namespace WindowsFormsApp1
{
    partial class ModifCoef
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.coefNum1 = new System.Windows.Forms.NumericUpDown();
            this.labelText1 = new System.Windows.Forms.Label();
            this.validateBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefNum1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(22, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.coefNum1);
            this.panel1.Controls.Add(this.labelText1);
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 168);
            this.panel1.TabIndex = 0;
            // 
            // coefNum1
            // 
            this.coefNum1.Location = new System.Drawing.Point(560, 5);
            this.coefNum1.Name = "coefNum1";
            this.coefNum1.Size = new System.Drawing.Size(120, 20);
            this.coefNum1.TabIndex = 1;
            this.coefNum1.ValueChanged += new System.EventHandler(this.coefNum1_ValueChanged);
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Location = new System.Drawing.Point(9, 7);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(35, 13);
            this.labelText1.TabIndex = 0;
            this.labelText1.Text = "label1";
            // 
            // validateBut
            // 
            this.validateBut.Location = new System.Drawing.Point(697, 266);
            this.validateBut.Name = "validateBut";
            this.validateBut.Size = new System.Drawing.Size(75, 23);
            this.validateBut.TabIndex = 1;
            this.validateBut.Text = "Valider";
            this.validateBut.UseVisualStyleBackColor = true;
            this.validateBut.Click += new System.EventHandler(this.validateBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(22, 266);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(75, 23);
            this.cancelBut.TabIndex = 2;
            this.cancelBut.Text = "Annuler";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Coefficient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enoncé";
            // 
            // ModifCoef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 301);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.validateBut);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifCoef";
            this.Text = "ModifNotation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifCoef_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefNum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button validateBut;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.NumericUpDown coefNum1;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}