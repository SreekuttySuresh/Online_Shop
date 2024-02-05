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
    public partial class AddProduct : System.Web.UI.Page
    {
        ConClass obj = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select Category_Id,Category_Name from Tbl_Category";
                DataSet ds = obj.Fun_Dataset(sel);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Category_Name";
                DropDownList1.DataTextField = "Category_Id";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Product_pts" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string sel = "insert into Tbl_Product values("+DropDownList1.SelectedItem.Value+",'"+ TextBox1.Text + "','" + TextBox2.Text + "','" + p + "'," + TextBox3.Text + "," + TextBox4.Text +",'available')";
            int i = obj.Fun_Non_Query(sel);
            if (i != 0)
            {
                Label7.Text="Insertion successfullly";
            }
            else
            {
                Label7.Text = "Error";
            }
        }
    }
}