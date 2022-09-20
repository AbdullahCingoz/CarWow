namespace AnaBayim
{
    partial class Urunler
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
            this.lbl_pID = new System.Windows.Forms.Label();
            this.lbl_pName = new System.Windows.Forms.Label();
            this.lbl_cName = new System.Windows.Forms.Label();
            this.lbl_bName = new System.Windows.Forms.Label();
            this.lbl_pDescription = new System.Windows.Forms.Label();
            this.lbl_pStock = new System.Windows.Forms.Label();
            this.lbl_pPrice = new System.Windows.Forms.Label();
            this.lbl_pStatus = new System.Windows.Forms.Label();
            this.lbl_pCoverImage = new System.Windows.Forms.Label();
            this.tb_pID = new System.Windows.Forms.TextBox();
            this.tb_pName = new System.Windows.Forms.TextBox();
            this.tb_pDescription = new System.Windows.Forms.TextBox();
            this.tb_pStock = new System.Windows.Forms.TextBox();
            this.tb_pPrice = new System.Windows.Forms.TextBox();
            this.tb_pCoverImage = new System.Windows.Forms.TextBox();
            this.cb_pStatus = new System.Windows.Forms.CheckBox();
            this.lbl_pCreationDay = new System.Windows.Forms.Label();
            this.tb_CreationDay = new System.Windows.Forms.TextBox();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_pEkle = new System.Windows.Forms.Button();
            this.btn_XML = new System.Windows.Forms.Button();
            this.btn_pGuncelle = new System.Windows.Forms.Button();
            this.cmb_pBrand = new System.Windows.Forms.ComboBox();
            this.cmb_pCategory = new System.Windows.Forms.ComboBox();
            this.pb_pCoverImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_selectProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pCoverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pID
            // 
            this.lbl_pID.AutoSize = true;
            this.lbl_pID.Location = new System.Drawing.Point(53, 37);
            this.lbl_pID.Name = "lbl_pID";
            this.lbl_pID.Size = new System.Drawing.Size(18, 13);
            this.lbl_pID.TabIndex = 0;
            this.lbl_pID.Text = "ID";
            // 
            // lbl_pName
            // 
            this.lbl_pName.AutoSize = true;
            this.lbl_pName.Location = new System.Drawing.Point(23, 74);
            this.lbl_pName.Name = "lbl_pName";
            this.lbl_pName.Size = new System.Drawing.Size(48, 13);
            this.lbl_pName.TabIndex = 1;
            this.lbl_pName.Text = "Ürün Adı";
            // 
            // lbl_cName
            // 
            this.lbl_cName.AutoSize = true;
            this.lbl_cName.Location = new System.Drawing.Point(7, 113);
            this.lbl_cName.Name = "lbl_cName";
            this.lbl_cName.Size = new System.Drawing.Size(64, 13);
            this.lbl_cName.TabIndex = 1;
            this.lbl_cName.Text = "Kategori Adı";
            // 
            // lbl_bName
            // 
            this.lbl_bName.AutoSize = true;
            this.lbl_bName.Location = new System.Drawing.Point(16, 150);
            this.lbl_bName.Name = "lbl_bName";
            this.lbl_bName.Size = new System.Drawing.Size(55, 13);
            this.lbl_bName.TabIndex = 1;
            this.lbl_bName.Text = "Marka Adı";
            // 
            // lbl_pDescription
            // 
            this.lbl_pDescription.AutoSize = true;
            this.lbl_pDescription.Location = new System.Drawing.Point(23, 187);
            this.lbl_pDescription.Name = "lbl_pDescription";
            this.lbl_pDescription.Size = new System.Drawing.Size(50, 13);
            this.lbl_pDescription.TabIndex = 1;
            this.lbl_pDescription.Text = "Açıklama";
            // 
            // lbl_pStock
            // 
            this.lbl_pStock.AutoSize = true;
            this.lbl_pStock.Location = new System.Drawing.Point(369, 37);
            this.lbl_pStock.Name = "lbl_pStock";
            this.lbl_pStock.Size = new System.Drawing.Size(29, 13);
            this.lbl_pStock.TabIndex = 1;
            this.lbl_pStock.Text = "Stok";
            // 
            // lbl_pPrice
            // 
            this.lbl_pPrice.AutoSize = true;
            this.lbl_pPrice.Location = new System.Drawing.Point(369, 74);
            this.lbl_pPrice.Name = "lbl_pPrice";
            this.lbl_pPrice.Size = new System.Drawing.Size(29, 13);
            this.lbl_pPrice.TabIndex = 1;
            this.lbl_pPrice.Text = "Fiyat";
            // 
            // lbl_pStatus
            // 
            this.lbl_pStatus.AutoSize = true;
            this.lbl_pStatus.Location = new System.Drawing.Point(369, 113);
            this.lbl_pStatus.Name = "lbl_pStatus";
            this.lbl_pStatus.Size = new System.Drawing.Size(38, 13);
            this.lbl_pStatus.TabIndex = 1;
            this.lbl_pStatus.Text = "Durum";
            // 
            // lbl_pCoverImage
            // 
            this.lbl_pCoverImage.AutoSize = true;
            this.lbl_pCoverImage.Location = new System.Drawing.Point(369, 162);
            this.lbl_pCoverImage.Name = "lbl_pCoverImage";
            this.lbl_pCoverImage.Size = new System.Drawing.Size(36, 13);
            this.lbl_pCoverImage.TabIndex = 1;
            this.lbl_pCoverImage.Text = "Resim";
            // 
            // tb_pID
            // 
            this.tb_pID.Enabled = false;
            this.tb_pID.Location = new System.Drawing.Point(86, 34);
            this.tb_pID.Name = "tb_pID";
            this.tb_pID.Size = new System.Drawing.Size(100, 20);
            this.tb_pID.TabIndex = 2;
            // 
            // tb_pName
            // 
            this.tb_pName.Location = new System.Drawing.Point(86, 71);
            this.tb_pName.Name = "tb_pName";
            this.tb_pName.Size = new System.Drawing.Size(100, 20);
            this.tb_pName.TabIndex = 2;
            // 
            // tb_pDescription
            // 
            this.tb_pDescription.Location = new System.Drawing.Point(86, 180);
            this.tb_pDescription.Multiline = true;
            this.tb_pDescription.Name = "tb_pDescription";
            this.tb_pDescription.Size = new System.Drawing.Size(213, 93);
            this.tb_pDescription.TabIndex = 2;
            // 
            // tb_pStock
            // 
            this.tb_pStock.Location = new System.Drawing.Point(430, 34);
            this.tb_pStock.Name = "tb_pStock";
            this.tb_pStock.Size = new System.Drawing.Size(100, 20);
            this.tb_pStock.TabIndex = 2;
            // 
            // tb_pPrice
            // 
            this.tb_pPrice.Location = new System.Drawing.Point(430, 67);
            this.tb_pPrice.Name = "tb_pPrice";
            this.tb_pPrice.Size = new System.Drawing.Size(100, 20);
            this.tb_pPrice.TabIndex = 2;
            // 
            // tb_pCoverImage
            // 
            this.tb_pCoverImage.Location = new System.Drawing.Point(430, 155);
            this.tb_pCoverImage.Name = "tb_pCoverImage";
            this.tb_pCoverImage.Size = new System.Drawing.Size(100, 20);
            this.tb_pCoverImage.TabIndex = 2;
            // 
            // cb_pStatus
            // 
            this.cb_pStatus.AutoSize = true;
            this.cb_pStatus.Location = new System.Drawing.Point(430, 113);
            this.cb_pStatus.Name = "cb_pStatus";
            this.cb_pStatus.Size = new System.Drawing.Size(15, 14);
            this.cb_pStatus.TabIndex = 3;
            this.cb_pStatus.UseVisualStyleBackColor = true;
            // 
            // lbl_pCreationDay
            // 
            this.lbl_pCreationDay.AutoSize = true;
            this.lbl_pCreationDay.Location = new System.Drawing.Point(336, 197);
            this.lbl_pCreationDay.Name = "lbl_pCreationDay";
            this.lbl_pCreationDay.Size = new System.Drawing.Size(71, 13);
            this.lbl_pCreationDay.TabIndex = 1;
            this.lbl_pCreationDay.Text = "Ekleme Tarihi";
            // 
            // tb_CreationDay
            // 
            this.tb_CreationDay.Location = new System.Drawing.Point(430, 190);
            this.tb_CreationDay.Name = "tb_CreationDay";
            this.tb_CreationDay.Size = new System.Drawing.Size(100, 20);
            this.tb_CreationDay.TabIndex = 2;
            // 
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(11, 290);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.Size = new System.Drawing.Size(780, 157);
            this.dgv_Product.TabIndex = 4;
            this.dgv_Product.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_Product_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil ";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // btn_pEkle
            // 
            this.btn_pEkle.Location = new System.Drawing.Point(626, 32);
            this.btn_pEkle.Name = "btn_pEkle";
            this.btn_pEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_pEkle.TabIndex = 6;
            this.btn_pEkle.Text = "Ekle";
            this.btn_pEkle.UseVisualStyleBackColor = true;
            this.btn_pEkle.Click += new System.EventHandler(this.btn_pEkle_Click);
            // 
            // btn_XML
            // 
            this.btn_XML.Location = new System.Drawing.Point(626, 108);
            this.btn_XML.Name = "btn_XML";
            this.btn_XML.Size = new System.Drawing.Size(75, 23);
            this.btn_XML.TabIndex = 6;
            this.btn_XML.Text = "XML";
            this.btn_XML.UseVisualStyleBackColor = true;
            this.btn_XML.Click += new System.EventHandler(this.btn_XML_Click);
            // 
            // btn_pGuncelle
            // 
            this.btn_pGuncelle.Location = new System.Drawing.Point(626, 71);
            this.btn_pGuncelle.Name = "btn_pGuncelle";
            this.btn_pGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_pGuncelle.TabIndex = 7;
            this.btn_pGuncelle.Text = "Güncelle";
            this.btn_pGuncelle.UseVisualStyleBackColor = true;
            this.btn_pGuncelle.Click += new System.EventHandler(this.btn_pGuncelle_Click);
            // 
            // cmb_pBrand
            // 
            this.cmb_pBrand.FormattingEnabled = true;
            this.cmb_pBrand.Location = new System.Drawing.Point(86, 142);
            this.cmb_pBrand.Name = "cmb_pBrand";
            this.cmb_pBrand.Size = new System.Drawing.Size(100, 21);
            this.cmb_pBrand.TabIndex = 8;
            // 
            // cmb_pCategory
            // 
            this.cmb_pCategory.FormattingEnabled = true;
            this.cmb_pCategory.Location = new System.Drawing.Point(86, 106);
            this.cmb_pCategory.Name = "cmb_pCategory";
            this.cmb_pCategory.Size = new System.Drawing.Size(100, 21);
            this.cmb_pCategory.TabIndex = 8;
            // 
            // pb_pCoverImage
            // 
            this.pb_pCoverImage.Location = new System.Drawing.Point(585, 141);
            this.pb_pCoverImage.Name = "pb_pCoverImage";
            this.pb_pCoverImage.Size = new System.Drawing.Size(160, 109);
            this.pb_pCoverImage.TabIndex = 9;
            this.pb_pCoverImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_selectProduct
            // 
            this.btn_selectProduct.Location = new System.Drawing.Point(536, 155);
            this.btn_selectProduct.Name = "btn_selectProduct";
            this.btn_selectProduct.Size = new System.Drawing.Size(28, 23);
            this.btn_selectProduct.TabIndex = 10;
            this.btn_selectProduct.Text = "...";
            this.btn_selectProduct.UseVisualStyleBackColor = true;
            this.btn_selectProduct.Click += new System.EventHandler(this.btn_selectProduct_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_selectProduct);
            this.Controls.Add(this.pb_pCoverImage);
            this.Controls.Add(this.cmb_pCategory);
            this.Controls.Add(this.cmb_pBrand);
            this.Controls.Add(this.btn_pGuncelle);
            this.Controls.Add(this.btn_XML);
            this.Controls.Add(this.btn_pEkle);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.cb_pStatus);
            this.Controls.Add(this.tb_pDescription);
            this.Controls.Add(this.tb_pName);
            this.Controls.Add(this.tb_CreationDay);
            this.Controls.Add(this.tb_pCoverImage);
            this.Controls.Add(this.tb_pPrice);
            this.Controls.Add(this.tb_pStock);
            this.Controls.Add(this.tb_pID);
            this.Controls.Add(this.lbl_pCreationDay);
            this.Controls.Add(this.lbl_pCoverImage);
            this.Controls.Add(this.lbl_pStatus);
            this.Controls.Add(this.lbl_pPrice);
            this.Controls.Add(this.lbl_pStock);
            this.Controls.Add(this.lbl_pDescription);
            this.Controls.Add(this.lbl_bName);
            this.Controls.Add(this.lbl_cName);
            this.Controls.Add(this.lbl_pName);
            this.Controls.Add(this.lbl_pID);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_pCoverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pID;
        private System.Windows.Forms.Label lbl_pName;
        private System.Windows.Forms.Label lbl_cName;
        private System.Windows.Forms.Label lbl_bName;
        private System.Windows.Forms.Label lbl_pDescription;
        private System.Windows.Forms.Label lbl_pStock;
        private System.Windows.Forms.Label lbl_pPrice;
        private System.Windows.Forms.Label lbl_pStatus;
        private System.Windows.Forms.Label lbl_pCoverImage;
        private System.Windows.Forms.TextBox tb_pID;
        private System.Windows.Forms.TextBox tb_pName;
        private System.Windows.Forms.TextBox tb_pDescription;
        private System.Windows.Forms.TextBox tb_pStock;
        private System.Windows.Forms.TextBox tb_pPrice;
        private System.Windows.Forms.TextBox tb_pCoverImage;
        private System.Windows.Forms.CheckBox cb_pStatus;
        private System.Windows.Forms.Label lbl_pCreationDay;
        private System.Windows.Forms.TextBox tb_CreationDay;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Button btn_pEkle;
        private System.Windows.Forms.Button btn_XML;
        private System.Windows.Forms.Button btn_pGuncelle;
        private System.Windows.Forms.ComboBox cmb_pBrand;
        private System.Windows.Forms.ComboBox cmb_pCategory;
        private System.Windows.Forms.PictureBox pb_pCoverImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_selectProduct;
    }
}