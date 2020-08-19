using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class SearchPerson : System.Web.UI.Page
    {
        protected void Search_Click(object sender, EventArgs e)
        {
            Regex checkName = new Regex(@"^[a-zA-Z]+$");
            if(!checkName.IsMatch(firstName.Text) || !checkName.IsMatch(lastName.Text))
            {
                error.Text = "Illegal character is detected in input name!";
                return;
            }
            string url = "http://localhost:64999/Service1.svc/SearchPerson?xmlURL=" + xmlURL.Text + 
                            "&personName=" + firstName.Text + " " + lastName.Text;

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                var res = request.GetResponse();
                Result.Text = "";
                using (var stream = res.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    string dataStr = reader.ReadToEnd();
                    Regex regex = new Regex(@">.*?<");
                    dataStr = regex.Match(dataStr).ToString();
                    if(dataStr == "")
                    {
                        Result.Text = "<p style=\"font-weight: bold; Color: Red\">No person named \"" + 
                                        firstName.Text + " " + lastName.Text + "\" in the current XML file!</p>";
                        return;
                    }
                    dataStr = dataStr.Substring(1, dataStr.Length - 2);

                    var personInfo = dataStr.Split(',');

                    Result.Text = string.Format("Name:&emsp;{0}<br /><br />ID:&emsp;{1}<br /><br />", personInfo[0], personInfo[1]); 

                    if(personInfo[3] == "yes")
                    {
                        Result.Text += "Decrypted Password:&emsp;" + Decryptor(personInfo[2]) + 
                                        "&emsp;(Encrypted password: " + personInfo[2]  + ")<br /><br />";
                    }
                    else
                    {
                        Result.Text += "Password:&emsp;" + personInfo[2] + "<br /><br />";
                    }

                    Result.Text += string.Format("Work Phone:&emsp;{0}<br /><br />Cell Phone:&emsp;{1}<br /><br />" +
                        "                         Provider:&emsp;{2}<br /><br />Category:&emsp;{3}", 
                                                    personInfo[4], personInfo[5], (personInfo[6] == "") ? "N/A" : personInfo[6], personInfo[7]);
                }
            }
            catch (Exception)
            {
                error.Text = "Unable to load the data!";
                return;
            }
        }

        private string Decryptor(string password)
        {
            string temp = "";
            for (int i = 0; i < password.Length; i++)
            {
                temp += (char)(password[i] - 1);
            }

            return temp;
        }
    }
}