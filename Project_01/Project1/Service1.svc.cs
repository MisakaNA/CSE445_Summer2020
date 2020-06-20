using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Project1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int c2f(int c)
        {
            return ((c * 9/5) + 32); //Just return the c to f conversion formula
        }

        public int f2c(int f)
        {
            return ((f - 32) * 5/9); //Rewirte the formula for f to c
        }

        public string sort(string s)
        {
            var numberArray = s.Split(','); //split the sting with ',' and get an array of the string of numbers
            int[] holder = new int[numberArray.Length]; //create new array to hold numbers
            for(int i = 0; i < holder.Length; i++) 
            {
                //convert each number from string type to integer
                holder[i] = int.Parse(numberArray[i]); 
            }

            Array.Sort(holder); //sort the numbers
            
            var rstr = "";
            //reconstruct the string
            for (int i = 0; i < holder.Length; i++)
            {
                rstr += holder[i]; 

                //add the "," between numbers
                if(i != holder.Length - 1) { rstr += ","; }
            }
            return rstr;
        }
    }
}
