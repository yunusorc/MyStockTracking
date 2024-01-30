
namespace MyStokTakip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtMailAdresi = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiNo = new DevExpress.XtraEditors.TextEdit();
            this.txtUnvan = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dgvCariHesap = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsCariHesaplar = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyStokTakip.MyDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblCariHesaplarTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblCariHesaplarTableAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.con = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adpCariHesaplar = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariHesap)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCariHesaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.txtMailAdresi);
            this.splitContainer1.Panel1.Controls.Add(this.txtTelefon);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdres);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiDairesi);
            this.splitContainer1.Panel1.Controls.Add(this.txtVergiNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtUnvan);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit7);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit8);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit3);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit4);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCariHesap);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(647, 58);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 40);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(496, 76);
            this.txtMailAdresi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(133, 22);
            this.txtMailAdresi.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(496, 44);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Mask.EditMask = "d";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTelefon.Size = new System.Drawing.Size(133, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(496, 12);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(133, 22);
            this.txtAdres.TabIndex = 4;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(179, 76);
            this.txtVergiDairesi.Margin = new System.Windows.Forms.Padding(4);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Properties.Mask.EditMask = "d";
            this.txtVergiDairesi.Size = new System.Drawing.Size(133, 22);
            this.txtVergiDairesi.TabIndex = 3;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(179, 44);
            this.txtVergiNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Properties.Mask.EditMask = "d";
            this.txtVergiNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVergiNo.Size = new System.Drawing.Size(133, 22);
            this.txtVergiNo.TabIndex = 2;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(179, 12);
            this.txtUnvan.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(133, 22);
            this.txtUnvan.TabIndex = 1;
            // 
            // textEdit7
            // 
            this.textEdit7.EditValue = "Mail adresi";
            this.textEdit7.Enabled = false;
            this.textEdit7.Location = new System.Drawing.Point(336, 76);
            this.textEdit7.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.ReadOnly = true;
            this.textEdit7.Size = new System.Drawing.Size(133, 22);
            this.textEdit7.TabIndex = 18;
            // 
            // textEdit8
            // 
            this.textEdit8.EditValue = "Telefon";
            this.textEdit8.Enabled = false;
            this.textEdit8.Location = new System.Drawing.Point(336, 44);
            this.textEdit8.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.ReadOnly = true;
            this.textEdit8.Size = new System.Drawing.Size(133, 22);
            this.textEdit8.TabIndex = 17;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Adres";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(336, 12);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(133, 22);
            this.textEdit3.TabIndex = 16;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "Vergi dairesi";
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(23, 76);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(133, 22);
            this.textEdit4.TabIndex = 15;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Vergi numarası";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(23, 44);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(133, 22);
            this.textEdit2.TabIndex = 14;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Ünvan";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(23, 12);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(133, 22);
            this.textEdit1.TabIndex = 13;
            // 
            // dgvCariHesap
            // 
            this.dgvCariHesap.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCariHesap.DataSource = this.bsCariHesaplar;
            this.dgvCariHesap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCariHesap.Location = new System.Drawing.Point(0, 0);
            this.dgvCariHesap.MainView = this.gridView1;
            this.dgvCariHesap.Name = "dgvCariHesap";
            this.dgvCariHesap.Size = new System.Drawing.Size(800, 346);
            this.dgvCariHesap.TabIndex = 0;
            this.dgvCariHesap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzeltToolStripMenuItem,
            this.silToolStripMenuItem,
            this.iptalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 76);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // düzeltToolStripMenuItem
            // 
            this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
            this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.düzeltToolStripMenuItem.Text = "Düzelt ";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // iptalToolStripMenuItem
            // 
            this.iptalToolStripMenuItem.Name = "iptalToolStripMenuItem";
            this.iptalToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.iptalToolStripMenuItem.Text = "İptal";
            // 
            // bsCariHesaplar
            // 
            this.bsCariHesaplar.DataMember = "tblCariHesaplar";
            this.bsCariHesaplar.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnvan,
            this.colVergiNo,
            this.colVergiDairesi,
            this.colAdres,
            this.colTelefon,
            this.colMail});
            this.gridView1.GridControl = this.dgvCariHesap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colUnvan
            // 
            this.colUnvan.FieldName = "Unvan";
            this.colUnvan.MinWidth = 25;
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.Visible = true;
            this.colUnvan.VisibleIndex = 0;
            this.colUnvan.Width = 94;
            // 
            // colVergiNo
            // 
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.MinWidth = 25;
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 1;
            this.colVergiNo.Width = 94;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.MinWidth = 25;
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 2;
            this.colVergiDairesi.Width = 94;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.MinWidth = 25;
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 3;
            this.colAdres.Width = 94;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.MinWidth = 25;
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 4;
            this.colTelefon.Width = 94;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.MinWidth = 25;
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 5;
            this.colMail.Width = 94;
            // 
            // tblCariHesaplarTableAdapter
            // 
            this.tblCariHesaplarTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select * from tblCariHesaplar";
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
            new System.Data.SqlClient.SqlParameter("@Unvan", System.Data.SqlDbType.NVarChar, 0, "Unvan"),
            new System.Data.SqlClient.SqlParameter("@VergiNo", System.Data.SqlDbType.NVarChar, 0, "VergiNo"),
            new System.Data.SqlClient.SqlParameter("@VergiDairesi", System.Data.SqlDbType.NVarChar, 0, "VergiDairesi"),
            new System.Data.SqlClient.SqlParameter("@Adres", System.Data.SqlDbType.NVarChar, 0, "Adres"),
            new System.Data.SqlClient.SqlParameter("@Telefon", System.Data.SqlDbType.NVarChar, 0, "Telefon"),
            new System.Data.SqlClient.SqlParameter("@Mail", System.Data.SqlDbType.NVarChar, 0, "Mail")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.con;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Unvan", System.Data.SqlDbType.NVarChar, 0, "Unvan"),
            new System.Data.SqlClient.SqlParameter("@VergiNo", System.Data.SqlDbType.NVarChar, 0, "VergiNo"),
            new System.Data.SqlClient.SqlParameter("@VergiDairesi", System.Data.SqlDbType.NVarChar, 0, "VergiDairesi"),
            new System.Data.SqlClient.SqlParameter("@Adres", System.Data.SqlDbType.NVarChar, 0, "Adres"),
            new System.Data.SqlClient.SqlParameter("@Telefon", System.Data.SqlDbType.NVarChar, 0, "Telefon"),
            new System.Data.SqlClient.SqlParameter("@Mail", System.Data.SqlDbType.NVarChar, 0, "Mail"),
            new System.Data.SqlClient.SqlParameter("@Original_CariID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CariID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Unvan", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Unvan", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Unvan", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Unvan", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VergiNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VergiNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VergiNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VergiNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VergiDairesi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VergiDairesi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VergiDairesi", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VergiDairesi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Adres", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Adres", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Adres", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adres", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Telefon", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefon", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Telefon", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mail", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mail", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mail", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mail", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@CariID", System.Data.SqlDbType.Int, 4, "CariID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.con;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CariID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CariID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Unvan", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Unvan", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Unvan", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Unvan", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VergiNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VergiNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VergiNo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VergiNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VergiDairesi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VergiDairesi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VergiDairesi", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VergiDairesi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Adres", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Adres", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Adres", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adres", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Telefon", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefon", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Telefon", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mail", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mail", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mail", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mail", System.Data.DataRowVersion.Original, null)});
            // 
            // adpCariHesaplar
            // 
            this.adpCariHesaplar.DeleteCommand = this.sqlDeleteCommand1;
            this.adpCariHesaplar.InsertCommand = this.sqlInsertCommand1;
            this.adpCariHesaplar.SelectCommand = this.sqlSelectCommand1;
            this.adpCariHesaplar.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblCariHesaplar", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CariID", "CariID"),
                        new System.Data.Common.DataColumnMapping("Unvan", "Unvan"),
                        new System.Data.Common.DataColumnMapping("VergiNo", "VergiNo"),
                        new System.Data.Common.DataColumnMapping("VergiDairesi", "VergiDairesi"),
                        new System.Data.Common.DataColumnMapping("Adres", "Adres"),
                        new System.Data.Common.DataColumnMapping("Telefon", "Telefon"),
                        new System.Data.Common.DataColumnMapping("Mail", "Mail")})});
            this.adpCariHesaplar.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hesaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariHesap)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsCariHesaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtMailAdresi;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.TextEdit txtVergiNo;
        private DevExpress.XtraEditors.TextEdit txtUnvan;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl dgvCariHesap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsCariHesaplar;
        private MyDataSet myDataSet;
        private MyDataSetTableAdapters.tblCariHesaplarTableAdapter tblCariHesaplarTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection con;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter adpCariHesaplar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalToolStripMenuItem;
    }
}