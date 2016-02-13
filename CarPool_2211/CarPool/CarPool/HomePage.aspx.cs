using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            LinkButton lnkBtn = ((LinkButton)Page.Master.FindControl("lnkUserAccount"));
            lnkBtn.Visible = true;
        }
    }


    protected void ibStart_Click(object sender, ImageClickEventArgs e)
    {
        DataAccessLayer dalCarPool = new DataAccessLayer();
        if (Session["userid"] == null)
        {
            Response.Redirect("~/LoginPage.aspx?page=strtCP");
        }
        else
        {
           
            if (dalCarPool.ReadRegisteredCarsCount(Convert.ToInt32(Session["userid"])) > 0)
            {
                Response.Redirect("Waypoints.aspx");
            }
            else
            {

                Response.Redirect("RegisterCar.aspx");
            }
        }
    }
    protected void ibJoin_Click(object sender, ImageClickEventArgs e)
    {
        DataAccessLayer dalCarPool = new DataAccessLayer();
        if (Session["userid"] == null)
        {
            Response.Redirect("~/LoginPage.aspx?page=joinCP");
        }
        else
        {
            Response.Redirect("JoinCarpool.aspx");           
        }
    }
}
