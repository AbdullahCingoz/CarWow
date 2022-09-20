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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void OpenForm(Form frm)
        {
            Form[] OpenForms = this.MdiChildren;
            bool isopen = false;
            foreach (Form item in OpenForms)
            {
                if (frm.GetType() == item.GetType())
                {
                    isopen = true;
                    item.Activate();

                }
            }
            if (isopen == false)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Urunler());
        }

        private void markaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Marka());
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Kategoriler());
        }
    }
}
