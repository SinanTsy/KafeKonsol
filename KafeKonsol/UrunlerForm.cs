using KafeKonsol.Data.Class;
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
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri _db;
        BindingList<Urun> urunler;
        public UrunlerForm(KafeVeri db)
        {
            _db = db;
            urunler = new BindingList<Urun>(db.Urunler);
            InitializeComponent();
            dgvUrunler.DataSource = urunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtUrunAd.Text.Trim();
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ürün adını belirtmediniz.");
                return;
            }

            if (btnEkle.Text == "EKLE")
            {
                var urun = new Urun() { UrunAd = ad, BirimFiyat = nudBirimFiyat.Value };
                urunler.Add(urun);
            }
            else if (_duzenleme != null)
            {
                _duzenleme.UrunAd = ad;
                _duzenleme.BirimFiyat = nudBirimFiyat.Value;
                urunler.ResetBindings();
            }

            FormuSifirla();
        }

        Urun? _duzenleme;
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
                return;

            var satir = dgvUrunler.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem;
            _duzenleme = urun;
            txtUrunAd.Text = urun.UrunAd;
            nudBirimFiyat.Value = urun.BirimFiyat;
            btnEkle.Text = "Kaydet";
            dgvUrunler.Enabled = false;
            btnIptal.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuSifirla();
        }

        private void FormuSifirla()
        {
            btnIptal.Hide();
            btnEkle.Text = "EKLE";
            txtUrunAd.Clear();
            nudBirimFiyat.Value = 0;
            dgvUrunler.Enabled = true;
            _duzenleme = null;
        }
    }
}
