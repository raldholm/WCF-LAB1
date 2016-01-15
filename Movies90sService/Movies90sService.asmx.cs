using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Movies90sService
{
    /// <summary>
    /// Summary description for Movies90sService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Movies90sService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetMoviesByYear(string yearinput)
        {
            //var input =
            //    File.ReadAllLines(Server.MapPath("filmer90talet.txt"));
            //return input.ToString();
            using (
                var sr =
                    new StreamReader(
                        @"C:\Users\Martin\Documents\Visual Studio 2015\Projects\WIN14\WCF\LAB1\Movies90sService\filmer90talet.txt")
                )
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(yearinput))
                    {
                        return line;
                    }
                }
            }
            return null;
        }
    }
}
