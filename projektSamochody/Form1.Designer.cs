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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowySamochódToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testowySamochódToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jakoJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jakoJsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jakoPlikXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doBazyDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // samochody
            // 
            this.samochody.AutoScroll = true;
            this.samochody.Location = new System.Drawing.Point(0, 27);
            this.samochody.Name = "samochody";
            this.samochody.Size = new System.Drawing.Size(960, 430);
            this.samochody.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utwórzToolStripMenuItem,
            this.jakoJsonToolStripMenuItem});
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.zapiszToolStripMenuItem.Text = "Projekt";
            // 
            // utwórzToolStripMenuItem
            // 
            this.utwórzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowySamochódToolStripMenuItem,
            this.testowySamochódToolStripMenuItem});
            this.utwórzToolStripMenuItem.Name = "utwórzToolStripMenuItem";
            this.utwórzToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.utwórzToolStripMenuItem.Text = "Utwórz";
            // 
            // nowySamochódToolStripMenuItem
            // 
            this.nowySamochódToolStripMenuItem.Name = "nowySamochódToolStripMenuItem";
            this.nowySamochódToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nowySamochódToolStripMenuItem.Text = "Nowy samochód";
            this.nowySamochódToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // testowySamochódToolStripMenuItem
            // 
            this.testowySamochódToolStripMenuItem.Name = "testowySamochódToolStripMenuItem";
            this.testowySamochódToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.testowySamochódToolStripMenuItem.Text = "Testowy samochód";
            this.testowySamochódToolStripMenuItem.Click += new System.EventHandler(this.utworzTestowySamochodButton_Click);
            // 
            // jakoJsonToolStripMenuItem
            // 
            this.jakoJsonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jakoJsonToolStripMenuItem1,
            this.jakoPlikXMLToolStripMenuItem,
            this.doBazyDanychToolStripMenuItem});
            this.jakoJsonToolStripMenuItem.Name = "jakoJsonToolStripMenuItem";
            this.jakoJsonToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.jakoJsonToolStripMenuItem.Text = "Zapisz";
            // 
            // jakoJsonToolStripMenuItem1
            // 
            this.jakoJsonToolStripMenuItem1.Name = "jakoJsonToolStripMenuItem1";
            this.jakoJsonToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.jakoJsonToolStripMenuItem1.Text = "Jako plik JSON";
            this.jakoJsonToolStripMenuItem1.Click += new System.EventHandler(this.saveToJson_Click);
            // 
            // jakoPlikXMLToolStripMenuItem
            // 
            this.jakoPlikXMLToolStripMenuItem.Name = "jakoPlikXMLToolStripMenuItem";
            this.jakoPlikXMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.jakoPlikXMLToolStripMenuItem.Text = "Jako plik XML";
            this.jakoPlikXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXml_Click);
            // 
            // doBazyDanychToolStripMenuItem
            // 
            this.doBazyDanychToolStripMenuItem.Name = "doBazyDanychToolStripMenuItem";
            this.doBazyDanychToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.doBazyDanychToolStripMenuItem.Text = "Do bazy danych";
            this.doBazyDanychToolStripMenuItem.Click += new System.EventHandler(this.saveToDb_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 477);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.samochody);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twoje samochody";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel samochody;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jakoJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jakoJsonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jakoPlikXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doBazyDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowySamochódToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testowySamochódToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
    }
}

