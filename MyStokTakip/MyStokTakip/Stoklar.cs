using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayFlatfunctions;

namespace MyStokTakip
{
    public partial class Stoklar : Form
    {
        public bool kaydet = true;

        public object FrameWork4D13 { get; private set; }
        public object ProjeAdaptorleri { get; private set; }

        public Stoklar()
        {
            InitializeComponent();
            

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

        private void Stoklar_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'myDataSet.tblBirim' table. You can move, or remove it, as needed.
            //this.tblBirimTableAdapter.Fill(this.myDataSet.tblBirim);
            //// TODO: This line of code loads data into the 'myDataSet.tblStok' table. You can move, or remove it, as needed.
            //this.tblStokTableAdapter.Fill(this.myDataSet.tblStok);
            genel.DataTableDoldur(myDataSet.tblBirim, "select * from tblBirim");

            genel.DataTableDoldur(myDataSet.tblStok, "select* from tblStok");

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Eksik alan kontrolü
            if (string.IsNullOrWhiteSpace(txtBarkod.Text) ||
                string.IsNullOrWhiteSpace(txtStokAdi.Text) ||
                string.IsNullOrWhiteSpace(txtStokKodu.Text) ||
                string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                string.IsNullOrWhiteSpace(txtKdvOrani.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olun.");
                return;
            }

            // Stok Adı kontrolü
            if (kaydet && genel.ExeCuteScalar("select COUNT (StokAdi) from tblStok where StokAdi='" + txtStokAdi.Text.Trim() + "'"))
            {
                MessageBox.Show($"{txtStokAdi.Text} Stok Adı Zaten Mevcut. Lütfen Farklı Bir Stok Adı Girin");
                txtStokAdi.Text = "";
                txtStokAdi.Select();
                return;
            }
            // Barkod kontrolü
            else if (kaydet && genel.ExeCuteScalar("select COUNT (Barkod) from tblStok where Barkod='" + txtBarkod.Text.Trim() + "'"))
            {
                MessageBox.Show($"{txtBarkod.Text} Barkod Zaten Mevcut. Lütfen Farklı Bir Barkod Girin");
                txtBarkod.Text = "";
                txtBarkod.Select();
                return;
            }
            // Stok Kodu kontrolü
            else if (kaydet && genel.ExeCuteScalar("select COUNT (StokKod) from tblStok where StokKod='" + txtStokKodu.Text.Trim() + "'"))
            {
                MessageBox.Show($"{txtStokKodu.Text} Stok Kodu Zaten Mevcut. Lütfen Farklı Bir Stok Kodu Girin");
                txtStokKodu.Text = "";
                txtStokKodu.Select();
                return;
            }

            // Yeni kayıt mı yoksa güncelleme mi yapılacağını kontrol eder.
            if (kaydet)
                bsStoklar.AddNew();
            


            // Güncelleme veya yeni kayıt için DataRow oluşturulur.
            DataRow drowStoklar = ((DataRowView)bsStoklar.Current).Row;
            drowStoklar["BirimID"] = cmbBirim.EditValue;
            drowStoklar["Barkod"] = txtBarkod.Text.TrimEnd();
            drowStoklar["StokAdi"] = txtStokAdi.Text.TrimEnd();
            drowStoklar["StokKod"] = txtStokKodu.Text.TrimEnd();
            drowStoklar["StokFiyat"] = Convert.ToDecimal(txtFiyat.Text.TrimEnd());
            drowStoklar["StokKdvOrani"] = Convert.ToDecimal(txtKdvOrani.Text.TrimEnd());

            // BindingSource'a yapılan değişiklikler uygulanır.
            bsStoklar.EndEdit();

            try
            {
                // Veritabanına güncellemeyi uygular.
                adpStok.Update(myDataSet.tblStok);
                if (kaydet)
                {
                    MessageBox.Show("Başarıyla Kaydedildi");
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarıyla Tamamlandı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            // DataGridView güncellenir.
            this.tblStokTableAdapter.Fill(this.myDataSet.tblStok);
            temizle(this);
        }



        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == duzenleToolStripMenuItem.Name)
            {
                // BindingSource'ta stok kaydı var mı kontrolü
                if (bsStoklar.Count == 0)
                {
                    return;
                }

                // Kaydet butonunu "DÜZELT" olarak ayarla ve işlem tipini güncelleme olarak belirle
                btnKaydet.Text = "DÜZELT";
                kaydet = false;

                // Seçili satırın DataRow nesnesine dönüştürülmesi
                DataRow drowStoklar = ((DataRowView)bsStoklar.Current).Row;

                // Form alanlarına seçili stok bilgilerini aktarma
                cmbBirim.EditValue = drowStoklar["BirimID"];
                txtBarkod.Text = drowStoklar["Barkod"].ToString();
                txtStokAdi.Text = drowStoklar["StokAdi"].ToString();
                txtStokKodu.Text = drowStoklar["StokKod"].ToString();
                txtFiyat.Text = drowStoklar["StokFiyat"].ToString();
                txtKdvOrani.Text = drowStoklar["StokKdvOrani"].ToString();
            }
            else if (e.ClickedItem.Name == silToolStripMenuItem.Name)
            {
                try
                {
                    // Seçili stok kaydını temsil eden DataRow nesnesini elde etme
                    DataRow drowStok = ((DataRowView)bsStoklar.Current).Row;
                    string stokAdi = drowStok["StokAdi"].ToString();

                    // Silme işlemine kullanıcı onayı alma
                    if (MessageBox.Show($"'{stokAdi}' Silmek İstediğinize Emin Misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // DataRow nesnesini veritabanından silme
                        drowStok.Delete();

                        // Veritabanındaki değişiklikleri uygulama
                        adpStok.Update(myDataSet.tblStok);

                        // DataGridView'i güncelleme
                        this.tblStokTableAdapter.Fill(this.myDataSet.tblStok);

                        // Kullanıcıya başarılı silme mesajını gösterme
                        MessageBox.Show($"'{stokAdi}' Başarıyla Silindi");
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

        private void iptalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
