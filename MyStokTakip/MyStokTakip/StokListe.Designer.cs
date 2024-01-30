
namespace MyStokTakip
{
    partial class StokListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokListe));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsStokListe = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyStokTakip.MyDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSotkID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.adpStokListe = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStokListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bsStokListe;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // bsStokListe
            // 
            this.bsStokListe.DataMember = "tblStok";
            this.bsStokListe.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSotkID,
            this.colBirimID,
            this.colBarkod,
            this.colStokAdi,
            this.colStokKod,
            this.colStokFiyat,
            this.colStokKdvOrani});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSotkID
            // 
            this.colSotkID.FieldName = "SotkID";
            this.colSotkID.MinWidth = 25;
            this.colSotkID.Name = "colSotkID";
            this.colSotkID.Visible = true;
            this.colSotkID.VisibleIndex = 0;
            this.colSotkID.Width = 117;
            // 
            // colBirimID
            // 
            this.colBirimID.FieldName = "BirimID";
            this.colBirimID.MinWidth = 25;
            this.colBirimID.Name = "colBirimID";
            this.colBirimID.Visible = true;
            this.colBirimID.VisibleIndex = 1;
            this.colBirimID.Width = 117;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 2;
            this.colBarkod.Width = 117;
            // 
            // colStokAdi
            // 
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.MinWidth = 25;
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 3;
            this.colStokAdi.Width = 117;
            // 
            // colStokKod
            // 
            this.colStokKod.FieldName = "StokKod";
            this.colStokKod.MinWidth = 25;
            this.colStokKod.Name = "colStokKod";
            this.colStokKod.Visible = true;
            this.colStokKod.VisibleIndex = 4;
            this.colStokKod.Width = 117;
            // 
            // colStokFiyat
            // 
            this.colStokFiyat.FieldName = "StokFiyat";
            this.colStokFiyat.MinWidth = 25;
            this.colStokFiyat.Name = "colStokFiyat";
            this.colStokFiyat.Visible = true;
            this.colStokFiyat.VisibleIndex = 5;
            this.colStokFiyat.Width = 117;
            // 
            // colStokKdvOrani
            // 
            this.colStokKdvOrani.FieldName = "StokKdvOrani";
            this.colStokKdvOrani.MinWidth = 25;
            this.colStokKdvOrani.Name = "colStokKdvOrani";
            this.colStokKdvOrani.Visible = true;
            this.colStokKdvOrani.VisibleIndex = 6;
            this.colStokKdvOrani.Width = 117;
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
            // adpStokListe
            // 
            this.adpStokListe.DeleteCommand = this.sqlDeleteCommand1;
            this.adpStokListe.InsertCommand = this.sqlInsertCommand1;
            this.adpStokListe.SelectCommand = this.sqlSelectCommand1;
            this.adpStokListe.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblStok", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SotkID", "SotkID"),
                        new System.Data.Common.DataColumnMapping("BirimID", "BirimID"),
                        new System.Data.Common.DataColumnMapping("Barkod", "Barkod"),
                        new System.Data.Common.DataColumnMapping("StokAdi", "StokAdi"),
                        new System.Data.Common.DataColumnMapping("StokKod", "StokKod"),
                        new System.Data.Common.DataColumnMapping("StokFiyat", "StokFiyat"),
                        new System.Data.Common.DataColumnMapping("StokKdvOrani", "StokKdvOrani")})});
            this.adpStokListe.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // StokListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.Name = "StokListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StokListe";
            this.Load += new System.EventHandler(this.StokListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStokListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MyDataSet myDataSet;
        private MyDataSetTableAdapters.tblStokTableAdapter tblStokTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSotkID;
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
        public System.Windows.Forms.BindingSource bsStokListe;
        public System.Data.SqlClient.SqlDataAdapter adpStokListe;
    }
}