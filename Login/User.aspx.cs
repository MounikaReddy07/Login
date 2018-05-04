using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Login
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Session["MailID"].ToString();
            GridView1.DataSource = getrecords(value);
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        SqlDataReader getrecords(string s)
        {

            string con = "server=FOB3JV1W2G; database=TestDB; integrated security=SSPI";
            SqlConnection sqlcon = new SqlConnection(con);
            string sqltest = "select * from USERS where MailID='"+ s +"'";
            SqlCommand sqlcmd = new SqlCommand(sqltest, sqlcon);
            sqlcon.Open();
            SqlDataReader dr = sqlcmd.ExecuteReader();

            return dr;

            
        }

        protected void Button1_Click(object sender, EventArgs e )
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e )

        {
            string value = Session["MailID"].ToString();
            string con = "server=FOB3JV1W2G; database=TestDB; integrated security=SSPI";
            SqlConnection sqlcon = new SqlConnection(con);
            string sqltest = "Delete * from table where MailID='" + value + "'";
            SqlCommand sqlcmd = new SqlCommand(sqltest, sqlcon);

        }
    }
}