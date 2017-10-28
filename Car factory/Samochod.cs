using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_factory
{
    class Samochod : Pojazd, IJedzie 
    {
        string marka;
        string model;
        int licznik;
        bool czy_bity;
        int pojemnosc_baku;
        string nr_rejestracyjny;

        public string Marka
        {
            get { return marka; }
            set { Marka = marka; }
        }

        public string Model
        {
            get { return model; }
            set { Model = model; }
        }

        public int Licznik
        {
            get { return licznik; }
            set { Licznik = licznik; }
        }
        public bool Czy_bity
        {
            get { return czy_bity; }
            set { Czy_bity = czy_bity; }
        }

        public int Pojemnosc_baku
        {
            get { return pojemnosc_baku; }
            set { Pojemnosc_baku = pojemnosc_baku; }
        }

        public void Jedz(Silnik nowy_silnik)
        {
        }
    }
}
