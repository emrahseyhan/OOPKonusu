using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppOOP_Abstract_Interface.Entities;

namespace WindowsFormsAppOOP_Abstract_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Radio butonlar tikli olmasın
            // todo : radiolar biri mutlaka seçili geliyor. istemiyoruz.

            // groupbox 
            grpBoxIslemler.Enabled = false;
            // checkboxların 
            checkBoxKare.Checked = false;
            checkBoxDikdortgen.Checked = false;
            
            btnCevreHesapla.Click += new EventHandler(btn_Click);
            btnAlanHesapla.Click += new EventHandler(btn_Click);

      }

        private void checkBoxKare_CheckedChanged(object sender, EventArgs e)
        {
            //Kare tiklendiyse dikdörtgendeki tik kalksın

            //if (checkBoxKare.CheckState==CheckState.Checked)
            //{
            //    checkBoxDikdortgen.Checked = false;
            //}

            if (checkBoxKare.Checked)
            {
                checkBoxDikdortgen.Checked = false;
                grpBoxIslemler.Enabled = true;

                lblKenar2.Visible = false;
                txtKenar2.Visible = false;
                lblKenar1.Visible = true;
                lblKenar1.Text = "KENAR";
                txtKenar1.Visible = true;
            }
            else if (checkBoxKare.Checked == false && !checkBoxDikdortgen.Checked)
            {
                grpBoxIslemler.Enabled = false;
            }


        }

        private void checkBoxDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxDikdortgen.CheckState == CheckState.Checked)
            //{
            //    checkBoxKare.Checked = false;
            //}

            if (checkBoxDikdortgen.Checked)
            {
                checkBoxKare.Checked = false;
                grpBoxIslemler.Enabled = true;

                lblKenar1.Visible = true;
                lblKenar1.Text = "KISA KENAR";
                txtKenar1.Visible = true;

                lblKenar2.Visible = true;
                lblKenar2.Text = "UZUN KENAR";
                txtKenar2.Visible = true;
            }
            else if (checkBoxKare.Checked == false && !checkBoxDikdortgen.Checked)
            {
                grpBoxIslemler.Enabled = false;
            }
        }

        //private void btnAlanHesapla_Click(object sender, EventArgs e)
        //{
        //    if (checkBoxDikdortgen.Checked)
        //    {
        //        Dikdortgen d = new Dikdortgen()
        //        {
        //            KisaKenar = Convert.ToInt32(txtKenar1.Text),
        //            UzunKenar = Convert.ToInt32(txtKenar2.Text),
        //            SeklinAdi = txtSekilAd.Text
        //        };
        //        double sonuc = d.AlanHesapla();
        //        MessageBox.Show($"{d.SeklinAdi} adlı şeklin alanı hesaplandı = {sonuc}");

        //    }
        //    else if (checkBoxKare.Checked)
        //    {
        //        Kare k = new Kare()
        //        {
        //            SeklinAdi = txtSekilAd.Text,
        //            Kenar = Convert.ToInt32(txtKenar1.Text)
        //        };
        //        double sonuc = k.AlanHesapla();
        //        MessageBox.Show($"{k.SeklinAdi} adlı şeklin alanı hesaplandı = {sonuc}");
        //    }

        //    //temizlik
        //    Temizle();

        //}

        //private void btnCevreHesapla_Click(object sender, EventArgs e)
        //{
        //    if (checkBoxDikdortgen.Checked)
        //    {
        //        Dikdortgen d = new Dikdortgen()
        //        {
        //            KisaKenar = Convert.ToInt32(txtKenar1.Text),
        //            UzunKenar = Convert.ToInt32(txtKenar2.Text),
        //            SeklinAdi = txtSekilAd.Text
        //        };
        //        double sonuc = d.CevreHesapla();
        //        MessageBox.Show($"{d.SeklinAdi} adlı şeklin çevresi hesaplandı = {sonuc}");

        //    }
        //    else if (checkBoxKare.Checked)
        //    {
        //        Kare k = new Kare()
        //        {
        //            SeklinAdi = txtSekilAd.Text,
        //            Kenar = Convert.ToInt32(txtKenar1.Text)
        //        };
        //        double sonuc = k.CevreHesapla();
        //        MessageBox.Show($"{k.SeklinAdi} adlı şeklin çevresi hesaplandı = {sonuc}");
        //    }

        //    //temizlik
        //    Temizle();

        //}



        private void btn_Click(object sender, EventArgs e)
        {
            // sender kim?
            string islemAdi = "";
            if  ( ((Button)sender).Name== "btnCevreHesapla")
            {
                islemAdi = "çevresi";
            }
            else if (((Button)sender).Name == "btnAlanHesapla")
            {
                islemAdi = "alanı";
            }

            //kare mi dikdörtgen mi?
            if (checkBoxKare.Checked)
            {
                Kare k = new Kare()
                {
                    SeklinAdi=txtSekilAd.Text,
                    Kenar= Convert.ToInt32(txtKenar1.Text)
                };
                double sonuc = 0d;
                switch (islemAdi)
                {
                    case "çevresi":
                        sonuc = k.CevreHesapla();
                        break;

                    case "alanı":
                        sonuc = k.AlanHesapla();
                        break;
                    default:
                        break;
                }


                MessageBox.Show($"{k.SeklinAdi} adlı şeklin {islemAdi} hesaplandı = {sonuc}");
            }
            else if (checkBoxDikdortgen.Checked)
            {
                Dikdortgen d = new Dikdortgen()
                {
                    KisaKenar = Convert.ToInt32(txtKenar1.Text),
                    UzunKenar = Convert.ToInt32(txtKenar2.Text),
                    SeklinAdi = txtSekilAd.Text
                };
                double sonuc = 0d;
                switch (islemAdi)
                {
                    case "çevresi":
                        sonuc = d.CevreHesapla();
                        break;

                    case "alanı":
                        sonuc = d.AlanHesapla();
                        break;
                    default:
                        break;
                }


                MessageBox.Show($"{d.SeklinAdi} adlı şeklin {islemAdi} hesaplandı = {sonuc}");
            }
            Temizle();

        }
        private void Temizle()
        {
            txtKenar1.Clear();
            txtKenar2.Clear();
            txtSekilAd.Clear();
            grpBoxIslemler.Enabled = false;
            checkBoxDikdortgen.Checked = false;
            checkBoxKare.Checked = false;
        }
    }
}
