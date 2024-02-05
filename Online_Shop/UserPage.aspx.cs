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
    public partial class LoginPage : System.Web.UI.Page
    {
        ConClass obj = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Tbl_Login";
            string regid = obj.Fun_Scalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ins = "insert into Tbl_User values(" + reg_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "'," + TextBox4.Text + ",'" + TextBox5.Text + "','" + RadioButtonList1.SelectedItem.Text + "'," + TextBox6.Text + ",'" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','active')";
            int p = obj.Fun_Non_Query(ins);
            string inslog = "insert into Tbl_Login values(" + reg_id + ",'" + TextBox7.Text + "','" + TextBox8.Text + "','user','active')";
            int j = obj.Fun_Non_Query(inslog);
        }
    }
}