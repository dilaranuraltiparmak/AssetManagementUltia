using AssetManagement.DTO.DTO;
using AssetManagement.Provider;
using AssetManagement.Provider.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.DAL
{
    public class BrandCostListDAL : ISelect<Select>
    {   MyDatabase provider = null;
        ListView listView;
        /// <summary>
        /// Marka-ücret ekranı rapor
        /// </summary>
        /// <param name="view"></param>
        public BrandCostListDAL(ListView view)
        {
            this.listView = view;
        }

      
        public void Select(Select state)
        {
            provider = new MyDatabase("Select Description,Cost from Asset ");
            SqlDataReader rdr = provider.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["Description"].ToString());
                    item.SubItems.Add(rdr["Cost"].ToString());


                    listView.Items.Add(item);

                }
            }
        }
    }
}