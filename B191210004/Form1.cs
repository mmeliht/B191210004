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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210004
{
    public partial class Form1 : Form
    {
       

        private GroupBox grbUrun;
        private GroupBox grbOzet;

        private PictureBox ptbBuzDolabi;
        private PictureBox ptbLedTv;
        private PictureBox ptbCepTel;
        private PictureBox ptbLaptop;

        private NumericUpDown nudBuzDolabi;
        private NumericUpDown nudLedTv;
        private NumericUpDown nudCepTel;
        private NumericUpDown nudLaptop;

        private ListBox lstAdet;
        private ListBox lstUrun;
        private ListBox lstKdvFiyat;

        private Button btnSepeteEkle;
        private Button btnSepetiTemizle;

        private Label lblLedTvFiyat;
        private Label lblLedTvFiyatSAyi;
        private Label lblLedTvStok;
        private Label lblLedTvStokSayi;
        private Label lblLedTvAlinacakAdet;

        private Label lblLaptopFiyat;
        private Label lblLapTopFiyatSayi;
        private Label lblLaptopStok;
        private Label lblLaptopStokSayi;
        private Label lblLaptopAlinacakAdet;

        private Label lblBuzDolabiFiyat;
        private Label lblBuzDolabiFiyatSayi;
        private Label lblBuzDolabiStok;
        private Label lblBuzDolabiStokSayi;
        private Label lblBuzDolabiAlinacakAdet;

        private Label lblCepTelFiyat;
        private Label lblCepTelFiyatSayi;
        private Label lblCepTelStok;
        private Label lblCepTelStokSayi;
        private Label lblCepTelAlinacakSayi;

        private Label lblAdet;
        private Label lblUrun;
        private Label lblKdvliFiyat;
        private Label lblKdvliToplam;
        private Label lblKdvLiToplamSayi;

        BuzDolabi buz = new BuzDolabi(50, "A");
        LedTv led = new LedTv(57, 1080);
        CepTel cep = new CepTel(1000, 16, 100);
        Laptop laptop = new Laptop(5.5, 1080, 1000, 16, 100);
        Sepet sepet = new Sepet();

        public Form1()
        {
            Height = 570;
            Width = 1000;
            Text = " ";


            grbUrun = new GroupBox();
            grbUrun.Text = "Urunlere Ait KDV'siz Fiyatlar";
            Controls.Add(grbUrun);
            grbUrun.SetBounds(10, 10, 410, 435);

            grbOzet = new GroupBox();
            grbOzet.Text = "Siparis Ozeti";
            Controls.Add(grbOzet);
            grbOzet.SetBounds(480, 10, 400, 375);


            nudLedTv = new NumericUpDown();
            grbUrun.Controls.Add(nudLedTv);
            nudLedTv.SetBounds(102, 191, 43, 22);

            nudLaptop = new NumericUpDown();
            grbUrun.Controls.Add(nudLaptop);
            nudLaptop.SetBounds(102, 392, 43, 22);

            nudBuzDolabi = new NumericUpDown();
            grbUrun.Controls.Add(nudBuzDolabi);
            nudBuzDolabi.SetBounds(318, 191, 43, 22);

            nudCepTel = new NumericUpDown();
            grbUrun.Controls.Add(nudCepTel);
            nudCepTel.SetBounds(326, 392, 43, 22);


            ptbLedTv = new PictureBox();
            grbUrun.Controls.Add(ptbLedTv);
            ptbLedTv.Image = Image.FromFile(Application.StartupPath + "\\televizyon1.png");
            ptbLedTv.SetBounds(31, 46, 114, 80);

            ptbLaptop = new PictureBox();
            grbUrun.Controls.Add(ptbLaptop);
            ptbLaptop.Image = Image.FromFile(Application.StartupPath + "\\laptop.png");
            ptbLaptop.SetBounds(31, 232, 144, 80);

            ptbBuzDolabi = new PictureBox();
            grbUrun.Controls.Add(ptbBuzDolabi);
            ptbBuzDolabi.Image = Image.FromFile(Application.StartupPath + "\\bozdolabı1.png");
            ptbBuzDolabi.SetBounds(255, 46, 114, 80);

            ptbCepTel = new PictureBox();
            grbUrun.Controls.Add(ptbCepTel);
            ptbCepTel.Image = Image.FromFile(Application.StartupPath + "\\ceptel1.png");
            ptbCepTel.SetBounds(255, 232, 114, 80);


            btnSepeteEkle = new Button();
            btnSepeteEkle.Text = "Urunleri Sepete Ekle";
            Controls.Add(btnSepeteEkle);
            btnSepeteEkle.SetBounds(43, 461, 157, 40);

            btnSepeteEkle.MouseClick += BtnSepeteEkle_MouseClick;

            btnSepetiTemizle = new Button();
            btnSepetiTemizle.Text = "Sepeti Temizle";
            Controls.Add(btnSepetiTemizle);
            btnSepetiTemizle.SetBounds(243, 461, 138, 40);


            lstAdet = new ListBox();
            grbOzet.Controls.Add(lstAdet);
            lstAdet.SetBounds(20, 66, 51, 180);

            lstUrun = new ListBox();
            grbOzet.Controls.Add(lstUrun);
            lstUrun.SetBounds(120, 66, 118, 180);

            lstKdvFiyat = new ListBox();
            grbOzet.Controls.Add(lstKdvFiyat);
            lstKdvFiyat.SetBounds(264, 66, 106, 180);


            lblLedTvFiyat = new Label();
            lblLedTvFiyat.Text = "Fiyat";
            grbUrun.Controls.Add(lblLedTvFiyat);
            lblLedTvFiyat.SetBounds(28, 129, 46, 20);

            lblLedTvFiyatSAyi = new Label();
            lblLedTvFiyatSAyi.Text = led.HamFiyat.ToString();
            grbUrun.Controls.Add(lblLedTvFiyatSAyi);
            lblLedTvFiyatSAyi.SetBounds(99, 129, 46, 17);

            lblLedTvStok = new Label();
            lblLedTvStok.Text = "Stok";
            grbUrun.Controls.Add(lblLedTvStok);
            lblLedTvStok.SetBounds(28, 158, 46, 17);

            lblLedTvStokSayi = new Label();
            lblLedTvStokSayi.Text = led.StokAdedi.ToString();
            grbUrun.Controls.Add(lblLedTvStokSayi);
            lblLedTvStokSayi.SetBounds(99, 158, 46, 17);

            lblLedTvAlinacakAdet = new Label();
            lblLedTvAlinacakAdet.Text = "Adet";
            grbUrun.Controls.Add(lblLedTvAlinacakAdet);
            lblLedTvAlinacakAdet.SetBounds(28, 191, 46, 17);



            lblLaptopFiyat = new Label();
            lblLaptopFiyat.Text = "Fiyat";
            grbUrun.Controls.Add(lblLaptopFiyat);
            lblLaptopFiyat.SetBounds(28, 329, 46, 20);

            lblLapTopFiyatSayi = new Label();
            lblLapTopFiyatSayi.Text = laptop.HamFiyat.ToString();
            grbUrun.Controls.Add(lblLapTopFiyatSayi);
            lblLapTopFiyatSayi.SetBounds(99, 329, 46, 17);

            lblLaptopStok = new Label();
            lblLaptopStok.Text = "Stok";
            grbUrun.Controls.Add(lblLaptopStok);
            lblLaptopStok.SetBounds(28, 357, 46, 17);

            lblLaptopStokSayi = new Label();
            lblLaptopStokSayi.Text = laptop.StokAdedi.ToString();
            grbUrun.Controls.Add(lblLaptopStokSayi);
            lblLaptopStokSayi.SetBounds(99, 357, 46, 17);

            lblLaptopAlinacakAdet = new Label();
            lblLaptopAlinacakAdet.Text = "Adet";
            grbUrun.Controls.Add(lblLaptopAlinacakAdet);
            lblLaptopAlinacakAdet.SetBounds(28, 394, 46, 17);



            lblBuzDolabiFiyat = new Label();
            lblBuzDolabiFiyat.Text = "Fiyat";
            grbUrun.Controls.Add(lblBuzDolabiFiyat);
            lblBuzDolabiFiyat.SetBounds(252, 129, 46, 20);

            lblBuzDolabiFiyatSayi = new Label();
            lblBuzDolabiFiyatSayi.Text = buz.HamFiyat.ToString();
            grbUrun.Controls.Add(lblBuzDolabiFiyatSayi);
            lblBuzDolabiFiyatSayi.SetBounds(315, 129, 46, 17);

            lblBuzDolabiStok = new Label();
            lblBuzDolabiStok.Text = "Stok";
            grbUrun.Controls.Add(lblBuzDolabiStok);
            lblBuzDolabiStok.SetBounds(252, 158, 46, 17);

            lblBuzDolabiStokSayi = new Label();
            lblBuzDolabiStokSayi.Text = buz.StokAdedi.ToString();
            grbUrun.Controls.Add(lblBuzDolabiStokSayi);
            lblBuzDolabiStokSayi.SetBounds(315, 158, 46, 17);

            lblBuzDolabiAlinacakAdet = new Label();
            lblBuzDolabiAlinacakAdet.Text = "Adet";
            grbUrun.Controls.Add(lblBuzDolabiAlinacakAdet);
            lblBuzDolabiAlinacakAdet.SetBounds(252, 189, 46, 17);



            lblCepTelFiyat = new Label();
            lblCepTelFiyat.Text = "Fiyat";
            grbUrun.Controls.Add(lblCepTelFiyat);
            lblCepTelFiyat.SetBounds(252, 329, 46, 20);

            lblCepTelFiyatSayi = new Label();
            lblCepTelFiyatSayi.Text = cep.HamFiyat.ToString();
            grbUrun.Controls.Add(lblCepTelFiyatSayi);
            lblCepTelFiyatSayi.SetBounds(323, 329, 46, 17);

            lblCepTelStok = new Label();
            lblCepTelStok.Text = "Stok";
            grbUrun.Controls.Add(lblCepTelStok);
            lblCepTelStok.SetBounds(252, 357, 46, 17);

            lblCepTelStokSayi = new Label();
            lblCepTelStokSayi.Text = cep.StokAdedi.ToString();
            grbUrun.Controls.Add(lblCepTelStokSayi);
            lblCepTelStokSayi.SetBounds(323, 357, 46, 17);

            lblCepTelAlinacakSayi = new Label();
            lblCepTelAlinacakSayi.Text = "Adet";
            grbUrun.Controls.Add(lblCepTelAlinacakSayi);
            lblCepTelAlinacakSayi.SetBounds(252, 394, 46, 17);


            lblAdet = new Label();
            lblAdet.Text = "Adet";
            grbOzet.Controls.Add(lblAdet);
            lblAdet.SetBounds(17, 46, 46, 20);

            lblUrun = new Label();
            lblUrun.Text = "Urun Adi";
            grbOzet.Controls.Add(lblUrun);
            lblUrun.SetBounds(117, 46, 46, 20);

            lblKdvliFiyat = new Label();
            lblKdvliFiyat.Text = "KDV'li Fiyat";
            grbOzet.Controls.Add(lblKdvliFiyat);
            lblKdvliFiyat.SetBounds(261, 46, 85, 20);

            lblKdvliToplam = new Label();
            lblKdvliToplam.Text = "KDV'li Toplam Fiyat :";
            grbOzet.Controls.Add(lblKdvliToplam);
            lblKdvliToplam.SetBounds(28, 344, 145, 20);

            lblKdvLiToplamSayi = new Label();
            grbOzet.Controls.Add(lblKdvLiToplamSayi);
            lblKdvLiToplamSayi.SetBounds(261, 344, 55, 20);

            btnSepetiTemizle.MouseClick += BtnSepetiTemizle_MouseClick;
        }

        private void BtnSepetiTemizle_MouseClick(object sender, MouseEventArgs e)
        {
            lstAdet.Items.Clear();
            lstUrun.Items.Clear();
            lstKdvFiyat.Items.Clear();
            lblKdvLiToplamSayi.Text = "0";

            lblLedTvStokSayi.Text = led.StokAdedi.ToString();
            nudLedTv.Value = 0;

            lblLaptopStokSayi.Text = laptop.StokAdedi.ToString();
            nudLaptop.Value = 0;

            lblBuzDolabiStokSayi.Text = buz.StokAdedi.ToString();
            nudBuzDolabi.Value = 0;

            lblCepTelStokSayi.Text = cep.StokAdedi.ToString();
            nudCepTel.Value = 0;

        }

        private void BtnSepeteEkle_MouseClick(object sender, MouseEventArgs e)
        {

            lstAdet.Items.Clear();
            lstUrun.Items.Clear();
            lstKdvFiyat.Items.Clear();

            led.SecilenAdet = Convert.ToInt32(nudLedTv.Value);
            laptop.SecilenAdet = Convert.ToInt32(nudLaptop.Value);
            buz.SecilenAdet = Convert.ToInt32(nudBuzDolabi.Value);
            cep.SecilenAdet = Convert.ToInt32(nudCepTel.Value);



            if (led.SecilenAdet != 0)
            {
                lstAdet.Items.Add(led.SecilenAdet);
                lstUrun.Items.Add("Led TV");
                lstKdvFiyat.Items.Add(led.KdvUygula());
            }

            if (laptop.SecilenAdet != 0)
            {
                lstAdet.Items.Add(laptop.SecilenAdet);
                lstUrun.Items.Add("Laptop");
                lstKdvFiyat.Items.Add(laptop.KdvUygula());
            }

            if (buz.SecilenAdet != 0)
            {
                lstAdet.Items.Add(buz.SecilenAdet);
                lstUrun.Items.Add("Buzdolabi");
                lstKdvFiyat.Items.Add(buz.KdvUygula());
            }

            if (cep.SecilenAdet != 0)
            {
                lstAdet.Items.Add(cep.SecilenAdet);
                lstUrun.Items.Add("Cep Telefonu");
                lstKdvFiyat.Items.Add(cep.KdvUygula());
            }
            
            lblLedTvStokSayi.Text = (led.StokAdedi - led.SecilenAdet).ToString();
            lblLaptopStokSayi.Text = (laptop.StokAdedi - laptop.SecilenAdet).ToString();
            lblBuzDolabiStokSayi.Text = (buz.StokAdedi - buz.SecilenAdet).ToString();
            lblCepTelStokSayi.Text = (cep.StokAdedi - cep.SecilenAdet).ToString();
            
            lblKdvLiToplamSayi.Text = sepet.SepeteUrunEkle(buz, led, cep, laptop).ToString();

        }
    }

    
}
