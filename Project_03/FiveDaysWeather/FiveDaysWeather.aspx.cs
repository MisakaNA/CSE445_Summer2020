using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace FiveDaysWeather
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void searchBut_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://webstrar63.fulton.asu.edu/page1/Service1.svc/";
            string unitAbbr;
            //convert the unit selected to the service accept one
            if(unitSelect.SelectedValue == "Fahrenheit (F, mph)")
            {
                unitAbbr = "I";
            }
            else
            {
                unitAbbr = "M";
            }
            //complete the url
            string url = baseUrl + "Weather5Days?city=" + cityInput.Text + "&state=" + stateInput.Text + "&unit=" + unitAbbr;
            string[][] weatherResult = new string[5][];
            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                using (var getDataStream = response.GetResponseStream())
                {
                    //read response
                    StreamReader reader = new StreamReader(getDataStream);
                    string dataStr = reader.ReadToEnd();
                    Regex regex = new Regex(@">(.*?)<");
                    string temp = regex.Match(dataStr).ToString();
                    //remove the redundant '>' and '<' and split with '|' to get an array contains 5 days weather
                    string[] dayWeather = temp.Substring(1, temp.Length - 2).Split('|');
                    for (int i = 0; i < dayWeather.Length; i++)
                    {
                        //split weather of each day to get detailed data
                        weatherResult[i] = dayWeather[i].Split(',');
                    }
                }
            }
            catch (Exception) 
            {
                //if exception occurs clear all previous result and show error message
                ClearResult();
                return;
            }
            //update the label texts
            assignLabels(weatherResult);
            
        }

        private void assignLabels(string[][] result)
        {
            //hide the error message
            error.Visible = false;
            //update all date label texts...
            date1.Text = result[0][0]; date2.Text = result[1][0]; date3.Text = result[2][0]; date4.Text = result[3][0]; date5.Text = result[4][0];
            //update all temperature label texts...
            highT1.Text = result[0][1]; highT2.Text = result[1][1]; highT3.Text = result[2][1]; highT4.Text = result[3][1]; highT5.Text = result[4][1];
            lowT1.Text = result[0][2]; lowT2.Text = result[1][2]; lowT3.Text = result[2][2]; lowT4.Text = result[3][2]; lowT5.Text = result[4][2];
            //update all description label texts...
            desc1.Text = result[0][3]; desc2.Text = result[1][3]; desc3.Text = result[2][3]; desc4.Text = result[3][3]; desc5.Text = result[4][3];
            //wind direction texts...
            dir1.Text = result[0][4]; dir2.Text = result[1][4]; dir3.Text = result[2][4]; dir4.Text = result[3][4]; dir5.Text = result[4][4];
            //wind speed texts...
            spd1.Text = result[0][5]; spd2.Text = result[1][5]; spd3.Text = result[2][5]; spd4.Text = result[3][5]; spd5.Text = result[4][5];
            //relative humidity texts...
            rh1.Text = result[0][6]; rh2.Text = result[1][6]; rh3.Text = result[2][6]; rh4.Text = result[3][6]; rh5.Text = result[4][6];
        }

        private void ClearResult()
        {
            //show the error message
            error.Visible = true;
            //assign all result label texts to empty string
            date1.Text = date2.Text = date3.Text = date4.Text = date5.Text =
            highT1.Text = highT2.Text = highT3.Text = highT4.Text = highT5.Text =
            lowT1.Text = lowT2.Text = lowT3.Text = lowT4.Text = lowT5.Text =
            desc1.Text = desc2.Text = desc3.Text = desc4.Text = desc5.Text =
            dir1.Text = dir2.Text = dir3.Text = dir4.Text = dir5.Text = 
            spd1.Text = spd2.Text = spd3.Text = spd4.Text = spd5.Text = 
            rh1.Text = rh2.Text = rh3.Text = rh4.Text = rh5.Text = "";


        }

    }
}