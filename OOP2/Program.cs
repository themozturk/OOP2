using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "13565";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "167431216541";

            TuzelMüsteri musteri2 = new TuzelMüsteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "546541";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "6549654654";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMüsteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


            // Gerçek Müşteri-Tüzel Müşteri
            // inheritance = Miras

        }
    }
}
