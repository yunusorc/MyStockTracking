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
    public partial class StokListe : Form
    {
        public bool StokKapandi = false;

        public StokListe()
        {
            InitializeComponent();
            con.ConnectionString = sabitDegiskenler.vtsYolu;

        }

        private void StokListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.tblStok' table. You can move, or remove it, as needed.
            //this.tblStokTableAdapter.Fill(this.myDataSet.tblStok);
            genel.DataTableDoldur(myDataSet.tblStok, "select * from tblStok");

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (bsStokListe.Count == 0)
            {
                return;
            }
            StokKapandi = true;
            this.Close();
        }
    }
}
