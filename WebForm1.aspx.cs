using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace DataTables_Assignment
{
    public class Item
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Price { get; set; }

        public List<Item> StudentData = new List<Item>();

        //constuctor to add attributes
        public Item(string name, int id, string price)
        {
            this.Name = name;
            this.ID = id;
            this.Price = price;
        }
        //Student list function to generate list
        public List<Item> ItemListGen()
        {

            //for loop to generate data
            Random rnd = new Random();
            for (int index = 1; index <= 20; index++)
            {
                int random_number = rnd.Next(1, 100); //generate random number between 1 and 100
                int newNumber = int.Parse(index.ToString() + random_number.ToString());
                Item studenti = new Item("Item" + index, newNumber, index+"$");
                StudentData.Add(studenti);
            }


            return StudentData;
        }
    }
    
   
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginForm.aspx");
            }
            Item itemSession = new Item("",0, "");
            Session["Item"] = itemSession.ItemListGen();
        }

        [WebMethod]
        public static string GetStaffInfo()
        {
            List<Item> list = (List<Item>)HttpContext.Current.Session["Item"];
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(list);


        }

        [WebMethod]
        public static string ClearItem(string id)
        {
            List<Item> list = (List<Item>)HttpContext.Current.Session["Item"];
            int ID = Convert.ToInt32(id);


            for (int index = 0; index < list.Count; index++)
            {
                if (ID == list[index].ID)
                {
                    list.Remove(list[index]);
                }
            }

            JavaScriptSerializer js3 = new JavaScriptSerializer();
            HttpContext.Current.Session["Item"] = list;
            return js3.Serialize(list);
        }

        [WebMethod]
        public static string EditItems(string id, string name, string price)
        {
            List<Item> list = (List<Item>)HttpContext.Current.Session["Item"];
            int ID = Convert.ToInt32(id);

            for (int index = 0; index < list.Count; index++)
            {
                if (ID == list[index].ID)
                {
                    if (name != "")
                    {
                        list[index].Name = name;
                    }
                    if (price != "")
                    {
                        list[index].Price = price;
                    }
                }
            }
            JavaScriptSerializer js1 = new JavaScriptSerializer();
            HttpContext.Current.Session["Item"] = list;
            return js1.Serialize(list);
        }

        protected void NewAcc_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountantAdd.aspx");
        }
    }
}



//return (List<Staff>) HttpContext.Current.Session["StaffList"];