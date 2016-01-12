﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WeatherService
{
    /// <summary>
    /// Summary description for WeatherService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WeatherService : System.Web.Services.WebService
    {
        private List<string> weatherList = new List<string> { "Cloudy", "Rainy", "Sunny" };

        [WebMethod]
        public string Weather()
        {
            var random = new Random();
            var randomnumber = random.Next(0, weatherList.Count);
            {
                return (weatherList[randomnumber]);
            }
        }
    }
}
