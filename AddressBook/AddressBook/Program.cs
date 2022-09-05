using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBook
{
    class Program
    {
        Address address1 = new Address("Akshay", "Bhagwat", "Katraj", "Pune",
            "MH", "413709", 8087148746, "akshayb407@gmail.com");

        static void Main(string[] args)
        {
            Program.FileExists();
            Program.ReadAllLines();
            Program.ReadAllText();
           // Program.DeleteFile();
            Program.CopyFile();
        }
        public static void FileExists()
        {
            String path = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\Contact.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
        }
        public static void ReadAllLines()
        {
            String path = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\Contact.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            String path = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\Contact.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void DeleteFile()
        {
            String path = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\Contacts.txt";
            File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine("File not deleted");
            }
            else
            {
                Console.WriteLine("File deleted");
            }
        }
        public static void CopyFile()
        {
            String path = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\TextFile1.txt";
            String copyPath = @"H:\All Asignment\Assignment27AddressBook\AddressBook\AddressBook\Contact.txt";

            File.Copy(path, copyPath);
            Console.ReadKey();
        }

    }
} 

       
    

