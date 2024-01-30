
namespace MyStokTakip
{
    partial class Stoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stoklar));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtKdvOrani = new DevExpress.XtraEditors.TextEdit();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.cmbBirim = new DevExpress.XtraEditors.LookUpEdit();
            this.bsBirimler = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyStokTakip.MyDataSet();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.text1 = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsStoklar = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBirimID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKdvOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblStokTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblStokTableAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.con = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adpStok = new System.Data.SqlClient.SqlDataAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblBirimTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblBirimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBirimler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.txtKdvOrani);
            this.splitContainer1.Panel1.Controls.Add(this.txtStokKodu);
            this.splitContainer1.Panel1.Controls.Add(this.txtStokAdi);
            this.splitContainer1.Panel1.Controls.Add(this.txtBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.cmbBirim);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit5);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit4);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit3);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.text1);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 366);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(149, 95);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtFiyat.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtFiyat.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtFiyat.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtFiyat.Properties.ContextImageOptions.SvgImage")));
            this.txtFiyat.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(25, 15);
            this.txtFiyat.Properties.Mask.EditMask = "c";
            this.txtFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFiyat.Size = new System.Drawing.Size(124, 20);
            this.txtFiyat.TabIndex = 38;
            // 
            // txtKdvOrani
            // 
            this.txtKdvOrani.Location = new System.Drawing.Point(149, 119);
            this.txtKdvOrani.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKdvOrani.Name = "txtKdvOrani";
            this.txtKdvOrani.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.txtKdvOrani.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtKdvOrani.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.txtKdvOrani.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtKdvOrani.Properties.ContextImageOptions.SvgImage")));
            this.txtKdvOrani.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(20, 15);
            this.txtKdvOrani.Properties.Mask.EditMask = "d";
            this.txtKdvOrani.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKdvOrani.Size = new System.Drawing.Size(124, 20);
            this.txtKdvOrani.TabIndex = 6;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(149, 73);
            this.txtStokKodu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(124, 20);
            this.txtStokKodu.TabIndex = 4;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(149, 51);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(124, 20);
            this.txtStokAdi.TabIndex = 3;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(149, 29);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(124, 20);
            this.txtBarkod.TabIndex = 2;
            // 
            // cmbBirim
            // 
            this.cmbBirim.Location = new System.Drawing.Point(149, 6);
            this.cmbBirim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBirim.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirimAdi", "Birim Adi", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbBirim.Properties.DataSource = this.bsBirimler;
            this.cmbBirim.Properties.DisplayMember = "BirimAdi";
            this.cmbBirim.Properties.NullText = "";
            this.cmbBirim.Properties.ValueMember = "BirimID";
            this.cmbBirim.Size = new System.Drawing.Size(124, 20);
            this.cmbBirim.TabIndex = 1;
            // 
            // bsBirimler
            // 
            this.bsBirimler.DataMember = "tblBirim";
            this.bsBirimler.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "Barkod";
            this.textEdit5.Enabled = false;
            this.textEdit5.Location = new System.Drawing.Point(10, 28);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit5.Properties.Appearance.Options.UseFont = true;
            this.textEdit5.Size = new System.Drawing.Size(131, 20);
            this.textEdit5.TabIndex = 37;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "Stok Adı";
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(10, 50);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Size = new System.Drawing.Size(131, 20);
            this.textEdit4.TabIndex = 36;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Stok Kodu";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(10, 72);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Size = new System.Drawing.Size(131, 20);
            this.textEdit3.TabIndex = 35;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Kdv Oranı";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(10, 118);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(131, 20);
            this.textEdit2.TabIndex = 34;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Fiyat";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(10, 94);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(131, 20);
            this.textEdit1.TabIndex = 33;
            // 
            // text1
            // 
            this.text1.EditValue = "Birim";
            this.text1.Enabled = false;
            this.text1.Location = new System.Drawing.Point(10, 4);
            this.text1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text1.Name = "text1";
            this.text1.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.text1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text1.Properties.Appearance.Options.UseBackColor = true;
            this.text1.Properties.Appearance.Options.UseFont = true;
            this.text1.Size = new System.Drawing.Size(131, 20);
            this.text1.TabIndex = 32;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(284, 106);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 32);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bsStoklar;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(600, 222);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsStoklar
            // 
            this.bsStoklar.DataMember = "tblStok";
            this.bsStoklar.DataSource = this.myDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBirimID,
            this.colBarkod,
            this.colStokAdi,
            this.colStokKod,
            this.colStokFiyat,
            this.colStokKdvOrani});
            this.gridView1.DetailHeight = 355;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colBirimID
            // 
            this.colBirimID.FieldName = "BirimID";
            this.colBirimID.MinWidth = 19;
            this.colBirimID.Name = "colBirimID";
            this.colBirimID.Visible = true;
            this.colBirimID.VisibleIndex = 0;
            this.colBirimID.Width = 88;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 19;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 1;
            this.colBarkod.Width = 88;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.MinWidth = 19;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 2;
            this.colStokAdi.Width = 88;
            // 
            // colStokKod
            // 
            this.colStokKod.FieldName = "StokKod";
            this.colStokKod.MinWidth = 19;
            this.colStokKod.Name = "colStokKod";
            this.colStokKod.Visible = true;
            this.colStokKod.VisibleIndex = 3;
            this.colStokKod.Width = 88;
            // 
            // colStokFiyat
            // 
            this.colStokFiyat.FieldName = "StokFiyat";
            this.colStokFiyat.MinWidth = 19;
            this.colStokFiyat.Name = "colStokFiyat";
            this.colStokFiyat.Visible = true;
            this.colStokFiyat.VisibleIndex = 4;
            this.colStokFiyat.Width = 88;
            // 
            // colStokKdvOrani
            // 
            this.colStokKdvOrani.FieldName = "StokKdvOrani";
            this.colStokKdvOrani.MinWidth = 19;
            this.colStokKdvOrani.Name = "colStokKdvOrani";
            this.colStokKdvOrani.Visible = true;
            this.colStokKdvOrani.VisibleIndex = 5;
            this.colStokKdvOrani.Width = 88;
            // 
            // tblStokTableAdapter
            // 
            this.tblStokTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select * from tblStok";
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
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 0, "BirimID"),
            new System.Data.SqlClient.SqlParameter("@Barkod", System.Data.SqlDbType.NVarChar, 0, "Barkod"),
            new System.Data.SqlClient.SqlParameter("@StokAdi", System.Data.SqlDbType.NVarChar, 0, "StokAdi"),
            new System.Data.SqlClient.SqlParameter("@StokKod", System.Data.SqlDbType.NVarChar, 0, "StokKod"),
            new System.Data.SqlClient.SqlParameter("@StokFiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "StokFiyat", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@StokKdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "StokKdvOrani", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.con;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 0, "BirimID"),
            new System.Data.SqlClient.SqlParameter("@Barkod", System.Data.SqlDbType.NVarChar, 0, "Barkod"),
            new System.Data.SqlClient.SqlParameter("@StokAdi", System.Data.SqlDbType.NVarChar, 0, "StokAdi"),
            new System.Data.SqlClient.SqlParameter("@StokKod", System.Data.SqlDbType.NVarChar, 0, "StokKod"),
            new System.Data.SqlClient.SqlParameter("@StokFiyat", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "StokFiyat", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@StokKdvOrani", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "StokKdvOrani", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_SotkID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SotkID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@SotkID", System.Data.SqlDbType.Int, 4, "SotkID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [tblStok] WHERE (([SotkID] = @Original_SotkID))";
            this.sqlDeleteCommand1.Connection = this.con;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_SotkID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SotkID", System.Data.DataRowVersion.Original, null)});
            // 
            // adpStok
            // 
            this.adpStok.DeleteCommand = this.sqlDeleteCommand1;
            this.adpStok.InsertCommand = this.sqlInsertCommand1;
            this.adpStok.SelectCommand = this.sqlSelectCommand1;
            this.adpStok.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblStok", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SotkID", "SotkID"),
                        new System.Data.Common.DataColumnMapping("BirimID", "BirimID"),
                        new System.Data.Common.DataColumnMapping("Barkod", "Barkod"),
                        new System.Data.Common.DataColumnMapping("StokAdi", "StokAdi"),
                        new System.Data.Common.DataColumnMapping("StokKod", "StokKod"),
                        new System.Data.Common.DataColumnMapping("StokFiyat", "StokFiyat"),
                        new System.Data.Common.DataColumnMapping("StokKdvOrani", "StokKdvOrani")})});
            this.adpStok.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.iptalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // duzenleToolStripMenuItem
            // 
            this.duzenleToolStripMenuItem.Name = "duzenleToolStripMenuItem";
            this.duzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duzenleToolStripMenuItem.Text = "Düzenle ";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // iptalToolStripMenuItem
            // 
            this.iptalToolStripMenuItem.Name = "iptalToolStripMenuItem";
            this.iptalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iptalToolStripMenuItem.Text = "İptal";
            this.iptalToolStripMenuItem.Click += new System.EventHandler(this.iptalToolStripMenuItem_Click);
            // 
            // tblBirimTableAdapter
            // 
            this.tblBirimTableAdapter.ClearBeforeFill = true;
            // 
            // Stoklar
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Stoklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoklar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stoklar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBirimler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.LookUpEdit cmbBirim;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit text1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtKdvOrani;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsStoklar;
        private MyDataSet myDataSet;
        private MyDataSetTableAdapters.tblStokTableAdapter tblStokTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimID;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKod;
        private DevExpress.XtraGrid.Columns.GridColumn colStokFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKdvOrani;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection con;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter adpStok;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem duzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsBirimler;
        private MyDataSetTableAdapters.tblBirimTableAdapter tblBirimTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
    }
}