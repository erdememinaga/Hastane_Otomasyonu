using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    class Hasta
    {
        public string hasta_adi { get; set; }
        public string hasta_soyadi { get; set; }
        
        public long hasta_tc { get; set; }
        public DateTime hasta_dogumT { get; set; }
        public DateTime kayit_tarihi { get; set; }
        
        public long hasta_tel { get; set; }
        public string hasta_adres { get; set; }


    }
}
