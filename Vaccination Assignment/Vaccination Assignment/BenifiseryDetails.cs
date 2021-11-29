using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination_Assignment
{
    class BenifiseryDetails


    {
        public int RegistraionNumber { get; set; }
        public string BenifiseryName { get; set; }
        public long PhoneNumber { get; set; }
        public string city { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public BenifiseryDetails()
        {

        }


        public BenifiseryDetails(int RegistraionNumber, string BenifiseryName, long PhoneNumber, string city, int Age, string Gender)
        {
            this.RegistraionNumber = RegistraionNumber;
            this.BenifiseryName = BenifiseryName;
            this.PhoneNumber = PhoneNumber;
            this.city = city;
            this.Age = Age;
            this.Gender = Gender;
        }


    }
    
}  
 