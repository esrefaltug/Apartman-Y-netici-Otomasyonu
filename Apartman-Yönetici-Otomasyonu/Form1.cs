using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Yönetici_Otomasyonu
{
    public partial class Form1 : Form
    {
        BINA myBINA = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BinaAdı = binaadıtxt.Text;
            int DaireSayısı = Int32.Parse( dairesystxt.Text);

            myBINA = new BINA(BinaAdı, DaireSayısı);
            MessageBox.Show("Bina oluşturuldu.");
            button1.Enabled = false;
            binaadıtxt.Enabled = false;
            dairesystxt.Enabled = false;
        }

        private void kytbtn_Click(object sender, EventArgs e)
        {
            string daireno = hngdairetxt.Text;
            string dairetel = telnotxt.Text;
            string bilgiler = daireno + "'Nolu daire tel:" + dairetel;
            
            System.IO.File.WriteAllText(@"C:\Users\eşref\OneDrive\Masaüstü\Apartman-Yönetici-Otomasyonu\dairebilgileri.txt", bilgiler);
            bool evsahibimi = EvSahibimichkbx.Checked;
            MessageBox.Show("Kayıt oluşturuldu dairebilgileri.txt dosyasından kayıtlara erişebilirsiniz.");
            
        }

        private void odendibtn_Click(object sender, EventArgs e)
        {
            
            string ay = aycmbox.Text;
            string yıl = yılcmbox.Text;
            string evnot = evnotxtbox.Text;
            string odendii = yıl + " yılı" + ay + " ayı ödendi." + evnot + " nolu daire tarafından ödendi";
            System.IO.File.WriteAllText(@"C:\Users\eşref\OneDrive\Masaüstü\Apartman-Yönetici-Otomasyonu\aidatbilgiler.txt", odendii);
            MessageBox.Show("ödeme işleri tamamlandı.Aidatbilgiler.txt dosyasından erişebilirsiniz.");
            myBINA.aidatgiris();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gdrndn = gdrndntxtbox.Text;
            int gdrucret = Int32.Parse(gdrucrettxtbx.Text);
            myBINA.giderler(gdrucret);
            string giderr = gdrndn + " dolayı" + gdrucret + " TL ödenmiştir.";
            System.IO.File.WriteAllText(@"C:\Users\eşref\OneDrive\Masaüstü\Apartman-Yönetici-Otomasyonu\gider.txt", giderr);
            MessageBox.Show("Gider işlemi tamamlandı.Gider.txt dosyasından erişebilirsiniz.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kasadaki para:"+myBINA.KasaSorgula()+"TL");
        }
    }
}
