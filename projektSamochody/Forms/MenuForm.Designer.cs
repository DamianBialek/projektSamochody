namespace projektSamochody.Forms
{
    partial class MenuForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.wczytajJsonButton = new System.Windows.Forms.Button();
            this.nowyProjektButton = new System.Windows.Forms.Button();
            this.wczytajXmlButton = new System.Windows.Forms.Button();
            this.wczytajBazaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(122, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz akcję";
            // 
            // wczytajJsonButton
            // 
            this.wczytajJsonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wczytajJsonButton.Location = new System.Drawing.Point(110, 175);
            this.wczytajJsonButton.Name = "wczytajJsonButton";
            this.wczytajJsonButton.Size = new System.Drawing.Size(187, 51);
            this.wczytajJsonButton.TabIndex = 2;
            this.wczytajJsonButton.Text = "Wczytaj samochody z pliku w formacie JSON";
            this.wczytajJsonButton.UseVisualStyleBackColor = true;
            this.wczytajJsonButton.Click += new System.EventHandler(this.wczytajJsonButton_Click);
            // 
            // nowyProjektButton
            // 
            this.nowyProjektButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowyProjektButton.Location = new System.Drawing.Point(110, 104);
            this.nowyProjektButton.Name = "nowyProjektButton";
            this.nowyProjektButton.Size = new System.Drawing.Size(187, 47);
            this.nowyProjektButton.TabIndex = 3;
            this.nowyProjektButton.Text = "Utwórz nowy projekt";
            this.nowyProjektButton.UseVisualStyleBackColor = true;
            this.nowyProjektButton.Click += new System.EventHandler(this.nowyProjektButton_Click);
            // 
            // wczytajXmlButton
            // 
            this.wczytajXmlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wczytajXmlButton.Location = new System.Drawing.Point(110, 245);
            this.wczytajXmlButton.Name = "wczytajXmlButton";
            this.wczytajXmlButton.Size = new System.Drawing.Size(187, 51);
            this.wczytajXmlButton.TabIndex = 4;
            this.wczytajXmlButton.Text = "Wczytaj samochody z pliku w formacie XML";
            this.wczytajXmlButton.UseVisualStyleBackColor = true;
            this.wczytajXmlButton.Click += new System.EventHandler(this.wczytajXmlButton_Click);
            // 
            // wczytajBazaButton
            // 
            this.wczytajBazaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wczytajBazaButton.Location = new System.Drawing.Point(110, 316);
            this.wczytajBazaButton.Name = "wczytajBazaButton";
            this.wczytajBazaButton.Size = new System.Drawing.Size(187, 51);
            this.wczytajBazaButton.TabIndex = 7;
            this.wczytajBazaButton.Text = "Wczytaj samochody z bazy danych";
            this.wczytajBazaButton.UseVisualStyleBackColor = true;
            this.wczytajBazaButton.Click += new System.EventHandler(this.wczytajBazaButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.wczytajBazaButton);
            this.Controls.Add(this.wczytajXmlButton);
            this.Controls.Add(this.nowyProjektButton);
            this.Controls.Add(this.wczytajJsonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wczytajJsonButton;
        private System.Windows.Forms.Button nowyProjektButton;
        private System.Windows.Forms.Button wczytajXmlButton;
        private System.Windows.Forms.Button wczytajBazaButton;
    }
}