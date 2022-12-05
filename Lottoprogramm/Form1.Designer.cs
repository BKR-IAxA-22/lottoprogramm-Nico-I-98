namespace Lottoprogramm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Zahl1 = new System.Windows.Forms.Label();
            this.Zahl2 = new System.Windows.Forms.Label();
            this.Zahl3 = new System.Windows.Forms.Label();
            this.Zahl4 = new System.Windows.Forms.Label();
            this.Zahl5 = new System.Windows.Forms.Label();
            this.Zahl6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zahl1
            // 
            this.Zahl1.AutoSize = true;
            this.Zahl1.Location = new System.Drawing.Point(184, 74);
            this.Zahl1.Name = "Zahl1";
            this.Zahl1.Size = new System.Drawing.Size(34, 13);
            this.Zahl1.TabIndex = 1;
            this.Zahl1.Text = "Zahl1";
            // 
            // Zahl2
            // 
            this.Zahl2.AutoSize = true;
            this.Zahl2.Location = new System.Drawing.Point(253, 74);
            this.Zahl2.Name = "Zahl2";
            this.Zahl2.Size = new System.Drawing.Size(34, 13);
            this.Zahl2.TabIndex = 2;
            this.Zahl2.Text = "Zahl2";
            // 
            // Zahl3
            // 
            this.Zahl3.AutoSize = true;
            this.Zahl3.Location = new System.Drawing.Point(330, 74);
            this.Zahl3.Name = "Zahl3";
            this.Zahl3.Size = new System.Drawing.Size(34, 13);
            this.Zahl3.TabIndex = 3;
            this.Zahl3.Text = "Zahl3";
            // 
            // Zahl4
            // 
            this.Zahl4.AutoSize = true;
            this.Zahl4.Location = new System.Drawing.Point(401, 74);
            this.Zahl4.Name = "Zahl4";
            this.Zahl4.Size = new System.Drawing.Size(34, 13);
            this.Zahl4.TabIndex = 4;
            this.Zahl4.Text = "Zahl4";
            // 
            // Zahl5
            // 
            this.Zahl5.AutoSize = true;
            this.Zahl5.Location = new System.Drawing.Point(475, 74);
            this.Zahl5.Name = "Zahl5";
            this.Zahl5.Size = new System.Drawing.Size(34, 13);
            this.Zahl5.TabIndex = 5;
            this.Zahl5.Text = "Zahl5";
            // 
            // Zahl6
            // 
            this.Zahl6.AutoSize = true;
            this.Zahl6.Location = new System.Drawing.Point(547, 74);
            this.Zahl6.Name = "Zahl6";
            this.Zahl6.Size = new System.Drawing.Size(34, 13);
            this.Zahl6.TabIndex = 6;
            this.Zahl6.Text = "Zahl6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 323);
            this.Controls.Add(this.Zahl6);
            this.Controls.Add(this.Zahl5);
            this.Controls.Add(this.Zahl4);
            this.Controls.Add(this.Zahl3);
            this.Controls.Add(this.Zahl2);
            this.Controls.Add(this.Zahl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Zahl1;
        private System.Windows.Forms.Label Zahl2;
        private System.Windows.Forms.Label Zahl3;
        private System.Windows.Forms.Label Zahl4;
        private System.Windows.Forms.Label Zahl5;
        private System.Windows.Forms.Label Zahl6;
    }
}

