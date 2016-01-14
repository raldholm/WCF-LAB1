using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NameDayClient.NameDayService;

namespace NameDayClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_GetDate_Click(object sender, EventArgs e)
        {
            var client = new NameDayServiceSoapClient();
            Label_Date.Text = client.GetDateByName(TextBox_Name.Text).ToString();
        }
    }
}