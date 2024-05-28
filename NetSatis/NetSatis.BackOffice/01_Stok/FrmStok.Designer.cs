
namespace NetSatis.BackOffice._01_Stok
{
    partial class FrmStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStok));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.bynAra = new System.Windows.Forms.Button();
            this.bynGuncelle = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKapatm = new System.Windows.Forms.Button();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btnFiltreleKapat = new System.Windows.Forms.Button();
            this.btn_filterKapat = new System.Windows.Forms.Button();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stokKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAltGrupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozelKod1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozelKod2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiSüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ureticiKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisKdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisKdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisFiyati1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisFiyati2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyati1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyati2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minStokMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxStokMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1274, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stok Kartları";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKapatm);
            this.groupBox1.Controls.Add(this.bynAra);
            this.groupBox1.Controls.Add(this.bynGuncelle);
            this.groupBox1.Controls.Add(this.btnKopyala);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnDuzenle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 559);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1274, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 11;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(12, 49);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 49);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.ImageIndex = 10;
            this.btnDuzenle.ImageList = this.ımageList1;
            this.btnDuzenle.Location = new System.Drawing.Point(115, 49);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(97, 49);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 13;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(218, 49);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 49);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // bynAra
            // 
            this.bynAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bynAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bynAra.ImageIndex = 15;
            this.bynAra.ImageList = this.ımageList1;
            this.bynAra.Location = new System.Drawing.Point(529, 49);
            this.bynAra.Name = "bynAra";
            this.bynAra.Size = new System.Drawing.Size(97, 49);
            this.bynAra.TabIndex = 9;
            this.bynAra.Text = "Ara";
            this.bynAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bynAra.UseVisualStyleBackColor = true;
            this.bynAra.Click += new System.EventHandler(this.bynAra_Click);
            // 
            // bynGuncelle
            // 
            this.bynGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bynGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bynGuncelle.ImageIndex = 8;
            this.bynGuncelle.ImageList = this.ımageList1;
            this.bynGuncelle.Location = new System.Drawing.Point(426, 49);
            this.bynGuncelle.Name = "bynGuncelle";
            this.bynGuncelle.Size = new System.Drawing.Size(97, 49);
            this.bynGuncelle.TabIndex = 8;
            this.bynGuncelle.Text = "Güncelle";
            this.bynGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bynGuncelle.UseVisualStyleBackColor = true;
            this.bynGuncelle.Click += new System.EventHandler(this.bynGuncelle_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKopyala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKopyala.ImageIndex = 12;
            this.btnKopyala.ImageList = this.ımageList1;
            this.btnKopyala.Location = new System.Drawing.Point(323, 49);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(97, 49);
            this.btnKopyala.TabIndex = 7;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "folder_out.png");
            this.ımageList1.Images.SetKeyName(3, "funnel.png");
            this.ımageList1.Images.SetKeyName(4, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(5, "package.png");
            this.ımageList1.Images.SetKeyName(6, "pencil.png");
            this.ımageList1.Images.SetKeyName(7, "redo.png");
            this.ımageList1.Images.SetKeyName(8, "refresh.png");
            this.ımageList1.Images.SetKeyName(9, "replace2.png");
            this.ımageList1.Images.SetKeyName(10, "Stok Düzenle.png");
            this.ımageList1.Images.SetKeyName(11, "Stok Ekle.png");
            this.ımageList1.Images.SetKeyName(12, "Stok Kopyala.png");
            this.ımageList1.Images.SetKeyName(13, "Stok Sil.png");
            this.ımageList1.Images.SetKeyName(14, "StokHareket.png");
            this.ımageList1.Images.SetKeyName(15, "view.png");
            // 
            // BtnKapatm
            // 
            this.BtnKapatm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapatm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKapatm.ImageIndex = 2;
            this.BtnKapatm.ImageList = this.ımageList1;
            this.BtnKapatm.Location = new System.Drawing.Point(1155, 49);
            this.BtnKapatm.Name = "BtnKapatm";
            this.BtnKapatm.Size = new System.Drawing.Size(97, 49);
            this.BtnKapatm.TabIndex = 10;
            this.BtnKapatm.Text = "Kapat";
            this.BtnKapatm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKapatm.UseVisualStyleBackColor = true;
            this.BtnKapatm.Click += new System.EventHandler(this.BtnKapatm_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 49);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_filterKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreleKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltrele);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1274, 510);
            this.splitContainerControl1.SplitterPosition = 256;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.durumuDataGridViewCheckBoxColumn,
            this.stokKoduDataGridViewTextBoxColumn,
            this.stokAdiDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn,
            this.barkodTürüDataGridViewTextBoxColumn,
            this.birimiDataGridViewTextBoxColumn,
            this.stokGrubuDataGridViewTextBoxColumn,
            this.stokAltGrupDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modeliDataGridViewTextBoxColumn,
            this.ozelKod1DataGridViewTextBoxColumn,
            this.ozelKod2DataGridViewTextBoxColumn,
            this.garantiSüresiDataGridViewTextBoxColumn,
            this.ureticiKoduDataGridViewTextBoxColumn,
            this.alisKdvDataGridViewTextBoxColumn,
            this.satisKdvDataGridViewTextBoxColumn,
            this.alisFiyati1DataGridViewTextBoxColumn,
            this.alisFiyati2DataGridViewTextBoxColumn,
            this.satisFiyati1DataGridViewTextBoxColumn,
            this.satisFiyati2DataGridViewTextBoxColumn,
            this.minStokMiktariDataGridViewTextBoxColumn,
            this.maxStokMiktariDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.NodeSeparatorHeight = 2;
            this.filterControl1.ShowActionButtonMode = DevExpress.XtraEditors.ShowActionButtonMode.Default;
            this.filterControl1.Size = new System.Drawing.Size(1274, 256);
            this.filterControl1.SourceControl = this.stokBindingSource;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.ImageIndex = 3;
            this.btnFiltrele.ImageList = this.ımageList1;
            this.btnFiltrele.Location = new System.Drawing.Point(1015, 181);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(75, 58);
            this.btnFiltrele.TabIndex = 1;
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btnFiltreleKapat
            // 
            this.btnFiltreleKapat.ImageIndex = 4;
            this.btnFiltreleKapat.ImageList = this.ımageList1;
            this.btnFiltreleKapat.Location = new System.Drawing.Point(1096, 181);
            this.btnFiltreleKapat.Name = "btnFiltreleKapat";
            this.btnFiltreleKapat.Size = new System.Drawing.Size(75, 58);
            this.btnFiltreleKapat.TabIndex = 2;
            this.btnFiltreleKapat.UseVisualStyleBackColor = true;
            this.btnFiltreleKapat.Click += new System.EventHandler(this.btnFiltreleKapat_Click);
            // 
            // btn_filterKapat
            // 
            this.btn_filterKapat.ImageIndex = 2;
            this.btn_filterKapat.ImageList = this.ımageList1;
            this.btn_filterKapat.Location = new System.Drawing.Point(1177, 181);
            this.btn_filterKapat.Name = "btn_filterKapat";
            this.btn_filterKapat.Size = new System.Drawing.Size(75, 58);
            this.btn_filterKapat.TabIndex = 3;
            this.btn_filterKapat.UseVisualStyleBackColor = true;
            this.btn_filterKapat.Click += new System.EventHandler(this.btn_filterKapat_Click);
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataSource = typeof(NetSatis.Entities.Tables.Stok);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumuDataGridViewCheckBoxColumn
            // 
            this.durumuDataGridViewCheckBoxColumn.DataPropertyName = "Durumu";
            this.durumuDataGridViewCheckBoxColumn.HeaderText = "Durumu";
            this.durumuDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumuDataGridViewCheckBoxColumn.Name = "durumuDataGridViewCheckBoxColumn";
            this.durumuDataGridViewCheckBoxColumn.ReadOnly = true;
            this.durumuDataGridViewCheckBoxColumn.Width = 125;
            // 
            // stokKoduDataGridViewTextBoxColumn
            // 
            this.stokKoduDataGridViewTextBoxColumn.DataPropertyName = "StokKodu";
            this.stokKoduDataGridViewTextBoxColumn.HeaderText = "Stok Kodu";
            this.stokKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokKoduDataGridViewTextBoxColumn.Name = "stokKoduDataGridViewTextBoxColumn";
            this.stokKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokAdiDataGridViewTextBoxColumn
            // 
            this.stokAdiDataGridViewTextBoxColumn.DataPropertyName = "StokAdi";
            this.stokAdiDataGridViewTextBoxColumn.HeaderText = "StokAdi";
            this.stokAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokAdiDataGridViewTextBoxColumn.Name = "stokAdiDataGridViewTextBoxColumn";
            this.stokAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "Barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            this.barkodDataGridViewTextBoxColumn.ReadOnly = true;
            this.barkodDataGridViewTextBoxColumn.Width = 125;
            // 
            // barkodTürüDataGridViewTextBoxColumn
            // 
            this.barkodTürüDataGridViewTextBoxColumn.DataPropertyName = "BarkodTürü";
            this.barkodTürüDataGridViewTextBoxColumn.HeaderText = "BarkodTürü";
            this.barkodTürüDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodTürüDataGridViewTextBoxColumn.Name = "barkodTürüDataGridViewTextBoxColumn";
            this.barkodTürüDataGridViewTextBoxColumn.ReadOnly = true;
            this.barkodTürüDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimiDataGridViewTextBoxColumn
            // 
            this.birimiDataGridViewTextBoxColumn.DataPropertyName = "Birimi";
            this.birimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.birimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimiDataGridViewTextBoxColumn.Name = "birimiDataGridViewTextBoxColumn";
            this.birimiDataGridViewTextBoxColumn.ReadOnly = true;
            this.birimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokGrubuDataGridViewTextBoxColumn
            // 
            this.stokGrubuDataGridViewTextBoxColumn.DataPropertyName = "StokGrubu";
            this.stokGrubuDataGridViewTextBoxColumn.HeaderText = "StokGrubu";
            this.stokGrubuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokGrubuDataGridViewTextBoxColumn.Name = "stokGrubuDataGridViewTextBoxColumn";
            this.stokGrubuDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokGrubuDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokAltGrupDataGridViewTextBoxColumn
            // 
            this.stokAltGrupDataGridViewTextBoxColumn.DataPropertyName = "StokAltGrup";
            this.stokAltGrupDataGridViewTextBoxColumn.HeaderText = "StokAltGrup";
            this.stokAltGrupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokAltGrupDataGridViewTextBoxColumn.Name = "stokAltGrupDataGridViewTextBoxColumn";
            this.stokAltGrupDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokAltGrupDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            this.markaDataGridViewTextBoxColumn.Visible = false;
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeliDataGridViewTextBoxColumn
            // 
            this.modeliDataGridViewTextBoxColumn.DataPropertyName = "Modeli";
            this.modeliDataGridViewTextBoxColumn.HeaderText = "Modeli";
            this.modeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeliDataGridViewTextBoxColumn.Name = "modeliDataGridViewTextBoxColumn";
            this.modeliDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeliDataGridViewTextBoxColumn.Visible = false;
            this.modeliDataGridViewTextBoxColumn.Width = 125;
            // 
            // ozelKod1DataGridViewTextBoxColumn
            // 
            this.ozelKod1DataGridViewTextBoxColumn.DataPropertyName = "OzelKod1";
            this.ozelKod1DataGridViewTextBoxColumn.HeaderText = "OzelKod1";
            this.ozelKod1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ozelKod1DataGridViewTextBoxColumn.Name = "ozelKod1DataGridViewTextBoxColumn";
            this.ozelKod1DataGridViewTextBoxColumn.ReadOnly = true;
            this.ozelKod1DataGridViewTextBoxColumn.Visible = false;
            this.ozelKod1DataGridViewTextBoxColumn.Width = 125;
            // 
            // ozelKod2DataGridViewTextBoxColumn
            // 
            this.ozelKod2DataGridViewTextBoxColumn.DataPropertyName = "OzelKod2";
            this.ozelKod2DataGridViewTextBoxColumn.HeaderText = "OzelKod2";
            this.ozelKod2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ozelKod2DataGridViewTextBoxColumn.Name = "ozelKod2DataGridViewTextBoxColumn";
            this.ozelKod2DataGridViewTextBoxColumn.ReadOnly = true;
            this.ozelKod2DataGridViewTextBoxColumn.Visible = false;
            this.ozelKod2DataGridViewTextBoxColumn.Width = 125;
            // 
            // garantiSüresiDataGridViewTextBoxColumn
            // 
            this.garantiSüresiDataGridViewTextBoxColumn.DataPropertyName = "GarantiSüresi";
            this.garantiSüresiDataGridViewTextBoxColumn.HeaderText = "GarantiSüresi";
            this.garantiSüresiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.garantiSüresiDataGridViewTextBoxColumn.Name = "garantiSüresiDataGridViewTextBoxColumn";
            this.garantiSüresiDataGridViewTextBoxColumn.Visible = false;
            this.garantiSüresiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ureticiKoduDataGridViewTextBoxColumn
            // 
            this.ureticiKoduDataGridViewTextBoxColumn.DataPropertyName = "UreticiKodu";
            this.ureticiKoduDataGridViewTextBoxColumn.HeaderText = "UreticiKodu";
            this.ureticiKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ureticiKoduDataGridViewTextBoxColumn.Name = "ureticiKoduDataGridViewTextBoxColumn";
            this.ureticiKoduDataGridViewTextBoxColumn.Visible = false;
            this.ureticiKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // alisKdvDataGridViewTextBoxColumn
            // 
            this.alisKdvDataGridViewTextBoxColumn.DataPropertyName = "AlisKdv";
            this.alisKdvDataGridViewTextBoxColumn.HeaderText = "AlisKdv";
            this.alisKdvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alisKdvDataGridViewTextBoxColumn.Name = "alisKdvDataGridViewTextBoxColumn";
            this.alisKdvDataGridViewTextBoxColumn.Visible = false;
            this.alisKdvDataGridViewTextBoxColumn.Width = 125;
            // 
            // satisKdvDataGridViewTextBoxColumn
            // 
            this.satisKdvDataGridViewTextBoxColumn.DataPropertyName = "SatisKdv";
            this.satisKdvDataGridViewTextBoxColumn.HeaderText = "SatisKdv";
            this.satisKdvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisKdvDataGridViewTextBoxColumn.Name = "satisKdvDataGridViewTextBoxColumn";
            this.satisKdvDataGridViewTextBoxColumn.Visible = false;
            this.satisKdvDataGridViewTextBoxColumn.Width = 125;
            // 
            // alisFiyati1DataGridViewTextBoxColumn
            // 
            this.alisFiyati1DataGridViewTextBoxColumn.DataPropertyName = "AlisFiyati1";
            this.alisFiyati1DataGridViewTextBoxColumn.HeaderText = "AlisFiyati1";
            this.alisFiyati1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alisFiyati1DataGridViewTextBoxColumn.Name = "alisFiyati1DataGridViewTextBoxColumn";
            this.alisFiyati1DataGridViewTextBoxColumn.Visible = false;
            this.alisFiyati1DataGridViewTextBoxColumn.Width = 125;
            // 
            // alisFiyati2DataGridViewTextBoxColumn
            // 
            this.alisFiyati2DataGridViewTextBoxColumn.DataPropertyName = "AlisFiyati2";
            this.alisFiyati2DataGridViewTextBoxColumn.HeaderText = "AlisFiyati2";
            this.alisFiyati2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alisFiyati2DataGridViewTextBoxColumn.Name = "alisFiyati2DataGridViewTextBoxColumn";
            this.alisFiyati2DataGridViewTextBoxColumn.Visible = false;
            this.alisFiyati2DataGridViewTextBoxColumn.Width = 125;
            // 
            // satisFiyati1DataGridViewTextBoxColumn
            // 
            this.satisFiyati1DataGridViewTextBoxColumn.DataPropertyName = "SatisFiyati1";
            this.satisFiyati1DataGridViewTextBoxColumn.HeaderText = "SatisFiyati1";
            this.satisFiyati1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisFiyati1DataGridViewTextBoxColumn.Name = "satisFiyati1DataGridViewTextBoxColumn";
            this.satisFiyati1DataGridViewTextBoxColumn.Visible = false;
            this.satisFiyati1DataGridViewTextBoxColumn.Width = 125;
            // 
            // satisFiyati2DataGridViewTextBoxColumn
            // 
            this.satisFiyati2DataGridViewTextBoxColumn.DataPropertyName = "SatisFiyati2";
            this.satisFiyati2DataGridViewTextBoxColumn.HeaderText = "SatisFiyati2";
            this.satisFiyati2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisFiyati2DataGridViewTextBoxColumn.Name = "satisFiyati2DataGridViewTextBoxColumn";
            this.satisFiyati2DataGridViewTextBoxColumn.Visible = false;
            this.satisFiyati2DataGridViewTextBoxColumn.Width = 125;
            // 
            // minStokMiktariDataGridViewTextBoxColumn
            // 
            this.minStokMiktariDataGridViewTextBoxColumn.DataPropertyName = "MinStokMiktari";
            this.minStokMiktariDataGridViewTextBoxColumn.HeaderText = "MinStokMiktari";
            this.minStokMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minStokMiktariDataGridViewTextBoxColumn.Name = "minStokMiktariDataGridViewTextBoxColumn";
            this.minStokMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxStokMiktariDataGridViewTextBoxColumn
            // 
            this.maxStokMiktariDataGridViewTextBoxColumn.DataPropertyName = "MaxStokMiktari";
            this.maxStokMiktariDataGridViewTextBoxColumn.HeaderText = "MaxStokMiktari";
            this.maxStokMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxStokMiktariDataGridViewTextBoxColumn.Name = "maxStokMiktariDataGridViewTextBoxColumn";
            this.maxStokMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 669);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmStok";
            this.Text = "Stok Kartları";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKapatm;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button bynAra;
        private System.Windows.Forms.Button bynGuncelle;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Button btn_filterKapat;
        private System.Windows.Forms.Button btnFiltreleKapat;
        private System.Windows.Forms.Button btnFiltrele;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokGrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAltGrupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozelKod1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozelKod2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiSüresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ureticiKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisKdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisKdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisFiyati1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisFiyati2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyati1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyati2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minStokMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxStokMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
    }
}