using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterCar : System.Web.UI.Page
{
    DataAccessLayer dalRegisterCar = new DataAccessLayer();
    static int owner;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

           
            try
            {
                if (Session["userid"] != null)
                {
                    owner = Convert.ToInt32(Session["userid"]);

                    //Modlog Seema: Commented the below code 
                    //LinkButton lnkBtn= ((LinkButton)Page.Master.FindControl("lnkUserAccount"));
                    //lnkBtn.Visible = true;
                }

            }

            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('Some error occured');", true);
                return;
            }
        }
    }


    protected void btnRegister_Click(object sender, EventArgs e)
    {
        int ret;
        try
        {
            ret = dalRegisterCar.RegisterCar(txtVehicleNum.Text, txtManufacturer.Text, txtMake.Text, ddlCapacity.SelectedIndex, owner, txtColor.Text);
            if (ret == -1)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('The vehicle is already registered');", true);
                ClearFields();
            }
            else if (ret == -2)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('registration was not successful');", true);
                ClearFields();
            }
            else
            {
               
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('Your car is successfully registered.');", true);
                btnSelectWayPoints.Enabled = true;
                btnRegister.Enabled = false;
             }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('registration was not successful');", true);
            ClearFields();
        }
    }
    public void ClearFields()
    {
        txtMake.Text = "";
        txtManufacturer.Text = "";
        txtVehicleNum.Text = "";
        ddlCapacity.SelectedIndex = -1;
        upMainDetails.Update();
    }
    protected void btnSelectWayPoints_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Waypoints.aspx");
    }
}