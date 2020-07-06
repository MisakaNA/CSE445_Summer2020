using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace ASUClassFinder
{
    public partial class ASUClassFinder : System.Web.UI.Page
    {
        protected void search_Click(object sender, EventArgs e)
        {
            //set open classes or all classes
            var setStatus = (status.SelectedValue == "All Classes") ? "all" : "open";
            var url = "http://webstrar63.fulton.asu.edu/page4/Service1.svc/ASUClassFinder?classCode="
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
                        rowCells[0]  = nameCell;
                        for (int j = 0; j < classInfo.Length; j++)
                        {
                            //create the subcell
                            TableCell newCell = new TableCell { Text = classInfo[j] };
                            //add to the row
                            rowCells[j + 1] = newCell;
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
    }
}