using System;

namespace Matemetik
{
    class DortIslem
    {
        // Topla(2,3)
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }

        public void Cikarma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + sonuc);
        }
    }
}
