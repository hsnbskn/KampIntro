using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri  //Gerçek müşteri bir müşteridir.
    {
        
        public string TcNo { get; set; }  //Veri üzerinde matematiksel işlem yapmayacağım için metinsel veri olarak tutuyoru. farklı ortamlara uyum içinde bu iyidir.        
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}

