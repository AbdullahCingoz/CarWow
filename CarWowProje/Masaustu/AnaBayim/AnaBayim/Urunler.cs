using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AnaBayim
{
    public partial class Urunler : Form
    { Model1 db = new Model1();
        int selectedid=0;
        public Urunler()
        {
            InitializeComponent();
        }

        private void dgv_Product_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgv_Product.HitTest(e.X, e.Y);
                dgv_Product.ClearSelection();
                if (hit.RowIndex != -1)
                {
                    dgv_Product.Rows[hit.RowIndex].Selected = true;
                    this.contextMenuStrip1.Show(this.dgv_Product, new Point(e.X, e.Y));
                    selectedid = Convert.ToInt32(dgv_Product.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            cmb_pCategory.DisplayMember = "CategoryName";
            cmb_pCategory.ValueMember = "ID";
            cmb_pCategory.DataSource=db.Categories.ToList();

            cmb_pBrand.ValueMember = "BrandName";
            cmb_pBrand.ValueMember = "ID";
            cmb_pBrand.DataSource=db.Brands.ToList();
            GridDoldur();
        }
        private void GridDoldur()
        {
            dgv_Product.DataSource = (from p in db.Products
                                      select new
                                      {
                                          ID = p.ID,
                                          ÜrünAdı=p.ProductName,
                                          Kategori=p.Category_ID,
                                          Marka=p.Brand_ID,
                                          Açıklama=p.Description,
                                          Stok=p.Stock,
                                          Fiyat=p.Price,
                                          Durum=p.Status,
                                          Resim=p.CoverImage,
                                          YüklemeTarihi=p.CreationDay

                                      }).ToList();
        }

        private void btn_pEkle_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_pName.Text))
            {
                Product p=new Product();
                p.ProductName=tb_pName.Text;
                p.Category_ID = Convert.ToInt32(cmb_pCategory.SelectedValue);
                p.Brand_ID = Convert.ToInt32(cmb_pBrand.SelectedValue);
                p.Description = tb_pDescription.Text;
                p.Stock =Convert.ToDecimal(tb_pStock.Text);
                p.Price=Convert.ToDecimal(tb_pPrice.Text);
                p.Status = cb_pStatus.Checked;
                p.CoverImage = Convert.ToString(pb_pCoverImage.Image);
                p.CreationDay = DateTime.Now;

                try
                {
                    db.Products.Add(p);
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

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = db.Products.Find(selectedid);
            try
            {
                db.Products.Remove(p);
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
            Product p = db.Products.Find(selectedid);
            tb_pName.Text = p.ProductName;
            cmb_pCategory.SelectedValue= p.Category;
            cmb_pBrand.SelectedValue=p.Brand;
            tb_pDescription.Text = p.Description;
            tb_pStock.Text = p.Stock.ToString();
            tb_pPrice.Text=p.Price.ToString();
            cb_pStatus.Checked = !p.Status;
            tb_pCoverImage.Text = p.CoverImage;
            tb_CreationDay.Text = p.CreationDay.ToString();


        }

        private void btn_pGuncelle_Click(object sender, EventArgs e)
        {
            Product p = db.Products.Find(selectedid);
            p.ProductName=tb_pName.Text;
            p.Category_ID=Convert.ToInt32(cmb_pCategory.SelectedValue);
            p.Brand_ID = Convert.ToInt32(cmb_pBrand.SelectedValue);
            p.Description=tb_pDescription.Text;
            p.Stock=Convert.ToDecimal(tb_pStock.Text);
            p.Price=Convert.ToDecimal(tb_pPrice.Text);
            p.Status =Convert.ToBoolean(!cb_pStatus.Checked);
            p.CoverImage = tb_pCoverImage.Text;
            p.CreationDay = Convert.ToDateTime(tb_CreationDay.Text);

            try
            {
                db.SaveChanges();
                btn_pEkle.Enabled = true;
                btn_pGuncelle.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Ürün güncellenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GridDoldur();
            
        }

        private void btn_selectProduct_Click(object sender, EventArgs e)
        {
            pb_pCoverImage.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pb_pCoverImage.ImageLocation = openFileDialog1.FileName;
        }

        private void btn_XML_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            XDocument xDoc = XDocument.Load("Urun.xml");
            XElement rootElement = xDoc.Root;
            XElement NewElement=new XElement("urun",Guid.NewGuid());
            XAttribute idAttribute = new XAttribute("id", tb_pID.Text);
            XElement NameElement= new XElement("name",tb_pName.Text);
            XElement CategoryElement=new XElement("category",cmb_pCategory.SelectedValue);
            XElement BrandElement=new XElement("brand",cmb_pBrand.SelectedValue);
            XElement DescriptionElement = new XElement("description", tb_pDescription.Text);
            XElement StockElement = new XElement("stock", tb_pStock.Text);
            XElement PrcieElement = new XElement("price", tb_pPrice.Text);
            XElement StatusElement=new XElement("status",cb_pStatus.Checked);
            XElement CoverImageElement = new XElement("coverımage", tb_pCoverImage.Text);
            XElement CreationDayElement= new XElement("creationday",DateTime.Now);

            NewElement.Add(idAttribute,NameElement,CategoryElement,BrandElement,DescriptionElement, StockElement, PrcieElement, StatusElement, CoverImageElement);
            rootElement.Add(NewElement);
            rootElement.Save("Urun.xml");
            MessageBox.Show("Dönüştürme başarılı","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
