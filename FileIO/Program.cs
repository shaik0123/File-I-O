using System;
using System.IO;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string FilePath = @"C:\Users\91951\source\repos\FileIO\FileIO\FristFile.txt";
            FileDemo.CheckFile(FilePath);
            //FileDemo.ReadFromFile(FilePath);
            //FileDemo.WriteToFile(FilePath);
        }

    }
}
