using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Online_Shop
{
    public partial class Admin : System.Web.UI.Page
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
                int newregid = Convert.ToInt32(reg_id);
                reg_id = newregid + 1;
            }
            string ins = "insert into Tbl_Admin values("+reg_id+",'"+TextBox1.Text+"','"+TextBox2.Text+"',"+TextBox3.Text+",'"+TextBox4.Text+"')";
            int i = obj.Fun_Non_Query(ins);
            if (i != 0)
            {
                string inslog = "insert into Tbl_Login values(" + reg_id + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','admin','active')";
                int j = obj.Fun_Non_Query(inslog);


            }
        }
    }
}