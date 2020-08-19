using System;
using System.Web;
using System.Xml;

namespace FindMember
{
    /// <summary>
    /// This is a class library 
    /// </summary>
    public class MemberExist
    {
        /// <summary>
        /// This function is to check if the input user name exists in the Members.xml
        /// </summary>
        /// <param name="memberName"></param>
        /// <returns>
        /// true if the member exists
        /// </returns>
        public static bool HasMember(string memberName)
        {
            //initialize the return value
            bool hasMember = false;
            XmlDocument xd = new XmlDocument();
            try
            {
                //set the xml path
                //the path need to go in one more folder when on the server
                string path = HttpRuntime.AppDomainAppPath;
                path += (path == "http://webstrar63.fulton.asu.edu/") ? @"page10\MemberUser\App_Data\Members.xml"
                                                                       : @"\MemberUser\App_Data\Members.xml";
                //load xml file
                xd.Load(path);
            }
            catch (Exception)
            {
                return hasMember;
            }
            
            //get member List
            var nodeList = xd.DocumentElement.SelectNodes("/Members/Member");
            foreach(XmlNode node in nodeList)
            {
                //compare the inner text of Name element with input name
                hasMember = (node["Name"].InnerText == memberName) ? true : false;
                //if member is found, break the loop 
                if (hasMember) break;
            }
            return hasMember;
        }
    }
}
