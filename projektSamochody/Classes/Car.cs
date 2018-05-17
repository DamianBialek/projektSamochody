using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;

namespace projektSamochody.Classes
{
    public class Samochod
    {
        //string marka;
        //string model;
        //int rocznik;
        //int predkosc;
        //float iloscPaliwaWBaku;
        //float pojemnoscBaku;
        //float srednieSpalanie;
        //bool silnikWlaczony;
        //int predkoscMaksymalna;

        bool koniecOperacji = true;

        public string marka{ get; set; }
        public string model{ get; set; }
        public int rocznik{ get; set; }
        public int predkosc{ get; set; }
        public float iloscPaliwaWBaku { get; set; }
        public float pojemnoscBaku { get; set; }
        public float srednieSpalanie { get; set; }
        public bool silnikWlaczony { get; set; }
        public int predkoscMaksymalna { get; set; }

        public Samochod() { }

        public Samochod(string marka, string model, int rocznik, int predkosc, float iloscPaliwa, bool silnikWlaczony, float pojemnoscBaku, float srednieSpalanie, int predkoscMaksymalna)
        {
            this.marka = marka;
            this.model = model;
            this.rocznik = rocznik;
            this.predkosc = predkosc;
            this.iloscPaliwaWBaku = iloscPaliwa;
            this.silnikWlaczony = silnikWlaczony;
            this.pojemnoscBaku = pojemnoscBaku;
            this.srednieSpalanie = srednieSpalanie;
            this.predkoscMaksymalna = predkoscMaksymalna;
        }

        public bool wlaczSilnik()
        {
            if (this.silnikWlaczony == false)
            {
                this.silnikWlaczony = true;
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool wylaczSilnik()
        {
            if (this.silnikWlaczony == true)
            {
                this.silnikWlaczony = false;
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool przyspiesz(int oIle)
        {
            if(oIle > 0 && this.predkosc < predkoscMaksymalna)
            {
                int start = this.predkosc;
                int stop = (this.predkosc + oIle <= predkoscMaksymalna ? this.predkosc + oIle : predkoscMaksymalna);

                koniecOperacji = false;

                Thread przyspieszanieWatek = new Thread(() => przyspieszanie(start, stop));
                przyspieszanieWatek.Start();
            }
            else
            {
                return false;
            }

            return true;
        }

        public void przyspieszanie(int start, int stop)
        {
            for (int i = start; i < stop; i++)
            {
                this.predkosc++;
                Thread.Sleep(500);
            }

            this.zmienStanOperacji();
        }

        public void zmienStanOperacji()
        {
            this.koniecOperacji = !this.koniecOperacji;
        }

        public bool zwolnij(int oIle)
        {
            if (oIle > 0 && this.predkosc > 0)
            {
                int start = this.predkosc;
                int stop = (this.predkosc - oIle >= 0 ? this.predkosc - oIle : 0);

                koniecOperacji = false;

                Thread zwalnianieWatek = new Thread(() => zwalnianie(start, stop));
                zwalnianieWatek.Start();
            }
            else
            {
                return false;
            }

            return true;
        }

        public void zwalnianie(int start, int stop)
        {
            for (int i = start; i > stop; i--)
            {
                this.predkosc--;
                Thread.Sleep(500);
            }

            this.zmienStanOperacji();
        }

        public bool zatankuj(int ileLitrow)
        {
            if (this.iloscPaliwaWBaku + ileLitrow <= pojemnoscBaku)
            {
                this.iloscPaliwaWBaku += ileLitrow;
            }
            else
            {
                return false;
            }


            return true;
        }

        public int pobierzPredkosc()
        {
            return this.predkosc;
        }

        public int pobierzRocznik()
        {
            return this.rocznik;
        }

        public float pobierzStanBaku()
        {
            return this.iloscPaliwaWBaku;
        }

        public string pobierzMarke()
        {
            return this.marka;
        }

        public string pobierzModel()
        {
            return this.model;
        }

        public float pobierzPojemnoscBaku()
        {
            return this.pojemnoscBaku;
        }

        public float pobierzSrednieSpalanie()
        {
            return this.srednieSpalanie;
        }

        public int pobierzPredkoscMaksymalna()
        {
            return this.predkoscMaksymalna;
        }
        public bool pobierzStanSilnika()
        {
            return (this.silnikWlaczony ? true : false);
        }

        public bool pobierzStanOperacji()
        {
            return this.koniecOperacji;
        }
    }
}
