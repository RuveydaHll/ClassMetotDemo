using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)

        {
            Console.WriteLine("Tebrikler. Müşteri kaydınız oluşturuldu. : " + musteri.Id + "  " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.TelefonNo);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri kaydınız silindi :" + musteri.Id + "  " + musteri.Adi + "  " + musteri.Soyadi + " " + musteri.TelefonNo);
        }


        public void List (Musteri musteri)
        {

             Console.WriteLine("Tebrikler. İstenilen müsteriler listelendi :" + musteri.Id + "  " + musteri.Adi + "  " + musteri.Soyadi + " " + musteri.TelefonNo);
        
        }
    }
}
