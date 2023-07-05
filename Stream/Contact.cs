using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
//using Newtonsoft.Json.Linq;

namespace Stream
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public static void ReadData()
        {
            var lines = File.ReadAllLines(@"C:\\Users\\91951\\source\\repos\\FileIO\\FileIO\\CSVFILE.csv");
            var list = new List<Contact>();
            foreach (var line in lines)
            {
                // Console.WriteLine(line);
                var values = line.Split(',');
                var contacts = new Contact() { Name = values[0], Phone = values[1] };
                list.Add(contacts);
            }
            list.ForEach(x => Console.WriteLine($"{x.Name} \t {x.Phone}"));
        }
        public static void AppendData()
        {
            var list = Contacts.GetContacts();
            foreach (var contact in list)
            {
                File.AppendAllText(@"C:\\Users\\91951\\source\\repos\\FileIO\\FileIO\\CSVFILE.csv", $"{contact.Name},{contact.Phone}\n");
            }
        }

    }
    public class Contacts
    {
        public static List<Contact> GetContacts()
        {
            return new List<Contact>()
            {
                new Contact(){Name="mohan",Phone="9988776655"},
                new Contact(){Name="raj",Phone="8888776666"},
                new Contact(){Name="krishna",Phone="9999777755"},
            };
        }

    }
}
