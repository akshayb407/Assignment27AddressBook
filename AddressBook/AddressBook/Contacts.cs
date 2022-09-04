using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AddressBook
{
    public class Contact
    {
        public string firstName, lastName, address, city, state, zipCode, phoneNo, emailId;

        public Contact()
        {
            firstName = "";
            lastName = "";
            address = "";
            city = "";
            state = "";
            zipCode = "";
            phoneNo = "";
            emailId = "";
        }
        public Contact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNo, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNo = phoneNo;
            this.emailId = emailId;
        }
        public override string ToString()
        {
            return "Name :" + firstName + " " + lastName + "\nAddress :" + address + "   ZipCode :" + zipCode + "\nPhone No :" + phoneNo + "   Email :" + emailId;
        }

    }
}
