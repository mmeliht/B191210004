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
    class Laptop : Urun
    {
        public double EkranBoyutu;
        public int EkranCozunurlugu;
        public double DahiliHafiza;
        public double RamKapasitesi;
        public double PilGucu;

        Random rnd = new Random();
        public Laptop(double EkranBoyutu, int EkranCozunurlugu, double DahiliHafiza, double RamKapasitesi, double PilGucu)
        {

            StokAdedi = rnd.Next(1, 100);

            this.EkranBoyutu = EkranCozunurlugu;
            this.EkranCozunurlugu = EkranCozunurlugu;
            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGucu = PilGucu;

            this.Ad = "Laptop";
            this.Marka = "Casper ";
            this.Model = " G serisi";
            this.Ozellik = "Yok ";
            this.HamFiyat = 6000;
        }
        public double KdvUygula()
        {
            return HamFiyat * 1.15 * SecilenAdet;

        }
    }
}

