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
    class CepTel : Urun
    {
        public double DahiliHafiza;
        public double RamKapasitesi;
        public int PilGucu;

        Random rnd = new Random();
        public CepTel(double DahiliHafiza, double RamKapasitesi, int PilGucu)
        {

            StokAdedi = rnd.Next(1, 100);

            this.DahiliHafiza = DahiliHafiza;
            this.RamKapasitesi = RamKapasitesi;
            this.PilGucu = PilGucu;


            this.Ad = "CepTel";
            this.Marka = "IPhone ";
            this.Model = "T serisi";
            this.Ozellik = " Yok";
            this.HamFiyat = 2500;
        }

        public double KdvUygula()
        {
            return HamFiyat * 1.20 * SecilenAdet;
        }

    }
}
