namespace NTP
{
    partial class frmStokMalzemeCesidi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokMalzemeCesidi));
            this.btEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMalzemeAdi = new System.Windows.Forms.TextBox();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.tbMarkasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gvMalzemeler = new System.Windows.Forms.DataGridView();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMalzemeleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verilerimDataSet = new NTP.verilerimDataSet();
            this.stokMalzemeleriTableAdapter = new NTP.verilerimDataSetTableAdapters.stokMalzemeleriTableAdapter();
            this.kullanicilarTableAdapter1 = new NTP.verilerimDataSetTableAdapters.kullanicilarTableAdapter();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMalzemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokMalzemeleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilerimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btEkle
            // 
            this.btEkle.ContextMenuStrip = this.contextMenuStrip1;
            this.btEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(22, 138);
            this.btEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(373, 37);
            this.btEkle.TabIndex = 0;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem1.Text = "Sil";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Malzeme Adı:";
            // 
            // tbMalzemeAdi
            // 
            this.tbMalzemeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMalzemeAdi.Location = new System.Drawing.Point(229, 19);
            this.tbMalzemeAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMalzemeAdi.Name = "tbMalzemeAdi";
            this.tbMalzemeAdi.Size = new System.Drawing.Size(167, 29);
            this.tbMalzemeAdi.TabIndex = 2;
            // 
            // cbBirim
            // 
            this.cbBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Items.AddRange(new object[] {
            "Kg",
            "Tepsi",
            "Adet"});
            this.cbBirim.Location = new System.Drawing.Point(229, 56);
            this.cbBirim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(167, 32);
            this.cbBirim.TabIndex = 3;
            // 
            // tbMarkasi
            // 
            this.tbMarkasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMarkasi.Location = new System.Drawing.Point(229, 96);
            this.tbMarkasi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMarkasi.Name = "tbMarkasi";
            this.tbMarkasi.Size = new System.Drawing.Size(167, 29);
            this.tbMarkasi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(108, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Markası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(124, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birimi";
            // 
            // gvMalzemeler
            // 
            this.gvMalzemeler.AllowUserToOrderColumns = true;
            this.gvMalzemeler.AutoGenerateColumns = false;
            this.gvMalzemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMalzemeler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMalzemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.birimDataGridViewTextBoxColumn,
            this.markasiDataGridViewTextBoxColumn});
            this.gvMalzemeler.ContextMenuStrip = this.contextMenuStrip1;
            this.gvMalzemeler.DataSource = this.stokMalzemeleriBindingSource;
            this.gvMalzemeler.Location = new System.Drawing.Point(22, 192);
            this.gvMalzemeler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvMalzemeler.Name = "gvMalzemeler";
            this.gvMalzemeler.RowTemplate.Height = 24;
            this.gvMalzemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMalzemeler.Size = new System.Drawing.Size(373, 122);
            this.gvMalzemeler.TabIndex = 12;
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "malzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "Malzeme Adı";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "Birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            // 
            // markasiDataGridViewTextBoxColumn
            // 
            this.markasiDataGridViewTextBoxColumn.DataPropertyName = "markasi";
            this.markasiDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markasiDataGridViewTextBoxColumn.Name = "markasiDataGridViewTextBoxColumn";
            // 
            // stokMalzemeleriBindingSource
            // 
            this.stokMalzemeleriBindingSource.DataMember = "stokMalzemeleri";
            this.stokMalzemeleriBindingSource.DataSource = this.verilerimDataSet;
            // 
            // verilerimDataSet
            // 
            this.verilerimDataSet.DataSetName = "verilerimDataSet";
            this.verilerimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokMalzemeleriTableAdapter
            // 
            this.stokMalzemeleriTableAdapter.ClearBeforeFill = true;
            // 
            // kullanicilarTableAdapter1
            // 
            this.kullanicilarTableAdapter1.ClearBeforeFill = true;
            // 
            // frmStokMalzemeCesidi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 361);
            this.Controls.Add(this.gvMalzemeler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMarkasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.tbMalzemeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmStokMalzemeCesidi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Malzeme Çeşitleri";
            this.Load += new System.EventHandler(this.frmStokMalzemeCesidi_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMalzemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokMalzemeleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilerimDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMalzemeAdi;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.TextBox tbMarkasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvMalzemeler;
        private verilerimDataSet verilerimDataSet;
        private System.Windows.Forms.BindingSource stokMalzemeleriBindingSource;
        private verilerimDataSetTableAdapters.stokMalzemeleriTableAdapter stokMalzemeleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private verilerimDataSetTableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter1;
    }
}