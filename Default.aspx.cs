using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con =new SqlConnection( ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
    SqlDataReader rd = null;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlog_Click(object sender, EventArgs e)
    {
        try
        {
            int flag = 0;
            string id = txtid.Text;
            string pwd = txtpwd.Text;
            string str = "select * from Login";
            cmd = new SqlCommand(str, con);
            con.Open();
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    if (id.Equals(rd[0]) && pwd.Equals(rd[1]))
                    {
                        Session["id"] = Session.SessionID;
                        Session["User"] = txtid.Text;
                        if (rd[2].Equals("a"))
                        {
                            flag++;
                            Response.Redirect("AdminHome.aspx");

                        }
                        else if (rd[2].Equals("m"))
                        {
                            flag++;
                            Response.Redirect("ManagerHome.aspx");

                        }
                        else
                        {
                            flag++;
                            Response.Redirect("EmployeeHome.aspx");

                        }

                    }


                }
                if (flag == 0)
                {
                    Label1.Text = "Invalid Id or Password";
                }

            }

        }
        catch (SqlException ex)
        {
            Label1.Text = ex.Message;

        }
        finally
        {
            if (rd != null)
                rd.Close();
            con.Close();
        }
    }
}