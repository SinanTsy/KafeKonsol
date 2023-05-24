using KafeKonsol.Data.Class;
using KafeKonsol.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKonsol
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            InitializeComponent();
            MasalariYukle();
            OrnekUrunleriYukle();
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 20m });
            db.Urunler.Add(new Urun() { UrunAd = "Ayran", BirimFiyat = 15m });
        }

        private void MasalariYukle()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                var lvi = new ListViewItem($"Masa {i}");
                lvi.Tag = i;
                lvi.ImageKey = "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            var lviTiklanan = lvwMasalar.SelectedItems[0];
            int masaNo = (int)lviTiklanan.Tag;

            // bu masada şu an oturan var mı ?
            var siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);  // FirstOrDefault(...): Bu metot, belirtilen koşula uyan ilk öğeyi seçer. Burada x parametresi, her bir siparişi temsil eder.

            if (siparis == null)
            {
                lviTiklanan.ImageKey = "dolu";
                siparis = new Siparis() { MasaNo = masaNo };
                db.AktifSiparisler.Add(siparis);
            }

            // SiparisForm'u bu sipariş nesnesiyle birlikte aç
            var frmSiparis = new SiparisForm(db, siparis);
            frmSiparis.ShowDialog();
            if (siparis.Durum != SiparisDurum.Aktif)
            {
                lviTiklanan.ImageKey = "bos";
            }

        }
    }
}
