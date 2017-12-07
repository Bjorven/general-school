﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.Common;

namespace Calculator2
{
    class Dbaccess
    {
        SqlConnection connection;
        SqlCommand command;

        public Dbaccess()
        {                                       // DONIAS CON STRING @"Data Source=LAPTOP-B9AASP37\SQLEXPRESS;Initial Catalog=DigitCashier;Integrated Security=True;Connect Timeout=30;";
                                                // BJÖRNS CON STRING Data Source=LAPTOP-TU1UMOIC;Initial Catalog=DigitCashier;Integrated Security=True
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=LAPTOP-TU1UMOIC;Initial Catalog=DigitCashier;Integrated Security=True";
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

        public DataSet GetGoodsList()
        {

            command.CommandText = "Select P.idnumber, P.Pname, P.price, P.qty, P.PricePerHg, P.pricePerKg, PG.PGname, V.Vvalue, M.Mname, S.Supname from Product P, ProductGroup PG, Vat V, Manufacturer M, Supplier s Where P.receiptId is NULL and P.productGroupId = PG.PGid and P.vatId = V.Vid and P.manufacturerId = M.Mid and P.supplierId = S.Supid";
            connection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            connection.Close();
            return ds;

        }

        public Product getProduct(string searchText)
        {
            SqlParameter workperameter1 = new SqlParameter();
            DataSet ds = new DataSet();

            connection.Open();
            command.CommandText = "spGetProduct";
            command.CommandType = CommandType.StoredProcedure;

            workperameter1 = command.Parameters.Add("@searchText", SqlDbType.VarChar);
            workperameter1.Value = searchText;
            command.ExecuteNonQuery();
            
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            adapt.Fill(ds);
            connection.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                Product getproduct = new Product
                 (
                 Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString()),
                 Convert.ToInt16(ds.Tables[0].Rows[0][1].ToString()),
                 //Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString()),
                 Convert.ToString(ds.Tables[0].Rows[0][2].ToString()),
                 Convert.ToString(ds.Tables[0].Rows[0][3].ToString()),
                 Convert.ToString(ds.Tables[0].Rows[0][4].ToString()),
                 Convert.ToDecimal(ds.Tables[0].Rows[0][5].ToString()),
                 Convert.ToBoolean(ds.Tables[0].Rows[0][6].ToString()),
                 Convert.ToBoolean(ds.Tables[0].Rows[0][7].ToString()),
                 Convert.ToString(ds.Tables[0].Rows[0][8].ToString())
                 );
                return getproduct;
            }
            else
            {
                throw new Exception();
            }
        }

        //***************************************************************************************************************************************************
        //***************************************************************************************************************************************************

        public DataTable getReceipt(string Search_text)

        {
            SqlParameter workparameter1 = new SqlParameter();
            connection.Open();
            command.CommandText = "spGetReceipt";
            command.CommandType = CommandType.StoredProcedure;

            workparameter1 = command.Parameters.Add("@Search_text", SqlDbType.VarChar);
            workparameter1.Value = Search_text;
            command.ExecuteNonQuery();


            SqlDataAdapter Adapt = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            Adapt.Fill(dt);
            connection.Close();


            return dt;
        }
        // //***************************************************************************************************************************************************
        // //***************************************************************************************************************************************************


    }


}


