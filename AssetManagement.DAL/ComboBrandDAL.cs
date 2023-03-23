using AssetManagement.DTO.DTO;
using AssetManagement.Provider;
using AssetManagement.Provider.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.DAL
{
    public class ComboBrandDAL : ISelect<BrandModel>
    {
        private ComboBox cmbMarka;
        private ComboBox cmbModel;
        private ComboBox cmbUrunTip;
        private ComboBox cmbCurrency;
        private ComboBox cmbCurrentCurrency;
        List<string[]> column = new List<string[]>();


        public ComboBrandDAL() { }
        public ComboBrandDAL(ComboBox cmbMarka, ComboBox cmbModel, ComboBox cmbUrunTip, ComboBox cmbCurrency, ComboBox cmbCurrentCurrency)
        {
            this.cmbMarka = cmbMarka;
            this.cmbModel = cmbModel;
            this.cmbUrunTip = cmbUrunTip;
            this.cmbCurrency = cmbCurrency;
            this.cmbCurrentCurrency = cmbCurrentCurrency;

        }
     /// <summary>
     /// ssecme islemini parcalara ayırarak cekme
     /// </summary>
     /// <param name="bModel"></param>

        public void Select(BrandModel bModel)
        {
            MyDatabase myDatabase = new MyDatabase("select * from BrandModel");
            MyDatabase myDatabase2 = new MyDatabase("select  ID,Description from AssetType ");
            MyDatabase myDatabase3 = new MyDatabase("select  Description from Currency ");



            SqlDataReader dr;
            SqlDataReader dr2;
            SqlDataReader dr3;


            ComboBox[] box1 = { cmbMarka };
            ComboBox[] box2 = { cmbUrunTip };
            ComboBox[] box3 = { cmbCurrency, cmbCurrentCurrency };
            string[] columns1 = { "Description" };
            string[] columns2 = { "ID", "Description" };
            string[] columns3 = { "Description", "Description" };
            column.Add(columns2);
            dr = myDatabase.ExecuteReader();
            dr2 = myDatabase2.ExecuteReader();
            dr3 = myDatabase3.ExecuteReader();
            FillComboBoxes(dr, box1, columns1);
            FillComboBoxes(dr2, box2, columns2);
            FillComboBoxes(dr3, box3, columns3);



        }
        /// <summary>
        /// veri okuma
        /// </summary>
        /// <param name="sqlDataReader"></param>
        /// <param name="cmbMarka"></param>
        /// <param name="cmbModel"></param>
        public void ReadeableData(SqlDataReader sqlDataReader, ComboBox cmbMarka, ComboBox cmbModel)
        {
            while (sqlDataReader.Read())
            {
                cmbModel.Items.Add(sqlDataReader["Model"]);
                cmbMarka.Items.Add(sqlDataReader["Description"]);


            }
        }
  /// <summary>
  /// sectigin markaya gore getirme metodu
  /// </summary>
  /// <param name="sqlDataReader"></param>
  /// <param name="boxes"></param>
  /// <param name="columns"></param>
        public void FillComboBoxes(SqlDataReader sqlDataReader, ComboBox[] boxes, string[] columns)
        {
            List<string[]> strings = new List<string[]>();
            strings.Add(columns);


            while (sqlDataReader.Read())
            {

                if (column[0] == strings[0])
                {
                    int id = Convert.ToInt32(sqlDataReader[columns[0]]);
                    Combobox.AssetTypeID.Add(id);
                    boxes[0].Items.Add(sqlDataReader[columns[1]]);

                }

                if (boxes.Length == columns.Length)
                {

                    for (int i = 0; i < boxes.Length; i++)
                    {
                        boxes[i].Items.Add(sqlDataReader[columns[i]]);
                    }
                }

            }
        }

    }
}
