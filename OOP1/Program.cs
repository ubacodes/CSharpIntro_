using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            // birinci ürünümü tanımlıyorum
            product1.Id = 1;
            product1.ProductName = "Keyboard & Mouse";
            product1.UnitPrice = 750;
            product1.CategoryId = 5; //Teknolojik ürünler
            product1.UnitsInStok = 24;

            //ikinci ürünümü tanımlıyorum 
            // iki farklı nesne tanımlaması yaptım
            // CategoryId = 3 = Mobilya ürünleri
            Product product2 = new Product { Id = 2, ProductName = "Masa", UnitPrice = 500, CategoryId = 3, UnitsInStok = 3 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

        }
    }
}