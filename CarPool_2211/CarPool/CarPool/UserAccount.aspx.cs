using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserAccount : System.Web.UI.Page
{
    DataAccessLayer dalRegisteredCars = new DataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!Page.IsPostBack)
        //{
        //    int userId = Convert.ToInt32( Session["userid"]);
        //    var registeredCars = dalRegisteredCars.ReadAllRegisteredCars(userId);
        //    mnuDetails.Items.Add(new MenuItem("Registered Cars"));
            
        //    foreach (var item in registeredCars)
        //    {
        //        MenuItem mn = new MenuItem(item.VehicleNumber);
        //        if (item.StartPnt != string.Empty && item.EndPnt != string.Empty)
        //        {
        //            mn.ChildItems.Add(new MenuItem(item.StartPnt + " to " + item.EndPnt));
        //        }
        //        mnuDetails.Items[0].ChildItems.Add(mn);

        //    }
        //}
    }
    //Modlock:@4-10-2013:Swati:changed UI handled:Start
   // protected void mnuUserInfo_MenuItemClick(object sender, MenuEventArgs e)
   // {
    //    if (e.Item.Text == "My Cars")
   //     {
    //        Response.Redirect("MyCars.aspx");
    //    }
    //    else if (e.Item.Text == "My Routes"){
    //        Response.Redirect("MyRoutes.aspx"); 
    //    }
    //    else if (e.Item.Text == "Joined"){
//
    //        Response.Redirect("JoinedPassengers.aspx"); 
   //     }
          
   // }
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
    //Modlock:@4-10-2013:Swati:changed UI handled:End
}