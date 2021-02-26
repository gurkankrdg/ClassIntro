using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(120, "Ahmet");
            ogrenci.Add(158, "Mehmet");
            ogrenci.Add(255, "Serhat");
            Console.WriteLine(ogrenci.Count);
            foreach (var key in ogrenci.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in ogrenci.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
