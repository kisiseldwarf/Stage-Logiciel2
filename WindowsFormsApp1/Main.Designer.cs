namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.source = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.filePreview = new System.Windows.Forms.RichTextBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.modifyCoef = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(27, 12);
            this.source.Name = "source";
            this.source.ReadOnly = true;
            this.source.Size = new System.Drawing.Size(478, 20);
            this.source.TabIndex = 0;
            this.source.TextChanged += new System.EventHandler(this.source_TextChanged);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(511, 10);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // filePreview
            // 
            this.filePreview.Location = new System.Drawing.Point(27, 38);
            this.filePreview.Name = "filePreview";
            this.filePreview.ReadOnly = true;
            this.filePreview.Size = new System.Drawing.Size(559, 174);
            this.filePreview.TabIndex = 2;
            this.filePreview.Text = "";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(462, 218);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(115, 23);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Modifier la notation";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // modifyCoef
            // 
            this.modifyCoef.Location = new System.Drawing.Point(284, 218);
            this.modifyCoef.Name = "modifyCoef";
            this.modifyCoef.Size = new System.Drawing.Size(172, 23);
            this.modifyCoef.TabIndex = 5;
            this.modifyCoef.Text = "Modifier les coefficients";
            this.modifyCoef.UseVisualStyleBackColor = true;
            this.modifyCoef.Click += new System.EventHandler(this.createProfil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exporter CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exporter SCODOC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 249);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modifyCoef);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.filePreview);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.RichTextBox filePreview;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button modifyCoef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

