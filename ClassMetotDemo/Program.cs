using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234566789;
            musteri1.Ad = "Hasan";
            musteri1.Soyad = "Kartal";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 232323451;
            musteri2.Ad = "Sedat";
            musteri2.Soyad = "Karman";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musteriEkleme(musteri1);
            musteriManager.musteriSilme(musteri2);
            musteriManager.musteriBilgiListeleme(musteriler);
        }
    }
}
