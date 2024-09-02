using System;
namespace Patikafy
{
    public class Data
    {
        public Data(string isim,string tur, int yil,int satis)
        {
            sanatciAdi = isim;
            janra = tur;
            date = yil;
            sold = satis;
        }
        public string sanatciAdi { get; set; }
        public string janra { get; set; }
        public int date { get; set; }
        public int sold { get; set; }

    }
}
