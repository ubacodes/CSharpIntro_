using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /* arrayler tanımlandıktan daha sonrasında belirtilen eleman sınırlarının dışına çıkamazlar yani daha sonradan arraylere elemen eklemek noktasında sorun yaşanabilir
                string[4] isimler = new string[4] {} iken isimler = new string[5] {} yapmak heapte yeni bir adres alır ve eski arrayin elemanları kaybedilir
            bu yüzden koleksiyonlar vardır.
             */

            string[] isimler = new string[] { "murat", "engin", "kerem", "halil" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine("------------------array items \n" + isimler[i]);
            }

            /*
            // Console.WriteLine(isimler[4]); //out of range hatası verir array sınırları dışına çıkamaz
            isimler = new string[5];
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]); // şimdi yazar ama önceki elemanları kaybettik
            */

            List<string> isimler2 = new List<string> { "engin", "murat", "kerem", "halil" };
            isimler2.Add("ilker");

            Console.WriteLine("---------------------List items" + "\n" + isimler2[4]);


        }
    }
}