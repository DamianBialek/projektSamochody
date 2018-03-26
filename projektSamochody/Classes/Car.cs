using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektSamochody.Classes
{
    public class Samochod
    {
        string marka;
        string model;
        int rocznik;
        int predkosc;
        float iloscPaliwaWBaku;
        float pojemnoscBaku;
        float srednieSpalanie;
        bool silnikWlaczony;
        int predkoscMaksymalna;

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
            if(predkosc+oIle <= predkoscMaksymalna && oIle > 0)
            {
                this.predkosc += oIle;
            }
            else
            {
                return false;
            }

            return true;
        }

        public bool zwolnij(int oIle)
        {
            if (this.predkosc - oIle >= 0 && oIle > 0)
            {
                this.predkosc -= oIle;
            }
            else
            {
                return false;
            }

            return true;
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
    }
}
