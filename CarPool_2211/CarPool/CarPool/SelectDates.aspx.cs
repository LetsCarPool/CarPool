using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectDates : System.Web.UI.Page
{
    static int owner;

    protected void Page_Load(object sender, EventArgs e)
    {
        CompareValidator1.ValueToCompare = DateTime.Now.ToShortDateString();
        CompareValidator2.ValueToCompare = DateTime.Now.ToShortDateString();
        try
        {
            if (Session["userid"] != null)
            {
                owner = Convert.ToInt32(Session["userid"]);

                //Modlog Seema: Commented the code for user account link
                //LinkButton lnkBtn = ((LinkButton)Page.Master.FindControl("lnkUserAccount"));
                //lnkBtn.Visible = true;
            }

        }

        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('Some error occured');", true);
            return;
        }

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

        if (rbSingleTrip.Checked == true)
        {
            lblStartdate.Text = "Travel Date";
            lblEndDate.Visible = false;
            txtEndDate.Visible = false;
            ImgBtnEndDate.Visible = false;
            RfvEnddate.Visible = false;
            ChkMon.Visible =  ChkTue.Visible=ChkWed.Visible =ChkThu.Visible =ChkFri.Visible = ChkSat.Visible =ChkSun.Visible = false;
          
        }

    }

    protected void rbRegularTrips_CheckedChanged(object sender, EventArgs e)
    {
        if (rbRegularTrips.Checked == true)
        {
            lblStartdate.Text = "Start Date";
            lblEndDate.Visible = true;
            txtEndDate.Visible = true;
            ImgBtnEndDate.Visible = true;
            ChkMon.Visible = ChkTue.Visible = ChkWed.Visible = ChkThu.Visible = ChkFri.Visible = ChkSat.Visible = ChkSun.Visible = true;
        }
    }

    protected void CalStartDate_SelectionChanged(object sender, EventArgs e)
    {
        txtStartDate.Text = CalStartDate.SelectedDate.ToString("d");
        CalStartDate.Visible = false;

        //if (CalStartDate.SelectedDate.ToString().Equals(DateTime.Now.ToString()))
        //{
        //    Response.Write("<script>alert('Booking cannot be done for the past dates')</script>");
        //    txtStartDate.Text = "";
        //}

    }

    protected void CalEndDate_SelectionChanged(object sender, EventArgs e)
    {
        txtEndDate.Text = CalEndDate.SelectedDate.ToString("d");
        CalEndDate.Visible = false;
        //if (DateTime.Now > CalEndDate.SelectedDate)
        //{
        //    Response.Write("<script>alert('Booking cannot be done for the past dates')</script>");
        //    txtEndDate.Text = "";

        //}
    }

    protected void ImgBtnStartDate_Click1(object sender, ImageClickEventArgs e)
    {
        CalStartDate.Visible = true;
        txtStartDate.Text = CalStartDate.SelectedDate.ToString("d");
    }

    protected void ImgBtnEndDate_Click(object sender, ImageClickEventArgs e)
    {
        CalEndDate.Visible = true;
    }

    protected void btnBook_Click(object sender, EventArgs e)
    {
        if ((rbSingleTrip.Checked == false) && (rbRegularTrips.Checked == false))
        {
            lblMsg.Visible = true;
        }
        DataAccessLayer dalCarPool = new DataAccessLayer();

        if (rbSingleTrip.Checked == true) 
        {
            lblMsg.Visible = false;
            RoutesEntity rEntSingleTrp = FillRouteEntitySTrip();

            dalCarPool.FillTripDetails(rEntSingleTrp);
          
           // Response.Write("<script>alert('Booking is done successfully')</script>");
        }
        else if (rbRegularTrips.Checked)
        {
            lblMsg.Visible = false;
            RoutesEntity rEntMultiTrp = FillRouteEntity();
            string runningDays = "";
            if (ChkMon.Checked)
            {

                runningDays += "1";
            }
            else
            {
                runningDays += "0";
            }
            if (ChkTue.Checked)
            {

                runningDays += "1";
            }
            else
            {
                runningDays += "0";
            }
            if (ChkWed.Checked)
            {

                runningDays += "1";
            }
            else
            {
                runningDays += "0";
            }
            if (ChkThu.Checked)
            {

                runningDays += "1";
            }
            else
            {
                runningDays += "0";
            }
            if (ChkFri.Checked)
            {

                runningDays += "1";
            }
            else
            {
                runningDays += "0";
            }
            if (ChkSat.Checked)
            {

                runningDays += "1";
            }
            else
            {
                runningDays += "0";
            }
            if (ChkSun.Checked)
            {

                runningDays += "1";
            }
            else
            {
                runningDays += "0";
            }
            rEntMultiTrp.RunningDays = runningDays;
           
            dalCarPool.FillTripDetails(rEntMultiTrp);

        }
        ClientScript.RegisterStartupScript(this.GetType(), "result", "alert('Registered vehicle Successfully..')",true);

    }
    public RoutesEntity FillRouteEntity()
    {
        RoutesEntity rEntity = ((RoutesEntity)Session["RouteInfo"]);
        rEntity.StartDate = Convert.ToDateTime(txtStartDate.Text);
        rEntity.EndDate = Convert.ToDateTime(txtEndDate.Text);
        return rEntity;
    }
    public RoutesEntity FillRouteEntitySTrip()
    {
        RoutesEntity rEntity = ((RoutesEntity)Session["RouteInfo"]);
        rEntity.StartDate = Convert.ToDateTime(txtStartDate.Text);
        rEntity.EndDate = Convert.ToDateTime(txtStartDate.Text);
        DayOfWeek dayOfTravel = Convert.ToDateTime( txtStartDate.Text).DayOfWeek ;
        string runningDays = "";
        if (DayOfWeek.Monday == dayOfTravel)
        {
            runningDays = "1000000";
        }
        else if (DayOfWeek.Tuesday == dayOfTravel)
        {
            runningDays = "0100000";
        }
        else if (DayOfWeek.Wednesday == dayOfTravel)
        {
            runningDays = "0010000";
        }
        else if (DayOfWeek.Thursday == dayOfTravel)
        {
            runningDays = "0001000";
        }
        else if (DayOfWeek.Friday == dayOfTravel)
        {
            runningDays = "0000100";
        }
        else if (DayOfWeek.Saturday == dayOfTravel)
        {
            runningDays = "0000010";
        }
        else if (DayOfWeek.Sunday == dayOfTravel)
        {
            runningDays = "0000001";
        }
        rEntity.RunningDays = runningDays;
        return rEntity;
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Waypoints.aspx");
    }
}