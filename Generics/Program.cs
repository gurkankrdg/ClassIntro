using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        private int _count;

        public  int Count
        {
            get { return _array.Length; }
        
        }

    }
}
