using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Deceased2010Service
{
    /// <summary>
    /// Summary description for Deceased2010Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Deceased2010Service : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetNamesByDate(string dateinput) {
            using (
                var sr =
                    new StreamReader(
                        @"C:\Users\Martin\Documents\Visual Studio 2015\Projects\WIN14\WCF\LAB1\Deceased2010Service\avlidna2010.txt")
                )
            {  
                string line;
                
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(dateinput))
                    {
                        return line;
                    }
                }
                }
            return null;
        }

    }
}
