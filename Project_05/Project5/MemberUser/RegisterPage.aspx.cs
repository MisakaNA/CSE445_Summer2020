using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FindMember;
using System.Xml;

namespace Project5
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //reset the labels and the error text
            regError.Text = "";
            pwdInvalid.Visible = pwdError.Visible = userExist.Visible = toLogin.Visible = false;
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            //get the captcha string
            string captchaString = CaptchaImg.ImageUrl.Substring(CaptchaImg.ImageUrl.Length - 6);
            //compare with the input
            if (captchaString != captchaInput.Text)
            {
                regError.Text = "Captcha verification failed!";
                return;
            }
            //reload the captcha image
            ImageClickEventArgs e1 = new ImageClickEventArgs(0, 0);
            CaptchaImg_Click(sender, e1);
            captchaInput.Text = "";

            //check if the password input fits all requirements
            if (password.Text.Length < 8 || password.Text.Length > 16 || !password.Text.Any(char.IsUpper))
            {
                pwdInvalid.Visible = true;
                return;
            }

            //check two passwords are same
            if(password.Text != passwordReenter.Text)
            {
                pwdError.Visible = true;
                return;
            }

            //to avoid html error
            string pwd = password.Text.Replace("&", "&amp;");

            //check if user name is legal
            Regex checkName = new Regex(@"^[a-zA-Z_ ]+$");
            if (!checkName.IsMatch(nameInput.Text)) 
            {
                userExist.Text = "Invalid User Name!";
                userExist.Visible = true;
                return;
            }

            //check if the existance of the user name
            if (MemberExist.HasMember(nameInput.Text))
            {
                userExist.Visible = toLogin.Visible = true;
                return;
            }

            //wirte the user info to xml
            RecordMemberInfo(nameInput.Text, pwd);
            //redirect to the member page with the user name (auto log in)
            Response.Redirect("Member.aspx?name=" + nameInput.Text);
        }

        /// <summary>
        ///This function is to write the user name and password to the xml
        /// </summary>
        /// <param name="memName"></param>
        /// <param name="memPwd"></param>
        private void RecordMemberInfo(string memName, string memPwd)
        {
            XmlDocument xd = new XmlDocument();
            string path;
            try
            {
                // the path will go in one more folder on the server
                path = HttpRuntime.AppDomainAppPath;
                path += (path == "http://webstrar63.fulton.asu.edu/") ? @"page10\MemberUser\App_Data\Members.xml"
                                                                      : @"\MemberUser\App_Data\Members.xml";
                xd.Load(path);
            }
            catch (Exception)
            {
                CreateUserXML(memName, memPwd);
                return;
            }
            
            XmlNode GetRoot = xd.SelectSingleNode("Members");
            //create a new element
            XmlElement newMember = xd.CreateElement("Member");
            //create name
            XmlElement newName = xd.CreateElement("Name");
            newName.InnerText = memName;
            newMember.AppendChild(newName);
            //create password
            XmlElement newPwd = xd.CreateElement("Password");
            newPwd.InnerText = memPwd;
            newMember.AppendChild(newPwd);
            //add the member to Members
            GetRoot.AppendChild(newMember);

            //save the file
            if(path != "")
            {
                xd.Save(path);
            }
            
        }

        /// <summary>
        /// if the xml is missing, the registerar will create a new xml
        /// </summary>
        /// <param name="memName"></param>
        /// <param name="memPwd"></param>
        private void CreateUserXML(string memName, string memPwd)
        {
            XmlTextWriter writer = null;
            try
            {
                // the path will go in one more folder on the server
                string path = HttpRuntime.AppDomainAppPath;
                path += (path == "http://webstrar63.fulton.asu.edu/") ? @"page10\MemberUser\App_Data\Members.xml"
                                                                      : @"\MemberUser\App_Data\Members.xml";
                //set format
                writer = new XmlTextWriter(path, System.Text.Encoding.Unicode)
                {
                    Formatting = Formatting.Indented
                };
                //write in information
                writer.WriteStartDocument();
                writer.WriteStartElement("Members");
                writer.WriteStartElement("Member");
                writer.WriteElementString("Name", memName);
                writer.WriteElementString("Password", memPwd);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            finally 
            { 
                if (writer != null) 
                    writer.Close(); 
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
                CaptchaImg.ImageUrl = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/" + dataStr;
            }
        }

    }
}