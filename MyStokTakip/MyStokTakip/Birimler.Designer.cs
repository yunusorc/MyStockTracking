
namespace MyStokTakip
{
    partial class Birimler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Birimler));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtBirim = new DevExpress.XtraEditors.TextEdit();
            this.text1 = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsBirimler = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyStokTakip.MyDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBirimAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblBirimTableAdapter = new MyStokTakip.MyDataSetTableAdapters.tblBirimTableAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.con = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adpBirimler = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBirimler)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtBirim);
            this.splitContainer1.Panel1.Controls.Add(this.text1);
            this.splitContainer1.Panel1.Controls.Add(this.btnKaydet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(355, 489);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(173, 13);
            this.txtBirim.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(140, 22);
            this.txtBirim.TabIndex = 1;
            // 
            // text1
            // 
            this.text1.EditValue = "Birim";
            this.text1.Enabled = false;
            this.text1.Location = new System.Drawing.Point(26, 13);
            this.text1.Margin = new System.Windows.Forms.Padding(4);
            this.text1.Name = "text1";
            this.text1.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.text1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text1.Properties.Appearance.Options.UseBackColor = true;
            this.text1.Properties.Appearance.Options.UseFont = true;
            this.text1.Size = new System.Drawing.Size(140, 24);
            this.text1.TabIndex = 30;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(173, 43);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.bsBirimler;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(355, 398);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenltToolStripMenuItem,
            this.silToolStripMenuItem,
            this.iptalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 76);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // düzenltToolStripMenuItem
            // 
            this.düzenltToolStripMenuItem.Name = "düzenltToolStripMenuItem";
            this.düzenltToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.düzenltToolStripMenuItem.Text = "Düzenlt ";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.silToolStripMenuItem.Text = "Sil ";
            // 
            // iptalToolStripMenuItem
            // 
            this.iptalToolStripMenuItem.Name = "iptalToolStripMenuItem";
            this.iptalToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.iptalToolStripMenuItem.Text = "İptal";
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBirimAdi});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colBirimAdi
            // 
            this.colBirimAdi.FieldName = "BirimAdi";
            this.colBirimAdi.MinWidth = 25;
            this.colBirimAdi.Name = "colBirimAdi";
            this.colBirimAdi.Visible = true;
            this.colBirimAdi.VisibleIndex = 0;
            this.colBirimAdi.Width = 117;
            // 
            // tblBirimTableAdapter
            // 
            this.tblBirimTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "select * from tblBirim";
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
            this.sqlInsertCommand1.CommandText = "INSERT INTO [tblBirim] ([BirimAdi]) VALUES (@BirimAdi);\r\nSELECT BirimID, BirimAdi" +
    " FROM tblBirim WHERE (BirimID = SCOPE_IDENTITY())";
            this.sqlInsertCommand1.Connection = this.con;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@BirimAdi", System.Data.SqlDbType.NVarChar, 0, "BirimAdi")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "UPDATE [tblBirim] SET [BirimAdi] = @BirimAdi WHERE (([BirimID] = @Original_BirimI" +
    "D));\r\nSELECT BirimID, BirimAdi FROM tblBirim WHERE (BirimID = @BirimID)";
            this.sqlUpdateCommand1.Connection = this.con;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@BirimAdi", System.Data.SqlDbType.NVarChar, 0, "BirimAdi"),
            new System.Data.SqlClient.SqlParameter("@Original_BirimID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirimID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@BirimID", System.Data.SqlDbType.Int, 4, "BirimID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [tblBirim] WHERE (([BirimID] = @Original_BirimID))";
            this.sqlDeleteCommand1.Connection = this.con;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_BirimID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BirimID", System.Data.DataRowVersion.Original, null)});
            // 
            // adpBirimler
            // 
            this.adpBirimler.DeleteCommand = this.sqlDeleteCommand1;
            this.adpBirimler.InsertCommand = this.sqlInsertCommand1;
            this.adpBirimler.SelectCommand = this.sqlSelectCommand1;
            this.adpBirimler.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tblBirim", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("BirimID", "BirimID"),
                        new System.Data.Common.DataColumnMapping("BirimAdi", "BirimAdi")})});
            this.adpBirimler.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Birimler
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 489);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "Birimler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Birimler_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsBirimler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtBirim;
        private DevExpress.XtraEditors.TextEdit text1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsBirimler;
        private MyDataSet myDataSet;
        private MyDataSetTableAdapters.tblBirimTableAdapter tblBirimTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimAdi;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection con;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter adpBirimler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalToolStripMenuItem;
    }
}