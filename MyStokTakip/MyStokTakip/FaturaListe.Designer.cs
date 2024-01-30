
namespace MyStokTakip
{
    partial class FaturaListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaListe));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.bsViewFatura = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyStokTakip.MyDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFaturaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAraToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsFaturaListe = new System.Windows.Forms.BindingSource(this.components);
            this.con = new System.Data.SqlClient.SqlConnection();
            this.bsStokHareket = new System.Windows.Forms.BindingSource(this.components);
            this.tblStokHareketTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblStokHareketTableAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.adpStokHareket = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adpFatura = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.tblFaturaTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblFaturaTableAdapter();
            this.view_FaturaTableAdapter = new MyStokTakip.MyDataSetTableAdapters.View_FaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.dgvMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFaturaListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStokHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.dgvMenu;
            this.gridControl1.DataSource = this.bsViewFatura;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1083, 460);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dgvMenu
            // 
            this.dgvMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dgvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDuzenle,
            this.MenuSil,
            this.menuYazdir});
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(133, 76);
            this.dgvMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dgvMenu_ItemClicked);
            // 
            // menuDuzenle
            // 
            this.menuDuzenle.Name = "menuDuzenle";
            this.menuDuzenle.Size = new System.Drawing.Size(132, 24);
            this.menuDuzenle.Text = "Düzenle";
            // 
            // MenuSil
            // 
            this.MenuSil.Name = "MenuSil";
            this.MenuSil.Size = new System.Drawing.Size(132, 24);
            this.MenuSil.Text = "Sil";
            // 
            // menuYazdir
            // 
            this.menuYazdir.Name = "menuYazdir";
            this.menuYazdir.Size = new System.Drawing.Size(132, 24);
            this.menuYazdir.Text = "Yazdır";
            // 
            // bsViewFatura
            // 
            this.bsViewFatura.DataMember = "View_Fatura";
            this.bsViewFatura.DataSource = this.myDataSet;
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
            this.colFaturaNo,
            this.colFaturaTarihi,
            this.colVergiNo,
            this.colAraToplam,
            this.colKdvToplam,
            this.colGenelToplam});
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colFaturaNo
            // 
            this.colFaturaNo.FieldName = "FaturaNo";
            this.colFaturaNo.MinWidth = 25;
            this.colFaturaNo.Name = "colFaturaNo";
            this.colFaturaNo.Visible = true;
            this.colFaturaNo.VisibleIndex = 0;
            this.colFaturaNo.Width = 94;
            // 
            // colFaturaTarihi
            // 
            this.colFaturaTarihi.FieldName = "FaturaTarihi";
            this.colFaturaTarihi.MinWidth = 25;
            this.colFaturaTarihi.Name = "colFaturaTarihi";
            this.colFaturaTarihi.Visible = true;
            this.colFaturaTarihi.VisibleIndex = 1;
            this.colFaturaTarihi.Width = 94;
            // 
            // colUnvan
            // 
            this.colUnvan.FieldName = "Unvan";
            this.colUnvan.MinWidth = 25;
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.Visible = true;
            this.colUnvan.VisibleIndex = 2;
            this.colUnvan.Width = 94;
            // 
            // colVergiNo
            // 
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.MinWidth = 25;
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 3;
            this.colVergiNo.Width = 94;
            // 
            // colAraToplam
            // 
            this.colAraToplam.FieldName = "AraToplam";
            this.colAraToplam.MinWidth = 25;
            this.colAraToplam.Name = "colAraToplam";
            this.colAraToplam.Visible = true;
            this.colAraToplam.VisibleIndex = 4;
            this.colAraToplam.Width = 94;
            // 
            // colKdvToplam
            // 
            this.colKdvToplam.FieldName = "KdvToplam";
            this.colKdvToplam.MinWidth = 25;
            this.colKdvToplam.Name = "colKdvToplam";
            this.colKdvToplam.Visible = true;
            this.colKdvToplam.VisibleIndex = 5;
            this.colKdvToplam.Width = 94;
            // 
            // colGenelToplam
            // 
            this.colGenelToplam.FieldName = "GenelToplam";
            this.colGenelToplam.MinWidth = 25;
            this.colGenelToplam.Name = "colGenelToplam";
            this.colGenelToplam.Visible = true;
            this.colGenelToplam.VisibleIndex = 6;
            this.colGenelToplam.Width = 94;
            // 
            // bsFaturaListe
            // 
            this.bsFaturaListe.DataMember = "tblFatura";
            this.bsFaturaListe.DataSource = this.myDataSet;
            // 
            // con
            // 
            this.con.ConnectionString = "Data Source=LAPTOP-HVN2B3FS\\SQLEXPRESS;Initial Catalog=Stok_takip;Integrated Secu" +
    "rity=True";
            this.con.FireInfoMessageEventOnUserErrors = false;
            // 
            // bsStokHareket
            // 
            this.bsStokHareket.DataMember = "tblStokHareket";
            this.bsStokHareket.DataSource = this.myDataSet;
            // 
            // tblStokHareketTableAdapter
            // 
            this.tblStokHareketTableAdapter.ClearBeforeFill = true;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [tblStokHareket] WHERE (([HareketID] = @Original_HareketID))";
            this.sqlDeleteCommand1.Connection = this.con;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_HareketID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HareketID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.con;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.con;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "select * from tblStokHareket";
            this.sqlSelectCommand2.Connection = this.con;
            // 
            // adpStokHareket
            // 
            this.adpStokHareket.DeleteCommand = this.sqlDeleteCommand1;
            this.adpStokHareket.InsertCommand = this.sqlInsertCommand1;
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
            this.adpStokHareket.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select * from tblFatura";
            this.sqlSelectCommand1.Connection = this.con;
            // 
            // adpFatura
            // 
            this.adpFatura.DeleteCommand = this.sqlDeleteCommand;
            this.adpFatura.InsertCommand = this.sqlInsertCommand;
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
            this.adpFatura.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = "DELETE FROM [tblFatura] WHERE (([FaturaID] = @Original_FaturaID))";
            this.sqlDeleteCommand.Connection = this.con;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FaturaID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = resources.GetString("sqlInsertCommand.CommandText");
            this.sqlInsertCommand.Connection = this.con;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CariID", System.Data.SqlDbType.Int, 0, "CariID"),
            new System.Data.SqlClient.SqlParameter("@FaturaTarihi", System.Data.SqlDbType.DateTime, 0, "FaturaTarihi"),
            new System.Data.SqlClient.SqlParameter("@FaturaNo", System.Data.SqlDbType.NVarChar, 0, "FaturaNo"),
            new System.Data.SqlClient.SqlParameter("@AraToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "AraToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@GenelToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "GenelToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvToplam", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.con;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CariID", System.Data.SqlDbType.Int, 0, "CariID"),
            new System.Data.SqlClient.SqlParameter("@FaturaTarihi", System.Data.SqlDbType.DateTime, 0, "FaturaTarihi"),
            new System.Data.SqlClient.SqlParameter("@FaturaNo", System.Data.SqlDbType.NVarChar, 0, "FaturaNo"),
            new System.Data.SqlClient.SqlParameter("@AraToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "AraToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@GenelToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "GenelToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@KdvToplam", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "KdvToplam", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FaturaID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FaturaID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@FaturaID", System.Data.SqlDbType.Int, 4, "FaturaID")});
            // 
            // tblFaturaTableAdapter
            // 
            this.tblFaturaTableAdapter.ClearBeforeFill = true;
            // 
            // view_FaturaTableAdapter
            // 
            this.view_FaturaTableAdapter.ClearBeforeFill = true;
            // 
            // FaturaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 460);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.Name = "FaturaListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaListe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FaturaListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.dgvMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsViewFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFaturaListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStokHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsFaturaListe;
        private MyDataSet myDataSet;
        private System.Data.SqlClient.SqlConnection con;
        private System.Windows.Forms.ContextMenuStrip dgvMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDuzenle;
        private System.Windows.Forms.ToolStripMenuItem MenuSil;
        private System.Windows.Forms.ToolStripMenuItem menuYazdir;
        private System.Windows.Forms.BindingSource bsStokHareket;
        private MyDataSetTableAdapters.tblStokHareketTableAdapter tblStokHareketTableAdapter;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        public System.Data.SqlClient.SqlDataAdapter adpStokHareket;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter adpFatura;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private MyDataSetTableAdapters.tblFaturaTableAdapter tblFaturaTableAdapter;
        private System.Windows.Forms.BindingSource bsViewFatura;
        private MyDataSetTableAdapters.View_FaturaTableAdapter view_FaturaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAraToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colGenelToplam;
    }
}