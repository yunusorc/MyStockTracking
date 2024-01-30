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
using System.Data.SqlClient;

namespace MyStokTakip
{
    public partial class Fatura : Form
    {

        public Fatura()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
            myDataSet.Relations.Add(myDataSet.tblFatura.FaturaIDColumn, myDataSet.tblStokHareket.FaturaIDColumn);

        }
        public decimal AraToplam, KdvToplami, GenelToplam = 0;
        public int CariID, FaturaID = 0;
        public bool Kaydet = true;
        public bool ListedenGeldi = false;


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
        }


        void Hesapla()
        {
            for (int i = 0; i < bsStokHareket.Count; i++)
            {
                DataRow drowStokhareket = ((DataRowView)bsStokHareket[i]).Row;

                drowStokhareket["Tutar"] = (Convert.ToDecimal(drowStokhareket["Fiyat"]) * Convert.ToDecimal(drowStokhareket["Miktar"])).ToString();
                drowStokhareket["KdvTutari"] = (Convert.ToDecimal(drowStokhareket["Tutar"]) / 100) * Convert.ToDecimal(drowStokhareket["KdvOrani"]);
            }

            if (!DBNull.Value.Equals(myDataSet.tblStokHareket.Compute("Sum(Tutar)", "")))
            {
                AraToplam = Convert.ToDecimal(myDataSet.tblStokHareket.Compute("Sum(Tutar)", ""));
                txtAraToplam.Text = AraToplam.ToString();
            }
            else
            {
                AraToplam = 0;
                txtAraToplam.Text = AraToplam.ToString();
            }

            if (!DBNull.Value.Equals(myDataSet.tblStokHareket.Compute("Sum(Kdvtutari)", "")))
            {
                KdvToplami = Convert.ToDecimal(myDataSet.tblStokHareket.Compute("Sum(Kdvtutari)", ""));
                txtKdvToplam.Text = KdvToplami.ToString();
            }
            else
            {
                KdvToplami = 0;
                txtKdvToplam.Text = KdvToplami.ToString();
            }
            txtGenelToplam.EditValue = (KdvToplami + AraToplam).ToString();
            GenelToplam = KdvToplami + AraToplam;
        }

        #endregion

        private void Fatura_Load(object sender, EventArgs e)
        {
            if (ListedenGeldi)
            {
                btnKaydet.Text = "GÜNCELLE";
            }           
            if (!Kaydet)
            {
                genel.DataTableDoldur(myDataSet.tblFatura, "select * from tblFatura where FaturaID =" + FaturaID);
                genel.DataTableDoldur(myDataSet.tblStokHareket, "select * from tblStokHareket where FaturaID =" + FaturaID);
                DataRow drowFatura = ((DataRowView)bsFatura[0]).Row;
                CariID = Convert.ToInt32(drowFatura["CariID"]);
                txtFaturaNumarasi.EditValue = drowFatura["FaturaNo"];
                dtpFaturaTarihi.EditValue = drowFatura["FaturaTarihi"];
                txtCariHesap.EditValue = genel.ExeCuteScalarStr("Select Unvan from tblCariHesaplar where CariID =" + CariID);
                Hesapla();
            }
            else
            {
                dtpFaturaTarihi.EditValue = DateTime.Now;
            }

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (CariID == 0)
            {
                MessageBox.Show("Cari Seçilmedi","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else if (bsStokHareket.Count == 0)
            {
                MessageBox.Show("Stok Seçilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtFaturaNumarasi.Text == "")
            {
                MessageBox.Show("Fatura Numarası Girilmedi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFaturaNumarasi.Focus();
                return;
            }
            if (Kaydet)
                bsFatura.AddNew();

            DataRow drowFatura = ((DataRowView)bsFatura.Current).Row;
            drowFatura["CariID"] = CariID;
            drowFatura["FaturaTarihi"] = dtpFaturaTarihi.EditValue;
            drowFatura["FaturaNo"] = txtFaturaNumarasi.EditValue;
            drowFatura["AraToplam"] = AraToplam;
            drowFatura["GenelToplam"] = GenelToplam;
            drowFatura["KdvToplam"] = KdvToplami;
            bsFatura.EndEdit();

            for (int i = 0; i < bsStokHareket.Count; i++)
            {
                DataRow drowStokHareket = ((DataRowView)bsStokHareket[i]).Row;
                drowStokHareket.SetParentRow(drowFatura);
                bsStokHareket.EndEdit();

            }

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
               
                adpFatura.Update(myDataSet.tblFatura);
                adpStokHareket.Update(myDataSet.tblStokHareket);


            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
                return;
            }
            MessageBox.Show("Fatura Kesildi");
            Kaydet = false;
            temizle(this);
            ListedenGeldi = false;
        }

       


        private void cmbFatura_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == stokSec.Name)
            {
                StokListe f = new StokListe();
                f.ShowDialog();
                if (f.StokKapandi)
                {
                    DataRow drowStokSec = ((DataRowView)f.bsStokListe.Current).Row;
                    bsStokHareket.AddNew();
                    DataRow drowStokHareket = ((DataRowView)bsStokHareket.Current).Row;
                    drowStokHareket["StokID"] = drowStokSec["SotkID"];
                    drowStokHareket["BirimID"] = drowStokSec["BirimID"];
                    drowStokHareket["StokKod"] = drowStokSec["StokKod"];
                    drowStokHareket["Barkod"] = drowStokSec["Barkod"];
                    drowStokHareket["Fiyat"] = drowStokSec["StokFiyat"];
                    drowStokHareket["KdvOrani"] = drowStokSec["StokKdvOrani"];
                    bsStokHareket.EndEdit();
                }
            }
            else if (e.ClickedItem.Name == stokCikart.Name)
            {
                if (bsStokHareket.Count == 0)
                {
                    return;
                }
                if (DialogResult.Yes==MessageBox.Show("Stok çıkarmak istediğinize emin misiniz?","",MessageBoxButtons.YesNo))
                {
                    MessageBox.Show("Stok Çıkarıldı");
                    return;
                }
                else
                {
                    MessageBox.Show("Başarısız");
                    return;
                }
                bsStokHareket.RemoveCurrent();

                if (bsStokHareket.Count != 0)
                {
                    if (!Kaydet)
                    {
                        Hesapla();
                        return;
                    }
                    temizle(this);
                    Hesapla();
                    return;
                }
                if (bsStokHareket.Count == 0)
                {

                     temizle(this);
                    return;
                }
            }
            
            else if (e.ClickedItem.Name == cariHesapSec.Name)
            {
                CariSec f = new CariSec();
                f.ShowDialog();
                if (f.FormKapandi)
                {
                    DataRow drowCariSec = ((DataRowView)f.bsCariSec.Current).Row;
                    CariID = Convert.ToInt32(drowCariSec["CariID"]);
                    txtCariHesap.EditValue = drowCariSec["Unvan"];
                }
            }
            else if (e.ClickedItem.Name == cariHesapCikart.Name)
            {
                if (CariID == 0)
                {
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Cari Hesabı Çıkartmak İstediğinize Emin Misiniz?", "", MessageBoxButtons.YesNo))
                {
                    return;
                }
                CariID = 0;
                txtCariHesap.EditValue = "";
                MessageBox.Show("Cari Çıkartıldı");
            }
        }



    }
}
