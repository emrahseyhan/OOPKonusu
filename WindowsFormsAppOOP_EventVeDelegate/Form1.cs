using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppOOP_EventVeDelegate.Entities;

namespace WindowsFormsAppOOP_EventVeDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KrediKarti masterKart = new KrediKarti()
        {
            KullanilabilirLimit = 1000
        };

        KrediKarti visaKart = new KrediKarti()
        {
            KullanilabilirLimit = 2000
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            btnOde.Click += new EventHandler(btnOdemeYap_Click);
            //MouseHover eventı hangi temsilciyle işaretlenebilir/bağlanabilir?
            //Cevap MouseEventHandler ile
            //Nerden biliyoruz?
            //btnOde.MouseMove yazıp fare ile imleci üzerine getirirseniz
            //event ismini görebilirsiniz.
            btnOde.MouseMove += new MouseEventHandler(betulBunuYazdi);
        }

        private void betulBunuYazdi(object sender, MouseEventArgs e)
        {
            MessageBox.Show("betulBunuYazdi metodu MouseMove eventu yani fare hareket etme olayı gerçekleştiği için çalıştı");
        }
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (radioBtnMasterKart.Checked)
            {
                masterKart.AlisverisYap(Convert.ToDecimal(txtTutar.Text));
            }
            else if (radioBtnVisaKart.Checked)
            {
                visaKart.AlisverisYap(Convert.ToDecimal(txtTutar.Text));
            }
        }
        private void MesajYaz()
        {
            MessageBox.Show("Kredi kartınız 250 lira altı limite düştüğü için ödeme alınamadı! Bankanızla iletişime geçiniz!");
        }

        private void radioBtnMasterKart_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnMasterKart.Checked)
            {
                masterKart.KalanLimitEvent += new KrediKarti.KalanLimitKontrolHandler(MesajYaz);
            }
        }

        private void radioBtnVisaKart_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnVisaKart.Checked)
            {
                visaKart.KalanLimitEvent += new KrediKarti.KalanLimitKontrolHandler(MesajYaz);
            }
        }

       
    }
}
