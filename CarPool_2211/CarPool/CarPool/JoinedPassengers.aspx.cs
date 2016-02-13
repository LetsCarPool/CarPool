using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JoinedPassengers : System.Web.UI.Page
{
    DataAccessLayer dalRegisteredCars = new DataAccessLayer();
    static int userId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            userId = Convert.ToInt32(Session["userid"]);
            FillPassengerInfoGrids();
        }
        
    }
    public void FillPassengerInfoGrids()
    {
          string personDetails="";
            var passengerInfo = dalRegisteredCars.ReadPassengerInfo(userId, out personDetails);

            if (personDetails == "Owner")
            {
                grdPassengerInfo.Visible = true;
                grdPassengerInfo.DataSource = passengerInfo;
            }
            else if (personDetails == "Passenger")
            {
                grdJoinedPassengerInfo.Visible = true;
                grdJoinedPassengerInfo.DataSource = passengerInfo;
            }
            Page.DataBind();

       
    }
    //protected void grdJoinedPassengerInfo_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    grdJoinedPassengerInfo.EditIndex = e.NewEditIndex;
    //    FillPassengerInfoGrids();

    //}
    //protected void grdJoinedPassengerInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
    //{

    //}
    //protected void grdJoinedPassengerInfo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    //{
    //    grdJoinedPassengerInfo.EditIndex = -1;
    //    FillPassengerInfoGrids();
    //}
    protected void grdJoinedPassengerInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string vehNum=((Label)grdJoinedPassengerInfo.Rows[e.RowIndex].FindControl("lblVNumber")).Text ;
        dalRegisteredCars.DeletePassengerInfo(userId, vehNum);
    }
}