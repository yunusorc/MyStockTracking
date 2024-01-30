using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayFlatfunctions;


namespace MyStokTakip
{
    public partial class Kullanici : Form
    {
        public bool kaydet = true;
        public Kullanici()
        {
            InitializeComponent();
            sabitDegiskenler.vtsYolu = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=Stok_takip;Integrated Security=True";
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        #region METODLAR

        private void temizle(Control form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    // Sadece etkin textboxları temizle.
                    if (item.Enabled)
                    {
                        item.Text = "";
                    }
                }
                else if (item.HasChildren)
                {
                    // Eğer kontrol bir container ise, içindeki kontroleri de kontrol et.
                    temizle(item);
                }
            }
            kaydet = true;
        }
        #endregion

        private void Kullanici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.tblKullanici' table. You can move, or remove it, as needed.
            this.tblKullaniciTableAdapter.Fill(this.myDataSet.tblKullanici);
            txtAdi.Select();


            List<string> Liste = new List<string>();
            Liste.Add("Admin");
            Liste.Add("Yönetici");
            Liste.Add("Üye");

            DataTable dt = new DataTable(); 
            cmbKuallanici.Properties.DataSource = Liste;
            cmbKuallanici.Properties.DropDownRows = 3;


        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Eksik alan kontrolü
            if (string.IsNullOrWhiteSpace(txtAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSoyadi.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtParola.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olun.");
                return;
            }

            // Adı kontrolü
            if (kaydet && genel.ExeCuteScalar("select COUNT (Adi) from tblKullanici where Adi='" + txtAdi.Text.Trim() + "'"))
            {
                MessageBox.Show($"{txtAdi.Text} Adı Zaten Mevcut. Lütfen Farklı Bir Ad Girin");
                txtAdi.Text = "";
                txtAdi.Select();
                return;
            }
            // Kullaniciadi kontrolü
            else if (kaydet && genel.ExeCuteScalar("select COUNT (KullaniciAdi) from tblKullanici where KullaniciAdi='" + txtKullaniciAdi.Text.Trim() + "'"))
            {
                MessageBox.Show($"{txtKullaniciAdi.Text} Kullanıcı Adı Zaten Mevcut. Lütfen Farklı Bir Kullanıcı Adı Girin");
                txtKullaniciAdi.Text = "";
                txtKullaniciAdi.Select();
                return;
            }

            // Yeni kayıt mı yoksa güncelleme mi yapılacağını kontrol eder.
            if (kaydet)
                bsKullanici.AddNew();
            MessageBox.Show("Başarıyla Kaydedildi");
           


            // Güncelleme veya yeni kayıt için DataRow oluşturulur.
            DataRow drowKullanici = ((DataRowView)bsKullanici.Current).Row;

            drowKullanici["Unvani"] = cmbKuallanici.EditValue;
            drowKullanici["Adi"] = txtAdi.Text.TrimEnd();
            drowKullanici["Soyadi"] = txtSoyadi.Text.TrimEnd();
            drowKullanici["KullaniciAdi"] = txtKullaniciAdi.Text.TrimEnd();
            drowKullanici["Sifre"] = txtParola.Text.TrimEnd();

            // BindingSource'a yapılan değişiklikler uygulanır.
            bsKullanici.EndEdit();

            try
            {
                // Veritabanına güncellemeyi uygular.
                adpKullanici.Update(myDataSet.tblKullanici);
                MessageBox.Show("Güncelleme Başarıyla Tamamlandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            // DataGridView güncellenir.
            this.tblKullaniciTableAdapter.Fill(this.myDataSet.tblKullanici);
            temizle(this);
        }

        private void cmpKullanici_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == düzeltToolStripMenuItem.Name)
            {
                // BindingSource'ta cari hesap kaydı var mı kontrolü
                if (bsKullanici.Count == 0)
                {
                    return;
                }

                // Kaydet butonunu "DÜZELT" olarak ayarla ve işlem tipini güncelleme olarak belirle
                btnKaydet.Text = "DÜZELT";
                kaydet = false;

                // Seçili satırın DataRow nesnesine dönüştürülmesi
                DataRow drowCariHesaplar = ((DataRowView)bsKullanici.Current).Row;

                // Form alanlarına seçili cari hesap bilgilerini aktarma
                txtAdi.Text = drowCariHesaplar["Adi"].ToString();
                txtSoyadi.Text = drowCariHesaplar["Soyadi"].ToString();
                cmbKuallanici.EditValue = drowCariHesaplar["Unvani"];
                txtKullaniciAdi.Text = drowCariHesaplar["KullaniciAdi"].ToString();
                txtParola.Text = drowCariHesaplar["Sfire"].ToString();
            }
            else if (e.ClickedItem.Name == silToolStripMenuItem.Name)
            {
                try
                {
                    // Seçili cari hesap kaydını temsil eden DataRow nesnesini elde etme
                    DataRow drowKullanici = ((DataRowView)bsKullanici.Current).Row;
                    string kullaniciName = drowKullanici["Adi"].ToString();

                    if (MessageBox.Show($"'{kullaniciName}' Silmek İstediğinize Emin Misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // DataRow nesnesini veritabanından silme
                        drowKullanici.Delete();

                        // Veritabanındaki değişiklikleri uygulama
                        adpKullanici.Update(myDataSet.tblKullanici);

                        // DataGridView'i güncelleme
                        this.tblKullaniciTableAdapter.Fill(this.myDataSet.tblKullanici);

                        MessageBox.Show($"'{kullaniciName}' Başarıyla Silindi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                temizle(this);
            }
            else if (e.ClickedItem.Name == iptalToolStripMenuItem.Name)
            {
                temizle(this);
            }
        }
    }
}
