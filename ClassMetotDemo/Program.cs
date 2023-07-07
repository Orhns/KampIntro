using ClassMetotDemo;
using System;

MusteriManager musteriManager = new MusteriManager();

Musteri musteri1 = new Musteri();
musteri1.Name = "Orhun";
musteri1.Surname = "Kırkağaçlıoğlu";
musteri1.Age = 28;

Musteri musteri2 = new Musteri();
musteri2.Name = "Sponge";
musteri2.Surname = "Bob";
musteri2.Age = 13;

Musteri musteri3 = new Musteri();
musteri3.Name = "Patrick";
musteri3.Surname = "pat";
musteri3.Age = 15;
Console.WriteLine("--- Ekle ---");
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);

Console.WriteLine("--- Listele ---");
musteriManager.Listele();
Console.WriteLine("--- Sil ---");
musteriManager.Sil(musteri1);
Console.WriteLine("--- Listele ---");
musteriManager.Listele();