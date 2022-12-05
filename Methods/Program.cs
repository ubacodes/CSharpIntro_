using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar bizim için tekrar tekrar kullanılabilirliği sağlayan yapıyı oluşturmamıza yardımcı olan elemanlar
            //Do not repeat yourself - DRY || Kendini tekrar etme

            //Ürün nesnesi türetmek = instance
            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();


            product1.Adi = "Elma";
            product1.Fiyati = 4;
            product1.Aciklama = "Amasya elması";
            product1.Stok = 1000;

            product2.Adi = "Armut";
            product2.Fiyati = 5;
            product2.Aciklama = "Armutun iyisi";
            product2.Stok = 500;

            product3.Adi = "Kayısı";
            product3.Fiyati = 6;
            product3.Aciklama = "Malatya kayısısı";
            product3.Stok = 17;


            //Ürün dizisi türetmek
            Product[] products = new Product[] { product1, product2, product3 };


            foreach (Product product in products)
            {
                Console.WriteLine("Ürünün adı: " + product.Adi);
                Console.WriteLine("Ürünün fiyatı: " + product.Fiyati + "TL");
                Console.WriteLine("Ürünün açıklaması: " + product.Aciklama);
                Console.WriteLine("Ürünün stok adedi: " + product.Stok);
            }

            Console.WriteLine(" -------------------------------------Metotlar---------------------------------------- ");

            //encapsulation yapısına uygun kod örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product3);

            /*
            Aşağıdaki gibi tanımlama sakıncalıdır çünkü sistemde bir update olduğu zaman yani ekleme işlemi yapılırken bir verinin daha eklenmesi istenildiği zaman patlayacaktır
            Çünkü metotun kullanılmış olduğu önceki tüm sayfalar artık yeni imzaya uygun olmayacaktır
            sepetManager.Ekle2("Elma","Yeşil elma",12,1000);
            sepetManager.Ekle2("Armut", "Sarı armut", 14);
            sepetManager.Ekle2("Karpuz", "Adıyaman karpuz", 20);
            */

        }
    }
}