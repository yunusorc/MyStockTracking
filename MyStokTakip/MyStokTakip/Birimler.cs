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
    public partial class Birimler : Form
    {
        public bool kaydet = true;
        public Birimler()
        {
            InitializeComponent();
        }


        #region METODLAR


        //Girilen değerin, veri tabanında var olup olmadığını kontrol eder.
        private bool Varmi(string birim)
        {
            foreach (DataRow row in myDataSet.tblBirim.Rows)
            {
                if (string.Equals(row["BirimAdi"].ToString().TrimEnd(), birim, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Aynı "Birim" değeri var
                }
            }
            return false; // Aynı "Birim" değeri yok
        }

        #endregion



        private void Birimler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.tblBirim' table. You can move, or remove it, as needed.
            this.tblBirimTableAdapter.Fill(this.myDataSet.tblBirim);
            txtBirim.Select();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Yeni kayıt mı yoksa güncelleme mi yapılacağını kontrol eder.
            if (kaydet)
            {
                // Yeni kayıt  eklerken var olan "Birim" değerini kontrol et
                bool varmi = Varmi(txtBirim.Text.TrimEnd());

                if (varmi)
                {
                    MessageBox.Show($"{txtBirim.Text} Zaten Mevcut. Lütfen Farklı Bir Birim Adı Girin");
                    txtBirim.Text = "";
                    return;
                }

                // Eksik alan kontrolü
                if (string.IsNullOrWhiteSpace(txtBirim.Text))
                  
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olun.");
                    return;
                }

                bsBirimler.AddNew();
                // Kayıt işlemi
                MessageBox.Show("Başarıyla Kaydedildi");
            }
            else
            {
                // Güncelleme işlemi sırasında var olan "Birim" değerini kontrol et
                string yeniBirim = txtBirim.Text.TrimEnd();
                DataRow currentRow = ((DataRowView)bsBirimler.Current).Row;
                string eskiBarkod = currentRow["BirimAdi", DataRowVersion.Original].ToString().TrimEnd();

                if (!string.Equals(yeniBirim, eskiBarkod, StringComparison.OrdinalIgnoreCase) && Varmi(yeniBirim))
                {
                    MessageBox.Show($"{yeniBirim} Zaten Mevcut. Lütfen Farklı Bir Barkod Girin");
                    return;
                }
                // Güncelleme işlemi
                MessageBox.Show("Başarıyla Güncellendi");
            }

            DataRow drowBirimler = ((DataRowView)bsBirimler.Current).Row;
            drowBirimler["BirimAdi"] = txtBirim.Text.TrimEnd();
            

            bsBirimler.EndEdit();

            try
            {
                // Veri tabanına güncellemeyi uygular.
                adpBirimler.Update(myDataSet.tblBirim);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            this.tblBirimTableAdapter.Fill(this.myDataSet.tblBirim);
            txtBirim.Text = "";
            kaydet = true;
        }




        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == düzenltToolStripMenuItem.Name)
            {
                if (bsBirimler.Count == 0)
                {
                    return;
                }
                btnKaydet.Text = "DÜZELT";
                kaydet = false;
                DataRow drowBirimler = ((DataRowView)bsBirimler.Current).Row;
                //!!!!!!BİRİM BURAYA GELECEK
                txtBirim.Text = drowBirimler["BirimAdi"].ToString();
                

            }


            else if (e.ClickedItem.Name == silToolStripMenuItem.Name)
            {
                try
                {
                    // Mevcut olan bsBirimler adlı BindingSource nesnesinden elde edilen öğeyi bir DataRow nesnesine dönüştürerek,
                    // bu satırı temsil eden bir DataRow nesnesini bsStoklar değişkenine atar.
                    DataRow drowBirimler = ((DataRowView)bsBirimler.Current).Row;
                    string BirimName = drowBirimler["BirimAdi"].ToString();

                    // Silme işlemini yapmadan önce kullanıcıdan onay alır.
                    if (MessageBox.Show($"'{BirimName}' Silmek İstediğinize Emin Misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Silme işlemini veritabanına uygular.
                        drowBirimler.Delete();

                        // Veri tabanı değiştikten sonra dgw'de yeni verileri gösterir.
                        adpBirimler.Update(myDataSet.tblBirim);

                        //Adaptör aracılığıyla  veri tabanını doldurarak verileri günceller 
                        this.tblBirimTableAdapter.Fill(this.myDataSet.tblBirim);

                        // Silme işleminin başarılı olduğunu kullanıcıya bildirir.
                        MessageBox.Show($"'{BirimName}'Başarıyla Silindi");
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda kullanıcıya hata mesajını göster
                    MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Temizleme işlemi
                txtBirim.Text = "";
                kaydet = true;
            }

            else if (e.ClickedItem.Name == iptalToolStripMenuItem.Name)
            {
                txtBirim.Text = "";
                kaydet = true;
            }
        }


        //Girilen değerin, veri tabanında var olup olmadığını kontrol eder.
        private bool BirimVarmi(string birim)
        {
            foreach (DataRow row in myDataSet.tblCariHesaplar.Rows)
            {
                if (string.Equals(row["BirimAdi"].ToString().TrimEnd(), birim, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Aynı "BirimAdi" değeri var
                }
            }
            return false; // Aynı "BirimAdi" değeri yok
        }



        

    }
}
