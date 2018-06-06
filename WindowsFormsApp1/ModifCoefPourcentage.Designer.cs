namespace WindowsFormsApp1
{
    partial class ModifCoefPourcentage
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
            this.cancelBut = new System.Windows.Forms.Button();
            this.validateBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coefNum1 = new System.Windows.Forms.NumericUpDown();
            this.labelText1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.satCoef = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefNum1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satCoef)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(16, 228);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(75, 23);
            this.cancelBut.TabIndex = 13;
            this.cancelBut.Text = "Annuler";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // validateBut
            // 
            this.validateBut.Location = new System.Drawing.Point(691, 228);
            this.validateBut.Name = "validateBut";
            this.validateBut.Size = new System.Drawing.Size(75, 23);
            this.validateBut.TabIndex = 12;
            this.validateBut.Text = "Valider";
            this.validateBut.UseVisualStyleBackColor = true;
            this.validateBut.Click += new System.EventHandler(this.validateBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catégories (en pourcentage)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.coefNum1);
            this.panel1.Controls.Add(this.labelText1);
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 104);
            this.panel1.TabIndex = 0;
            // 
            // coefNum1
            // 
            this.coefNum1.Location = new System.Drawing.Point(560, 5);
            this.coefNum1.Name = "coefNum1";
            this.coefNum1.Size = new System.Drawing.Size(120, 20);
            this.coefNum1.TabIndex = 1;
            this.coefNum1.ValueChanged += new System.EventHandler(this.coefNum1_ValueChanged);
            this.coefNum1.Click += new System.EventHandler(this.coefNum1_ValueChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.satCoef);
            this.groupBox2.Location = new System.Drawing.Point(16, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satisfaction Globale";
            // 
            // satCoef
            // 
            this.satCoef.Location = new System.Drawing.Point(322, 19);
            this.satCoef.Name = "satCoef";
            this.satCoef.Size = new System.Drawing.Size(120, 20);
            this.satCoef.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "%";
            // 
            // ModifCoefPourcentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.validateBut);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifCoefPourcentage";
            this.Text = "ModifNotationPourcentage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifCoef_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coefNum1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.satCoef)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button validateBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown coefNum1;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown satCoef;
        private System.Windows.Forms.Label label1;
    }
}