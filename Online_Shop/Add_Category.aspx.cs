using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Online_Shop
{
    public partial class Add_Category : System.Web.UI.Page
    {
        ConClass obj = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "";
            s = "~/phts/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));

            string ins = "insert into Tbl_Category values('" + TextBox1.Text + "','" + s + "','" + TextBox2.Text + "','active')";
            int i = obj.Fun_Non_Query(ins);   
          
        }
    }
}