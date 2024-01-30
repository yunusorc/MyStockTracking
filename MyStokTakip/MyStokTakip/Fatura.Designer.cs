
namespace MyStokTakip
{
    partial class Fatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpFaturaTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtCariHesap = new DevExpress.XtraEditors.TextEdit();
            this.txtKdvToplam = new DevExpress.XtraEditors.TextEdit();
            this.txtGenelToplam = new DevExpress.XtraEditors.TextEdit();
            this.txtAraToplam = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txtFaturaNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.text1 = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cmbFatura = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokSec = new System.Windows.Forms.ToolStripMenuItem();
            this.stokCikart = new System.Windows.Forms.ToolStripMenuItem();
            this.cariHesapSec = new System.Windows.Forms.ToolStripMenuItem();
            this.cariHesapCikart = new System.Windows.Forms.ToolStripMenuItem();
            this.bsStokHareket = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyStokTakip.MyDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHareketID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblStokHareketTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblStokHareketTableAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.con = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adpFatura = new System.Data.SqlClient.SqlDataAdapter();
            this.bsFatura = new System.Windows.Forms.BindingSource(this.components);
            this.tblFaturaTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblFaturaTableAdapter();
            this.tableAdapterManager1 = new MyStokTakip.MyDataSetTableAdapters.TableAdapterManager();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.adpStokHareket = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFaturaTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFaturaTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariHesap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAraToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.cmbFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpFaturaTarihi);
            this.splitContainer1.Panel1.Controls.Add(this.txtCariHesap);
            this.splitContainer1.Panel1.Controls.Add(this.txtKdvToplam);
            this.splitContainer1.Panel1.Controls.Add(this.txtGenelToplam);
            this.splitContainer1.Panel1.Controls.Add(this.txtAraToplam);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit6);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit5);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit4);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit3);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.txtFaturaNumarasi);
            this.splitContainer1.Panel1.Controls.Add(this.text1);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1022, 450);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtpFaturaTarihi
            // 
            this.dtpFaturaTarihi.EditValue = null;
            this.dtpFaturaTarihi.Location = new System.Drawing.Point(168, 42);
            this.dtpFaturaTarihi.Name = "dtpFaturaTarihi";
            this.dtpFaturaTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFaturaTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFaturaTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpFaturaTarihi.Properties.ReadOnly = true;
            this.dtpFaturaTarihi.Size = new System.Drawing.Size(166, 22);
            this.dtpFaturaTarihi.TabIndex = 45;
            // 
            // txtCariHesap
            // 
            this.txtCariHesap.Location = new System.Drawing.Point(849, 7);
            this.txtCariHesap.Margin = new System.Windows.Forms.Padding(10);
            this.txtCariHesap.Name = "txtCariHesap";
            this.txtCariHesap.Properties.Mask.EditMask = "d";
            this.txtCariHesap.Properties.ReadOnly = true;
            this.txtCariHesap.Size = new System.Drawing.Size(169, 22);
            this.txtCariHesap.TabIndex = 43;
            // 
            // txtKdvToplam
            // 
            this.txtKdvToplam.Location = new System.Drawing.Point(503, 42);
            this.txtKdvToplam.Margin = new System.Windows.Forms.Padding(8);
            this.txtKdvToplam.Name = "txtKdvToplam";
            this.txtKdvToplam.Properties.Mask.EditMask = "d";
            this.txtKdvToplam.Properties.ReadOnly = true;
            this.txtKdvToplam.Size = new System.Drawing.Size(169, 22);
            this.txtKdvToplam.TabIndex = 42;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(849, 42);
            this.txtGenelToplam.Margin = new System.Windows.Forms.Padding(8);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Properties.Mask.EditMask = "d";
            this.txtGenelToplam.Properties.ReadOnly = true;
            this.txtGenelToplam.Size = new System.Drawing.Size(169, 22);
            this.txtGenelToplam.TabIndex = 41;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Location = new System.Drawing.Point(503, 9);
            this.txtAraToplam.Margin = new System.Windows.Forms.Padding(6);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Properties.Mask.EditMask = "d";
            this.txtAraToplam.Properties.ReadOnly = true;
            this.txtAraToplam.Size = new System.Drawing.Size(169, 22);
            this.txtAraToplam.TabIndex = 40;
            // 
            // textEdit6
            // 
            this.textEdit6.EditValue = "Ara Toplam";
            this.textEdit6.Enabled = false;
            this.textEdit6.Location = new System.Drawing.Point(342, 7);
            this.textEdit6.Margin = new System.Windows.Forms.Padding(6);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Size = new System.Drawing.Size(149, 24);
            this.textEdit6.TabIndex = 39;
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "Genel Toplam";
            this.textEdit5.Enabled = false;
            this.textEdit5.Location = new System.Drawing.Point(692, 40);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(6);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit5.Properties.Appearance.Options.UseFont = true;
            this.textEdit5.Size = new System.Drawing.Size(149, 24);
            this.textEdit5.TabIndex = 38;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "Cari Hesap";
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(692, 7);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(6);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Size = new System.Drawing.Size(149, 24);
            this.textEdit4.TabIndex = 37;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "KDV Toplam";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(342, 40);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(6);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Size = new System.Drawing.Size(149, 24);
            this.textEdit3.TabIndex = 36;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Fatura Tarihi";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(6, 40);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(6);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(151, 24);
            this.textEdit2.TabIndex = 35;
            // 
            // txtFaturaNumarasi
            // 
            this.txtFaturaNumarasi.Location = new System.Drawing.Point(165, 7);
            this.txtFaturaNumarasi.Margin = new System.Windows.Forms.Padding(5);
            this.txtFaturaNumarasi.Name = "txtFaturaNumarasi";
            this.txtFaturaNumarasi.Properties.Mask.EditMask = "d";
            this.txtFaturaNumarasi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFaturaNumarasi.Size = new System.Drawing.Size(169, 22);
            this.txtFaturaNumarasi.TabIndex = 31;
            // 
            // text1
            // 
            this.text1.EditValue = "Fatura Numarası";
            this.text1.Enabled = false;
            this.text1.Location = new System.Drawing.Point(6, 5);
            this.text1.Margin = new System.Windows.Forms.Padding(5);
            this.text1.Name = "text1";
            this.text1.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.text1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text1.Properties.Appearance.Options.UseBackColor = true;
            this.text1.Properties.Appearance.Options.UseFont = true;
            this.text1.Size = new System.Drawing.Size(149, 24);
            this.text1.TabIndex = 33;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(14, 86);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 40);
            this.btnKaydet.TabIndex = 32;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.cmbFatura;
            this.gridControl1.DataSource = this.bsStokHareket;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1022, 317);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmbFatura
            // 
            this.cmbFatura.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmbFatura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokSec,
            this.stokCikart,
            this.cariHesapSec,
            this.cariHesapCikart});
            this.cmbFatura.Name = "cms";
            this.cmbFatura.Size = new System.Drawing.Size(193, 100);
            this.cmbFatura.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmbFatura_ItemClicked);
            // 
            // stokSec
            // 
            this.stokSec.Name = "stokSec";
            this.stokSec.Size = new System.Drawing.Size(192, 24);
            this.stokSec.Text = "Stok Seç";
            // 
            // stokCikart
            // 
            this.stokCikart.Name = "stokCikart";
            this.stokCikart.Size = new System.Drawing.Size(192, 24);
            this.stokCikart.Text = "Stok Çıkart";
            // 
            // cariHesapSec
            // 
            this.cariHesapSec.Name = "cariHesapSec";
            this.cariHesapSec.Size = new System.Drawing.Size(192, 24);
            this.cariHesapSec.Text = "Cari Hesap Seç";
            // 
            // cariHesapCikart
            // 
            this.cariHesapCikart.Name = "cariHesapCikart";
            this.cariHesapCikart.Size = new System.Drawing.Size(192, 24);
            this.cariHesapCikart.Text = "Cari Hesap Çıkart";
            // 
            // bsStokHareket
            // 
            this.bsStokHareket.DataMember = "tblStokHareket";
            this.bsStokHareket.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHareketID,
            this.colFaturaID,
            this.colStokID,
            this.colBirimID,
            this.colStokKod,
            this.colBarkod,
            this.colFiyat,
            this.colTutar,
            this.colKdvOrani,
            this.colMiktar,
            this.colKdvTutari});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colHareketID
            // 
            this.colHareketID.FieldName = "HareketID";
            this.colHareketID.MinWidth = 25;
            this.colHareketID.Name = "colHareketID";
            this.colHareketID.OptionsColumn.AllowEdit = false;
            this.colHareketID.Visible = true;
            this.colHareketID.VisibleIndex = 0;
            this.colHareketID.Width = 94;
            // 
            // colFaturaID
            // 
            this.colFaturaID.FieldName = "FaturaID";
            this.colFaturaID.MinWidth = 25;
            this.colFaturaID.Name = "colFaturaID";
            this.colFaturaID.OptionsColumn.AllowEdit = false;
            this.colFaturaID.Visible = true;
            this.colFaturaID.VisibleIndex = 1;
            this.colFaturaID.Width = 94;
            // 
            // colStokID
            // 
            this.colStokID.FieldName = "StokID";
            this.colStokID.MinWidth = 25;
            this.colStokID.Name = "colStokID";
            this.colStokID.OptionsColumn.AllowEdit = false;
            this.colStokID.Visible = true;
            this.colStokID.VisibleIndex = 2;
            this.colStokID.Width = 94;
            // 
            // colBirimID
            // 
            this.colBirimID.FieldName = "BirimID";
            this.colBirimID.MinWidth = 25;
            this.colBirimID.Name = "colBirimID";
            this.colBirimID.OptionsColumn.AllowEdit = false;
            this.colBirimID.Visible = true;
            this.colBirimID.VisibleIndex = 3;
            this.colBirimID.Width = 94;
            // 
            // colStokKod
            // 
            this.colStokKod.FieldName = "StokKod";
            this.colStokKod.MinWidth = 25;
            this.colStokKod.Name = "colStokKod";
            this.colStokKod.OptionsColumn.AllowEdit = false;
            this.colStokKod.Visible = true;
            this.colStokKod.VisibleIndex = 4;
            this.colStokKod.Width = 94;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 5;
            this.colBarkod.Width = 94;
            // 
            // colFiyat
            // 
            this.colFiyat.DisplayFormat.FormatString = "n";
            this.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.MinWidth = 25;
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 6;
            this.colFiyat.Width = 94;
            // 
            // colTutar
            // 
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 7;
            this.colTutar.Width = 94;
            // 
            // colKdvOrani
            // 
            this.colKdvOrani.FieldName = "KdvOrani";
            this.colKdvOrani.MinWidth = 25;
            this.colKdvOrani.Name = "colKdvOrani";
            this.colKdvOrani.OptionsColumn.AllowEdit = false;
            this.colKdvOrani.Visible = true;
            this.colKdvOrani.VisibleIndex = 8;
            this.colKdvOrani.Width = 94;
            // 
            // colMiktar
            // 
            this.colMiktar.DisplayFormat.FormatString = "n";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.MinWidth = 25;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 9;
            this.colMiktar.Width = 94;
            // 
            // colKdvTutari
            // 
            this.colKdvTutari.FieldName = "KdvTutari";
            this.colKdvTutari.MinWidth = 25;
            this.colKdvTutari.Name = "colKdvTutari";
            this.colKdvTutari.OptionsColumn.AllowEdit = false;
            this.colKdvTutari.Visible = true;
            this.colKdvTutari.VisibleIndex = 10;
            this.colKdvTutari.Width = 94;
            // 
            // tblStokHareketTableAdapter
            // 
            this.tblStokHareketTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select * from tblFatura";
            this.sqlSelectCommand1.Connection = this.con;
            // 
            // con
            // 
            this.con.ConnectionString = "Data Source=LAPTOP-HVN2B3FS\\SQLEXPRESS;Initial Catalog=Stok_takip;Integrated Secu" +
    "rity=True";
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.con;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CariID", System.Data.SqlDbType.Int, 0, "CariID"),
            new System.Data.SqlClient.SqlParameter("@FaturaTarihi", System.Data.SqlDbType.DateTime, 0, "FaturaTarihi"),
            new System.Data.SqlClient.SqlParameter("@FaturaNo", System.Data.SqlDbType.NVarChar, 0, "FaturaNo"),
            new System.Data.SqlClient.SqlParameter("@AraToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "AraToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@GenelToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "GenelToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvToplam", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.con;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CariID", System.Data.SqlDbType.Int, 0, "CariID"),
            new System.Data.SqlClient.SqlParameter("@FaturaTarihi", System.Data.SqlDbType.DateTime, 0, "FaturaTarihi"),
            new System.Data.SqlClient.SqlParameter("@FaturaNo", System.Data.SqlDbType.NVarChar, 0, "FaturaNo"),
            new System.Data.SqlClient.SqlParameter("@AraToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "AraToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@GenelToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "GenelToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FaturaID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CariID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CariID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CariID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CariID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FaturaTarihi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FaturaTarihi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FaturaTarihi", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaTarihi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FaturaNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FaturaNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FaturaNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AraToplam", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AraToplam", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AraToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "AraToplam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GenelToplam", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GenelToplam", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GenelToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "GenelToplam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KdvToplam", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KdvToplam", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KdvToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvToplam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@FaturaID", System.Data.SqlDbType.Int, 4, "FaturaID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.con;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FaturaID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CariID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CariID", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CariID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CariID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FaturaTarihi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FaturaTarihi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FaturaTarihi", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaTarihi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FaturaNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FaturaNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FaturaNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AraToplam", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AraToplam", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AraToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "AraToplam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_GenelToplam", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "GenelToplam", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_GenelToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "GenelToplam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_KdvToplam", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "KdvToplam", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_KdvToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvToplam", System.Data.DataRowVersion.Original, null)});
            // 
            // adpFatura
            // 
            this.adpFatura.DeleteCommand = this.sqlDeleteCommand1;
            this.adpFatura.InsertCommand = this.sqlInsertCommand1;
            this.adpFatura.SelectCommand = this.sqlSelectCommand1;
            this.adpFatura.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblFatura", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FaturaID", "FaturaID"),
                        new System.Data.Common.DataColumnMapping("CariID", "CariID"),
                        new System.Data.Common.DataColumnMapping("FaturaTarihi", "FaturaTarihi"),
                        new System.Data.Common.DataColumnMapping("FaturaNo", "FaturaNo"),
                        new System.Data.Common.DataColumnMapping("AraToplam", "AraToplam"),
                        new System.Data.Common.DataColumnMapping("GenelToplam", "GenelToplam"),
                        new System.Data.Common.DataColumnMapping("KdvToplam", "KdvToplam")})});
            this.adpFatura.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // bsFatura
            // 
            this.bsFatura.DataMember = "tblFatura";
            this.bsFatura.DataSource = this.myDataSet;
            // 
            // tblFaturaTableAdapter
            // 
            this.tblFaturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblBirimTableAdapter = null;
            this.tableAdapterManager1.tblCariHesaplarTableAdapter = null;
            this.tableAdapterManager1.tblFaturaTableAdapter = this.tblFaturaTableAdapter;
            this.tableAdapterManager1.tblKullaniciTableAdapter = null;
            this.tableAdapterManager1.tblStokHareketTableAdapter = this.tblStokHareketTableAdapter;
            this.tableAdapterManager1.tblStokTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MyStokTakip.MyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "select * from tblStokHareket";
            this.sqlSelectCommand2.Connection = this.con;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.con;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FaturaID", System.Data.SqlDbType.Int, 0, "FaturaID"),
            new System.Data.SqlClient.SqlParameter("@StokID", System.Data.SqlDbType.Int, 0, "StokID"),
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 0, "BirimID"),
            new System.Data.SqlClient.SqlParameter("@StokKod", System.Data.SqlDbType.NVarChar, 0, "StokKod"),
            new System.Data.SqlClient.SqlParameter("@Barkod", System.Data.SqlDbType.NVarChar, 0, "Barkod"),
            new System.Data.SqlClient.SqlParameter("@Fiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Fiyat", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tutar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Tutar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvOrani", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Miktar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Miktar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvTutari", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvTutari", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.con;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FaturaID", System.Data.SqlDbType.Int, 0, "FaturaID"),
            new System.Data.SqlClient.SqlParameter("@StokID", System.Data.SqlDbType.Int, 0, "StokID"),
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 0, "BirimID"),
            new System.Data.SqlClient.SqlParameter("@StokKod", System.Data.SqlDbType.NVarChar, 0, "StokKod"),
            new System.Data.SqlClient.SqlParameter("@Barkod", System.Data.SqlDbType.NVarChar, 0, "Barkod"),
            new System.Data.SqlClient.SqlParameter("@Fiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Fiyat", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tutar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Tutar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvOrani", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Miktar", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Miktar", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvTutari", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvTutari", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@HareketID", System.Data.SqlDbType.Int, 4, "HareketID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [tblStokHareket] WHERE (([HareketID] = @Original_HareketID))";
            this.sqlDeleteCommand2.Connection = this.con;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null)});
            // 
            // adpStokHareket
            // 
            this.adpStokHareket.DeleteCommand = this.sqlDeleteCommand2;
            this.adpStokHareket.InsertCommand = this.sqlInsertCommand2;
            this.adpStokHareket.SelectCommand = this.sqlSelectCommand2;
            this.adpStokHareket.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblStokHareket", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("HareketID", "HareketID"),
                        new System.Data.Common.DataColumnMapping("FaturaID", "FaturaID"),
                        new System.Data.Common.DataColumnMapping("StokID", "StokID"),
                        new System.Data.Common.DataColumnMapping("BirimID", "BirimID"),
                        new System.Data.Common.DataColumnMapping("StokKod", "StokKod"),
                        new System.Data.Common.DataColumnMapping("Barkod", "Barkod"),
                        new System.Data.Common.DataColumnMapping("Fiyat", "Fiyat"),
                        new System.Data.Common.DataColumnMapping("Tutar", "Tutar"),
                        new System.Data.Common.DataColumnMapping("KdvOrani", "KdvOrani"),
                        new System.Data.Common.DataColumnMapping("Miktar", "Miktar"),
                        new System.Data.Common.DataColumnMapping("KdvTutari", "KdvTutari")})});
            this.adpStokHareket.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // Fatura
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "Fatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fatura_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFaturaTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFaturaTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariHesap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAraToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.cmbFatura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtFaturaNumarasi;
        private DevExpress.XtraEditors.TextEdit text1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsStokHareket;
        private MyDataSet myDataSet;
        private MyDataSetTableAdapters.tblStokHareketTableAdapter tblStokHareketTableAdapter;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection con;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private DevExpress.XtraEditors.TextEdit txtCariHesap;
        private DevExpress.XtraEditors.TextEdit txtKdvToplam;
        private DevExpress.XtraEditors.TextEdit txtGenelToplam;
        private DevExpress.XtraEditors.TextEdit txtAraToplam;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.DateEdit dtpFaturaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketID;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokID;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimID;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvTutari;
        private System.Windows.Forms.BindingSource bsFatura;
        private MyDataSetTableAdapters.tblFaturaTableAdapter tblFaturaTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmbFatura;
        private System.Windows.Forms.ToolStripMenuItem stokSec;
        private System.Windows.Forms.ToolStripMenuItem stokCikart;
        private System.Windows.Forms.ToolStripMenuItem cariHesapSec;
        private System.Windows.Forms.ToolStripMenuItem cariHesapCikart;
        private MyDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        public System.Data.SqlClient.SqlDataAdapter adpFatura;
        public System.Data.SqlClient.SqlDataAdapter adpStokHareket;
    }
}