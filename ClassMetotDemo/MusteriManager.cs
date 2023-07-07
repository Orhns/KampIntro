using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        Musteri[] musteriler = new Musteri[] {};
        List<Musteri> mlist = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            mlist.Add(musteri);
            musteriler = mlist.ToArray<Musteri>();

            Console.WriteLine("Müşteri Eklendi." + "(" + musteri.Name +")");
        }
        public void Listele()
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.Age);
            }
        }
        public void Sil(Musteri musteri)
        {
            musteriler = musteriler.Where(val => val != musteri).ToArray();
            Console.WriteLine(musteri.Name + " silindi.");
        }
    }
}
