using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JoinCarPoolDet2 : System.Web.UI.Page
{
    DataAccessLayer DALayer = new DataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["VehicleNum"]=Convert.ToString(Request.QueryString["VehicleNumber"]);
        Session["CarId"] = Convert.ToInt32(Request.QueryString["CarId"]);
        Session["RouteId"] = Convert.ToInt32(Request.QueryString["RouteId"]);
        DateTime startDate = Convert.ToDateTime(Request.QueryString["StartDt"]);
        DateTime endDate = Convert.ToDateTime(Request.QueryString["EndDt"]);
        if (!Page.IsPostBack)
        {
            Session["noOfPassengers"] = Convert.ToInt32(ddlNoOfPass.SelectedValue);
            var SearchCarsRoutesInfo = DALayer.searchRoute(Convert.ToInt32(Session["CarId"]), Convert.ToInt32(Session["RouteId"]), startDate, endDate, Convert.ToInt32(Session["noOfPassengers"]));
            gvBookCar.DataSource = SearchCarsRoutesInfo;
            Page.DataBind();     
            
        }
    }
    protected void btnBook_Click(object sender, EventArgs e)
    {
        Session["TravelDt"] = string.Empty;
        //for (int i = 0; i < gvBookCar.Rows.Count; i++)
        foreach (GridViewRow grv in gvBookCar.Rows)
        {
            //GridViewRow row = gvBookCar.Rows[i];
            bool isChecked = ((CheckBox)grv.FindControl("chkCar")).Checked;

            if (isChecked)
            {
                Session["TravelDt"] += (((Label)grv.Cells[2].Controls[1]).Text).ToString() + "|";
                //cvalues += gvBookCar.SelectedRow.Cells[3].Text.ToString() + "|";
            }
        }
        if (!string.IsNullOrEmpty(Convert.ToString(Session["TravelDt"])))
        {
            Session["noOfPassengers"] = Convert.ToInt32(ddlNoOfPass.SelectedValue);
            Response.Redirect("~/JoinCarpoolDet3.aspx?cvalues=" + Session["TravelDt"]);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('Please select a carpool');", true);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/JoinCarpool.aspx");
    }
}