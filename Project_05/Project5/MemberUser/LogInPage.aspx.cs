using FindMember;
using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Xml;

namespace Project5
{
    public partial class LogInPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //reset error message
            LogInErr.Text = "";
            //if there are cookies avaliable and the user name textbox 
            //is empty (if the user has already input the user name), load the cookie
            HttpCookie checkCookies = Request.Cookies["RememberMe"];
            if (checkCookies != null && checkCookies["Name"] != "" && userName.Text == "")
            {
                userName.Text = checkCookies["Name"];
                //password.Text = checkCookies["Password"];
                password.Attributes.Add("value", Request.Cookies["RememberMe"]["Password"]);
                //set Remember Me checked
                Remember.Checked = true;
            }

            //avoid password textbox disappearing after click the buttons
            if (this.IsPostBack)
            {
                this.password.Attributes.Add("value", Request["password"]);
            }
        }

        protected void LogInBut_Click(object sender, EventArgs e)
        {
            //get the captcha string
            string captchaString = CaptchaImg.ImageUrl.Substring(CaptchaImg.ImageUrl.Length - 6);
            //compare with the input
            if (captchaString != captchaInput.Text)
            {
                LogInErr.Text = "Captcha verification failed!";
                return;
            }

            //reload the captcha image
            ImageClickEventArgs e1 = new ImageClickEventArgs(0, 0);
            CaptchaImg_Click(sender, e1);
            captchaInput.Text = "";

            //check the user name exists in the xml
            if (!MemberExist.HasMember(userName.Text))
            {
                LogInErr.Text = "User name not found!";
                return;
            }

            //check the password with the one stores in the xml
            if (GetPassword(userName.Text) != password.Text)
            {
                LogInErr.Text = "Password wrong!";
                return;
            }

            //if the user want to add the cookie
            if (Remember.Checked)
            {
                SetRememberMe(userName.Text, password.Text);
            }
            else
            {
                //will clear the cookie if the user does not check Remember Me box during this log in
                /*HttpCookie checkCookies = Request.Cookies["RememberMe"];
                if (checkCookies != null && checkCookies["Name"] != "")
                {
                    Response.Cookies.Remove("RememberMe");
                    checkCookies.Expires = DateTime.Now.AddDays(-10);
                    checkCookies.Value = null;
                    Response.SetCookie(checkCookies);
                }*/
            }
            //redirect to the member page with the user name
            Response.Redirect("Member.aspx?name=" + userName.Text + "&rem=" + Remember.Checked);
        }

        /// <summary>
        /// The private function to get the password stores in the xml by the input user name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private string GetPassword(string name)
        {
            string password = "";
            XmlDocument xd = new XmlDocument();
            try
            {
                //the path will go in one more folder on the server
                string path = HttpRuntime.AppDomainAppPath;
                path += (path == "http://webstrar63.fulton.asu.edu/")? @"page10\MemberUser\App_Data\Members.xml"
                                                                      : @"\MemberUser\App_Data\Members.xml"; 
                xd.Load(path);
            }
            catch (Exception)
            {
                LogInErr.Text = "Member XML not found! Please register to create a new one!";
                return "";
            }
            
            var nodeList = xd.DocumentElement.SelectNodes("/Members/Member");
            foreach (XmlNode node in nodeList)
            {
                if(node["Name"].InnerText == name)
                {
                    password = node["Password"].InnerText;
                    break;
                }

            }
            //to avoid displaying errors
            password = password.Replace("&amp;", "&");
            return password;
        }
        /// <summary>
        /// The private function when Remember Me is checked, otoh add the cookie
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        private void SetRememberMe(string name, string password)
        {
            HttpCookie checkCookies = Request.Cookies["RememberMe"];
            //add the cookie
            if (checkCookies == null || checkCookies["Name"] == "")
            {
                HttpCookie myCookies = new HttpCookie("RememberMe");
                myCookies["Name"] = name;
                myCookies["Password"] = password;
                myCookies.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Add(myCookies);
            }
            //will update the cookie when the user name or the password is changed
            else if(checkCookies["Name"] != name || checkCookies["Password"] != password)
            {
                HttpCookie myCookies = new HttpCookie("RememberMe");
                myCookies["Name"] = name;
                myCookies["Password"] = password;
            }
        }
        protected void CaptchaImg_Click(object sender, ImageClickEventArgs e)
        {
            //get a random string with length 6
            string captchaStringUrl = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetVerifierString/6";
            string dataStr = "";
            try
            {
                //request the url
                var request = (HttpWebRequest)WebRequest.Create(captchaStringUrl);
                var response = request.GetResponse();

                using (var getDataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(getDataStream);
                    //read the response
                    dataStr = reader.ReadToEnd();
                    //remove redundant characters
                    Regex regex = new Regex(@">(.*?)<");
                    dataStr = regex.Match(dataStr).ToString();
                    dataStr = dataStr.Substring(1, dataStr.Length - 2);
                }
            }
            catch (Exception) { }

            //if the random string is get
            if (dataStr != "")
            {
                //update the captcha image
                CaptchaImg.ImageUrl = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/" + dataStr;
            }
        }

        /// <summary>
        /// This action makes sure that the cookie is cleared when Remember Me is unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Remember_CheckedChanged(object sender, EventArgs e)
        {
            if (!Remember.Checked)
            {
                HttpCookie checkCookies = Request.Cookies["RememberMe"];
                if (checkCookies != null && checkCookies["Name"] != "")
                {
                    Response.Cookies.Remove("RememberMe");
                    checkCookies.Expires = DateTime.Now.AddDays(-10);
                    checkCookies.Value = null;
                    Response.SetCookie(checkCookies);
                }
            }
        }
    }
}