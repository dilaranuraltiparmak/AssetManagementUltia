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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssetManagement.UI
{
    public partial class FormReporting : Form
    {
        Select selectUser = null;
        public FormReporting()
        {
            InitializeComponent();
        }

        private void FormReporting_Load(object sender, EventArgs e)
        {
            UserReportingDAL list = new UserReportingDAL(listView1);
            list.Select(selectUser);

        }
    }
}
