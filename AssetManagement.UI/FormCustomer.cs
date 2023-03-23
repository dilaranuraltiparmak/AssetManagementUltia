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
    public partial class FormCustomer : Form
    {
        Select selectCustomer=null;
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            CustomerListDAL customerListDAL = new CustomerListDAL(listView1);
        
            customerListDAL.Select(selectCustomer);
        }
    }
}
