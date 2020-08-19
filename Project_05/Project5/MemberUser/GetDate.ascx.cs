using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    /// <summary>
    /// This class is a user control, will show today's date and user's login time
    /// </summary>
    public partial class GetDate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToShortTimeString();
            //assign current date
            this.Date.Text = date;
            //assign current time
            this.Time.Text = time;
        }
    }
}