namespace WindowsFormsApp1
{
    partial class ModifNota
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
            this.note1 = new System.Windows.Forms.NumericUpDown();
            this.note2 = new System.Windows.Forms.NumericUpDown();
            this.note3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.noteSat2 = new System.Windows.Forms.NumericUpDown();
            this.noteSat1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.note1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.note2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.note3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteSat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteSat1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // note1
            // 
            this.note1.Location = new System.Drawing.Point(44, 69);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(120, 20);
            this.note1.TabIndex = 0;
            // 
            // note2
            // 
            this.note2.Location = new System.Drawing.Point(221, 69);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(120, 20);
            this.note2.TabIndex = 1;
            // 
            // note3
            // 
            this.note3.Location = new System.Drawing.Point(399, 69);
            this.note3.Name = "note3";
            this.note3.Size = new System.Drawing.Size(120, 20);
            this.note3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peu Satisfaisant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Satisfaisant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Très satisfaisant";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notation des questions normales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "A donné satisfaction ou a dépassé vos attentes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "N\'a pas donné satisfaction";
            // 
            // noteSat2
            // 
            this.noteSat2.Location = new System.Drawing.Point(325, 56);
            this.noteSat2.Name = "noteSat2";
            this.noteSat2.Size = new System.Drawing.Size(120, 20);
            this.noteSat2.TabIndex = 11;
            // 
            // noteSat1
            // 
            this.noteSat1.Location = new System.Drawing.Point(61, 56);
            this.noteSat1.Name = "noteSat1";
            this.noteSat1.Size = new System.Drawing.Size(120, 20);
            this.noteSat1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.noteSat2);
            this.groupBox2.Controls.Add(this.noteSat1);
            this.groupBox2.Location = new System.Drawing.Point(22, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 105);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notation de la satisfaction";
            // 
            // ModifNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.note3);
            this.Controls.Add(this.note2);
            this.Controls.Add(this.note1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifNota";
            this.Text = "ModifNota";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifNota_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.note1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.note2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.note3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteSat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteSat1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown note1;
        private System.Windows.Forms.NumericUpDown note2;
        private System.Windows.Forms.NumericUpDown note3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown noteSat2;
        private System.Windows.Forms.NumericUpDown noteSat1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}