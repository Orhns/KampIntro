﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            
            Console.WriteLine("Sepete Eklendi." + urun.Adi);
        }

        public void Ekle2(string adi,string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi." + adi);
        }
    }
}
