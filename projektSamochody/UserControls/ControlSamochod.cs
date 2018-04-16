using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projektSamochody.Classes;
using System.Threading;

namespace projektSamochody.UserControls
{
    public partial class ControlSamochod : UserControl
    {
        Samochod samochodObject;

        public delegate void delAktualizacjaPredkosci();
        delAktualizacjaPredkosci metAktualizacjaPredkosci;
        delAktualizacjaPredkosci metAktualizacjaPrzyciskow;


        public ControlSamochod(Samochod samochodObject)
        {
            InitializeComponent();

            this.samochodObject = samochodObject;

            this.markaTextBox.Text = samochodObject.pobierzMarke();
            this.modelTextBox.Text = samochodObject.pobierzModel();
            this.rocznikTextBox.Text = samochodObject.pobierzRocznik().ToString();
            this.pojemnoscBakuTextBox.Text = samochodObject.pobierzPojemnoscBaku().ToString();
            this.srednieSpalanieTextBox.Text = samochodObject.pobierzSrednieSpalanie().ToString();
            this.predkoscMaksymalnaTextBox.Text = samochodObject.pobierzPredkoscMaksymalna().ToString();
            this.iloscPaliwaLabel.Text = samochodObject.pobierzStanBaku().ToString()+" l";
            this.predkoscLabel.Text = samochodObject.pobierzPredkosc().ToString();

            this.silnikCheckbox.Checked = (samochodObject.pobierzStanSilnika());

            metAktualizacjaPredkosci += this.aktualizujPoleZPredkoscia;
            metAktualizacjaPrzyciskow += this.aktualizujStanPrzyciskow;
        }

        private void silnikButton_Click(object sender, EventArgs e)
        {
            if (!this.silnikCheckbox.Checked)
            {
                this.samochodObject.wlaczSilnik();
                this.silnikButton.Text = "Zgaś silnik";
            }
            else
            {
                this.samochodObject.wylaczSilnik();
                this.silnikButton.Text = "Uruchom silnik";
            }
            this.silnikCheckbox.Checked = this.samochodObject.pobierzStanSilnika();
        }

        private void zwiekszPredkoscButton_Click(object sender, EventArgs e)
        {
            int oIle;
            if (oIlePredkoscTextBox.Text != String.Empty)
            {
                if (int.TryParse(oIlePredkoscTextBox.Text, out oIle))
                {
                    if (this.samochodObject.przyspiesz(oIle))
                    {
                        this.aktualizujStanPrzyciskow();
                        Thread watekAktualizujPredkosc = new Thread(aktualizujPredkosc);
                        watekAktualizujPredkosc.Start();
                    }
                    else
                    {
                        MessageBox.Show("Samochód osiągnał już swoją prędkość maksymalną");
                    }
                }
            }
        }

        private void aktualizujStanPrzyciskow()
        {
            this.zwiekszPredkoscButton.Enabled = !this.zwiekszPredkoscButton.Enabled;
            this.zmniejszPredkoscButton.Enabled = !this.zmniejszPredkoscButton.Enabled;
        }

        private void aktualizujPredkosc()
        {
            while (!this.samochodObject.pobierzStanOperacji())
            {
                this.Invoke(metAktualizacjaPredkosci);
                Thread.Sleep(500);
            }

            this.Invoke(metAktualizacjaPrzyciskow);
        }

        private void aktualizujPoleZPredkoscia()
        {
            this.predkoscLabel.Text = this.samochodObject.pobierzPredkosc().ToString() + " km/h";
        }

        private void zmniejszPredkoscButton_Click(object sender, EventArgs e)
        {
            int oIle;
            if (oIlePredkoscTextBox.Text != String.Empty)
            {
                if (int.TryParse(oIlePredkoscTextBox.Text, out oIle))
                {
                    if (this.samochodObject.zwolnij(oIle))
                    {
                        this.aktualizujStanPrzyciskow();
                        Thread watekAktualizujPredkosc = new Thread(aktualizujPredkosc);
                        watekAktualizujPredkosc.Start();
                    }
                    else
                        MessageBox.Show("Samochód już bardziej zwolnić nie może");
                }
            }
        }
    }
}
