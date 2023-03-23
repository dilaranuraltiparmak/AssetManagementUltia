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
    public partial class FormList : Form
    {
        Select selectList = null;
        public FormList()
        {
            InitializeComponent();
        }

        

        private void FormList_Load(object sender, EventArgs e)
        {
            ListDAL list = new ListDAL(listView1);
            list.Select(selectList);

        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            FormNewRecord frmnew = new FormNewRecord();
            frmnew.Show();
            this.Hide();
        }
    }
}
