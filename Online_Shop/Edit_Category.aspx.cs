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
    public partial class Edit_Category : System.Web.UI.Page
    {
        ConClass obj = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Bind_Grid();
            }
            
        }
        public void Bind_Grid()
        {
            string sel = "select * from Tbl_Category";
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
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[1].Controls[0];
            TextBox txtdes = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            string strup = "update Tbl_Category set Category_Name='" + txtname.Text + "',Description='" + txtdes.Text + "'where Category_Id=" + getid + "";
            
            int j = obj.Fun_Non_Query(strup);
            GridView1.EditIndex = -1;
            Bind_Grid();

            
        }

        
    }
}