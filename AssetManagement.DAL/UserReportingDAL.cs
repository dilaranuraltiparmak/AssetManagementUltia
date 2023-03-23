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
    public class UserReportingDAL : ISelect<Select>
    {
        ListView listView;
        public UserReportingDAL(ListView view)
        {
            this.listView = view;
        }

        MyDatabase provider = null;
        public void Select(Select state)
        {
            provider = new MyDatabase("Select UserName ,CreatedBy from Login ");
            SqlDataReader rdr = provider.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["UserName"].ToString());
                    item.SubItems.Add(rdr["CreatedBy"].ToString());
         

                    listView.Items.Add(item);

                }
            }

          


        }
    }
    }

