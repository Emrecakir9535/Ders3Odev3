using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3Odev3
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Sisteme Eklendi.");
        }

        public void MusteriSil(Musteri musteri)
        {

            Console.WriteLine(musteri.Adi +" "+ musteri.Soyadi + " Müşterisi Sistemden silinmiştir. ");

        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("-------------Listeleme Başlıyor--------");
            Console.WriteLine("Müsteri No:"+musteri.Id + " ID li Müşteri Listeleniyor:");
            Console.WriteLine("Müsteri Adı:" + musteri.Adi);
            Console.WriteLine("Müsteri Soyadı:" + musteri.Soyadi);
            Console.WriteLine("Müsteri Tc Kimlik No:" + musteri.TcKimlikNo);


        }
    }
}
