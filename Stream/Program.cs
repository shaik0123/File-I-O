using System;

namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // WriteData.WriteToFile();
            //WriteData.ReadFromFile();
            Contact.ReadData();
            Contact.AppendData();
        }
    }
}
