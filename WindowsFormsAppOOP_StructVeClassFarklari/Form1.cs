using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOOP_StructVeClassFarklari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxSonuc.ReadOnly = true;

        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            // iki tane öğrenci class yapısından oluşturulacaktır
            // sonra s1 ve s2 birbirine eşitlenecektir
            // sonra s1'nin adı değiştirilsin sonuc textbox'ında neler göreceğiz?
            string[] s1Dizi = txtOgr1.Text.Split(' ');
            Student s1 = new Student(s1Dizi[0], s1Dizi[1]);
            
            string[] s2Dizi = txtOgr2.Text.Split(' ');
            Student s2 = new Student(s2Dizi[0], s2Dizi[1]);

            s1 = s2; // class old için referansları eşitlendi
            s2.Name = "Betül";
            s2.Surname = "Akşan"; // yapılan değişiklik s2dedir Fakat class old için s1de etkilenecektir.
            richTextBoxSonuc.Text += $"Class buton sonucu \n {s1.Name} {s2.Surname}\n";
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            string[] s1Dizi = txtOgr1.Text.Split(' ');
            string[] s2Dizi = txtOgr2.Text.Split(' ');
            // Struct içinde default ctor yazmamış olmamıza rağmen 
            // Struct'ı default ctor ile yaratmaya izin verdi
            OgrenciYapisi o1 = new OgrenciYapisi();
            o1.OgrAd = s1Dizi[0];
            o1.OgrSoyad = s1Dizi[1];

            OgrenciYapisi o2 = new OgrenciYapisi(s2Dizi[0], s2Dizi[1]);
            o1 = o2; // denizi mavi yaptın
            o2.OgrAd = "Betül"; // maviyi betül yaptn
            o2.OgrSoyad = "Akşan";
            richTextBoxSonuc.Text += $"Struct buton sonucu \n {o1.OgrAd} {o1.OgrSoyad}\n";
        }
    }
}
