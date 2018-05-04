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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            enterdata(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text);
            Session["MailID"] = TextBox6.Text;
            Response.Redirect("User.aspx");

        }
        void enterdata( string t1, string t2, string t3, string t4, string t5 ,string t6)
        {
            string con = " Server= FOB3JV1W2G; database=TestDB; integrated security=SSPI ";
            SqlConnection sqlcon = new SqlConnection(con);
            string sqlenter = "Insert into USERS(FirstName, LastName,Password,Retype_Password,MobileNo,MailID) values('" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "','" + t6 + "')";
            SqlCommand sqlcmd = new SqlCommand(sqlenter, sqlcon);
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();

        }
    }
}