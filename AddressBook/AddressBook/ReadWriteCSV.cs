using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace AddressBook
{
    class ReadWriteCSV
    {
        public class AddressData
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
        }

        public static void CsvReadWrite()
        {
            string importPath = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\addressBook.csv";
            string exportPath = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\contactList.csv";
            using (var reader = new StreamReader(importPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Contacts: ");

                int count = 1;
                foreach (var contact in records)
                {

                    Console.WriteLine(count + ".  " + contact.Name + "\t" + contact.Phone + "\t" + contact.Email + "\t" + contact.Address
                                  + "\t" + contact.City + "\t" + contact.State + "\t" + contact.Zip);
                    count++;
                }

                using (var writer = new StreamWriter(exportPath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }

    }
}
