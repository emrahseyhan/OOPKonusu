using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppOOP_Polymorphism.Entities;

namespace WindowsFormsAppOOP_Polymorphism
{
    public partial class Form1 : Form
    {
        //classın içi
        Random rnd = new Random(); // bir tane rnd nesnesi oluşturdum

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Temizle();
            timerSistemSaati.Interval = 1000; //1 saniye
            timerSistemSaati.Enabled = true;

            timerRenkDegisimi.Interval = 1000; //3 saniye
            timerRenkDegisimi.Enabled = true;
        }
        private void Temizle()
        {
            groupBoxBakiye.Enabled = false;
            lblOncekiBakiye.Text = "---";
            lblAkbilUcreti.Text = "---";
            lblBakiye.Text = "---";
        }

        private void btnAkbilBas_Click(object sender, EventArgs e)
        {
            Temizle();
            groupBoxBakiye.Enabled = true;

            if (radioBtnAkbil.Checked)
            {
                Akbil akbl = new Akbil()
                {
                    SeriNumarasi = Guid.NewGuid().ToString().Replace("-", ""),
                    KartTipi = KartTipleri.Standart,
                    SonGuncellestirmeTarihi = DateTime.Now
                };
                lblOncekiBakiye.Text = $"Önceki Bakiyeniz: " + akbl.Bakiye;
                akbl.AkbilBas();
                lblAkbilUcreti.Text = $"Ücret: " + akbl.BirBiletlikUcret;
                lblBakiye.Text = $"Bakiye : " + akbl.Bakiye;
            }
            else if (radioBtnOgrenci.Checked)
            {
                OgrenciAkbili ogrAkbl = new OgrenciAkbili(3) //ctor'a parametre gönderildi.
                {
                    KartTipi = KartTipleri.Ogrenci,
                    SeriNumarasi = Guid.NewGuid().ToString().Replace("-", ""),
                    SonGuncellestirmeTarihi = DateTime.Now.AddMonths(-2)
                };
                lblOncekiBakiye.Text = $"Önceki Bakiyeniz: " + ogrAkbl.Bakiye;
                ogrAkbl.AkbilBas();
                lblAkbilUcreti.Text = $"Ücret: " + ogrAkbl.BirBiletlikUcret;
                lblBakiye.Text = $"Bakiye : " + ogrAkbl.Bakiye;

            }
            else if (radioBtnMaviKart.Checked)
            {

            }
            else
            {
                MessageBox.Show("Herhangi bir akbil tipi seçmeden işlem yapılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void timerSistemSaati_Tick(object sender, EventArgs e)
        {
            //timer her saniye bu kodları çalştıracak
            Text = DateTime.Now.ToString("HH:mm:ss");


        }

        private void timerRenkDegisimi_Tick(object sender, EventArgs e)
        {
            byte rastgeleSayi = Convert.ToByte(rnd.Next(0, 6));
            //  byte rastgeleSayi = (byte)rnd.Next(0, 6);

            switch (rastgeleSayi)
            {
                case 0:
                    ForeColor = Color.Black;
                    break;
                case 1:
                    ForeColor = Color.DarkBlue;
                    break;
                case 2:
                    ForeColor = Color.DarkGreen;
                    break;
                case 3:
                    ForeColor = Color.Cyan;
                    break;
                case 4:
                    ForeColor = Color.Red;
                    break;
                case 5:
                    ForeColor = Color.Magenta;
                    break;
                case 6:
                    ForeColor = Color.Yellow; 
                    break;

                default:
                    ForeColor = Color.Black;
                    break;
            }


        }
    }
}
