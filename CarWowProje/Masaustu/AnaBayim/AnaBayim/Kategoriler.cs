using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaBayim
{
    public partial class Kategoriler : Form
    {
        Model1 db = new Model1();
        int selectedid = 0;
        public Kategoriler()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                if (hit.RowIndex != -1)
                {
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                    selectedid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }

        private void btn_cEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_cName.Text))
            {
                Category c = new Category();
                c.CategoryName = tb_cName.Text;
                c.Description = tb_cDescription.Text;
                c.Status = cb_cStatus.Checked;
                try
                {
                    db.Categories.Add(c);
                    db.SaveChanges();
                    MessageBox.Show("Ekleme işlemi başarılı", "Başarılı");
                }
                catch 
                {
                    MessageBox.Show("Bir hata oluştu");
                }
                GridDoldur();
            }

        }
        private void GridDoldur()
        {
            dataGridView1.DataSource = (from c in db.Categories
                                        select new
                                        {
                                            ID = c.ID,
                                            KategoriAdı = c.CategoryName,
                                            Açıklama = c.Description,
                                            Durum = c.Status,
                                        }).ToList();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category c = db.Categories.Find(selectedid);
            try
            {
                db.Categories.Remove(c);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Hata var", "Hata");
            }
            GridDoldur();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category c = db.Categories.Find(selectedid);
            tb_cName.Text = c.CategoryName;
            tb_cDescription.Text = c.Description;
            cb_cStatus.Checked = c.Status;
        }

        private void btn_cGuncelle_Click(object sender, EventArgs e)
        {
            Category c = db.Categories.Find(selectedid);
            c.CategoryName = tb_cName.Text;
            c.Description = tb_cDescription.Text;
            c.Status = cb_cStatus.Checked;
            try
            {
                db.SaveChanges();
                btn_cEkle.Enabled = true;
                btn_cEkle.Enabled=false;
            }
            catch
            {
                MessageBox.Show("Kategori güncellenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridDoldur();
        }
    }
}
