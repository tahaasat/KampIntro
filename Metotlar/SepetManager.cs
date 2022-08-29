using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("TEBRİKLER SEPETE EKLENDİ : " + urun.Adi);
        }

        public void Ekle2(string urunadi,string aciklama, double fiyat,int stokadedi)
        {
            Console.WriteLine("TEBRİKLER SEPETE EKLENDİ : " + urunadi);
        }

    }
}
