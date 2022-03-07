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
    class LedTv : Urun
    {
        public double EkranBoyutu;
        public int EkranCozunurlugu;

        Random rnd = new Random();
        public LedTv(double EkranBoyutu, int EkranCozunurlugu)
        {

            StokAdedi = rnd.Next(1, 100);

            this.EkranBoyutu = EkranBoyutu;
            this.EkranCozunurlugu = EkranCozunurlugu;

            this.Ad = "LedTv";
            this.Marka = "Samsung ";
            this.Model = "Z serisi";
            this.Ozellik = "Yok";
            this.HamFiyat = 4000;
        }

        public double KdvUygula()
        {
            return HamFiyat * 1.18 * SecilenAdet;
        }
    }
}
