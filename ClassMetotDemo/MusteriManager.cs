using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri Kimlik No : " + musteri.Id);
            Console.WriteLine("Eklenen Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Eklenen Müşteri Soyadı : " + musteri.Soyad);
        }
        public void musteriSilme(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri Kimlik No : " + musteri.Id);
            Console.WriteLine("Silinen Müşteri Adı : " + musteri.Ad);
            Console.WriteLine("Silinen Müşteri Soyadı : " + musteri.Soyad);
        }
        public void musteriBilgiListeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Listlenen Müşteri Kimlik No : " + musteri.Id);
                Console.WriteLine("Listelenen Müşteri Adı : " + musteri.Ad);
                Console.WriteLine("Listelenen Müşteri Soyadı : " + musteri.Soyad);
            }
            

        }
    }
}
