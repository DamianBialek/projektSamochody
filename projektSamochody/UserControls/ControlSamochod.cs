﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projektSamochody.Classes;

namespace projektSamochody.UserControls
{
    public partial class ControlSamochod : UserControl
    {
       Samochod samochodObject;
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void silnikButton_Click(object sender, EventArgs e)
        {
            if (!this.silnikCheckbox.Checked)
            {
                this.silnikCheckbox.Checked = true;
                this.silnikButton.Text = "Zgaś silnik";
            }
            else
            {
                this.silnikCheckbox.Checked = false;
                this.silnikButton.Text = "Uruchom silnik";
            }
        }

        private void zwiekszPredkoscButton_Click(object sender, EventArgs e)
        {
            int oIle;
            if (oIlePredkoscTextBox.Text != String.Empty)
            {
                if (int.TryParse(oIlePredkoscTextBox.Text, out oIle))
                {
                    if (this.samochodObject.przyspiesz(oIle))
                        this.predkoscLabel.Text = this.samochodObject.pobierzPredkosc().ToString() + " km/h";
                    //else
                    //    MessageBox.Show("Samochód osiągnął już swoją prędkość maksymalną");
                }
            }
        }

        private void zmniejszPredkoscButton_Click(object sender, EventArgs e)
        {
            int oIle;
            if (oIlePredkoscTextBox.Text != String.Empty)
            {
                if (int.TryParse(oIlePredkoscTextBox.Text, out oIle))
                {
                    if (this.samochodObject.zwolnij(oIle))
                        this.predkoscLabel.Text = this.samochodObject.pobierzPredkosc().ToString()+" km/h";
                    //else
                    //    MessageBox.Show("Samochód już bardziej zwolnić nie może");
                }
            }
        }
    }
}