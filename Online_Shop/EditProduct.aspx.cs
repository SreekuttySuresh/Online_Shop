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
    public partial class EditProduct : System.Web.UI.Page
    {
        ConClass obj = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Grid();
            }
        }
        public void Bind_Grid()
        {
            string sel = "select * from Tbl_Product";
            DataSet ds = obj.Fun_Dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_Grid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind_Grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox txtdes = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox txtpr = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtsto = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox txtsta = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            string strup = "update Tbl_Product set Pro_Name='" + txtname.Text + "',Pro_Description='" + txtdes.Text + "',Pro_Price="+txtpr+",Stock="+txtsto+",Status='"+txtsta+"'where Product_Id=" + getid + "";

            int j = obj.Fun_Non_Query(strup);
            GridView1.EditIndex = -1;
            Bind_Grid();
        }
    }
}