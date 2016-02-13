using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Waypoints : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {

            DataAccessLayer DALayer = new DataAccessLayer();
            int empId = Convert.ToInt32(Session["userid"]);
            lnkLogin.Text = "Log Out";
            lblWelcome.Visible = true;
            lblWelcome.Text += DALayer.getEmpFirstname(empId);
            ddlCarInfo.DataSource = DALayer.ReadRegisteredCars(empId);
            Page.DataBind();
            // ddlCarInfo.Attributes.Add("onChange", "return saveSelectedCarInfo();");

        }

    }

    protected void lnkLogin_Click(object sender, EventArgs e)
    {
        if (lnkLogin.Text == "Log Out")
        {
            //modlock:swati:24-10-2013:Removed homepage redirection
            Session["userid"] = null;
            Response.Redirect("~/LoginPage.aspx");
        }
    }

    protected void btnSelectDates_Click(object sender, EventArgs e)
    {
        Page page = HttpContext.Current.CurrentHandler as Page;
        page.ClientScript.RegisterStartupScript(typeof(Page), "Test", "calcRoute();return false;");
        
        RoutesEntity rEntity = new RoutesEntity();
        DataAccessLayer DALayer = new DataAccessLayer();
        rEntity.CarId = DALayer.ReadCarId(ddlCarInfo.SelectedItem.Text);
        //Modlog Start: Seema
        rEntity.StartPnt = txtStartPoint.Value.Substring(0, txtStartPoint.Value.IndexOf(',', txtStartPoint.Value.IndexOf(',') + 1));
        rEntity.EndPnt = txtEndPoint.Value.Substring(0, txtEndPoint.Value.IndexOf(',', txtEndPoint.Value.IndexOf(',') + 1));
        //rEntity.StartPnt = txtStartPoint.Value;
        //rEntity.EndPnt = txtEndPoint.Value;
        //Modlog End: Seema
        List<string> intermediatePntsLst = new List<string>();
        var items = hdnLstWayPoints.Value.Split(';');
        for (int i = 0; i < items.Count() - 1; i++)
        {
            intermediatePntsLst.Add(items[i]);
        }
        rEntity.IntermediatePnts = intermediatePntsLst;
        Session["RouteInfo"] = rEntity;
        Response.Redirect("SelectDates.aspx");
    }
}