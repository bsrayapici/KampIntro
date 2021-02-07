using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            // Console.WriteLine(urun1.Adi + "," + urun1.Fiyati + "," + urun1.Aciklama);

            // Console.WriteLine(urun2.Adi + "," + urun2.Fiyati + "," + urun2.Aciklama);

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("---------Metodlar-----------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "sarı armut", 12);
            sepetManager.Ekle2("elma", "y", 12);
            sepetManager.Ekle2("karpuz", "x", 12);

            Console.ReadKey();
        }
    }
}