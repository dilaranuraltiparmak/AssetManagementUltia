using AssetManagement.DTO.DTO;
using AssetManagement.Provider;
using AssetManagement.Provider.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagement.DAL
{
    public class AssetDAL : IInsert<AssetInsert>
    {
        SqlTransaction transaction = null;
       
        MyDatabase myDatabase = new MyDatabase("select * from Asset");
        /// <summary>
        /// yeni kayıt ekleme ekranımız icin olusturdugumuz metot
        ///
        /// </summary>
        /// <param name="state"></param>
        
        public void Insert(AssetInsert state)
        {

            myDatabase.OpenConnection();
            SqlTransaction tran = myDatabase.conn.BeginTransaction();
            try
            {
                myDatabase = new MyDatabase("sp_InsertAsset", CommandType.StoredProcedure, transaction);
                List<SqlParameter[]> sqlParameters = new List<SqlParameter[]>();
                List<SqlParameter> sqls = new List<SqlParameter>();
                sqls.Add(new SqlParameter("@barcode", state.Asset.hasBarcode));
                sqls.Add(new SqlParameter("@assetType", state.AssetType.Description));
                sqls.Add(new SqlParameter("@startDate", state.AssetOwner.StartDate));
                sqls.Add(new SqlParameter("@endDate", state.AssetOwner.EndDate));
                sqls.Add(new SqlParameter("@money", state.Asset.Cost));
                sqls.Add(new SqlParameter("@brand", state.Brand.Description));
                sqls.Add(new SqlParameter("@model", state.Brand.Model));
                sqls.Add(new SqlParameter("@cost", state.Currency.Description));
                sqls.Add(new SqlParameter("@guarantee", state.Asset.Guarantee));
                sqls.Add(new SqlParameter("@companyId", state.Asset.CompanyID));
                sqls.Add(new SqlParameter("@retireDate", state.AssetOwner.EndDate));

                sqlParameters.Add(sqls.ToArray());
         myDatabase.AddParameter(sqlParameters[0]);
                int query = myDatabase.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {

                tran.Rollback();
            }
            finally { myDatabase.CloseConnection(); }

      


        }

    }
}
