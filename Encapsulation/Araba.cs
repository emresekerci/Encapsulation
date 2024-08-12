using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnekler
{
    internal class Araba
    {
        private string _marka;
        private string _model;
        private string _renk;
        private int _kapiSayisi;

        public Araba(string marka, string model, string renk, int kapisayisi)
        {
            _marka = marka;
            _model = model;
            _renk = renk;
            KapiSayisi = kapisayisi;
        }
        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }
        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {

                    _kapiSayisi = value;
                }
                else
                {
                    _kapiSayisi = -1;
                }
            }
        }
        public void ArabaBilgileri()
        {
            Console.WriteLine($"Arabanın Markası: {_marka}");
            Console.WriteLine($"{_marka} marka aracın modeli: {_model}");
            Console.WriteLine($"Renk: {_renk}");
            Console.WriteLine($"Kapı Sayısı: {_kapiSayisi}");
        }


    }
}
