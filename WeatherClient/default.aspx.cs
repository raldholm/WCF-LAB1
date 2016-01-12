using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeatherClient.WeatherService;

namespace WeatherClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WeatherService.WeatherServiceSoapClient client = new WeatherServiceSoapClient();

            TextBox1.Text = client.Weather();

        }
    }
}