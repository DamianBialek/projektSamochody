namespace projektSamochody
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
            this.samochody = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.saveToJson = new System.Windows.Forms.Button();
            this.utworzTestowySamochodButton = new System.Windows.Forms.Button();
            this.saveToXml = new System.Windows.Forms.Button();
            this.saveToDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // samochody
            // 
            this.samochody.AutoSize = true;
            this.samochody.Location = new System.Drawing.Point(0, 0);
            this.samochody.Name = "samochody";
            this.samochody.Size = new System.Drawing.Size(778, 528);
            this.samochody.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1114, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Utwórz nowy samochód";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveToJson
            // 
            this.saveToJson.Location = new System.Drawing.Point(1148, 71);
            this.saveToJson.Name = "saveToJson";
            this.saveToJson.Size = new System.Drawing.Size(131, 53);
            this.saveToJson.TabIndex = 4;
            this.saveToJson.Text = "Zapisz samochody do pliku w formacie JSON";
            this.saveToJson.UseVisualStyleBackColor = true;
            this.saveToJson.Click += new System.EventHandler(this.saveToJson_Click);
            // 
            // utworzTestowySamochodButton
            // 
            this.utworzTestowySamochodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.utworzTestowySamochodButton.Location = new System.Drawing.Point(1114, 472);
            this.utworzTestowySamochodButton.Name = "utworzTestowySamochodButton";
            this.utworzTestowySamochodButton.Size = new System.Drawing.Size(185, 39);
            this.utworzTestowySamochodButton.TabIndex = 5;
            this.utworzTestowySamochodButton.Text = "Utworz testowy samochod";
            this.utworzTestowySamochodButton.UseVisualStyleBackColor = true;
            this.utworzTestowySamochodButton.Click += new System.EventHandler(this.utworzTestowySamochodButton_Click);
            // 
            // saveToXml
            // 
            this.saveToXml.Location = new System.Drawing.Point(1148, 148);
            this.saveToXml.Name = "saveToXml";
            this.saveToXml.Size = new System.Drawing.Size(131, 53);
            this.saveToXml.TabIndex = 6;
            this.saveToXml.Text = "Zapisz samochody do pliku w formacie XML";
            this.saveToXml.UseVisualStyleBackColor = true;
            this.saveToXml.Click += new System.EventHandler(this.saveToXml_Click);
            // 
            // saveToDb
            // 
            this.saveToDb.Location = new System.Drawing.Point(1148, 236);
            this.saveToDb.Name = "saveToDb";
            this.saveToDb.Size = new System.Drawing.Size(131, 53);
            this.saveToDb.TabIndex = 7;
            this.saveToDb.Text = "Zapisz samochody do bazy danych";
            this.saveToDb.UseVisualStyleBackColor = true;
            this.saveToDb.Click += new System.EventHandler(this.saveToDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1322, 636);
            this.Controls.Add(this.saveToDb);
            this.Controls.Add(this.saveToXml);
            this.Controls.Add(this.utworzTestowySamochodButton);
            this.Controls.Add(this.saveToJson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.samochody);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel samochody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveToJson;
        private System.Windows.Forms.Button utworzTestowySamochodButton;
        private System.Windows.Forms.Button saveToXml;
        private System.Windows.Forms.Button saveToDb;
    }
}

