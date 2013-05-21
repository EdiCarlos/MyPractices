using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;
using System.Text;
using System.Web;

namespace ProtectionLevelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WeatherService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WeatherService.svc or WeatherService.svc.cs at the Solution Explorer and start debugging.

    [AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Allowed)]
    public class WeatherService : IWeatherService
    {
        public WeatherResponse GetWeather(WeatherRequest request)
        {
            if (request.OutputType == ResponseType.Celsius)
            {
                return new WeatherResponse() { Celsius = 10.00 };
            }
            else
            {
                return new WeatherResponse() { Ferhenit = 11.1 };
            }
        }
    }
}
