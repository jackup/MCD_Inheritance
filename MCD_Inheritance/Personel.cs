﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimNedir
{
    public class Personel : TemelTip
    {
        public DateTime IsBaslangicTarih { get; set; }
        public DateTime IsBitisTarih { get; set; }
        public int IzinGunSayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("Personel nesnesi yapıcı metot");
            TemelTipMetot2();
        }
    }
}