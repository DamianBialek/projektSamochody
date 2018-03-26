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
using projektSamochody.UserControls;

namespace projektSamochody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.samochody.SetAutoScrollMargin(20,20);

            utworzNowySamochod();
        }

        public void utworzNowySamochod()
        {
            Samochod nowySamochod = new Samochod("Audi","A6",2004,0,10,false,70,7,200);

            ControlSamochod kontrolkaSamochodu = new ControlSamochod(nowySamochod);
            kontrolkaSamochodu.Name = "ControlSamochod" + this.samochody.Controls.Count;

            Button removeButton = utworzNowyPrzyciskDoUsunieciaSamochodu(kontrolkaSamochodu.Name);

            this.samochody.Controls.Add(kontrolkaSamochodu);
            this.samochody.Controls.Add(removeButton);
            this.samochody.SetFlowBreak(removeButton as Control, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utworzNowySamochod();
        }

        private Button utworzNowyPrzyciskDoUsunieciaSamochodu(string kotrolkaSamochoduName)
        {
            Button removeButton = new Button();
            removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            removeButton.Size = new System.Drawing.Size(196, 40);
            removeButton.Name = "removeSamochod" + kotrolkaSamochoduName;
            removeButton.Text = "Usuń samochód";
            removeButton.Click += new System.EventHandler(this.removeButton_Click);

            return removeButton;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            string samochodDoUsunieciaName = buttonClicked.Name.Replace("removeSamochod","");

            Control[] znalezioneSamochodyDoUsuniecia = this.samochody.Controls.Find(samochodDoUsunieciaName,true);

            if (znalezioneSamochodyDoUsuniecia.Length > 0)
            {
                ControlSamochod samochodDoUsunieciaKontrolka = znalezioneSamochodyDoUsuniecia[0] as ControlSamochod;
                this.samochody.Controls.Remove(samochodDoUsunieciaKontrolka);
            }

            this.samochody.Controls.Remove(buttonClicked);
        }
    }
}
