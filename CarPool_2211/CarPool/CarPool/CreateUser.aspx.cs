using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateUser : System.Web.UI.Page
{
    DataAccessLayer dalCreateUser = new DataAccessLayer();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        int ret;

        bool ret1 = false;

        try
        {
            //ret = dalCreateUser.createUser(Convert.ToInt32(txtEmpId.Text), txtPwd.Text, txtFirstName.Text, txtLastName.Text, txtUserId.Text, Convert.ToInt64(txtMobileNo.Text), txtLocation.Text, ddlCity.SelectedItem.Text);
            ret = dalCreateUser.createUser(Convert.ToInt32(txtEmpId.Text), txtPwd.Text, txtFirstName.Text, txtLastName.Text, Convert.ToInt64(txtMobileNo.Text), txtLocation.Text, ddlCity.SelectedItem.Text);

            // ModLock:22-Oct-2013:Swati:Commented code:Start
            //if (ret == -1)
            //{
            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('registration was not successfuL, the user id already exists');", true);
            //    txtPwd.Text = "";
            //    txtRePwd.Text = "";
            //    txtEmpId.Text = "";
            //    upMainDetails.Update();
            //    upRePwd.Update();
            //    return;
            //}
            //else if (ret == -1)
            // ModLock:22-Oct-2013:Swati:Commented code:End
            if (ret == -1)
            {
               ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('registration was not successfuL,you have already registered');", true);
               clear();
               upMainDetails.Update();
               upRePwd.Update();
               upLastDetails.Update();
                return;
            }
            else if(ret==0)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('You are successfully registered.Click on Log In button to Login');", true);
                clear();
                upMainDetails.Update();
                upRePwd.Update();
                upLastDetails.Update();
                if(Request.QueryString["page"]==string.Empty)
                {
                    return;
                }
              

            }
            else if (ret == 0)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('registration was not successful');", true);
                clear();
                upMainDetails.Update();
                upRePwd.Update();
                upLastDetails.Update();
                return;

            }

            ret1 = dalCreateUser.verifyExistance(Convert.ToInt32(txtEmpId.Text));
            if (ret1 == true)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('you have already registered');", true);
                clear();
                upMainDetails.Update();
                upRePwd.Update();
                upLastDetails.Update();
                return;
            }
            else
            {

                lblVerify.Text = "AVAILABLE";
                lblVerify.ForeColor = System.Drawing.Color.Green;
            }
        }
        
         catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('Error! try Again');", true);
            clear();
            upMainDetails.Update();
            upRePwd.Update();
            upLastDetails.Update();
            return;
        }  
    

    }

    public void clear()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmpId.Text = "";
        txtLocation.Text = "";
        txtMobileNo.Text = "";
        txtPwd.Text = "";
        txtRePwd.Text = "";
        txtEmpId.Text = "";
        ddlCity.SelectedIndex = 0;
        lblVerify.Text = "";
    }

    //protected void btnVerify_Click(object sender, EventArgs e)
    //{
    //    bool ret = false;

    //    try
    //    {
    //        ret = dalCreateUser.verifyExistance(Convert.ToInt32(txtEmpId.Text));
    //        if (ret == true)
    //        {
    //            ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('you have already registered');", true);
    //            clear();
    //            upMainDetails.Update();
    //            upRePwd.Update();
    //            upLastDetails.Update();
    //            return;
    //        }
    //        else
    //        {

    //            lblVerify.Text = "AVAILABLE";
    //            lblVerify.ForeColor = System.Drawing.Color.Green;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        ScriptManager.RegisterStartupScript(this, this.GetType(), "myscript", "alert('Error! try Again');", true);
    //        clear();
    //        upMainDetails.Update();
    //        upRePwd.Update();
    //        upLastDetails.Update();
    //        return;
    //    }

    //}
}