namespace AnaBayim
{
    partial class Marka
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
            this.lbl_bID = new System.Windows.Forms.Label();
            this.lbl_bName = new System.Windows.Forms.Label();
            this.lbl_bStatus = new System.Windows.Forms.Label();
            this.tb_bID = new System.Windows.Forms.TextBox();
            this.tb_bName = new System.Windows.Forms.TextBox();
            this.cb_bStatus = new System.Windows.Forms.CheckBox();
            this.dgv_Brand = new System.Windows.Forms.DataGridView();
            this.btn_bEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_bGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Brand)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_bID
            // 
            this.lbl_bID.AutoSize = true;
            this.lbl_bID.Location = new System.Drawing.Point(33, 27);
            this.lbl_bID.Name = "lbl_bID";
            this.lbl_bID.Size = new System.Drawing.Size(18, 13);
            this.lbl_bID.TabIndex = 0;
            this.lbl_bID.Text = "ID";
            // 
            // lbl_bName
            // 
            this.lbl_bName.AutoSize = true;
            this.lbl_bName.Location = new System.Drawing.Point(33, 66);
            this.lbl_bName.Name = "lbl_bName";
            this.lbl_bName.Size = new System.Drawing.Size(55, 13);
            this.lbl_bName.TabIndex = 0;
            this.lbl_bName.Text = "Marka Adı";
            // 
            // lbl_bStatus
            // 
            this.lbl_bStatus.AutoSize = true;
            this.lbl_bStatus.Location = new System.Drawing.Point(33, 109);
            this.lbl_bStatus.Name = "lbl_bStatus";
            this.lbl_bStatus.Size = new System.Drawing.Size(38, 13);
            this.lbl_bStatus.TabIndex = 0;
            this.lbl_bStatus.Text = "Durum";
            // 
            // tb_bID
            // 
            this.tb_bID.Enabled = false;
            this.tb_bID.Location = new System.Drawing.Point(99, 24);
            this.tb_bID.Name = "tb_bID";
            this.tb_bID.Size = new System.Drawing.Size(100, 20);
            this.tb_bID.TabIndex = 1;
            // 
            // tb_bName
            // 
            this.tb_bName.Location = new System.Drawing.Point(99, 59);
            this.tb_bName.Name = "tb_bName";
            this.tb_bName.Size = new System.Drawing.Size(100, 20);
            this.tb_bName.TabIndex = 1;
            // 
            // cb_bStatus
            // 
            this.cb_bStatus.AutoSize = true;
            this.cb_bStatus.Location = new System.Drawing.Point(99, 105);
            this.cb_bStatus.Name = "cb_bStatus";
            this.cb_bStatus.Size = new System.Drawing.Size(15, 14);
            this.cb_bStatus.TabIndex = 2;
            this.cb_bStatus.UseVisualStyleBackColor = true;
            // 
            // dgv_Brand
            // 
            this.dgv_Brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Brand.Location = new System.Drawing.Point(11, 268);
            this.dgv_Brand.Name = "dgv_Brand";
            this.dgv_Brand.Size = new System.Drawing.Size(776, 169);
            this.dgv_Brand.TabIndex = 3;
            this.dgv_Brand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_Brand_MouseDown);
            // 
            // btn_bEkle
            // 
            this.btn_bEkle.Location = new System.Drawing.Point(36, 152);
            this.btn_bEkle.Name = "btn_bEkle";
            this.btn_bEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_bEkle.TabIndex = 4;
            this.btn_bEkle.Text = "Ekle";
            this.btn_bEkle.UseVisualStyleBackColor = true;
            this.btn_bEkle.Click += new System.EventHandler(this.btn_bEkle_Click);
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
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // btn_bGuncelle
            // 
            this.btn_bGuncelle.Location = new System.Drawing.Point(36, 190);
            this.btn_bGuncelle.Name = "btn_bGuncelle";
            this.btn_bGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_bGuncelle.TabIndex = 5;
            this.btn_bGuncelle.Text = "Güncelle";
            this.btn_bGuncelle.UseVisualStyleBackColor = true;
            this.btn_bGuncelle.Click += new System.EventHandler(this.btn_bGuncelle_Click);
            // 
            // Marka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_bGuncelle);
            this.Controls.Add(this.btn_bEkle);
            this.Controls.Add(this.dgv_Brand);
            this.Controls.Add(this.cb_bStatus);
            this.Controls.Add(this.tb_bName);
            this.Controls.Add(this.tb_bID);
            this.Controls.Add(this.lbl_bStatus);
            this.Controls.Add(this.lbl_bName);
            this.Controls.Add(this.lbl_bID);
            this.Name = "Marka";
            this.Text = "Marka";
            this.Load += new System.EventHandler(this.Marka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Brand)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bID;
        private System.Windows.Forms.Label lbl_bName;
        private System.Windows.Forms.Label lbl_bStatus;
        private System.Windows.Forms.TextBox tb_bID;
        private System.Windows.Forms.TextBox tb_bName;
        private System.Windows.Forms.CheckBox cb_bStatus;
        private System.Windows.Forms.DataGridView dgv_Brand;
        private System.Windows.Forms.Button btn_bEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Button btn_bGuncelle;
    }
}