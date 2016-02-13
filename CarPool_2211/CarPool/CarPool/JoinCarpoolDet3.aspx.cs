using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JoinCarpoolDetails : System.Web.UI.Page
{
    DataAccessLayer DALayer = new DataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        txtCarNumber.Text = Convert.ToString(Session["VehicleNum"]);
        int SeatsBooked = Convert.ToInt32(Session["noOfPassengers"]);

        if (!Page.IsPostBack)
        {
            //ddlBoardingPt.DataSource = DALayer.GetBoardingPt(CarId, RouteId);
            //ddlDropPt.DataSource = DALayer.GetDropPt(CarId, RouteId);
            //Page.DataBind();
        }
        if (SeatsBooked == 1)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = false;
            txtPassenger2.Visible = false;
            lblPassenger3.Visible = false;
            txtPassenger3.Visible = false;
            lblPassenger4.Visible = false;
            txtPassenger4.Visible = false;
            lblPassenger5.Visible = false;
            txtPassenger5.Visible = false;
            lblPassenger6.Visible = false;
            txtPassenger6.Visible = false;
            lblPassenger7.Visible = false;
            txtPassenger7.Visible = false;
            lblPassenger8.Visible = false;
            txtPassenger8.Visible = false;
            lblPassenger9.Visible = false;
            txtPassenger9.Visible = false;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = false;
            rfvPass3.Enabled = false;
            rfvPass4.Enabled = false;
            rfvPass5.Enabled = false;
            rfvPass6.Enabled = false;
            rfvPass7.Enabled = false;
            rfvPass8.Enabled = false;
            rfvPass9.Enabled = false;
            rfvPass10.Enabled = false;

        }
        if (SeatsBooked == 2)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = false;
            txtPassenger3.Visible = false;
            lblPassenger4.Visible = false;
            txtPassenger4.Visible = false;
            lblPassenger5.Visible = false;
            txtPassenger5.Visible = false;
            lblPassenger6.Visible = false;
            txtPassenger6.Visible = false;
            lblPassenger7.Visible = false;
            txtPassenger7.Visible = false;
            lblPassenger8.Visible = false;
            txtPassenger8.Visible = false;
            lblPassenger9.Visible = false;
            txtPassenger9.Visible = false;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = false;
            rfvPass4.Enabled = false;
            rfvPass5.Enabled = false;
            rfvPass6.Enabled = false;
            rfvPass7.Enabled = false;
            rfvPass8.Enabled = false;
            rfvPass9.Enabled = false;
            rfvPass10.Enabled = false;
        }
        if (SeatsBooked == 3)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = true;
            txtPassenger3.Visible = true;
            lblPassenger4.Visible = false;
            txtPassenger4.Visible = false;
            lblPassenger5.Visible = false;
            txtPassenger5.Visible = false;
            lblPassenger6.Visible = false;
            txtPassenger6.Visible = false;
            lblPassenger7.Visible = false;
            txtPassenger7.Visible = false;
            lblPassenger8.Visible = false;
            txtPassenger8.Visible = false;
            lblPassenger9.Visible = false;
            txtPassenger9.Visible = false;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = true;
            rfvPass4.Enabled = false;
            rfvPass5.Enabled = false;
            rfvPass6.Enabled = false;
            rfvPass7.Enabled = false;
            rfvPass8.Enabled = false;
            rfvPass9.Enabled = false;
            rfvPass10.Enabled = false;
        }
        if (SeatsBooked == 4)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = true;
            txtPassenger3.Visible = true;
            lblPassenger4.Visible = true;
            txtPassenger4.Visible = true;
            lblPassenger5.Visible = false;
            txtPassenger5.Visible = false;
            lblPassenger6.Visible = false;
            txtPassenger6.Visible = false;
            lblPassenger7.Visible = false;
            txtPassenger7.Visible = false;
            lblPassenger8.Visible = false;
            txtPassenger8.Visible = false;
            lblPassenger9.Visible = false;
            txtPassenger9.Visible = false;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = true;
            rfvPass4.Enabled = true;
            rfvPass5.Enabled = false;
            rfvPass6.Enabled = false;
            rfvPass7.Enabled = false;
            rfvPass8.Enabled = false;
            rfvPass9.Enabled = false;
            rfvPass10.Enabled = false;
        }
        if (SeatsBooked == 5)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = true;
            txtPassenger3.Visible = true;
            lblPassenger4.Visible = true;
            txtPassenger4.Visible = true;
            lblPassenger5.Visible = true;
            txtPassenger5.Visible = true;
            lblPassenger6.Visible = false;
            txtPassenger6.Visible = false;
            lblPassenger7.Visible = false;
            txtPassenger7.Visible = false;
            lblPassenger8.Visible = false;
            txtPassenger8.Visible = false;
            lblPassenger9.Visible = false;
            txtPassenger9.Visible = false;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = true;
            rfvPass4.Enabled = true;
            rfvPass5.Enabled = true;
            rfvPass6.Enabled = false;
            rfvPass7.Enabled = false;
            rfvPass8.Enabled = false;
            rfvPass9.Enabled = false;
            rfvPass10.Enabled = false;
        }
        if (SeatsBooked == 6)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = true;
            txtPassenger3.Visible = true;
            lblPassenger4.Visible = true;
            txtPassenger4.Visible = true;
            lblPassenger5.Visible = true;
            txtPassenger5.Visible = true;
            lblPassenger6.Visible = true;
            txtPassenger6.Visible = true;
            lblPassenger7.Visible = false;
            txtPassenger7.Visible = false;
            lblPassenger8.Visible = false;
            txtPassenger8.Visible = false;
            lblPassenger9.Visible = false;
            txtPassenger9.Visible = false;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = true;
            rfvPass4.Enabled = true;
            rfvPass5.Enabled = true;
            rfvPass6.Enabled = true;
            rfvPass7.Enabled = false;
            rfvPass8.Enabled = false;
            rfvPass9.Enabled = false;
            rfvPass10.Enabled = false;
        }
        if (SeatsBooked == 7)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = true;
            txtPassenger3.Visible = true;
            lblPassenger4.Visible = true;
            txtPassenger4.Visible = true;
            lblPassenger5.Visible = true;
            txtPassenger5.Visible = true;
            lblPassenger6.Visible = true;
            txtPassenger6.Visible = true;
            lblPassenger7.Visible = true;
            txtPassenger7.Visible = true;
            lblPassenger8.Visible = false;
            txtPassenger8.Visible = false;
            lblPassenger9.Visible = false;
            txtPassenger9.Visible = false;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = true;
            rfvPass4.Enabled = true;
            rfvPass5.Enabled = true;
            rfvPass6.Enabled = true;
            rfvPass7.Enabled = true;
            rfvPass8.Enabled = false;
            rfvPass9.Enabled = false;
            rfvPass10.Enabled = false;
        }
        if (SeatsBooked == 8)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = true;
            txtPassenger3.Visible = true;
            lblPassenger4.Visible = true;
            txtPassenger4.Visible = true;
            lblPassenger5.Visible = true;
            txtPassenger5.Visible = true;
            lblPassenger6.Visible = true;
            txtPassenger6.Visible = true;
            lblPassenger7.Visible = true;
            txtPassenger7.Visible = true;
            lblPassenger8.Visible = true;
            txtPassenger8.Visible = true;
            lblPassenger9.Visible = false;
            txtPassenger9.Visible = false;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = true;
            rfvPass4.Enabled = true;
            rfvPass5.Enabled = true;
            rfvPass6.Enabled = true;
            rfvPass7.Enabled = true;
            rfvPass8.Enabled = true;
            rfvPass9.Enabled = false;
            rfvPass10.Enabled = false;
        }
        if (SeatsBooked == 9)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = true;
            txtPassenger3.Visible = true;
            lblPassenger4.Visible = true;
            txtPassenger4.Visible = true;
            lblPassenger5.Visible = true;
            txtPassenger5.Visible = true;
            lblPassenger6.Visible = true;
            txtPassenger6.Visible = true;
            lblPassenger7.Visible = true;
            txtPassenger7.Visible = true;
            lblPassenger8.Visible = true;
            txtPassenger8.Visible = true;
            lblPassenger9.Visible = true;
            txtPassenger9.Visible = true;
            lblPassenger10.Visible = false;
            txtPassenger10.Visible = false;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = true;
            rfvPass4.Enabled = true;
            rfvPass5.Enabled = true;
            rfvPass6.Enabled = true;
            rfvPass7.Enabled = true;
            rfvPass8.Enabled = true;
            rfvPass9.Enabled = true;
            rfvPass10.Enabled = false;
        }
        if (SeatsBooked == 10)
        {
            lblPassenger1.Visible = true;
            txtPassenger1.Visible = true;
            lblPassenger2.Visible = true;
            txtPassenger2.Visible = true;
            lblPassenger3.Visible = true;
            txtPassenger3.Visible = true;
            lblPassenger4.Visible = true;
            txtPassenger4.Visible = true;
            lblPassenger5.Visible = true;
            txtPassenger5.Visible = true;
            lblPassenger6.Visible = true;
            txtPassenger6.Visible = true;
            lblPassenger7.Visible = true;
            txtPassenger7.Visible = true;
            lblPassenger8.Visible = true;
            txtPassenger8.Visible = true;
            lblPassenger9.Visible = true;
            txtPassenger9.Visible = true;
            lblPassenger10.Visible = true;
            txtPassenger10.Visible = true;
            rfvPass1.Enabled = true;
            rfvPass2.Enabled = true;
            rfvPass3.Enabled = true;
            rfvPass4.Enabled = true;
            rfvPass5.Enabled = true;
            rfvPass6.Enabled = true;
            rfvPass7.Enabled = true;
            rfvPass8.Enabled = true;
            rfvPass9.Enabled = true;
            rfvPass10.Enabled = true;
        }

    }  
  
    protected void btnBook_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //validate is successful.
            string TravelDate = Convert.ToString(Session["TravelDt"]);
            int SeatsBooked = Convert.ToInt32(Session["noOfPassengers"]);
            
            int ret;
            Boolean temp=false;
            string[] TravelDateSingle = TravelDate.Split('|');
            foreach (string TraDteSingle in TravelDateSingle)
            {
                ret = DALayer.insertBookingDetails(Convert.ToInt32(Session["CarId"]), Convert.ToInt32(Session["RouteId"]), SeatsBooked, Convert.ToString(TraDteSingle), Convert.ToString(txtPassenger1.Text), Convert.ToString(txtPassenger2.Text), Convert.ToString(txtPassenger3.Text), Convert.ToString(txtPassenger4.Text), Convert.ToString(txtPassenger5.Text), Convert.ToString(txtPassenger6.Text), Convert.ToString(txtPassenger7.Text), Convert.ToString(txtPassenger8.Text), Convert.ToString(txtPassenger9.Text), Convert.ToString(txtPassenger10.Text));
                if (ret == 0)
                    temp = true;
                else
                    temp = false;
            }
            if (temp == true)
            ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('Booking Successfully completed');", true);
            else
            ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('Some error occured');", true);            
        }
       
    }
   
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/JoinCarpool.aspx");
    }
}