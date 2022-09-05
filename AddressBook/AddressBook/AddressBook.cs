using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Addressbook
    {
        List<Address> addresses;

        public Addressbook(Address addr)
        {
            addresses = new List<Address>();
        }

        public bool Add(string fName, string lName, string addr, string ct, string st, string zip, long phNum, string eMail)
        {
            Address address = new Address(fName, lName, addr, ct, st, zip, phNum, eMail);
            Address result = Find(fName);

            if (result == null)
            {
                addresses.Add(address);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(string name)
        {
            Address addr = Find(name);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void List(Action<Address> action)
        {
            addresses.ForEach(action);
        }

        public bool isEmpty()
        {
            return (addresses.Count == 0);
        }

        public Address Find(string name)
        {
            Address addr = addresses.Find((a) => a.firstName == name);
            return addr;
        }
    }
}
