using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace AddressBook
{
    class ReadWriteJSON
    {
        public class AddressData
        {
            public string name { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zip { get; set; }
        }
        public static void csvToJSON()
        {
            string importPath = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\addressBook.csv";
            string exportPath = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\contactData.json";
            using (var reader = new StreamReader(importPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Contacts: ");

                int count = 1;
                foreach (var contact in records)
                {

                    Console.WriteLine(count + ".  " + contact.name + "\t" + contact.phone + "\t" + contact.email + "\t" + contact.address
                                  + "\t" + contact.city + "\t" + contact.state + "\t" + contact.zip);
                    count++;
                }

                JsonSerializer serializer = new JsonSerializer();
                using (var writer = new StreamWriter(exportPath))
                using (JsonWriter jsonExport = new JsonTextWriter(writer))
                {
                    serializer.Serialize(jsonExport, records);
                }
            }
        }
    }
}
