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
    public partial class NowySamochod : Form
    {
        public Samochod nowySamochod { get; set; }

        public NowySamochod()
        {
            InitializeComponent();
        }

        private void utworzButtonClick(object sender, EventArgs e)
        {
            if (this.sprawdzPola())
            {
                this.nowySamochod = new Samochod(markaTextBox.Text, modelTextBox.Text, int.Parse(rocznikTextBox.Text), 0, float.Parse(iloscPaliwaWBakuTextBox.Text), false, float.Parse(pojemnoscBakuTextBox.Text), float.Parse(srednieSpalanieTextBox.Text), int.Parse(predkoscMaksymalnaTextBox.Text));

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private bool sprawdzPola()
        {
            TextBox[] dostepnePola = 
            {
                markaTextBox,
                modelTextBox,
                rocznikTextBox,
                iloscPaliwaWBakuTextBox,
                pojemnoscBakuTextBox,
                srednieSpalanieTextBox,
                predkoscMaksymalnaTextBox
            };

            foreach (TextBox pole in dostepnePola)
            {
                if (pole.Text == String.Empty)
                {
                    Label etykietaPustegoPola = this.Controls.Find(pole.Name.Replace("TextBox", "Label"), true).FirstOrDefault() as Label;
                    MessageBox.Show("Pole: "+etykietaPustegoPola.Text + " jest puste !", "Uzupełnij puste pole !");
                    return false;
                }
            }

            return true;
        }
    }
}
