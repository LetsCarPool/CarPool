using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyRoutes : System.Web.UI.Page
{
    DataAccessLayer dalRegisteredCars = new DataAccessLayer();
    static int userId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
             userId = Convert.ToInt32(Session["userid"]);
            FillGrdRouresDetails(userId);
        }
    }
    public void FillGrdRouresDetails(int userId)
    {
       
        var registeredCarsRoutesInfo = dalRegisteredCars.ReadRoutesInfo(userId);
        grdRoutesInfo.DataSource = registeredCarsRoutesInfo;
        Page.DataBind();
        if (registeredCarsRoutesInfo.Count <= 0)
        {
            divNote.Visible = false;
        }
    }


    //protected void grdRouteDetail_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    //{
    //    grdRouteDetail.EditIndex = -1;
    //    FillGrdRouresDetails(userId);
    //}
    //protected void grdRouteDetail_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    grdRouteDetail.EditIndex = e.NewEditIndex;
    //    FillGrdRouresDetails(userId);
    //}
    //protected void grdRouteDetail_RowUpdating(object sender, GridViewUpdateEventArgs e)
    //{

    //}
    //protected void grdRouteDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
    //{
    //    int userId = Convert.ToInt32(Session["userid"]);
    //    string routeID = ((Label)grdRouteDetail.Rows[e.RowIndex].FindControl("lblrtId")).Text;
    //    dalRegisteredCars.DeleteRoute(Convert.ToInt32( routeID));
    //    FillGrdRouresDetails(userId);
    //}
    protected void grdRoutesInfo_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdRoutesInfo.EditIndex = e.NewEditIndex;
        FillGrdRouresDetails(userId);
    }
    protected void grdRoutesInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        RoutesEntity rEntInfo = new RoutesEntity();
        rEntInfo.RouteID =Convert.ToInt32( ((Label)grdRoutesInfo.Rows[e.RowIndex].FindControl("lblrtIdEdit")).Text);
        rEntInfo.StartPnt = ((TextBox)grdRoutesInfo.Rows[e.RowIndex].FindControl("txtStartPoint")).Text;
        rEntInfo.EndPnt = ((TextBox)grdRoutesInfo.Rows[e.RowIndex].FindControl("txtEndPnt")).Text;
        rEntInfo.StartDt = ((TextBox)grdRoutesInfo.Rows[e.RowIndex].FindControl("txtStartDt")).Text;
        rEntInfo.EndDt = ((TextBox)grdRoutesInfo.Rows[e.RowIndex].FindControl("txtEndDt")).Text;
        rEntInfo.RunningDays = ((TextBox)grdRoutesInfo.Rows[e.RowIndex].FindControl("txtRunningDays")).Text;
        rEntInfo.AllWayPoints = ((TextBox)grdRoutesInfo.Rows[e.RowIndex].FindControl("txtWayPoints")).Text;
        dalRegisteredCars.UpdateRouteInfo(rEntInfo);
        grdRoutesInfo.EditIndex = -1;
        FillGrdRouresDetails(userId);
    }
    protected void grdRoutesInfo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdRoutesInfo.EditIndex = -1;
        FillGrdRouresDetails(userId);
    }
    protected void grdRoutesInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int userId = Convert.ToInt32(Session["userid"]);
        string routeID = ((Label)grdRoutesInfo.Rows[e.RowIndex].FindControl("lblrtId")).Text;
        dalRegisteredCars.DeleteRoute(Convert.ToInt32(routeID));
        FillGrdRouresDetails(userId);
    }

    //Modlog Start : Seema - 24/10/2013
    protected void lnkCreateRoute_Click(object sender, EventArgs e)
    {
        if (grdRoutesInfo.Rows.Count > 0)
        {
            Response.Redirect("WayPoints.aspx");
        }
        else
        {
            string message = "Order Placed Successfully.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }

    }
    //Modlog End : Seema - 24/10/2013

    protected void lnkNewRoute_Click(object sender, EventArgs e)
    {
        Response.Redirect("Waypoints.aspx");
    }
}