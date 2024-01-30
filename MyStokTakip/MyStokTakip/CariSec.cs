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
    public partial class CariSec : Form
    {
        public bool FormKapandi = false;
        internal object bsCari;

        public CariSec()
        {
            InitializeComponent();

        }

        private void CariSec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.tblCariHesaplar' table. You can move, or remove it, as needed.
            this.tblCariHesaplarTableAdapter.Fill(this.myDataSet.tblCariHesaplar);

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            if (bsCariSec.Count == 0)
            {
                return;
            }
            FormKapandi = true;
            this.Close();
        }

        
    }
}
