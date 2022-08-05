using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    public class studentInfoController : Controller
    {
        // GET: studentInfo
        

        public string Get()
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
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}