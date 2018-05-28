using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projektSamochody.Classes;

namespace projektSamochody.Forms
{
    public partial class MenuForm : Form
    {
        string akcja;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void wczytajJsonButton_Click(object sender, EventArgs e)
        {
            this.akcja = "readJson";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string pobierzAkcje()
        {
            return this.akcja;
        }

        private void nowyProjektButton_Click(object sender, EventArgs e)
        {
            this.akcja = "newProject";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void wczytajXmlButton_Click(object sender, EventArgs e)
        {
            this.akcja = "readXml";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JsonFile.pobierzSciezkeDoPliku("write");
        }

        private void wczytajBazaButton_Click(object sender, EventArgs e)
        {
            this.akcja = "readDatabase";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
