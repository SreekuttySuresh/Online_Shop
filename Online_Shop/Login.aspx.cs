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
    public partial class Login : System.Web.UI.Page
    {
        ConClass obj = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_Id) from Tbl_Login where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
            string cid = obj.Fun_Scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select Reg_Id from Tbl_Login Where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
                string regid = obj.Fun_Scalar(str1);
                Session["userid"] = regid;
                string str2 = "select Login_Type from Tbl_Login where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
                string Login_Type = obj.Fun_Scalar(str2);
                if (Login_Type == "admin")
                {
                    Response.Redirect("AdminView.aspx");
                }
                else if (Login_Type == "user")
                {
                    Response.Redirect("UserView.aspx");
                }
            }
        }
    }
}