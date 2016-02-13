using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RoutesEntity
/// </summary>
public class RoutesEntity
{
    public int RouteID { get; set; }
    public int CarId { get; set; }
    public string StartPnt { get; set; }
    public string EndPnt { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime  EndDate { get; set; }
    public string RunningDays { get; set; }
    public List<string>  IntermediatePnts { get; set; }
    public string VehicleNumber { get; set; }
    public string Travel { get; set; }
    public string AllWayPoints { get; set; }
    public string StartDt { get; set; }
    public string EndDt { get; set; }
    //sWATI:mODloack:Added new field
    public string TravelDt { get; set; }
    public int SeatsAvailable { get; set; }
}

