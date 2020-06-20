using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1_WebApp
{
    public partial class Project1 : System.Web.UI.Page
    {
        //set the feature of the application when "Sort" button is clicked
        protected void Sort_Click(object sender, EventArgs e)
        {
            SortStringServ.Service1Client sortService = new SortStringServ.Service1Client();
            var sortedString = sortService.sort(TextBox1.Text);
            SortResult.Text = sortedString.ToString();
        }
    }
}