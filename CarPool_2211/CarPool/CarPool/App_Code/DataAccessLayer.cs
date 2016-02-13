using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.Collections;

/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
[DataObject(true)]
public class DataAccessLayer
{
    SqlConnection Con;
	public DataAccessLayer()
	{

        Con = new SqlConnection(ConfigurationManager.ConnectionStrings["CarPoolConnStr"].ToString());

	}
    /*****Modlock:25-10-2013 Swati:Added Function: Start:

     /*************************************************************************************
     * Method Name      :  GetStartPoint                                            
     * Return Value     :  list                                                
     * Input Parameters :  none                                                 
     * Description      :  This method fetches the start points for populating the dropdown.
     *************************************************************************************/

    public List<string>  GetStartPoint()
    {
        List<string> StPointLst = new List<string>();
        SqlCommand cmd = new SqlCommand("select distinct Startpoint,Intermediatepoint1,Intermediatepoint2,Intermediatepoint3,Intermediatepoint4,Intermediatepoint5,Intermediatepoint6,Intermediatepoint7,Intermediatepoint8,Intermediatepoint9,Intermediatepoint10 from tbl_RouteTable ", Con);

        try
        {
            Con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr[0]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[0]));
                }
                if (Convert.ToString(dr[1]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[1]));
                }
                if (Convert.ToString(dr[2]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[2]));
                }
                if (Convert.ToString(dr[3]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[3]));
                }
                if (Convert.ToString(dr[4]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[4]));
                }
                if (Convert.ToString(dr[5]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[5]));
                }
                if (Convert.ToString(dr[6]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[6]));
                }
                if (Convert.ToString(dr[7]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[7]));
                }
                if (Convert.ToString(dr[8]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[8]));
                }
                if (Convert.ToString(dr[9]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[9]));
                }
                if (Convert.ToString(dr[10]) != "")
                {
                    StPointLst.Add(Convert.ToString(dr[10]));
                }
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }
        return StPointLst;

    }


    /*************************************************************************************
    * Method Name      :  GetDestination                                            
    * Return Value     :  list                                                
    * Input Parameters :  none                                                 
    * Description      :  This method fetches the start points for populating the dropdown.
    *************************************************************************************/

    public List<string> GetDestination()
    {
        List<string> DestinationLst = new List<string>();
        SqlCommand cmd = new SqlCommand("select distinct Destination,Intermediatepoint1,Intermediatepoint2,Intermediatepoint3,Intermediatepoint4,Intermediatepoint5,Intermediatepoint6,Intermediatepoint7,Intermediatepoint8,Intermediatepoint9,Intermediatepoint10 from tbl_RouteTable ", Con);

        try
        {
            Con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToString(dr[0]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[0]));
                }
                if (Convert.ToString(dr[1]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[1]));
                }
                if (Convert.ToString(dr[2]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[2]));
                }
                if (Convert.ToString(dr[3]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[3]));
                }
                if (Convert.ToString(dr[4]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[4]));
                }
                if (Convert.ToString(dr[5]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[5]));
                }
                if (Convert.ToString(dr[6]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[6]));
                }
                if (Convert.ToString(dr[7]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[7]));
                }
                if (Convert.ToString(dr[8]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[8]));
                }
                if (Convert.ToString(dr[9]) != "")
                {
                    DestinationLst.Add(Convert.ToString(dr[9]));
                }
                if (Convert.ToString(dr[10]) != "")
                {
                DestinationLst.Add(Convert.ToString(dr[10]));
                    }
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }
        return DestinationLst;

    }



    public List<RoutesEntity> searchRoute(DateTime startDate, DateTime endDate, string startPoint, string destination)
    {
        List<RoutesEntity> SearchCars = new List<RoutesEntity>();
        string query;
        //SqlCommand cmdSearchRoute = new SqlCommand("usp_searchRoute", Con);
        string p1 = "SELECT cd.VehicleNumber,rt.carID,rt.Startpoint,rt.Destination,rt.StartDate,rt.EndDate,rt.RunningDays,rt.Intermediatepoint1  ";
        string p2 = ",rt.Intermediatepoint2,rt.Intermediatepoint3,rt.Intermediatepoint4,rt.Intermediatepoint5,rt.Intermediatepoint6, ";
        string p3 = "rt.Intermediatepoint7,rt.Intermediatepoint8,rt.Intermediatepoint9,rt.Intermediatepoint10,rt.RouteID ";
        string p4 = "FROM TBL_ROUTETABLE RT INNER JOIN tbl_CarDetails CD ON RT.CarID=CD.CarID ";
        string passeneger = p1 + p2 + p3 + p4;
        query = passeneger + " WHERE (STARTPOINT='" + startPoint + "' OR INTERMEDIATEPOINT1='" + startPoint + "' OR INTERMEDIATEPOINT2='" + startPoint + "' OR INTERMEDIATEPOINT3='" + startPoint + "' OR INTERMEDIATEPOINT4='" + startPoint + "' OR INTERMEDIATEPOINT5='" + startPoint + "' OR INTERMEDIATEPOINT6='" + startPoint + "' OR INTERMEDIATEPOINT7='" + startPoint + "' OR INTERMEDIATEPOINT8='" + startPoint + "' OR INTERMEDIATEPOINT9='" + startPoint + "' OR INTERMEDIATEPOINT10='" + startPoint + "') AND (DESTINATION='" + destination + "' OR INTERMEDIATEPOINT1='" + destination + "' OR INTERMEDIATEPOINT2='" + destination + "' OR INTERMEDIATEPOINT3='" + destination + "' OR INTERMEDIATEPOINT4='" + destination + "'  OR INTERMEDIATEPOINT5='" + destination + "' OR INTERMEDIATEPOINT6='" + destination + "'  OR INTERMEDIATEPOINT7='" + destination + "' OR INTERMEDIATEPOINT8='" + destination + "' OR INTERMEDIATEPOINT9='" + destination + "' OR INTERMEDIATEPOINT10='" + destination + "') AND (rt.StartDate<='" + startDate + "' AND rt.EndDate>='" + endDate + "')";
        SqlCommand cmdSearchRoute = new SqlCommand(query, Con);
        //cmdSearchRoute.CommandType = CommandType.StoredProcedure;

        //cmdSearchRoute.Parameters.AddWithValue("@STARTDATE", startDate);
        //cmdSearchRoute.Parameters.AddWithValue("@ENDDATE", endDate);
        // cmdSearchRoute.Parameters.AddWithValue("@STARTPOINT", startPoint);
        //cmdSearchRoute.Parameters.AddWithValue("@DESTINATION", destination);
        //cmdSearchRoute.Parameters.AddWithValue("@NOOFPASSENGER", noOfPassengers);
        try
        {
            Con.Open();
            SqlDataReader dr = cmdSearchRoute.ExecuteReader();
            while (dr.Read())
            {
                SearchCars.Add(new RoutesEntity
                {
                    VehicleNumber = Convert.ToString(dr[0]),
                    CarId = Convert.ToInt32(dr[1]),
                    StartPnt = Convert.ToString(dr[2]),
                    EndPnt = Convert.ToString(dr[3]),
                    StartDt = Convert.ToDateTime(dr[4]).ToShortDateString(),
                    EndDt = Convert.ToDateTime(dr[5]).ToShortDateString(),
                    RunningDays = Convert.ToString(dr[6]),
                    AllWayPoints = Convert.ToString(dr[7]) + " " + Convert.ToString(dr[8]) + " " + Convert.ToString(dr[9]) + " " + Convert.ToString(dr[10]) + " " + Convert.ToString(dr[11]) + " " + Convert.ToString(dr[12]) + " " + Convert.ToString(dr[13]) + " " + Convert.ToString(dr[14]) + " " + Convert.ToString(dr[15]) + " " + Convert.ToString(dr[16]),
                    RouteID = Convert.ToInt32(dr[17])
                });
            }
        }
        catch (SqlException ex)
        {
            throw ex;

        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            Con.Close();
        }
        return SearchCars;
    }

    public List<RoutesEntity> searchRouteNearestMatch(DateTime startDate, DateTime endDate, string startPoint, string destination)
    {
        List<RoutesEntity> SearchCars = new List<RoutesEntity>();
        string query;

        string p1 = "SELECT cd.VehicleNumber,rt.carID,rt.Startpoint,rt.Destination,rt.StartDate,rt.EndDate,rt.RunningDays,rt.Intermediatepoint1  ";
        string p2 = ",rt.Intermediatepoint2,rt.Intermediatepoint3,rt.Intermediatepoint4,rt.Intermediatepoint5,rt.Intermediatepoint6, ";
        string p3 = "rt.Intermediatepoint7,rt.Intermediatepoint8,rt.Intermediatepoint9,rt.Intermediatepoint10,rt.RouteID ";
        string p4 = "FROM TBL_ROUTETABLE RT INNER JOIN tbl_CarDetails CD ON RT.CarID=CD.CarID ";
        string passeneger = p1 + p2 + p3 + p4;
        query = passeneger + " WHERE (STARTPOINT='" + startPoint + "' OR INTERMEDIATEPOINT1='" + startPoint + "' OR INTERMEDIATEPOINT2='" + startPoint + "' OR INTERMEDIATEPOINT3='" + startPoint + "' OR INTERMEDIATEPOINT4='" + startPoint + "' OR INTERMEDIATEPOINT5='" + startPoint + "' OR INTERMEDIATEPOINT6='" + startPoint + "' OR INTERMEDIATEPOINT7='" + startPoint + "' OR INTERMEDIATEPOINT8='" + startPoint + "' OR INTERMEDIATEPOINT9='" + startPoint + "' OR INTERMEDIATEPOINT10='" + startPoint + "') AND (DESTINATION='" + destination + "' OR INTERMEDIATEPOINT1='" + destination + "' OR INTERMEDIATEPOINT2='" + destination + "' OR INTERMEDIATEPOINT3='" + destination + "' OR INTERMEDIATEPOINT4='" + destination + "'  OR INTERMEDIATEPOINT5='" + destination + "' OR INTERMEDIATEPOINT6='" + destination + "'  OR INTERMEDIATEPOINT7='" + destination + "' OR INTERMEDIATEPOINT8='" + destination + "' OR INTERMEDIATEPOINT9='" + destination + "' OR INTERMEDIATEPOINT10='" + destination + "') AND (rt.StartDate<='" + startDate + "' OR rt.EndDate>='" + endDate + "')";
        SqlCommand cmdSearchRoute = new SqlCommand(query, Con);

        try
        {
            Con.Open();
            SqlDataReader dr = cmdSearchRoute.ExecuteReader();
            while (dr.Read())
            {
                SearchCars.Add(new RoutesEntity
                {
                    VehicleNumber = Convert.ToString(dr[0]),
                    CarId = Convert.ToInt32(dr[1]),
                    StartPnt = Convert.ToString(dr[2]),
                    EndPnt = Convert.ToString(dr[3]),
                    StartDt = Convert.ToDateTime(dr[4]).ToShortDateString(),
                    EndDt = Convert.ToDateTime(dr[5]).ToShortDateString(),
                    RunningDays = Convert.ToString(dr[6]),
                    AllWayPoints = Convert.ToString(dr[7]) + " " + Convert.ToString(dr[8]) + " " + Convert.ToString(dr[9]) + " " + Convert.ToString(dr[10]) + " " + Convert.ToString(dr[11]) + " " + Convert.ToString(dr[12]) + " " + Convert.ToString(dr[13]) + " " + Convert.ToString(dr[14]) + " " + Convert.ToString(dr[15]) + " " + Convert.ToString(dr[16]),
                    RouteID = Convert.ToInt32(dr[17])
                });
            }
        }
        catch (SqlException ex)
        {
            throw ex;

        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            Con.Close();
        }
        return SearchCars;
    }
    /*************************************************************************************
    * Method Name      :  searchRoute                                            
    * Return Value     :  list                                                
    * Input Parameters :  startDate,endDate,startPoint,destination,noOfPassengers                                                  
    * Description      :  This method fetches the searched cars.
    *************************************************************************************/

    public List<RoutesEntity> searchRoute(int carId, int routeId, DateTime startDate, DateTime endDate, int noOfPassengers)
    {
        List<RoutesEntity> SearchCars = new List<RoutesEntity>();
        string query;
        //SqlCommand cmdSearchRoute = new SqlCommand("usp_searchRoute", Con);
        string p1 = "SELECT cd.VehicleNumber,rt.carID,rt.Startpoint,rt.Destination,rt.StartDate,rt.EndDate,rt.RunningDays,rt.Intermediatepoint1  ";
        string p2 = ",rt.Intermediatepoint2,rt.Intermediatepoint3,rt.Intermediatepoint4,rt.Intermediatepoint5,rt.Intermediatepoint6, ";
        string p3 = "rt.Intermediatepoint7,rt.Intermediatepoint8,rt.Intermediatepoint9,rt.Intermediatepoint10,TP.SeatsAvailable,rt.RouteID,tp.date ";
        string p4 = "FROM TBL_ROUTETABLE RT INNER JOIN tbl_CarDetails CD ON RT.CarID=CD.CarID ";
        string p5 = "INNER JOIN tbl_Trip TP ON (TP.CarID=CD.CarID AND TP.RouteId=RT.RouteID)";
        string passeneger = p1 + p2 + p3 + p4 + p5;
        query = passeneger + " WHERE rt.carId=" + carId + " AND rt.routeId=" + routeId + " AND (tp.date>='" + startDate + "' AND tp.date<='" + endDate + "') AND TP.SeatsAvailable>=" + noOfPassengers;
        SqlCommand cmdSearchRoute = new SqlCommand(query, Con);
        //cmdSearchRoute.CommandType = CommandType.StoredProcedure;

        //cmdSearchRoute.Parameters.AddWithValue("@STARTDATE", startDate);
        //cmdSearchRoute.Parameters.AddWithValue("@ENDDATE", endDate);
        // cmdSearchRoute.Parameters.AddWithValue("@STARTPOINT", startPoint);
        //cmdSearchRoute.Parameters.AddWithValue("@DESTINATION", destination);
        //cmdSearchRoute.Parameters.AddWithValue("@NOOFPASSENGER", noOfPassengers);
        try
        {
            Con.Open();
            SqlDataReader dr = cmdSearchRoute.ExecuteReader();
            while (dr.Read())
            {
                SearchCars.Add(new RoutesEntity
                {
                    VehicleNumber = Convert.ToString(dr[0]),
                    CarId = Convert.ToInt32(dr[1]),
                    StartPnt = Convert.ToString(dr[2]),
                    EndPnt = Convert.ToString(dr[3]),
                    StartDt = Convert.ToDateTime(dr[4]).ToShortDateString(),
                    EndDt = Convert.ToDateTime(dr[5]).ToShortDateString(),
                    RunningDays = Convert.ToString(dr[6]),
                    AllWayPoints = Convert.ToString(dr[7]) + " " + Convert.ToString(dr[8]) + " " + Convert.ToString(dr[9]) + " " + Convert.ToString(dr[10]) + " " + Convert.ToString(dr[11]) + " " + Convert.ToString(dr[12]) + " " + Convert.ToString(dr[13]) + " " + Convert.ToString(dr[14]) + " " + Convert.ToString(dr[15]) + " " + Convert.ToString(dr[16]),
                    SeatsAvailable = Convert.ToInt32(dr[17]),
                    RouteID = Convert.ToInt32(dr[18]),
                    TravelDt = Convert.ToDateTime(dr[19]).ToShortDateString()
                });
            }
        }
        catch (SqlException ex)
        {
            throw ex;

        }
        catch (Exception ex)
        {
            throw ex;

        }
        finally
        {
            Con.Close();
        }
        return SearchCars;
    }


    public int insertBookingDetails(int carId, int routeId, int noOfSeats, string date, string passenger1, string passenger2, string passenger3, string passenger4, string passenger5, string passenger6, string passenger7, string passenger8, string passenger9, string passenger10)
    {
        SqlCommand cmdinsertBookingDet = new SqlCommand("usp_InsertBookingDetails", Con);
        cmdinsertBookingDet.CommandType = CommandType.StoredProcedure;

        cmdinsertBookingDet.Parameters.AddWithValue("@CARID", carId);
        cmdinsertBookingDet.Parameters.AddWithValue("@ROUTEID", routeId);
        cmdinsertBookingDet.Parameters.AddWithValue("@NOOFSEATS", noOfSeats);
        //if (date != null)
        cmdinsertBookingDet.Parameters.AddWithValue("@DATE", date);
        //else
        //cmdinsertBookingDet.Parameters.AddWithValue("@DATE", DBNull.Value);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER1", passenger1);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER2", passenger2);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER3", passenger3);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER4", passenger4);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER5", passenger5);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER6", passenger6);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER7", passenger7);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER8", passenger8);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER9", passenger9);
        cmdinsertBookingDet.Parameters.AddWithValue("@PASSENGER10", passenger10);
        SqlParameter ret = new SqlParameter();
        ret.SqlDbType = SqlDbType.Int;
        ret.Direction = ParameterDirection.ReturnValue;
        cmdinsertBookingDet.Parameters.Add(ret);
        try
        {
            Con.Open();
            cmdinsertBookingDet.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }
        return Convert.ToInt32(ret.Value);
    }



    /*****Modlock:25-10-2013 Swati:Added Function: End
     * 
  /*************************************************************************************
  * Method Name      :  validateLogin                                            
  * Return Value     :  bool, true if user is valid. else false                                                 
  * Input Parameters :  emailId,password                                                  
  * Description      :  This method validates the user name and password
  *************************************************************************************/

    public bool validateLogin(string empId, string password)
    {
        bool ret = false;
        //SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_User WHERE employeeid = '"+empId+"' AND CAST(Password AS varbinary(15)) = CAST('"+password+"' AS varbinary(15)) AND Password ='"+password+"'", Con);
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_User WHERE employeeid = " + empId + " AND  Password ='" + password + "'", Con);

        try
        {
            Con.Open();
            //Execute the Query

            int i=Convert.ToInt32(cmd.ExecuteScalar());
            if (i != 0)
                ret = true;

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return ret;
    }

    /*************************************************************************************
  * Method Name      :  createUser                                            
  * Return Value     :  int                                              
  * Input Parameters :  emailId,password                                                  
  * Description      :  This method validates the user name and password
  *************************************************************************************/
    //public int createUser(int empId,string pwd,string firstName,string lastName,string userId,Int64 mobileNo,string location,string city)
    public int createUser(int empId, string pwd, string firstName, string lastName,  Int64 mobileNo, string location, string city)
    {
        SqlCommand cmdCreateUser = new SqlCommand("usp_InsertUser", Con);
        cmdCreateUser.CommandType = CommandType.StoredProcedure;

        cmdCreateUser.Parameters.AddWithValue("@EmployeeId", empId);
        cmdCreateUser.Parameters.AddWithValue("@Password", pwd);
        cmdCreateUser.Parameters.AddWithValue("@FirstName", firstName);
        cmdCreateUser.Parameters.AddWithValue("@LastName", lastName);
        //cmdCreateUser.Parameters.AddWithValue("@UserId", userId);
        cmdCreateUser.Parameters.AddWithValue("@MobileNumber", mobileNo);
        cmdCreateUser.Parameters.AddWithValue("@SeatingLocation", location);
        cmdCreateUser.Parameters.AddWithValue("@City", city);

        SqlParameter ret = new SqlParameter();
        ret.SqlDbType = SqlDbType.Int;
        ret.Direction = ParameterDirection.ReturnValue;
        cmdCreateUser.Parameters.Add(ret);


        try
        {
            Con.Open();
            cmdCreateUser.ExecuteNonQuery();
           
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }
        return Convert.ToInt32(ret.Value);
    }

    /*************************************************************************************
    * Method Name      :  validateLogin                                            
    * Return Value     :  bool, true if user is valid. else false                                                 
    * Input Parameters :  emailId,password                                                  
    * Description      :  This method validates the user name and password
    *************************************************************************************/

    public bool verifyExistance(int empId)
    {
        bool ret = false;
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_User WHERE EmployeeId="+empId, Con);
        try
        {
            Con.Open();
            //Execute the Query

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i != 0)
                ret = true;

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return ret;
    }

    /*************************************************************************************
    * Method Name      :  getEmpId                                          
    * Return Value     :  int,gets the car id                                            
    * Input Parameters :  -                                            
    * Description      :  This method  generates the next car id
    *************************************************************************************/

    public string getEmpFirstname(int empId)
    {
        string fName = "";
        SqlCommand cmd = new SqlCommand("SELECT FirstName FROM tbl_User WHERE employeeid = " + empId + "", Con);
        try
        {
            Con.Open();
            //Execute the Query

            fName = Convert.ToString(cmd.ExecuteScalar());

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return fName;
    }

    /*************************************************************************************
 * Method Name      :  RegisterCar                                            
 * Return Value     :  int                                              
 * Input Parameters :  emailId,password                                                  
 * Description      :  This method validates the user name and password
 *************************************************************************************/
    public int RegisterCar(string VehicleNumber, string Manufacturer, string Make, int Capacity, int Owner,string Color)
    {
        SqlCommand cmdCreateUser = new SqlCommand("usp_InsertCarDetails", Con);
        cmdCreateUser.CommandType = CommandType.StoredProcedure;

        cmdCreateUser.Parameters.AddWithValue("@VehicleNumber", VehicleNumber);
        cmdCreateUser.Parameters.AddWithValue("@Manufacturer", Manufacturer);
        cmdCreateUser.Parameters.AddWithValue("@Make", Make);
        cmdCreateUser.Parameters.AddWithValue("@Capacity", Capacity);
        cmdCreateUser.Parameters.AddWithValue("@Owner", Owner);
        cmdCreateUser.Parameters.AddWithValue("@Color", Color);
        SqlParameter ret = new SqlParameter();
        ret.SqlDbType = SqlDbType.Int;
        ret.Direction = ParameterDirection.ReturnValue;
        cmdCreateUser.Parameters.Add(ret);


        try
        {
            Con.Open();
            cmdCreateUser.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }
        return Convert.ToInt32(ret.Value);
    }

    /*************************************************************************************
   * Method Name      :  ReadRegisteredCars                                            
   * Return Value     :  List<String>                                                
   * Input Parameters :  Owner                                                
   * Description      :  This method is used to read all registered cars for a given account
   *************************************************************************************/
    public List<string> ReadRegisteredCars(int Owner)
    {
        List<string> carsLst = new List<string>();
        SqlCommand cmd = new SqlCommand("SELECT VehicleNumber FROM tbl_CarDetails WHERE Owner =" + Owner.ToString(), Con);
        try
        {
            Con.Open();
            //Execute the Query

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                carsLst.Add(Convert.ToString(dr[0]));
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return carsLst;
    }

    /*************************************************************************************
  * Method Name      :  ReadRegisteredCarsCount                                           
  * Return Value     :  int                                               
  * Input Parameters :  Owner                                                
  * Description      :  This method is used to read count of registered cars for a given account
  *************************************************************************************/
    public int ReadRegisteredCarsCount(int Owner)
    {
        int carCnt=0;

        SqlCommand cmd = new SqlCommand("SELECT count(*) FROM tbl_CarDetails WHERE Owner =" + Owner.ToString(), Con);
        try
        {
            Con.Open();
            //Execute the Query

            carCnt =Convert.ToInt32( cmd.ExecuteScalar());
           

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return carCnt;
    }

    /*************************************************************************************
  * Method Name      :  ReadAllRegisteredCars                                           
  * Return Value     :  List<string>                                               
  * Input Parameters :  Owner                                                
  * Description      :  This method is used to read all registered cars for a given account
  *************************************************************************************/
    public List<RoutesEntity> ReadAllRegisteredCars(int Owner)
    {
        List<RoutesEntity> RegisterdCars = new List<RoutesEntity>();
        //int Owner = getEmpId(OwnerName);
       // SqlCommand cmd = new SqlCommand("SELECT VehicleNumber FROM tbl_CarDetails WHERE Owner =" + OwnerName.ToString(), Con);
        SqlCommand cmd = new SqlCommand("select tc.VehicleNumber,tr.Startpoint,tr.Destination  from tbl_cardetails tc left outer join tbl_RouteTable tr on tc.CarId =tr.carid and tc.Owner=" + Owner.ToString(), Con);
        try
        {
            Con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                RegisterdCars.Add(new RoutesEntity { VehicleNumber = Convert.ToString(dr[0]), StartPnt = Convert.ToString(dr[1]), EndPnt = Convert.ToString(dr[2]) });
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return RegisterdCars;
    }

    /*************************************************************************************
  * Method Name      :  ReadCarId                                           
  * Return Value     :  int                                               
  * Input Parameters :  Owner                                                
  * Description      :  This method is used to read carid for the given vehicle number
  *************************************************************************************/
    public int ReadCarId(string vehicleNumber)
    {
        int carId = 0;

        SqlCommand cmd = new SqlCommand("SELECT carid FROM tbl_CarDetails WHERE VehicleNumber ='" + vehicleNumber + "'", Con);
        try
        {
            Con.Open();
            //Execute the Query

            carId = Convert.ToInt32(cmd.ExecuteScalar());


        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return carId;
    }
    /*************************************************************************************
  * Method Name      :  FillTripDetails                                           
  * Return Value     :  int                                               
  * Input Parameters :  RoutesEntity                                                
  * Description      :  This method is used to insert all vehical trip details in to Database
  *************************************************************************************/
    public int FillTripDetails(RoutesEntity rEnt)
    {
   

        SqlCommand cmdCreateRoute = new SqlCommand("usp_InsertRoute", Con);
        cmdCreateRoute.CommandType = CommandType.StoredProcedure;

        cmdCreateRoute.Parameters.AddWithValue("@carId", rEnt.CarId);
        cmdCreateRoute.Parameters.AddWithValue("@startPoint", rEnt.StartPnt);
        //Modlog : Seema - 22/10/2013 - Modified parameter names to align with table column names
        cmdCreateRoute.Parameters.AddWithValue("@Destination", rEnt.EndPnt);
        cmdCreateRoute.Parameters.AddWithValue("@StartDate", rEnt.StartDate);
        cmdCreateRoute.Parameters.AddWithValue("@EndDate", rEnt.EndDate);
        cmdCreateRoute.Parameters.AddWithValue("@runningDays", rEnt.RunningDays);
        int i = 1;
        foreach (var item in rEnt.IntermediatePnts )
        {
            var pnts = item.Substring(0, item.IndexOf(',', item.IndexOf(',') + 1));
            cmdCreateRoute.Parameters.AddWithValue("@Intermediatepoint" + i.ToString(), pnts);
            i++;
        }
       
        SqlParameter ret = new SqlParameter();
        ret.SqlDbType = SqlDbType.Int;
        ret.Direction = ParameterDirection.ReturnValue;
        cmdCreateRoute.Parameters.Add(ret);


        try
        {
            Con.Open();
            cmdCreateRoute.ExecuteNonQuery();
           
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }
        return Convert.ToInt32(ret.Value);

     

    }

    /*************************************************************************************
  * Method Name      :  ReadAllRegisteredCarDetails                                           
  * Return Value     :  List<CarDetails>                                               
  * Input Parameters :  OwnerName                                                
  * Description      :  This method is used to read all registered car details for a owner
  *************************************************************************************/
    public List<CarDetailsEntity> ReadAllRegisteredCarDetails(int Owner)
    {
        List<CarDetailsEntity> carsLst = new List<CarDetailsEntity>();
        SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_CarDetails WHERE Owner =" + Owner.ToString(), Con);
        try
        {
            Con.Open();
            //Execute the Query

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                carsLst.Add(new CarDetailsEntity { CarId = Convert.ToInt32(dr[0]), VehicleNumber = Convert.ToString(dr[1]),
                                             Manufacturer = Convert.ToString(dr[2]),
                                             Make = Convert.ToString(dr[3]),Capacity = Convert.ToInt32(dr[4]),
                                             Color = Convert.ToString(dr[6])
                });
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return carsLst;
    }
    /*************************************************************************************
* Method Name      :  UpdateCarDetails                                           
* Return Value     :  void                                               
* Input Parameters :  CarDetails                                                
* Description      :  This method is used to update registered car details for a owner
*************************************************************************************/
    public void UpdateCarDetails(CarDetailsEntity carInfo)
    {

        SqlCommand cmdUpdateCarDetails = new SqlCommand("usp_UpdateCarInfo", Con);
        cmdUpdateCarDetails.CommandType = CommandType.StoredProcedure;

        cmdUpdateCarDetails.Parameters.AddWithValue("@VehicleNumber", carInfo.VehicleNumber);
        cmdUpdateCarDetails.Parameters.AddWithValue("@Manufacturer", carInfo.Manufacturer);
        cmdUpdateCarDetails.Parameters.AddWithValue("@Make", carInfo.Make);
        cmdUpdateCarDetails.Parameters.AddWithValue("@Owner", carInfo.Owner);
        cmdUpdateCarDetails.Parameters.AddWithValue("@Color", carInfo.Color);
        cmdUpdateCarDetails.Parameters.AddWithValue("@Capacity", carInfo.Capacity);
     
        try
        {
            Con.Open();
            cmdUpdateCarDetails.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }


    }
    /*************************************************************************************
* Method Name      :  DeleteCarDetails                                           
* Return Value     :  void                                               
* Input Parameters :  VehicleNumber, Owner                                                
* Description      :  This method is used to update registered car details for a owner
*************************************************************************************/
    public void DeleteCarDetails(string VehicleNumber,int Owner )
    {

        SqlCommand cmdDeleteCarDetails = new SqlCommand("usp_DelcarInfo", Con);
        cmdDeleteCarDetails.CommandType = CommandType.StoredProcedure;

        cmdDeleteCarDetails.Parameters.AddWithValue("@VehicleNumber", VehicleNumber);
        cmdDeleteCarDetails.Parameters.AddWithValue("@Owner", Owner);
        try
        {
            Con.Open();
            cmdDeleteCarDetails.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }


    }

    /*************************************************************************************
  * Method Name      :  ReadRoutesInfo                                           
  * Return Value     :  List<MyRoutesEntity>                                               
  * Input Parameters :  Owner                                                
  * Description      :  This method is used to read all routes for the registered cars to a specific owner
  *************************************************************************************/
    public List<RoutesEntity> ReadRoutesInfo(int Owner)
    {
        List<RoutesEntity> myRoutes = new List<RoutesEntity>();
        SqlCommand cmd = new SqlCommand("select cd.VehicleNumber ,rt.StartDate,rt.EndDate, rt.Startpoint,rt.Destination,rt.RunningDays,rt.Intermediatepoint1,rt.Intermediatepoint2,rt.Intermediatepoint3,rt.Intermediatepoint4,rt.Intermediatepoint5,rt.Intermediatepoint6,rt.Intermediatepoint7,rt.Intermediatepoint8,rt.Intermediatepoint9,rt.Intermediatepoint10,rt.RouteID from tbl_CarDetails cd inner join tbl_RouteTable rt on cd.CarId=rt.CarID and cd.Owner="+Owner , Con);
        try
        {
            Con.Open();
            //Execute the Query

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                RoutesEntity rEnt=new RoutesEntity
                {
                    VehicleNumber = Convert.ToString(dr[0]),
                    StartDt = Convert.ToDateTime(dr[1]).ToShortDateString(),EndDt = Convert.ToDateTime(dr[2]).ToShortDateString(),
                    StartPnt =Convert.ToString(dr[3]),EndPnt =Convert.ToString(dr[4]),RunningDays=Convert.ToString(dr[5]), RouteID=Convert.ToInt32(dr[16])
                };
             rEnt.AllWayPoints= Convert.ToString(dr[6]);
             if(Convert.ToString(dr[7])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[7]);
             }
             if(Convert.ToString(dr[8])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[8]);
             }
             if(Convert.ToString(dr[9])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[9]);
             }
             if(Convert.ToString(dr[10])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[10]);
             }
                  if(Convert.ToString(dr[11])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[11]);
             }
                  if(Convert.ToString(dr[12])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[12]);
             }
                  if(Convert.ToString(dr[13])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[13]);
             }
                  if(Convert.ToString(dr[14])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[14]);
             }
                  if(Convert.ToString(dr[15])!=string.Empty)
             {
                 rEnt.AllWayPoints+=", "+Convert.ToString(dr[15]);
             }            
                myRoutes.Add(rEnt);                          
            }


        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return myRoutes;
    }
    /*************************************************************************************
 * Method Name      :  DeleteRoute                                           
 * Return Value     :  Void                                               
 * Input Parameters :  routeId                                                
 * Description      :  This method is used to delete a registered route
 *************************************************************************************/
    public void DeleteRoute(int routeId)
    {
        SqlCommand cmd = new SqlCommand("usp_DelRouteInfo", Con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@RouteId", routeId);
        try
        {
            Con.Open();
            //Execute the Query

             cmd.ExecuteNonQuery();
            
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }        
    }
    /*************************************************************************************
 * Method Name      :  ReadPassengerInfo                                           
 * Return Value     :  List<PassengerEntity>                                               
 * Input Parameters :  Owner, passengerInfo                                               
 * Description      :  This method is used to read all registered passengers info
 *************************************************************************************/
    public List<PassengerEntity> ReadPassengerInfo(int Owner, out string passengerInfo)
    {
            List<PassengerEntity> passengers = new List<PassengerEntity>();

        try
        {

            //Start Modlog: Seema - 22/10/2013
            //SqlCommand cmdCount = new SqlCommand("Select count(*) from tbl_passenger where ownerid="+Owner,Con);
            SqlCommand cmdCount = new SqlCommand("Select count(*) from tbl_passenger where Passenger1=" + Owner, Con);
            //End Modlog: Seema - 22/10/2013
            Con.Open();
            int count = Convert.ToInt32( cmdCount.ExecuteScalar());
            string query;
            if (count > 0)
            {

                string p1 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger1)as p1, ";
                string p2 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger2)as p2, ";
                string p3 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger3)as p3, ";
                string p4 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger4)as p4, ";
                string p5 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger5)as p5, ";
                string p6 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger6)as p6, ";
                string p7 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger7)as p7, ";
                string p8 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger8)as p8, ";
                string p9 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger9)as p9, ";
                string p10 = "(select tuu.FirstNAme from tbl_user tuu inner join tbl_passenger tpp on tuu.employeeid = tpp.passenger10)as p10";
                string passeneger = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10;
                 query = "select tc.VehicleNumber ,tr.startpoint,tr.destination, " + passeneger + " from tbl_passenger tp inner join tbl_User tu on tp.ownerid = tu.employeeid join tbl_routetable tr on tp.routeid =tr.routeid join tbl_cardetails tc on tc.carid=tr.carid and tu.employeeid=" + Owner;
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string passengerLst = "";
                        if(Convert.ToString(dr[3]) !="")
                        {
                            passengerLst = Convert.ToString(dr[3]) + ", ";
                        }
                        if (Convert.ToString(dr[4]) != "")
                        {
                            passengerLst += Convert.ToString(dr[4]) + ", ";
                        }
                        if (Convert.ToString(dr[5]) != "")
                        {
                            passengerLst += Convert.ToString(dr[5]) + ", ";
                        }
                        if (Convert.ToString(dr[6]) != "")
                        {
                            passengerLst += Convert.ToString(dr[6]) + ", ";
                        }
                        if (Convert.ToString(dr[7]) != "")
                        {
                            passengerLst += Convert.ToString(dr[7]) + ", ";
                        }
                        if (Convert.ToString(dr[8]) != "")
                        {
                            passengerLst += Convert.ToString(dr[8]) + ", ";
                        }
                        if (Convert.ToString(dr[9]) != "")
                        {
                            passengerLst += Convert.ToString(dr[9]) + ", ";
                        }
                        if (Convert.ToString(dr[10]) != "")
                        {
                            passengerLst += Convert.ToString(dr[10]) + ", ";
                        }
                        if (Convert.ToString(dr[11]) != "")
                        {
                            passengerLst += Convert.ToString(dr[11]) + ", ";
                        }
                        if (Convert.ToString(dr[12]) != "")
                        {
                            passengerLst += Convert.ToString(dr[12]);
                        }
                    //passengers.Add(new PassengerEntity
                    //{
                    //    RouteDetails = new RoutesEntity { VehicleNumber = Convert.ToString(dr[0]) },
                    //    Travel = Convert.ToString(dr[1]) + " to " + Convert.ToString(dr[2]),
                    //    Passenger1 = Convert.ToString(dr[3]),
                    //    Passenger2 = Convert.ToString(dr[4]),
                    //    Passenger3 = Convert.ToString(dr[5]),
                    //    Passenger4 = Convert.ToString(dr[6]),
                    //    Passenger5 = Convert.ToString(dr[7]),
                    //    Passenger6 = Convert.ToString(dr[8]),
                    //    Passenger7 = Convert.ToString(dr[9]),
                    //    Passenger8 = Convert.ToString(dr[10]),
                    //    Passenger9 = Convert.ToString(dr[11]),
                    //    Passenger10 = Convert.ToString(dr[12])
                    //});
                        passengers.Add(new PassengerEntity
                        {
                            RouteDetails = new RoutesEntity { VehicleNumber = Convert.ToString(dr[0]) },
                            Travel = Convert.ToString(dr[1]) + " to " + Convert.ToString(dr[2]),
                            Passengers = passengerLst !=""?passengerLst.Substring(0,passengerLst.Length-2) :""
                        });

                }
                passengerInfo = "Owner";
            }
            else
            {

                query = "select tc.VehicleNumber ,tr.startpoint,tr.destination,tu.FirstName "+
                    "from tbl_passenger tp,tbl_User tu,tbl_RouteTable tr,tbl_CarDetails tc where ((tp.Passenger1 =tu.employeeid "+
                    "and tp.Passenger1="+Owner+") or (tp.Passenger2 =tu.employeeid and tp.Passenger2="+Owner+") or"+
                    "(tp.Passenger3 =tu.employeeid and tp.Passenger3="+Owner+") or (tp.Passenger4 =tu.employeeid and tp.Passenger4="+Owner+") "+
                    "or(tp.Passenger5 =tu.employeeid and tp.Passenger5="+Owner+") or (tp.Passenger6 =tu.employeeid and tp.Passenger6="+Owner+") "+
                    "or(tp.Passenger7 =tu.employeeid and tp.Passenger7="+Owner+") or (tp.Passenger8 =tu.employeeid and tp.Passenger8="+Owner+") or "+
                    "(tp.Passenger9 =tu.employeeid and tp.Passenger9="+Owner+") or (tp.Passenger10 =tu.employeeid and tp.Passenger10="+Owner+")) "+
                    "and tp.RouteID =tr.RouteID and tp.CarID =tc.CarId ";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    passengers.Add(new PassengerEntity
                    {
                        RouteDetails = new RoutesEntity { VehicleNumber = Convert.ToString(dr[0]) },
                        Travel = Convert.ToString(dr[1]) + " to " + Convert.ToString(dr[2]),
                        Passengers = Convert.ToString(dr[3])
                    });
                }
                passengerInfo = "Passenger";
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }
        return passengers;

    }

    /*************************************************************************************
* Method Name      :  DeletePassengerInfo                                           
* Return Value     :  void                                               
* Input Parameters :  Owner, VehicalNumber                                               
* Description      :  This method is used to delete passengers info for a registered vehical
*************************************************************************************/
    public void DeletePassengerInfo(int Owner,string VehicalNumber)
    {
        string query = "update tbl_Passenger set Passenger1 = case when (Passenger1=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"'))then null else Passenger1 end ," +
                        "Passenger2 = case when Passenger2=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger2 end," +
                        "Passenger3 = case when Passenger3=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger3 end ," +
                        "Passenger4 = case when Passenger4=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger4 end ," +
                        "Passenger5 = case when Passenger5=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger5 end ," +
                        "Passenger6 = case when Passenger6=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger6 end ," +
                        "Passenger7 = case when Passenger7=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger7 end ," +
                        "Passenger8 = case when Passenger8=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger8 end ," +
                        "Passenger9 = case when Passenger9=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger9 end ," +
                        "Passenger10 = case when Passenger10=  "+Owner+" and carid =(select CarID from tbl_CarDetails where VehicleNumber ='"+VehicalNumber+"') then null else Passenger10 end";

        SqlCommand cmdDeleteCarDetails = new SqlCommand(query, Con);
       try
        {
            Con.Open();
            cmdDeleteCarDetails.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }
    }
    /*************************************************************************************
* Method Name      :  UpdateRouteInfo                                           
* Return Value     :  void                                               
* Input Parameters :  RoutesEntity rentity                                             
* Description      :  This method is used to update route info for a registered vehical & route
*************************************************************************************/
    public void UpdateRouteInfo(RoutesEntity rentity)
    {
        try
        {
            string[] iMPnts = rentity.AllWayPoints.Split(new string[] { ", " }, StringSplitOptions.None);
            int i = 1;
            string query = "";

            foreach (var item in iMPnts)
            {
                if (i < iMPnts.Count())
                {
                    query += "intermediatepoint" + i.ToString() + "='" + item + "', ";
                }
                else
                {
                    query += "intermediatepoint" + i.ToString() + "='" + item+"'";
                }
                i++;
            }
            SqlCommand cmd = new SqlCommand("update tbl_RouteTable set startpoint ='" + rentity.StartPnt + "',Destination='"
            + rentity.EndPnt + "',startdate='"+rentity.StartDt +"',enddate='"+rentity.EndDt +"', runningDays='" + rentity.RunningDays + "'," + query + " where routeid=" + rentity.RouteID, Con);
            Con.Open();
            cmd.ExecuteNonQuery();
            return;

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Con.Close();
        }

    }

    //Modlog Start : Seema - For displaying in marquee
    public List<TodaysRouteEntity> GetTodaysRoutes()
    {
        List<TodaysRouteEntity> RouteLst = new List<TodaysRouteEntity>();
        SqlCommand cmd = new SqlCommand("SELECT Startpoint, Destination FROM tbl_RouteTable where EndDate >= CAST(GETDATE() AS date)", Con);
        try
        {
            Con.Open();
            //Execute the Query

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                RouteLst.Add(new TodaysRouteEntity
                {
                    Startpoint = Convert.ToString(dr[0]),
                    Destination = Convert.ToString(dr[1])
                });
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //Close the Connection from the Database
            Con.Close();
        }

        return RouteLst;
    }
}