using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Covid19Searcher
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            //the api can't recognize the abbr for United Kingdom
            if(countryInput.Text == "UK")
            {
                countryInput.Text = "United Kingdom";
            }
            //request the local service url
            string url = "http://webstrar63.fulton.asu.edu/page1/Service1.svc/Covid19Cases?country=" + countryInput.Text; ;
            string[] getValue = new string[3];
            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                //get the response and update array
                using (var getDataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(getDataStream);
                    string dataStr = reader.ReadToEnd();
                    Regex regex = new Regex(@">(.*?)<");
                    dataStr = regex.Match(dataStr).ToString();
                    //remove the redundant '>' and '<' and update array
                    getValue = dataStr.Substring(1, dataStr.Length - 2).Split(',');
                }
            }
            catch (Exception)
            {
                //set the appearance of error message
                invalid.Visible = true;
                confirm.Text = recover.Text = deaths.Text = "--";
                return;
            }
            //assign values to the labels and reset the appearance of error message
            invalid.Visible = false;
            confirm.Text = getValue[0];
            recover.Text = getValue[1];
            deaths.Text = getValue[2];
        }
    }
}