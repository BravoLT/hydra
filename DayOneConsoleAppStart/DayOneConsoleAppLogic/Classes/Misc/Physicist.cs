using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Physicist
    {
        private string fieldOfStudy = string.Empty;
        private string scientistName = string.Empty;
        private int numberOfPublications;
        private bool stillLiving = true;


        public Physicist(string fieldOfStudy, string scientistName, int numberOfPublications)
        {
            this.FieldOfStudy = fieldOfStudy;
            this.ScientistName = scientistName;
            this.NumberOfPublications = numberOfPublications;
        }

        public string FieldOfStudy
        {
            get { return fieldOfStudy; }
            set { fieldOfStudy = value; }
        }

        public string ScientistName
        {
            get { return scientistName; }
            set { scientistName = value; }
        }

        public int NumberOfPublications
        {
            get { return numberOfPublications; }
            set { numberOfPublications = value; }
        }


    }
}
