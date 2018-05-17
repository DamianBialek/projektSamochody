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
using projektSamochody.Forms;

namespace projektSamochody
{
    public partial class Form1 : Form
    {
        ThreadForm form;

        List<Samochod> listaSamochodow = new List<Samochod>();

        public Form1()
        {
            InitializeComponent();

            this.samochody.SetAutoScrollMargin(20,20);

            MenuForm startMenu = new MenuForm();
            startMenu.ShowDialog();

            if(startMenu.DialogResult != DialogResult.OK)
                Environment.Exit(0);

            try
            {
                string akcja = startMenu.pobierzAkcje();

                switch (akcja)
                {
                    case "readJson":
                        listaSamochodow = JsonFile.readJsonFile();
                        this.zaladujListeSamochodow();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd aplikacji !");
                Environment.Exit(0);
            }
        }

        public void zaladujListeSamochodow()
        {
            foreach (Samochod samochod in listaSamochodow)
            {
                this.dodajSamochod(samochod, false);
            }
        }

        public void utworzNowyTestowySamochod()
        {
            Samochod nowySamochod = new Samochod("Audi","A6",2004,0,10,false,70,7,50);
            this.dodajSamochod(nowySamochod);
        }

        public void dodajSamochod(Samochod nowySamochod, bool dodajDoListy = true)
        {
            if(dodajDoListy)
                listaSamochodow.Add(nowySamochod);

            ControlSamochod kontrolkaSamochodu = new ControlSamochod(nowySamochod);
            kontrolkaSamochodu.Name = "ControlSamochod" + this.samochody.Controls.Count;

            Button removeButton = utworzNowyPrzyciskDoUsunieciaSamochodu(kontrolkaSamochodu.Name);

            this.samochody.Controls.Add(kontrolkaSamochodu);
            this.samochody.Controls.Add(removeButton);
            this.samochody.SetFlowBreak(removeButton as Control, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NowySamochod nowySamochodForm = new NowySamochod();
            DialogResult result = nowySamochodForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Samochod nowySamochod = nowySamochodForm.nowySamochod;
                this.dodajSamochod(nowySamochod);
            }
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
                Samochod samochodDoUsunieciaObiekt = samochodDoUsunieciaKontrolka.pobierzObiektSamochodu();

                this.listaSamochodow.Remove(samochodDoUsunieciaObiekt);
                this.samochody.Controls.Remove(samochodDoUsunieciaKontrolka);
            }

            
            this.samochody.Controls.Remove(buttonClicked);
        }

        private void threadButton(object sender, EventArgs e)
        {
            form = new ThreadForm();
            form.delMetoda += this.przypiszTextBox;
            form.ShowDialog();
        }

        private void przypiszTextBox(int i)
        {
            //this.textBox1.Text = i.ToString();
        }

        private void saveToJson_Click(object sender, EventArgs e)
        {
            JsonFile.writeToFile(listaSamochodow);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void utworzTestowySamochodButton_Click(object sender, EventArgs e)
        {
            this.utworzNowyTestowySamochod();
        }
    }
}
