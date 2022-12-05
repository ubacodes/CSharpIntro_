using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager //ProductService de denilebilirdi.
    {
        //CRUD operasyonları
        //C - Create R - Read U - Update D - Delete
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " " + "Sepete eklendi!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " " + "Ürün güncellendi!");
        }

        // void : geriye değer döndürmez (metot içerisinde işlem tamamlanır ve bitirir)

    }
}
