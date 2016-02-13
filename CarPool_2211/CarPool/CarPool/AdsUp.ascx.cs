using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdsUp : System.Web.UI.UserControl
{
    static int i;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            i = 1;
            imgchange.ImageUrl = "~/Images/CarImages/Image" + i + ".jpg";
            i++;
        }
    }
    protected void imgtimer_Tick(object sender, EventArgs e)
    {

        if (i > 8)
            i = 1;
        else
        {
            imgchange.ImageUrl = "~/Images/CarImages/Image" + i + ".jpg";
            i++;
        }
    }
}