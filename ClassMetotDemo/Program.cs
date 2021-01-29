using System;

namespace ClassMetotDemo
  
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri();
            musteri1.Id = 32565874513;
            musteri1.Adi = "Ruveyda";
            musteri1.Soyadi = "Başarı";
            musteri1.TelefonNo = 05369874112;

            

            Musteri musteri2 = new Musteri();
            musteri2.Id = 12114658256;
            musteri2.Adi = "Arda";
            musteri2.Soyadi = "Toprak";
            musteri2.TelefonNo = 02321101447;

            

            Musteri musteri3 = new Musteri();
            musteri3.Id = 36655441239;
            musteri3.Adi = "Halime";
            musteri3.Soyadi = "Sağlam";
            musteri3.TelefonNo = 05462131014;

            


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.TelefonNo);
                Console.WriteLine("\n");


            }
            Console.WriteLine("---------------------------------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Console.WriteLine("---------------------------------");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);

            Console.WriteLine("---------------------------------");
            musteriManager.List(musteri1);
            musteriManager.List(musteri2);
            musteriManager.List(musteri3);

            
        }
    }
}
