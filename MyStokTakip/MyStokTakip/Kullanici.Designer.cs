
namespace MyStokTakip
{
    partial class Kullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbKuallanici = new DevExpress.XtraEditors.LookUpEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.dgvKullanici = new DevExpress.XtraGrid.GridControl();
            this.cmpKullanici = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsKullanici = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyStokTakip.MyDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblKullaniciTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblKullaniciTableAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.con = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adpKullanici = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKuallanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).BeginInit();
            this.cmpKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsKullanici)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbKuallanici);
            this.splitContainer1.Panel1.Controls.Add(this.txtParola);
            this.splitContainer1.Panel1.Controls.Add(this.txtKullaniciAdi);
            this.splitContainer1.Panel1.Controls.Add(this.txtSoyadi);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdi);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit8);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit3);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit4);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit2);
            this.splitContainer1.Panel1.Controls.Add(this.textEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvKullanici);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yönetici",
            "Admin",
            "Üye"});
            this.comboBox1.Location = new System.Drawing.Point(320, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // cmbKuallanici
            // 
            this.cmbKuallanici.EditValue = "Seçiniz";
            this.cmbKuallanici.Location = new System.Drawing.Point(163, 73);
            this.cmbKuallanici.Name = "cmbKuallanici";
            this.cmbKuallanici.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmbKuallanici.Properties.Appearance.Options.UseBackColor = true;
            this.cmbKuallanici.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKuallanici.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unvan", "Unvan")});
            this.cmbKuallanici.Size = new System.Drawing.Size(133, 22);
            this.cmbKuallanici.TabIndex = 31;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(480, 41);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Mask.EditMask = "n";
            this.txtParola.Size = new System.Drawing.Size(133, 22);
            this.txtParola.TabIndex = 23;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(480, 9);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(133, 22);
            this.txtKullaniciAdi.TabIndex = 22;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(163, 41);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Properties.Mask.EditMask = "n";
            this.txtSoyadi.Size = new System.Drawing.Size(133, 22);
            this.txtSoyadi.TabIndex = 20;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(163, 9);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(133, 22);
            this.txtAdi.TabIndex = 19;
            // 
            // textEdit8
            // 
            this.textEdit8.EditValue = "Parola";
            this.textEdit8.Enabled = false;
            this.textEdit8.Location = new System.Drawing.Point(320, 41);
            this.textEdit8.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.ReadOnly = true;
            this.textEdit8.Size = new System.Drawing.Size(133, 22);
            this.textEdit8.TabIndex = 29;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Kuallanıcı Adı";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(320, 9);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(133, 22);
            this.textEdit3.TabIndex = 28;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "Unvanı";
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(7, 73);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(133, 22);
            this.textEdit4.TabIndex = 27;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Soyadı";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(7, 41);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(133, 22);
            this.textEdit2.TabIndex = 26;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Adı";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(7, 9);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(133, 22);
            this.textEdit1.TabIndex = 25;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(480, 76);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 40);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgvKullanici
            // 
            this.dgvKullanici.ContextMenuStrip = this.cmpKullanici;
            this.dgvKullanici.DataSource = this.bsKullanici;
            this.dgvKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKullanici.Location = new System.Drawing.Point(0, 0);
            this.dgvKullanici.MainView = this.gridView1;
            this.dgvKullanici.Name = "dgvKullanici";
            this.dgvKullanici.Size = new System.Drawing.Size(800, 328);
            this.dgvKullanici.TabIndex = 0;
            this.dgvKullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmpKullanici
            // 
            this.cmpKullanici.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmpKullanici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzeltToolStripMenuItem,
            this.silToolStripMenuItem,
            this.iptalToolStripMenuItem});
            this.cmpKullanici.Name = "cmpKullanici";
            this.cmpKullanici.Size = new System.Drawing.Size(122, 76);
            this.cmpKullanici.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmpKullanici_ItemClicked);
            // 
            // düzeltToolStripMenuItem
            // 
            this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
            this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.düzeltToolStripMenuItem.Text = "Düzelt";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // iptalToolStripMenuItem
            // 
            this.iptalToolStripMenuItem.Name = "iptalToolStripMenuItem";
            this.iptalToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.iptalToolStripMenuItem.Text = "İptal";
            // 
            // bsKullanici
            // 
            this.bsKullanici.DataMember = "tblKullanici";
            this.bsKullanici.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colSoyadi,
            this.colUnvani,
            this.colKullaniciAdi,
            this.colSifre});
            this.gridView1.GridControl = this.dgvKullanici;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colAdi
            // 
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 94;
            // 
            // colSoyadi
            // 
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.MinWidth = 25;
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 94;
            // 
            // colUnvani
            // 
            this.colUnvani.FieldName = "Unvani";
            this.colUnvani.MinWidth = 25;
            this.colUnvani.Name = "colUnvani";
            this.colUnvani.Visible = true;
            this.colUnvani.VisibleIndex = 2;
            this.colUnvani.Width = 94;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.MinWidth = 25;
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 3;
            this.colKullaniciAdi.Width = 94;
            // 
            // colSifre
            // 
            this.colSifre.FieldName = "Sifre";
            this.colSifre.MinWidth = 25;
            this.colSifre.Name = "colSifre";
            this.colSifre.Visible = true;
            this.colSifre.VisibleIndex = 4;
            this.colSifre.Width = 94;
            // 
            // tblKullaniciTableAdapter
            // 
            this.tblKullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select * from tblKullanici";
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
            new System.Data.SqlClient.SqlParameter("@Adi", System.Data.SqlDbType.NVarChar, 0, "Adi"),
            new System.Data.SqlClient.SqlParameter("@Soyadi", System.Data.SqlDbType.NVarChar, 0, "Soyadi"),
            new System.Data.SqlClient.SqlParameter("@Unvani", System.Data.SqlDbType.NVarChar, 0, "Unvani"),
            new System.Data.SqlClient.SqlParameter("@KullaniciAdi", System.Data.SqlDbType.NVarChar, 0, "KullaniciAdi"),
            new System.Data.SqlClient.SqlParameter("@Sifre", System.Data.SqlDbType.NVarChar, 0, "Sifre")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.con;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Adi", System.Data.SqlDbType.NVarChar, 0, "Adi"),
            new System.Data.SqlClient.SqlParameter("@Soyadi", System.Data.SqlDbType.NVarChar, 0, "Soyadi"),
            new System.Data.SqlClient.SqlParameter("@Unvani", System.Data.SqlDbType.NVarChar, 0, "Unvani"),
            new System.Data.SqlClient.SqlParameter("@KullaniciAdi", System.Data.SqlDbType.NVarChar, 0, "KullaniciAdi"),
            new System.Data.SqlClient.SqlParameter("@Sifre", System.Data.SqlDbType.NVarChar, 0, "Sifre"),
            new System.Data.SqlClient.SqlParameter("@Original_KullaniciID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KullaniciID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@KullaniciID", System.Data.SqlDbType.Int, 4, "KullaniciID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [tblKullanici] WHERE (([KullaniciID] = @Original_KullaniciID))";
            this.sqlDeleteCommand1.Connection = this.con;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_KullaniciID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KullaniciID", System.Data.DataRowVersion.Original, null)});
            // 
            // adpKullanici
            // 
            this.adpKullanici.DeleteCommand = this.sqlDeleteCommand1;
            this.adpKullanici.InsertCommand = this.sqlInsertCommand1;
            this.adpKullanici.SelectCommand = this.sqlSelectCommand1;
            this.adpKullanici.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblKullanici", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("KullaniciID", "KullaniciID"),
                        new System.Data.Common.DataColumnMapping("Adi", "Adi"),
                        new System.Data.Common.DataColumnMapping("Soyadi", "Soyadi"),
                        new System.Data.Common.DataColumnMapping("Unvani", "Unvani"),
                        new System.Data.Common.DataColumnMapping("KullaniciAdi", "KullaniciAdi"),
                        new System.Data.Common.DataColumnMapping("Sifre", "Sifre")})});
            this.adpKullanici.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Kullanici
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Kullanici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbKuallanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).EndInit();
            this.cmpKullanici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl dgvKullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsKullanici;
        private MyDataSet myDataSet;
        private MyDataSetTableAdapters.tblKullaniciTableAdapter tblKullaniciTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvani;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSifre;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LookUpEdit cmbKuallanici;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection con;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter adpKullanici;
        private System.Windows.Forms.ContextMenuStrip cmpKullanici;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}