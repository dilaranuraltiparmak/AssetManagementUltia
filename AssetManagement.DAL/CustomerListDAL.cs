using AssetManagement.DTO.DTO;
using AssetManagement.Provider.Repositories;
using AssetManagement.Provider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.DAL
{
    public class CustomerListDAL : ISelect<Select>
    {
        ListView listView;
        public CustomerListDAL(ListView view)
        {
            this.listView = view;
        }

        MyDatabase myDatabase = null;
        public void Select(Select state)
        {
            myDatabase = new MyDatabase("Select SubscriptionNumber,FirstName,LastName from Customer");
            SqlDataReader rdr = myDatabase.ExecuteReader();
            if (rdr.HasRows)
            {
                

                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr["SubscriptionNumber"].ToString());
                    item.SubItems.Add(rdr["FirstName"].ToString());
                    item.SubItems.Add(rdr["LastName"].ToString());


                    listView.Items.Add(item);

                }
            }

        }
    }
}
