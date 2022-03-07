
/*************************************************************************************************************************
 **
 **                                             	SAKARYA ÜNİVERSİTESİ
 **                                        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                            BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 **                                           NESNEYE DAYALI PROGRAMLAMA DERSİ
 **	                                             2019-2020 BAHAR DÖNEMİ
 **    
 **
 **
 **
 **                                            ÖDEV NUMARASI..........: 3
 **                                            ÖĞRENCİ ADI............: Mustafa Melih TÜFEKCİOĞLU
 **                                            ÖĞRENCİ NUMARASI.......: B191210004
 **                                            DERSİN ALINDIĞI GRUP...: 1.Öğretim B grubu
 **
 **
 **
 ***************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace B191210004
{
    class BuzDolabi : Urun
    {
        public double IcHacim;
        public string EnerjiSinifi;

        Random rnd = new Random();

        public BuzDolabi(double IcHacim, string EnerjiSinifi)
        {

            StokAdedi = rnd.Next(1, 100);


            this.IcHacim = IcHacim;
            this.EnerjiSinifi = EnerjiSinifi;

            this.Ad = "Buzdolabı";
            this.Marka = "arcelik ";
            this.Model = "X sinifi";
            this.Ozellik = " Yok";
            this.HamFiyat = 3500;
        }

        public double KdvUygula()
        {
            return this.HamFiyat * 1.05 * SecilenAdet;
        }
    }
}
