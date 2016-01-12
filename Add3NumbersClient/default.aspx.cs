using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Add3NumbersClient.Add3NumbersService;

namespace Add3NumbersClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         

        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            var client = new Add3NumbersService.Add3NumbersServiceSoapClient();
            Label_Result.Text =
                client.Add3Numbers(int.Parse(TextBox_Number1.Text), int.Parse(TextBox2_Number2.Text),
                    int.Parse(TextBox3_Number3.Text)).ToString();
        }
    }
}
