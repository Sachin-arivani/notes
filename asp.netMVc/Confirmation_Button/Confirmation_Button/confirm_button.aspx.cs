using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace Confirmation_Button
{
    public partial class confirm_button : System.Web.UI.Page
    {
        static cs = ConfigurationManager.ConnectionStrings["docs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Wellcome";
            Label1.Visible = true;
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from emp where id = @id";
            SqlDataAdapter sda = new SqlDataAdapter(query ,con);
            sda.SelectCommand.Parameters.AddWithValue("@id",SearchTextBox.Text);
            DataTable Data = new DataTable();
            sda.Fill(Data);

            if(Data.Rows.Count > 0)
            {
                NameTextBox.Text = Data.Rows[0]["name"].ToString();
                DesignationTextBox.Text = Data.Rows[0]["name"].ToString();
                Label1.Text = "Record Found";
                Label1.Visible =true;
            }
            else
            {
                Label1.Text = "Record Not Found";
                Label1.Visible = true;
                NameTextBox.Text = "";
                DesignationTextBox.Text = "";
            }
        }
    }
}