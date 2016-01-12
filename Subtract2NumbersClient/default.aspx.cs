using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subtract2NumbersClient.Subtract2NumbersService;

namespace Subtract2NumbersClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Calculate_Click(object sender, EventArgs e)
        {
            var client = new Subtract2NumbersServiceSoapClient();
            LabelResult.Text = client.Subtract2Numbers(int.Parse(txt_Number1.Text), int.Parse(txt_Number2.Text)).ToString();
        }
    }
}