using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    class GercekMusteri: Musteri //gerçek müşteri, bir müşteridir. Inheritance! 
                                //Artık Müşteri'de olan özellikler GercekMusteri'de de vardır demektir!
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
