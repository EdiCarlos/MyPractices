using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService()]
public class Athletes : System.Web.Services.WebService {
    //-----------------------------------------------------------+
    public Athletes() 
    {
    }
    //-----------------------------------------------------------+
    [WebMethod]
    public List<AnAthlete> GetAthletesByService(string service)
    {
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

    SqlCommand cmd = new SqlCommand(
            @"SELECT Id, Weight, Name, City, State, WebsiteUrl, Latitude, Longitude
              FROM Athlete
              WHERE (Weight = @Weight)", cn);

    cmd.Parameters.AddWithValue("Weight", service);

    List<AnAthlete> retrievedAthletes = new List<AnAthlete>();

    cn.Open();
    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
    {
        while (dr.Read())
        {
            retrievedAthletes.Add(new AnAthlete(dr.GetInt32(0),
                                                dr.GetString(1),
                                                dr.GetString(2),
                                                dr.GetString(3),
                                                dr.GetString(4),
                                                dr.GetString(5),
                                                dr.GetDouble(6),
                                                dr.GetDouble(7)));
            }
        }
        return retrievedAthletes;
    }

}
