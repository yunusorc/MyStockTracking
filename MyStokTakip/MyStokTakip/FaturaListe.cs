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
using DevExpress.XtraReports.UI;

namespace MyStokTakip
{
    public partial class FaturaListe : Form
    {
        public bool Duzenle = false;
        public FaturaListe()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;
        }

        private void FaturaListe_Load(object sender, EventArgs e)
        {
           
            genel.DataTableDoldur(myDataSet.View_Fatura, "select * from View_Fatura");
            genel.DataTableDoldur(myDataSet.tblFatura, "select * from tblFatura");
            genel.DataTableDoldur(myDataSet.tblStokHareket, "select * from tblStokHareket");



        }

        private void dgvMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == MenuSil.Name)
            {
                if (bsFaturaListe.Count == 0)
                {
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "", MessageBoxButtons.YesNo))
                {
                    return;
                }

                bsFaturaListe.RemoveCurrent();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlTransaction trans = con.BeginTransaction();
               

                try
                {
                    adpFatura.Update(myDataSet.tblFatura);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    trans.Rollback();
                    con.Close();
                    return;
                }

                MessageBox.Show("Kayıt Silindi");
            }

            else if (e.ClickedItem.Name == menuYazdir.Name)
            {

                if (bsFaturaListe.Count == 0)
                    return;
              

                //DataRow drowFatura = ((DataRowView)bsFaturaListe.Current).Row;

                //int aa = Convert.ToInt32(drowFatura["FaturaID"]);

                genel.DataTableDoldur(myDataSet.View_Fatura, "SELECT * FROM View_Fatura");

                RaporEdusama rapor = new RaporEdusama();
                rapor.DataSource = myDataSet;
                rapor.DataMember = "View_Fatura";

                rapor.ShowPreview();

            }
            else if (e.ClickedItem.Name == menuDuzenle.Name)
            {   
                if (bsFaturaListe.Count == 0)
                {
                    return;
                }
                Fatura Rapor = new Fatura();
                Rapor.Kaydet = false;
                Rapor.ListedenGeldi = true;
                   DataRow drowFatura = ((DataRowView)bsFaturaListe.Current).Row;
                Rapor.FaturaID = Convert.ToInt32(drowFatura["FaturaID"]);
                Rapor.CariID = Convert.ToInt32(drowFatura["CariID"]);
                Rapor.ShowDialog();
                genel.DataTableDoldur(myDataSet.tblFatura, "select * from tblFatura");

            }
        }
    }
}
