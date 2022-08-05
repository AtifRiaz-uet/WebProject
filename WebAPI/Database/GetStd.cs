using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace WebAPI.Database
{
    public class GetStd
    {

        public string GetRecord()

        {
            SqlConnection con = new
            SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Open();
            string query = "SELECT * FROM StudentDATA";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            sda.Fill(table);
            if (table.Rows.Count > 0)
            {
                con.Close();
                return JsonConvert.SerializeObject(table);
            }
            else
            {
                con.Close();
                return "Data doesn't Exist ";
            }

        }

    }
}