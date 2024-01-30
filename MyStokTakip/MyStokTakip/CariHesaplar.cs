using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStokTakip
{
    public partial class Form1 : Form
    {
        public bool kaydet = true;
        private object selectedRow;

        public Form1()
        {
            InitializeComponent();

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

        //Girilen değerin, veri tabanında var olup olmadığını kontrol eder.
        private bool UnvanVarMi(string unvan)
        {
            foreach (DataRow row in myDataSet.tblCariHesaplar.Rows)
            {
                if (string.Equals(row["Unvan"].ToString().TrimEnd(), unvan, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Aynı "Unvan" değeri var
                }
            }
            return false; // Aynı "Unvan" değeri yok
        }

        #endregion



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.tblCariHesaplar' table. You can move, or remove it, as needed.
            this.tblCariHesaplarTableAdapter.Fill(this.myDataSet.tblCariHesaplar);


            txtUnvan.Select();
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Yeni kayıt mı yoksa güncelleme mi yapılacağını kontrol eder.
            if (kaydet)
            {
                // Yeni kayıt eklerken var olan "Unvan" değerini kontrol et
                string yeniUnvan = txtUnvan.Text.TrimEnd();
                if (UnvanVarMi(yeniUnvan))
                {
                    MessageBox.Show($"{yeniUnvan} Zaten Mevcut. Lütfen Farklı Bir Ünvan Adı Girin");
                    temizle(this);
                    return;
                }

                // Eksik alan kontrolü
                if (string.IsNullOrWhiteSpace(txtUnvan.Text) ||
                    string.IsNullOrWhiteSpace(txtVergiNo.Text) ||
                    string.IsNullOrWhiteSpace(txtVergiDairesi.Text) ||
                    string.IsNullOrWhiteSpace(txtAdres.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                    string.IsNullOrWhiteSpace(txtMailAdresi.Text))
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olun.");
                    return;
                }

                bsCariHesaplar.AddNew();
                // Kayıt işlemi
                MessageBox.Show("Başarıyla Kaydedildi");
            }
            else
            {
                // Güncelleme işlemi sırasında var olan "Unvan" değerini kontrol et
                string yeniUnvan = txtUnvan.Text.TrimEnd();
                DataRow currentRow = ((DataRowView)bsCariHesaplar.Current).Row;
                string eskiUnvan = currentRow["Unvan", DataRowVersion.Original].ToString().TrimEnd();

                if (!string.Equals(yeniUnvan, eskiUnvan, StringComparison.OrdinalIgnoreCase) && UnvanVarMi(yeniUnvan))
                {
                    MessageBox.Show($"{yeniUnvan} Zaten Mevcut. Lütfen Farklı Bir Ünvan Adı Girin");
                    txtUnvan.Text = "";
                    txtUnvan.Select();
                    return;
                }
                // Güncelleme işlemi
                MessageBox.Show("Başarıyla Güncellendi");
            }

            DataRow drowCariHesaplar = ((DataRowView)bsCariHesaplar.Current).Row;

            drowCariHesaplar["Unvan"] = txtUnvan.Text.TrimEnd();
            drowCariHesaplar["VergiNo"] = txtVergiNo.Text.TrimEnd();
            drowCariHesaplar["VergiDairesi"] = txtVergiDairesi.Text.TrimEnd();
            drowCariHesaplar["Adres"] = txtAdres.Text.TrimEnd();
            drowCariHesaplar["Telefon"] = txtTelefon.Text.TrimEnd();
            drowCariHesaplar["Mail"] = txtMailAdresi.Text.TrimEnd();

            bsCariHesaplar.EndEdit();

            try
            {
                // Veri tabanına güncellemeyi uygular.
                adpCariHesaplar.Update(myDataSet.tblCariHesaplar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            this.tblCariHesaplarTableAdapter.Fill(this.myDataSet.tblCariHesaplar);
            temizle(this);
        }



        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem.Name == düzeltToolStripMenuItem.Name)
            {
                // BindingSource'ta cari hesap kaydı var mı kontrolü
                if (bsCariHesaplar.Count == 0)
                {
                    return;
                }

                // Kaydet butonunu "DÜZELT" olarak ayarla ve işlem tipini güncelleme olarak belirle
                btnKaydet.Text = "DÜZELT";
                kaydet = false;

                // Seçili satırın DataRow nesnesine dönüştürülmesi
                DataRow drowCariHesaplar = ((DataRowView)bsCariHesaplar.Current).Row;

                // Form alanlarına seçili cari hesap bilgilerini aktarma
                txtUnvan.Text = drowCariHesaplar["Unvan"].ToString();
                txtAdres.Text = drowCariHesaplar["Adres"].ToString();
                txtMailAdresi.Text = drowCariHesaplar["Mail"].ToString();
                txtTelefon.Text = drowCariHesaplar["Telefon"].ToString();
                txtVergiDairesi.Text = drowCariHesaplar["VergiDairesi"].ToString();
                txtVergiNo.Text = drowCariHesaplar["VergiNo"].ToString();
            }
            else if (e.ClickedItem.Name == silToolStripMenuItem.Name)
            {
                try
                {
                    // Seçili cari hesap kaydını temsil eden DataRow nesnesini elde etme
                    DataRow drowUnvan = ((DataRowView)bsCariHesaplar.Current).Row;
                    string unvanName = drowUnvan["Unvan"].ToString();

                    if (MessageBox.Show($"'{unvanName}' Silmek İstediğinize Emin Misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // DataRow nesnesini veritabanından silme
                        drowUnvan.Delete();

                        // Veritabanındaki değişiklikleri uygulama
                        adpCariHesaplar.Update(myDataSet.tblCariHesaplar);

                        // DataGridView'i güncelleme
                        this.tblCariHesaplarTableAdapter.Fill(this.myDataSet.tblCariHesaplar);
                        
                        MessageBox.Show($"'{unvanName}' Başarıyla Silindi");
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
