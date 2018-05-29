using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Address
    {
        private string street = string.Empty;
        private string city = string.Empty;
        private string state = string.Empty;
        private string zip = string.Empty;


        public string Street
        {
            get { return this.street; }
        }
        public string City
        {
            get { return this.city; }
        }
        public string State
        {
            get { return this.state; }
        }
        public string Zip
        {
            get { return this.zip; }
        }

        public Address(string street, string city, string stateAbbrev, string zip)
        {
            this.street = street;
            this.city = city;
            this.state = stateAbbrev;
            this.zip = zip;
        }

     

    }
}
