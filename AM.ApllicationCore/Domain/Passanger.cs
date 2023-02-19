using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PasseportNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "Passenger : FirstName=" + FirstName + "LastName=" + LastName + "BirthDate=" + BirthDate +
                "TelNumber=" + TelNumber + "EmailAddress=" + EmailAddress + "Passeport Number=" + "\n";
        }

        /* public bool CheckProfil(String firstname,string lastname)
         {
             return  FirstName==firstname && LastName==lastname;
         }
         public bool CheckProfil(String firstname, string lastname,string emailadress )
         {
             return FirstName == firstname && LastName == lastname && EmailAddress == emailadress;
         }*/
        public bool CheckProfil(String firstname, string lastname, string emailadress = null)
        {
            if (emailadress == null)
            {
                return FirstName == firstname && LastName == lastname;

            }
            else
            {
                return FirstName == firstname && LastName == lastname && EmailAddress == emailadress;

            }
        }
        public virtual void PassangerType()
        {

            Console.WriteLine("I am a passanger");
        }


    }
}
