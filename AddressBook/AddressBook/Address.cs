using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Address
    {
        public Address(string fName, string lName, string addr, string ct, string st, string zip, long phNum, string eMail)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.address = addr;
            this.city = ct;
            this.state = st;
            this.zipcode = zip;
            this.phoneNumber = phNum;
            this.email = eMail;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }
    }
}
