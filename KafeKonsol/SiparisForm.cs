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
    public partial class SiparisForm : Form
    {
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        private readonly BindingList<SiparisDetay> _siparisDetaylar;

        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            _db = db;
            _siparis = siparis;
            _siparisDetaylar = new BindingList<SiparisDetay>(_siparis.SiparisDetaylar);
            _siparisDetaylar.ListChanged += _siparisDetaylar_ListChanged;
            InitializeComponent();
            dgvDetaylar.AutoGenerateColumns = false;
            dgvDetaylar.DataSource = _siparisDetaylar;
            Guncelle();

        }

        private void _siparisDetaylar_ListChanged(object? sender, ListChangedEventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            Text = $"Masa {_siparis.MasaNo} (Açılış: {_siparis.AcilisZamani})";
            lblMasaNo.Text = _siparis.MasaNo.ToString("00");
            lblOdemeTutari.Text = _siparis.ToplamTutarTL;
            cboUrun.DataSource = _db.Urunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)cboUrun.SelectedItem;
            if (urun == null) return;

            // seçilen ürün adıyla eşleşen bir detay var mı ?
            var sd = _siparisDetaylar.FirstOrDefault(x => x.UrunAd == urun.UrunAd);

            if (sd == null)
            {
                sd = new SiparisDetay()
                {
                    UrunAd = urun.UrunAd,
                    BirimFiyat = urun.BirimFiyat,
                    Adet = (int)nudAdet.Value
                };
                _siparisDetaylar.Add(sd);
            }
            else
            {
                sd.Adet += (int)nudAdet.Value;
                _siparisDetaylar.ResetBindings(); // bağları tekrar kur (böylelikle değişiklik olduğu haberi yayılacak, ListChanged eventi de tetiklenecek)
            }

        }

        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            MasayiKapat(SiparisDurum.Odendi, _siparis.ToplamTutar());
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            MasayiKapat(SiparisDurum.Iptal, 0);
        }

        private void MasayiKapat(SiparisDurum yeniDurum, decimal odenenTutar)
        {
            _siparis.Durum = yeniDurum;
            _siparis.OdenenTutar = odenenTutar;
            _siparis.KapanisZamani = DateTime.Now;
            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);
        }
    }
}
