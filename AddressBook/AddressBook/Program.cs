using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program!");
            ContactDetails createContacts = new ContactDetails();
            createContacts.Contacts();
        }
    }
}
