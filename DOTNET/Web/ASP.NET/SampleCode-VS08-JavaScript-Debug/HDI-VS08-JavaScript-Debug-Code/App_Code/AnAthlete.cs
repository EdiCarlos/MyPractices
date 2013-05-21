using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for MilitaryInstallation
/// </summary>
public class AnAthlete
{
    public AnAthlete()
    { 
    }

    public AnAthlete(int id, string service, string name, string city, string state, string websiteUrl, double latitude, double longitude)
    {
        _id = id;
        _service = service;
        _name = name;
        _city = city;
        _state = state;
        _websiteUrl = websiteUrl;
        _latitude = latitude;
        _longitude = longitude;
    }
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private string _service;

    public string Service
    {
        get { return _service; }
        set { _service = value; }
    }

    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private string _city;

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    private string _state;

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    private string _websiteUrl;

    public string WebsiteUrl
    {
        get { return _websiteUrl; }
        set { _websiteUrl = value; }
    }

    private double _latitude;

    public double Latitude
    {
        get { return _latitude; }
        set { _latitude = value; }
    }

    private double _longitude;

    public double Longitude
    {
        get { return _longitude; }
        set { _longitude = value; }
    }

}