using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JoinCarpool : System.Web.UI.Page
{
    DataAccessLayer DALayer = new DataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        CmpStartDtValidator.ValueToCompare = DateTime.Now.ToShortDateString();
        CmpEndDtValidator.ValueToCompare = DateTime.Now.ToShortDateString();
        //btnBook.Attributes.Add("onclick", "javascript:return Validate()");
        if (!Page.IsPostBack)
        {
            ddlStPoint.DataSource = DALayer.GetStartPoint();
            ddlDestination.DataSource = DALayer.GetDestination();
            Page.DataBind();            
        }
    }
    ///*****Modlock:25-10-2013 Swati:Modified Function: Start
    protected void ImgBtnStartDate_Click(object sender, ImageClickEventArgs e)
    {
        if (CalStartDate.Visible == false)
        {
            CalStartDate.Visible = true;
        }
        else
        {
            CalStartDate.Visible = false;
        }
    }
    protected void ImgBtnEndDate_Click(object sender, ImageClickEventArgs e)
    {
        if (CalEndDate.Visible == false)
        {
            CalEndDate.Visible = true;
        }
        else
        {
            CalEndDate.Visible = false;
        }
    }
    ///*****Modlock:25-10-2013 Swati:Modified Function: End

    protected void CalStartDate_SelectionChanged(object sender, EventArgs e)
    {
        txtStartDate.Text = CalStartDate.SelectedDate.ToString("d");
        CalStartDate.Visible = false;
    }
    protected void CalEndDate_SelectionChanged(object sender, EventArgs e)
    {
        txtEndDate.Text = CalEndDate.SelectedDate.ToString("d");
        CalEndDate.Visible = false;
    }
    ///*****Modlock:25-10-2013 Swati:Added Function: Start
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        FillGrdCarDetails();
        gvSearchRoute.Visible = true;
        if (gvSearchRoute.Rows.Count == 0)
        {
            MsgShow.Text = "No Such Carpool Exist.Please modify your Search.";
            MsgShow.Visible = true;
        }
        else
        {
            MsgShow.Text = "";
            MsgShow.Visible = false;            
        }
    }

    public void FillGrdCarDetails()
    {
        DateTime startDate = Convert.ToDateTime(txtStartDate.Text);
        DateTime endDate;
        if (Convert.ToString(txtEndDate.Text) == "")
        {
            endDate=startDate;
        }
        else
        {
             endDate = Convert.ToDateTime(txtEndDate.Text);
        }
        string startPoint = Convert.ToString(ddlStPoint.SelectedValue);
        string destination = Convert.ToString(ddlDestination.SelectedValue);
        if (chkExact.Checked.Equals(true))
        {
            var SearchCarsRoutesInfo = DALayer.searchRoute(startDate, endDate, startPoint, destination);
            gvSearchRoute.DataSource = SearchCarsRoutesInfo;
            Page.DataBind();
        }
        else
        {
            var SearchCarsRoutesInfo = DALayer.searchRouteNearestMatch(startDate, endDate, startPoint, destination);
            gvSearchRoute.DataSource = SearchCarsRoutesInfo;
            Page.DataBind();            
        }
    }

    ///*****Modlock:25-10-2013 Swati:Added Function: End
    protected void gvSearchRoute_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        lblStartDate.Text = "Travel date";
        lblStartDate.Visible = true;
        txtStartDate.Visible = true;
        ImgBtnStartDate.Visible = true;
        //CalStartDate.Visible = true;
        lblEndDate0.Visible = false;
        txtEndDate.Visible = false;
        ImgBtnEndDate.Visible = false;
        //CalEndDate.Visible = false;
        RfvEnddate.Enabled = false;
        CmpEndDtValidator.Enabled = false;
    }
    protected void rbRegularTrips_CheckedChanged(object sender, EventArgs e)
    {
        lblStartDate.Text = "From date";
        lblStartDate.Visible = true;
        txtStartDate.Visible = true;
        ImgBtnStartDate.Visible = true;
        //CalStartDate.Visible = true;
        lblEndDate0.Visible = true;
        txtEndDate.Visible = true;
        ImgBtnEndDate.Visible = true;
        //CalEndDate.Visible = true;
        RfvEnddate.Enabled = true;
        CmpEndDtValidator.Enabled = true;
    }
}