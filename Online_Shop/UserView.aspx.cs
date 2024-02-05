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
    public partial class UserView : System.Web.UI.Page
    {
        ConClass obj = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select Pro_Name,Pro_Description,Pro_Image,Pro_Price from Tbl_Product";
                DataSet ds = new DataSet();
                ds = obj.Fun_Dataset(s);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ProductCart.aspx");
        }
    }
}