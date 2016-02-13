using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyCars : System.Web.UI.Page
{
    DataAccessLayer dalRegisteredCars = new DataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int userId = Convert.ToInt32(Session["userid"]);
            FillGrdCarDetails(userId);

            //Modlog Start : Seema - 22/10/2013
            if (grdCarsInfo.Rows.Count > 0)
            {
                lnkNewCar.Text = "Register Another Car";
            }
            else
            {
                lnkNewCar.Text = "Register New Car";
            }
            //Modlog End : Seema - 22/10/2013
        }
    }

    public void FillGrdCarDetails(int userId)
    {
        var registeredCars = dalRegisteredCars.ReadAllRegisteredCarDetails(userId);
        grdCarsInfo.DataSource = registeredCars;
        Page.DataBind();
    }
    protected void grdCarsInfo_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdCarsInfo.EditIndex = e.NewEditIndex;
        int userId = Convert.ToInt32(Session["userid"]);
        FillGrdCarDetails( userId);
    }
    protected void grdCarsInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string vehicalNum = ((Label)grdCarsInfo.Rows[e.RowIndex].FindControl("lblVNumberEdit")).Text;
        string manufacturer = ((TextBox)grdCarsInfo.Rows[e.RowIndex].FindControl("txtManufacturer")).Text;
        string make = ((TextBox)grdCarsInfo.Rows[e.RowIndex].FindControl("txtMake")).Text;
        int capacity = Convert.ToInt32(((TextBox)grdCarsInfo.Rows[e.RowIndex].FindControl("txtCapacity")).Text);
        string color = ((TextBox)grdCarsInfo.Rows[e.RowIndex].FindControl("txtColor")).Text;
        int userId = Convert.ToInt32(Session["userid"]);

        CarDetailsEntity cdetails = new CarDetailsEntity { VehicleNumber = vehicalNum, Manufacturer = manufacturer, Make = make, Capacity = capacity, Color = color, Owner = userId };
        dalRegisteredCars.UpdateCarDetails(cdetails);
        grdCarsInfo.EditIndex = -1;
        FillGrdCarDetails(userId);


    }
    protected void grdCarsInfo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdCarsInfo.EditIndex = -1;
        int userId = Convert.ToInt32(Session["userid"]);
        FillGrdCarDetails(userId);
    }
    protected void grdCarsInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string vehicalNum = ((Label)grdCarsInfo.Rows[e.RowIndex].FindControl("lblVNumber")).Text;
        int userId = Convert.ToInt32(Session["userid"]);
        dalRegisteredCars.DeleteCarDetails(vehicalNum, userId);
        FillGrdCarDetails(userId);

    }

    //Modlog Start : Seema - 22/10/2013
    protected void lnkNewCar_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegisterCar.aspx");
    }
    //Modlog End : Seema - 22/10/2013
}