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
            ((System.ComponentModel.ISupportInitialize)(this.note1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.note2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.note3)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(445, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModifNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 177);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.note3);
            this.Controls.Add(this.note2);
            this.Controls.Add(this.note1);
            this.Name = "ModifNota";
            this.Text = "ModifNota";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifNota_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.note1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.note2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.note3)).EndInit();
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
    }
}