using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Deceased2010Client.Deceased2010Service;

namespace Deceased2010Client
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new Deceased2010ServiceSoapClient();
                 
            Label1.Text = client.GetNamesByDate(TextBox1.Text).ToString();
        }
    }
}