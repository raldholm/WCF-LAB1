using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MoviesClient.MoviesReference;

namespace MoviesClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new Movies90sServiceSoapClient();
            Label1.Text = client.GetMoviesByYear(TextBox1.Text).ToString();

        }
    }
}