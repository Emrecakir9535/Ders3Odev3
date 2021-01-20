using System;

namespace Ders3Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcKimlikNo = 13456432131;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Emre";
            musteri2.Soyadi = "Çakır";
            musteri2.TcKimlikNo = 12254569871;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Yavuz";
            musteri3.Soyadi = "Yılmaz";
            musteri3.TcKimlikNo = 71322567891;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Ayşe";
            musteri4.Soyadi = "Güneş";
            musteri4.TcKimlikNo = 32140532891;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Halime";
            musteri5.Soyadi = "Acar";
            musteri5.TcKimlikNo = 51342668179;



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriEkle(musteri4);
            musterimanager.MusteriListele(musteri3);
            musterimanager.MusteriSil(musteri2);
            musterimanager.MusteriSil(musteri5);
        }
    }
}
