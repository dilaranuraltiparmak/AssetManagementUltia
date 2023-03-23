using AssetManagement.DAL;
using AssetManagement.DTO.DTO;
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
    public partial class FormReportingBrandCost : Form
    {
        Select select = null;
        public FormReportingBrandCost()
        {
            InitializeComponent();
        }

        private void FormReportingBrandCost_Load(object sender, EventArgs e)
        {
            BrandCostListDAL list = new BrandCostListDAL(listView1);
            list.Select(select);

        }
    }
}
