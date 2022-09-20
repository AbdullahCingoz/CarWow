namespace AnaBayim
{
    partial class Kategoriler
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
            this.lbl_cID = new System.Windows.Forms.Label();
            this.lbl_cName = new System.Windows.Forms.Label();
            this.lbl_cDescription = new System.Windows.Forms.Label();
            this.lbl_cStatus = new System.Windows.Forms.Label();
            this.tb_cID = new System.Windows.Forms.TextBox();
            this.tb_cName = new System.Windows.Forms.TextBox();
            this.tb_cDescription = new System.Windows.Forms.TextBox();
            this.cb_cStatus = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cEkle = new System.Windows.Forms.Button();
            this.btn_cGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cID
            // 
            this.lbl_cID.AutoSize = true;
            this.lbl_cID.Location = new System.Drawing.Point(48, 37);
            this.lbl_cID.Name = "lbl_cID";
            this.lbl_cID.Size = new System.Drawing.Size(18, 13);
            this.lbl_cID.TabIndex = 0;
            this.lbl_cID.Text = "ID";
            // 
            // lbl_cName
            // 
            this.lbl_cName.AutoSize = true;
            this.lbl_cName.Location = new System.Drawing.Point(2, 79);
            this.lbl_cName.Name = "lbl_cName";
            this.lbl_cName.Size = new System.Drawing.Size(64, 13);
            this.lbl_cName.TabIndex = 0;
            this.lbl_cName.Text = "Kategori Adı";
            // 
            // lbl_cDescription
            // 
            this.lbl_cDescription.AutoSize = true;
            this.lbl_cDescription.Location = new System.Drawing.Point(31, 119);
            this.lbl_cDescription.Name = "lbl_cDescription";
            this.lbl_cDescription.Size = new System.Drawing.Size(50, 13);
            this.lbl_cDescription.TabIndex = 0;
            this.lbl_cDescription.Text = "Açıklama";
            // 
            // lbl_cStatus
            // 
            this.lbl_cStatus.AutoSize = true;
            this.lbl_cStatus.Location = new System.Drawing.Point(334, 34);
            this.lbl_cStatus.Name = "lbl_cStatus";
            this.lbl_cStatus.Size = new System.Drawing.Size(38, 13);
            this.lbl_cStatus.TabIndex = 0;
            this.lbl_cStatus.Text = "Durum";
            // 
            // tb_cID
            // 
            this.tb_cID.Enabled = false;
            this.tb_cID.Location = new System.Drawing.Point(85, 34);
            this.tb_cID.Name = "tb_cID";
            this.tb_cID.Size = new System.Drawing.Size(100, 20);
            this.tb_cID.TabIndex = 1;
            // 
            // tb_cName
            // 
            this.tb_cName.Location = new System.Drawing.Point(85, 72);
            this.tb_cName.Name = "tb_cName";
            this.tb_cName.Size = new System.Drawing.Size(100, 20);
            this.tb_cName.TabIndex = 1;
            // 
            // tb_cDescription
            // 
            this.tb_cDescription.Location = new System.Drawing.Point(85, 116);
            this.tb_cDescription.Multiline = true;
            this.tb_cDescription.Name = "tb_cDescription";
            this.tb_cDescription.Size = new System.Drawing.Size(207, 109);
            this.tb_cDescription.TabIndex = 1;
            // 
            // cb_cStatus
            // 
            this.cb_cStatus.AutoSize = true;
            this.cb_cStatus.Location = new System.Drawing.Point(392, 33);
            this.cb_cStatus.Name = "cb_cStatus";
            this.cb_cStatus.Size = new System.Drawing.Size(15, 14);
            this.cb_cStatus.TabIndex = 2;
            this.cb_cStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 164);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
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
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // btn_cEkle
            // 
            this.btn_cEkle.Location = new System.Drawing.Point(332, 109);
            this.btn_cEkle.Name = "btn_cEkle";
            this.btn_cEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_cEkle.TabIndex = 5;
            this.btn_cEkle.Text = "Ekle";
            this.btn_cEkle.UseVisualStyleBackColor = true;
            this.btn_cEkle.Click += new System.EventHandler(this.btn_cEkle_Click);
            // 
            // btn_cGuncelle
            // 
            this.btn_cGuncelle.Location = new System.Drawing.Point(332, 156);
            this.btn_cGuncelle.Name = "btn_cGuncelle";
            this.btn_cGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_cGuncelle.TabIndex = 5;
            this.btn_cGuncelle.Text = "Güncelle";
            this.btn_cGuncelle.UseVisualStyleBackColor = true;
            this.btn_cGuncelle.Click += new System.EventHandler(this.btn_cGuncelle_Click);
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cGuncelle);
            this.Controls.Add(this.btn_cEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_cStatus);
            this.Controls.Add(this.tb_cDescription);
            this.Controls.Add(this.tb_cName);
            this.Controls.Add(this.tb_cID);
            this.Controls.Add(this.lbl_cStatus);
            this.Controls.Add(this.lbl_cDescription);
            this.Controls.Add(this.lbl_cName);
            this.Controls.Add(this.lbl_cID);
            this.Name = "Kategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cID;
        private System.Windows.Forms.Label lbl_cName;
        private System.Windows.Forms.Label lbl_cDescription;
        private System.Windows.Forms.Label lbl_cStatus;
        private System.Windows.Forms.TextBox tb_cID;
        private System.Windows.Forms.TextBox tb_cName;
        private System.Windows.Forms.TextBox tb_cDescription;
        private System.Windows.Forms.CheckBox cb_cStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Button btn_cEkle;
        private System.Windows.Forms.Button btn_cGuncelle;
    }
}