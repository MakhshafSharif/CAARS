using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static List<string> DisplayData(string Carname)
        {
            var dispCars = new List<string>();//temperory array in which we will store our data..
            var matchList = carList();
            foreach (string x in matchList)
            {
                if (x.StartsWith(Carname)) // string1.StartsWith("Welcome");
                {
                    dispCars.Add(x);
                }
            }
            return dispCars;
        }
        public class Cars
        {
            public string name { get; set; }

        }
        public static List<string> carList()
        {
            var myList = new List<string>();
            myList.Add("Chevrolet" );
            myList.Add("Honda");
            myList.Add("Nissan");
            myList.Add("Ford");
            myList.Add("Fiat");
            myList.Add("Jeep");
            myList.Add("Volkswagen");
            myList.Add("Volvo");
            myList.Add("Jaguar");
            myList.Add("Audi");
            myList.Add("Toyota");
            myList.Add("Civic");
            myList.Add("Lexus");
            myList.Add("Porshce");
            myList.Add("Bugatti");
            myList.Add("Bentley");

            return myList;
        }
    }
}