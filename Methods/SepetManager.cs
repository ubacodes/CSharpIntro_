using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //Operasyon tutuyor | Manager - Dal (DataAccessLayer) 
        //name convention = isimlendirme kuralı (Pascal Case)

        public void Ekle(Product addProduct)
        {
            //Business codes
            Console.WriteLine("Tebrikler!" + " " + addProduct.Adi + " " + "Sepete eklendi. \n Ürüne ait stok bilgisi (kg) -->" + " " + addProduct.Stok);
        }

        /*
        public void Ekle2(string urunAdi, string urunAciklama, double urunFiyat, int urunStok)
        {
            Console.WriteLine( urunAdi+" "+urunAciklama+" "+urunFiyat+" "+"Sepete Eklendi!");
        }
        */
    }
}
