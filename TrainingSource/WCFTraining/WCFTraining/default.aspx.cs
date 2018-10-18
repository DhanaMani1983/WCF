using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFTraining
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWCFLibraryCall_Click(object sender, EventArgs e)
        {
            SimpleInterestService.SimpleInterestClient proxy = 
                new SimpleInterestService.SimpleInterestClient();
            double res = proxy.Calculate(50000, 18, 3);
            lblResult.Text = "Simple Interest : " + res.ToString();
            proxy.Close();
        }

        protected void btnCustomers_Click(object sender, EventArgs e)
        {
            SimpleInterestService.SimpleInterestClient proxy =
                new SimpleInterestService.SimpleInterestClient();
            GridView1.DataSource = proxy.GetCustomers();
            GridView1.DataBind();
            proxy.Close();
        }
    }
}