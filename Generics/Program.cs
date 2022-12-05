using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic types
            //Genericlere hangi tip veri verirseniz içerisindeki operasyonlar (metotlar) o tip'e göre çalışıyor.
            List<string> sehirler = new List<string>();

            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");


            MyList<string> sehirler2 = new MyList<string>();

            sehirler2.Add("İstanbul");
            sehirler2.Add("Ankara");
            sehirler2.Add("Adana");


            Console.WriteLine("sehirler array elaman sayısı : " + sehirler.Count + "\n" + "sehirler2 array eleman sayısı : " + sehirler2.Count);

            sehirler2.ElemanlariGoster();

            //Generic yapının bize kazandırdığı avantajını bu şekilde görebiliriz.
            //Biz liste elamanımızı bellekte oluştururken hangi type yapıda çalışmasını istiyorsak belirleriz ve o type da çalışabiliriz
            /*
            MyList<int> plakalar1 = new MyList<int>(); 
            plakalar1.Add(06);
            */
        }

        class MyList<T> //Generic class 
        {
            T[] _array;
            T[] _tempArray;
            public MyList() //Constructor metot
            {
                _array = new T[0];
            }

            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                /*
                int i = 0;
                foreach (T item2 in _tempArray)
                {
                    _array[i] = _tempArray[i];
                    i++;
                }
                */

                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;

            }
            public void ElemanlariGoster()
            {
                Console.WriteLine("-----------------ElemanlariGosterMetotuCalisti (sehirler2 array)----------------------");
                for (int r = 0; r < _array.Length; r++)
                {
                    Console.WriteLine(_array[r]);
                }
            }

            private int _count;

            public int Count
            {
                get { return _array.Length; }
            }
        }
    }
}