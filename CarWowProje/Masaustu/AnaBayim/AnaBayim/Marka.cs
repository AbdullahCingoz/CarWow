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
    public partial class Marka : Form
    {
        Model1 db = new Model1();
        int selectedid = 0;


       
        public Marka()
        {
            InitializeComponent();
        }
        private void Marka_Load(object sender, EventArgs e)
        {

            GridDoldur();
        }
        private void btn_bEkle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_bName.Text))
            {
                Brand b = new Brand();
                b.BrandName = tb_bName.Text;
                b.Status = Convert.ToBoolean(cb_bStatus.Checked);
                try
                {
                    db.Brands.Add(b);
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

        private void dgv_Brand_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgv_Brand.HitTest(e.X, e.Y);
                dgv_Brand.ClearSelection();
                if (hit.RowIndex != -1)
                {
                    dgv_Brand.Rows[hit.RowIndex].Selected = true;
                    this.contextMenuStrip1.Show(this.dgv_Brand, new Point(e.X, e.Y));
                    selectedid = Convert.ToInt32(dgv_Brand.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }

      
        private void GridDoldur()
        {
            dgv_Brand.DataSource = (from b in db.Brands
                                    select new
                                    {
                                        ID = b.ID.ToString(),
                                        MarkaAdı = b.BrandName,
                                        Durum = b.Status,
                                    }).ToList();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brand b = db.Brands.Find(selectedid);
            try
            {
                db.Brands.Remove(b);
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
            Brand b = db.Brands.Find(selectedid);
            b.BrandName=tb_bName.Text;
            b.Status = Convert.ToBoolean(!cb_bStatus.Checked);

           
        }

        private void btn_bGuncelle_Click(object sender, EventArgs e)
        {
            Brand b = db.Brands.Find(selectedid);
            tb_bName.Text = b.BrandName;
            cb_bStatus.Checked = b.Status;
            try
            {
                db.SaveChanges();
                btn_bEkle.Enabled = true;
                btn_bGuncelle.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Marka güncellenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridDoldur();
        }
    }
}
