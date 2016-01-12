using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Add2NumbersService
{
    /// <summary>
    /// Summary description for Add2NumbersService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Add2NumbersService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add2Numbers(int tal1, int tal2)
        {
            return tal1 + tal2;
        }
    }
}
