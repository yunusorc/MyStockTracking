using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using LayFlatfunctions;
using System.Windows.Forms;

namespace MyStokTakip
{
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
            sabitDegiskenler.vtsYolu = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=Stok_takip;Integrated Security=True";

        }


        void MdiAc( Form form)
        {
            Form f = form;
            Form tempForm = null;
            foreach ( Form child in this.MdiChildren)
            {
                if (child.Text==f.Text)
                {
                    tempForm = child;
                    break;
                }
            }
            if (tempForm != null)
            {
                tempForm.BringToFront();
            }
            else
            {
                f.MdiParent = this;
                f.Show();
                TabPage tabPage = new TabPage();
                tabPage.Text = f.Text;
            }
        }

        private void AnaSayfa_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 1)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm != this.ActiveMdiChild)
                    {
                        childForm.Close();
                        return;
                    }
                }
            }
        }


        

        private void btnCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 CariHesaplarForm = new Form1();
            MdiAc(CariHesaplarForm);
        }

        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stoklar StoklarForm = new Stoklar();
            MdiAc(StoklarForm);
        }

        private void btnBirimler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Birimler BirimlerForm = new Birimler();
            MdiAc(BirimlerForm);
        }

        private void btnFaturaKes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fatura FaturaForm = new Fatura();
            MdiAc(FaturaForm);
        }

        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FaturaListe FaturaListeForm = new FaturaListe();
            MdiAc(FaturaListeForm);
        }

        private void btnKullanici_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Kullanici KullaniciForm = new Kullanici();
            MdiAc(KullaniciForm);
        }
    }
}
