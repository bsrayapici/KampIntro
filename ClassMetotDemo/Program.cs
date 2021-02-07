using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();

            musteri1.Ad = "Kel Hasan";
            musteri1.Soyad = "Hep keldi";
            musteri1.TCNo = 44185638986 ;
            musteri1.TelefonNo = "05432992391";
            musteri1.HesapNo = 1325;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Duzenle(musteri1);
            musteriManager.Listele();
            musteriManager.Sil(musteri1);

            Console.ReadKey();
        }
    }
}
