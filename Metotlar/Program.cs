using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "ELMA";
            double fiyati = 15;
            string aciklama = "AMASYA ELMASI";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "AMASYA ELMASI";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
         urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            //type - safe = 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------------Metotlar-----------");

          SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("ARMUT", "YEŞİL ARMUT", 12, 10);
            sepetManager.Ekle2("Elma", "yeşil elma", 12, 9);
            sepetManager.Ekle2("KARPUZ", "DİYARBAKIR KARPUZU", 12, 8);



        }
    }
}


