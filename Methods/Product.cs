using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Product
    {
        //Property = Özellik
        //Ürünün özellikleri gibi düşünülebilir
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        //Sonradan istenilen yeni özelliği ekliyorum
        public int Stok { get; set; }
    }
}
