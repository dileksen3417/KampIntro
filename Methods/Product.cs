using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Product
    {
        //Classların kullanım şekli;
        // 1. Property : yani ürünlerin 'özellikleri'
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
