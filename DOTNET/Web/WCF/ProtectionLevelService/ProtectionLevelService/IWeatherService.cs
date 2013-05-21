using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Security;
namespace ProtectionLevelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWeatherService" in both code and config file together.
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract(ProtectionLevel=ProtectionLevel.None)]
        WeatherResponse GetWeather(WeatherRequest request);
    }
    [MessageContract(ProtectionLevel=ProtectionLevel.None)]
    public class WeatherRequest
    {
        [MessageBodyMember]
        public string CityName { get; set; }
        [MessageBodyMember]
        public int zipCode { get; set; }
        [MessageBodyMember]
        public ResponseType OutputType { get; set; }
    }

    
    [MessageContract]
    public class WeatherResponse
    {
        [MessageBodyMember]
        public double Celsius { get; set; }
        [MessageBodyMember]
        public double Ferhenit { get; set; }
    }

    [DataContract]
    public enum ResponseType
    {
        [EnumMember]
        Ferhenit,
        [EnumMember]
        Celsius
    }
}
