using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{

            if (Session["userid"] != null)
            {
                DataAccessLayer dalGetFName = new DataAccessLayer();

                int empId = Convert.ToInt32(Session["userid"]);
                lnkLogin.Text = "Log Out";
                //Modlock:24-10-2013:Swati:Added new menu Items:Start

                NavigationMenu.Items.Add(new MenuItem
                {
                    Text = "Home",
                    NavigateUrl = "~/UserAccount.aspx"
                });
                NavigationMenu.Items.Add(new MenuItem
                {
                    Text = "About",
                    NavigateUrl = "~/About.aspx"
                });
                NavigationMenu.Items.Add(new MenuItem
                {
                    Text = "My Cars",
                    NavigateUrl = "~/MyCars.aspx"
                });
                NavigationMenu.Items.Add(new MenuItem
                {
                    Text = "My Routes",
                    NavigateUrl = "~/MyRoutes.aspx"
                });
                NavigationMenu.Items.Add(new MenuItem
                {
                    Text = "Joined",
                    NavigateUrl = "~/JoinedPassengers.aspx"
                });

                //Modlog Start: Seema

                if (!Page.IsPostBack)
                {
                    lblWelcome.Visible = true;
                    lblWelcome.Text += dalGetFName.getEmpFirstname(empId);
                }
                //Modlog End : Seema
            }
            else
            {
                NavigationMenu.Items.Add(new MenuItem
                {
                    Text = "Home",
                    NavigateUrl = "~/LoginPage.aspx"
                });
                NavigationMenu.Items.Add(new MenuItem
                {
                    Text = "About",
                    NavigateUrl = "~/About.aspx"
                });
            }
            //Modlock:24-10-2013:Swati:Added new menu Items:End
        //}
    }
    protected void lnkLogin_Click(object sender, EventArgs e)
    {
        if (lnkLogin.Text == "Log Out")
        {

            Session["userid"] = null;
            //Modlock:24-10-2013:Swati:Removed Home Page redirection
            Response.Redirect("~/LoginPage.aspx");
        }
        else
        {
            if (Request.QueryString["page"] == null)
            {
                Response.Redirect("~/LoginPage.aspx");
            }
            else
            {

                Response.Redirect("LoginPage.aspx?page=" + Request.QueryString["page"]);
            }  
           
        }
    }

    protected void lnkUserAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserAccount.aspx");
    }
}
