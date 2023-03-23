using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormList list = new FormList();
            list.MdiParent = this;
            list.Dock=DockStyle.Fill;
            list.Show();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewRecord yeni = new FormNewRecord();
            yeni.MdiParent = this;
            yeni.Dock = DockStyle.Fill;
            yeni.Show();

        }

      

        private void kullanıcıRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporting rapor = new FormReporting();
            rapor.Dock = DockStyle.Fill;
            rapor.ShowDialog();
        }

        private void markaFiyatBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportingBrandCost bRapor = new FormReportingBrandCost();
            bRapor.Dock = DockStyle.Fill;
            bRapor.ShowDialog();

        }

        private void müşteriBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer customer = new FormCustomer();
            customer.Dock = DockStyle.Fill;
            customer.ShowDialog();

        }
    }
}
