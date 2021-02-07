using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        // Ekleme, Düzenleme, Listeleme, Silme  

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isimli musteri eklendi : ", musteri.Ad, musteri.Soyad);
        }

        public void Duzenle(Musteri musteri)
        {
            Console.WriteLine("{0} numaralı {1} {2} kullanıcısının hesabında düzenleme yapıldı", musteri.HesapNo, musteri.Ad, musteri.Soyad );
        }

        public Musteri[] Listele()
        {
            Console.WriteLine("Musteriler listelendi.");

            // Git database bağlan müşterileri linq,ado net, dapper,  ile sorgula getir ve dön.

            return new Musteri[0];
        }

        public void Sil (Musteri musteri)
        {
            Console.WriteLine("hesap silindi.");
        }

    }
}
