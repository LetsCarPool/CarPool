using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class LoginPage : System.Web.UI.Page
{
    DataAccessLayer dalCarPool = new DataAccessLayer();
    DataAccessLayer dalTodaysRoute = new DataAccessLayer();
    string s1;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        //Modlog Start : Seema - 22/10/2013
        if (!Page.IsPostBack)
        {
            txtEmpId.Focus();
            Page.Master.Page.Form.DefaultButton = btnLogin.UniqueID;

            var todaysroutes = dalTodaysRoute.GetTodaysRoutes();

            s1 = "Today's Routes";
            s1 += "<br/><br/>";
            foreach (var item in todaysroutes)
            {               
                s1 += item.Startpoint;
                s1 += "&nbsp;";
                s1 += '>';
                s1 += "&nbsp;";
                s1 += item.Destination;
                s1 += "<br/>";

            }
            MqText.Text = s1.ToString();

        }
        else
        {
            Page.Master.Page.Form.DefaultButton = btnLogin.UniqueID;
        }
        //Modlog End : Seema - 22/10/2013
        //Modlog Seema: 19-11
        HtmlGenericControl Divid = (HtmlGenericControl)Page.Master.FindControl("SitemapDiv");
        Divid.Visible = false;
        //Modlog Seema: 19-11
    }
    protected void lnkNewUser_Click(object sender, EventArgs e)
    {
        string page = Convert.ToString(Request.QueryString["page"]);
        Response.Redirect("CreateUser.aspx?page=" + page);
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Session["userid"] = txtEmpId.Text;
        bool ret = false;

        try
        {
            ret = dalCarPool.validateLogin(txtEmpId.Text, txtPassword.Text);
            if (ret == false)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('invalid UserId/ password');", true);
                txtPassword.Text = string.Empty;
                return;
            }
            else
            {

                //Changes made by Soujanya
                //Response.Redirect("UserAccount.aspx");               
                string nextPage = Convert.ToString(Request.QueryString["page"]);
                // Session["page"] = nextPage;
                if (nextPage == "strtCP")
                {

                    if (dalCarPool.ReadRegisteredCarsCount(Convert.ToInt32(txtEmpId.Text)) > 0)
                    {
                        Response.Redirect("Waypoints.aspx");
                    }
                    else
                    {

                        Response.Redirect("RegisterCar.aspx");
                    }
                }
                else if (nextPage == "joinCP")
                {
                    Response.Redirect("JoinCarpool.aspx");
                }
                else if (nextPage == "" || nextPage == null)
                {
                    Response.Redirect("UserAccount.aspx");
                }

            }
            btnLogin.Text = "Logout";
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('login was not successful');", true);
            txtEmpId.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }


    }


}