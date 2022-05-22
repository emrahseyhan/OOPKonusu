using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppileOPP.Entities;
using static System.Windows.Forms.ListBox;

namespace WindowsFormsAppileOPP
{
    public partial class FrmGiris : Form
    {

        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            // Form yüklenirken comboya cinsiyetler enumdan alınarak getirilsin.
            //cmbBoxOgrCinsiyet.Items.Add("Bay");
            //cmbBoxOgrCinsiyet.Items.Add("Bayan");
            //cmbBoxOgrCinsiyet.Items.Add("Belirtilmemiş");

            string[] cinsiyetler = Enum.GetNames(typeof(Cinsiyet));
            cmbBoxOgrCinsiyet.Items.AddRange(cinsiyetler);

            //Form ilk yüklenirken static öğrenci listemizi var edelim
            Ogrenci.Ogrenciler = new List<Ogrenci>();
            // tabIndex
            txtOgrTc.TabIndex = 1;
            txtOgrAd.TabIndex = 2;
            txtOgrSoyad.TabIndex = 3;
            cmbBoxOgrCinsiyet.TabIndex = 4;
            txtOgrTel.TabIndex = 5;
            btnOgrenciEkle.TabIndex = 6;
            listBoxOgrenciler.TabIndex = 7;

            // listboxın context menu strip özellik (property) burada da atayabilirsiniz
            listBoxOgrenciler.ContextMenuStrip = contextMenuStrip1;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Acaba bu tc ile daha önce kayıt yapılmış mı?
                if (OgrenciTCdenVarMi(txtOgrTc.Text)) // true gelirse
                {
                    MessageBox.Show("Bu Tc ile kayıt zaten vardır!", "ÖĞRENCİ KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //burada ogrenci nesnesi türetilecektir 
                Ogrenci yeniOgrenci = new Ogrenci();
                yeniOgrenci.Ad = txtOgrAd.Text.Substring(0, 1).ToUpper() +
                    txtOgrAd.Text.Substring(1).ToLower();
                yeniOgrenci.Soyad = txtOgrSoyad.Text.ToUpper();
                yeniOgrenci.TCKimlik = txtOgrTc.Text;
                yeniOgrenci.Telefon = txtOgrTel.Text;
                yeniOgrenci.Cinsiyeti = (Cinsiyet)cmbBoxOgrCinsiyet.SelectedIndex;
                Ogrenci.Ogrenciler.Add(yeniOgrenci);
                listBoxOgrenciler.Items.Clear();
                listBoxOgrenciler.Items.AddRange(Ogrenci.Ogrenciler.ToArray());
                
                MessageBox.Show("Öğrenci kayıt edildi!");
                // temizlik 
                OgrenciFormunuTemizle();


            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedil bir hata oldu!!" + hata.Message);
            }

        }

        private void OgrenciFormunuTemizle()
        {
            //txtOgrAd.Clear(); // 1. yol tek tek txtboxların namelerini yazarak temizlemek
            //txtOgrSoyad.Clear();
            //txtOgrTc.Clear();
            //txtOgrTel.Clear();
            // cmbBoxOgrCinsiyet.SelectedIndex = -1;
            foreach (var item in this.Controls[0].Controls[0].Controls) //2. yöntem formun controllerini gezelim
            {
                if (item is TextBox) // eğer item textbox ise 
                {
                    ((TextBox)item).Clear(); // item'ı textboxa cast ederek textbox clasının özelliklerinden clear metodunu çağıralım.
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
            }

        }

        private bool OgrenciTCdenVarMi(string tc)
        {
            try
            {
                foreach (var item in Ogrenci.Ogrenciler)
                {
                    if (item.TCKimlik == tc)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = (Ogrenci)listBoxOgrenciler.SelectedItem;
          //  Ogrenci ogr = listBoxOgrenciler.SelectedItem as Ogrenci;

            DialogResult sonuc= MessageBox.Show("Öğrenciyi silmek ister misiniz?", "Silme Onay",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (sonuc== DialogResult.Yes)
            {

                Ogrenci.Ogrenciler.Remove(ogr);
                listBoxOgrenciler.Items.Clear();
                listBoxOgrenciler.Items.AddRange(Ogrenci.Ogrenciler.ToArray());
            }
        }
    }
}
