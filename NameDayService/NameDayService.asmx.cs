using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NameDayService
{
    /// <summary>
    /// Summary description for NameDayService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NameDayService : System.Web.Services.WebService
    {

        [WebMethod]
        public DateTime GetDateByName(string name)
        {
            using (var sr = new StreamReader(@"C:\Users\Martin\Documents\Visual Studio 2015\Projects\WIN14\WCF\LAB1\NameDayService\namnsdagar.txt"))
            {
                var months = "jan feb mar apr maj jun jul aug okt nov dec".Split(' ');

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(name))
                    {
                        var split = line.Split(' ');

                        var date = split[0] + " " + split[1];

                        var month = split[1].Substring(0, 3);

                        var monthInt = Array.IndexOf(months, month) + 1;

                        return new DateTime(2016, monthInt, int.Parse(split[0]));
                    }
                }

                return new DateTime(1900, 01, 01);
            }
        }
    }
}
