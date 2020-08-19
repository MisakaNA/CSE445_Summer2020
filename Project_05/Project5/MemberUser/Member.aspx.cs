using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Encryptor;
using System.Web.UI.WebControls;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Web.Security;

namespace Project5
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //get the user name from the redirection of log in page
                userName.Text = Request.QueryString["name"].ToString();
                //carry the user name when back to public page
                //this is not log out, the user do not need to 
                //log in again when going back to this page in 10 minutes
                HyperLink1.NavigateUrl = "../Public.aspx?name=" + userName.Text;
            }
            catch (Exception)
            {
                Response.Redirect("LogInPage.aspx");
                return;
            }
            
        }

        protected void Encrypt_Click(object sender, EventArgs e)
        {
            //call dll function to encrypt the string
            resultStr.Text = CryptorDLL.Encrypt(enteredStr.Text);
        }

        protected void Decrypt_Click(object sender, EventArgs e)
        {
            //call dll function to decrypt the string
            resultStr.Text = CryptorDLL.Decrypt(enteredStr.Text);
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            //set open classes or all classes
            var setStatus = (status.SelectedValue == "All Classes") ? "all" : "open";
            string url = "http://webstrar63.fulton.asu.edu/page4/Service1.svc/ASUClassFinder?" + "semester=2207" + "&classCode="
                        + subject.Text + "&classNum=" + num.Text + "&status=" + setStatus;
            try
            {
                //request the url
                var request = (HttpWebRequest)WebRequest.Create(url);
                var response = request.GetResponse();

                using (var getDataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(getDataStream);
                    //read the response
                    string dataStr = reader.ReadToEnd();
                    //remove redundant characters
                    Regex regex = new Regex(@">(.*?)<");
                    dataStr = regex.Match(dataStr).ToString();
                    //check if the response string is empty
                    if (dataStr.Length == 0)
                    {
                        //show no data avaliable message
                        noData.Visible = true;
                        //total amount is 0 in this case
                        amountLabel.Text = "0";
                        return;
                    }
                    //remove the redundant '>' and '<' and split with '|' to get an array contains 5 days weather
                    string information = dataStr.Substring(1, dataStr.Length - 2);
                    noData.Visible = false;
                    string[] infoArr = information.Split('|');
                    amountLabel.Text = infoArr[0];
                    for (int i = 2; i < infoArr.Length; i++)
                    {
                        string[] classInfo = infoArr[i].Split(',');
                        //add a new row for the result table
                        TableRow newRow = new TableRow() { HorizontalAlign = HorizontalAlign.Center };
                        //each piece of result have 7 parts
                        TableCell[] rowCells = new TableCell[7];
                        //create the class name subcell
                        TableCell nameCell = new TableCell { Text = infoArr[1] };
                        //add to the row
                        rowCells[0] = nameCell;
                        for (int j = 0; j < classInfo.Length; j++)
                        {
                            //professors's full name will not be shown in a cell
                            if(j == 2) { continue; }
                            //if it is editing professor name cell
                            if(j == 1)
                            {
                                //create the subcell
                                TableCell newCell = new TableCell();
                                newCell.Text = classInfo[j];
                                //set the full name as the tip
                                if(classInfo[2] != "Staff")
                                {
                                    newCell.ToolTip = classInfo[2];
                                }
                                //add to the row
                                rowCells[j + 1] = newCell;
                            }
                            else
                            {
                                //cell index will change due to the loop skip the index 2
                                if (j == 0)
                                {
                                    TableCell newCell = new TableCell { Text = classInfo[j] };
                                    rowCells[j + 1] = newCell;
                                }
                                else
                                {
                                    TableCell newCell = new TableCell { Text = classInfo[j] };
                                    rowCells[j] = newCell;
                                }
                            } 
                        }
                        //add cells to the row
                        newRow.Cells.AddRange(rowCells);
                        //add the row to the table
                        resultTable.Rows.Add(newRow);
                    }

                }
            }
            catch (Exception)
            {
                //show no data message
                noData.Visible = true;
                return;
            }
        }

        protected void SearchRating_Click(object sender, EventArgs e)
        {
            string url = "http://webstrar63.fulton.asu.edu/page4/Service1.svc/RateMyProfessor?schoolName=" + schoolInput.Text.Replace("&", "amp") + "&professorName=" + nameInput.Text.Replace("&", "amp");
            try
            {
                //check if no professor name input
                if (nameInput.Text.Length == 0)
                {
                    return;
                }

                //request the url
                var request = (HttpWebRequest)WebRequest.Create(url);
                var response = request.GetResponse();
                //reset the error message
                noData.Visible = false;
                using (var getDataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(getDataStream);
                    //read the response
                    string dataStr = reader.ReadToEnd();
                    Regex regex = new Regex(@">(.*?)<");
                    //get the useful parts
                    dataStr = regex.Match(dataStr).ToString();
                    var getRating = dataStr.Substring(1, dataStr.Length - 2);
                    //split the string with '^'
                    var ratingDetails = getRating.Split('^');

                    //assign the labels
                    name.Text = nameInput.Text;
                    dept.Text = ratingDetails[0];
                    overall.Text = ratingDetails[1];
                    full.Visible = true;
                    takeAgain.Text = ratingDetails[2];
                    level.Text = ratingDetails[3];
                    //split the tags
                    var tags = ratingDetails[4].Split('#');
                    //assign tag labels base on the array length 
                    switch (tags.Length)
                    {
                        case 1:
                            tag1.Text = tags[0];
                            break;
                        case 2:
                            tag1.Text = tags[0];
                            tag2.Text = tags[1];
                            break;
                        case 3:
                            tag1.Text = tags[0];
                            tag2.Text = tags[1];
                            tag3.Text = tags[2];
                            break;
                        default:
                            tag1.Text = "No hot tag for this professor";
                            //reset the text
                            tag2.Text = tag3.Text = "";
                            break;
                    }
                    topRating.Text = ratingDetails[5];
                    time.Text = ratingDetails[6];
                }
            }
            catch (Exception)
            {
                //hide "/ 5" label
                full.Visible = false;
                //show error message
                noData.Visible = true;
                return;
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            foreach (string key in Request.Cookies.AllKeys)
            {
                HttpCookie cookie = Request.Cookies[key];
                cookie.Expires = DateTime.Now.AddMonths(-1);
                Response.AppendCookie(cookie);
            }
            Response.Redirect("~/Public.aspx");
        }
    }
}