using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int MusteriSil = 1;
            int MusteriEkle = 1;
            int MusteriGuncelle = 1;

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriName = "Bilal";
            musteri1.MusteriSurname = "Altındağ";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriName = "Efe";
            musteri2.MusteriSurname = "Altındağ";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriName = "Tamer";
            musteri3.MusteriSurname = "Çetin";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri'nin Adı : " + musteri.MusteriName + " " + musteri.MusteriSurname);
            }

            MusteriManager musteriManager = new MusteriManager();

            if (MusteriSil == 1)
            {
                musteriManager.Delete(musteri1);
            }

            if (MusteriEkle == 1)
            {
                musteriManager.Add(musteri2);
            }

            if (MusteriGuncelle == 1)
            
                musteriManager.MusteriGuncelle(musteri3);
            }




        }
    }

