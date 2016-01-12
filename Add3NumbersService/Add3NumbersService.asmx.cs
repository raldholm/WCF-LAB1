using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Add3NumbersService
{
    /// <summary>
    /// Summary description for Add3NumbersService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Add3NumbersService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add3Numbers(int tal1, int tal2, int tal3)
        {
            return (tal1 + tal2 + tal3);
        }
    }
}
