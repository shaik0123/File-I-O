using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    public  class FileDemo
    {
        public static void CheckFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                Console.WriteLine("file present");
            }
            else
            {
                Console.WriteLine("file is not present");
            }
        }
        public static void ReadFromFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                Console.WriteLine("file present");
                string data = File.ReadAllText(FilePath);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("file is not present");
            }
        }
        public static void WriteToFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                Console.WriteLine("file present");
                string newdata = "second file";
                File.AppendAllText(FilePath, newdata);
               ReadFromFile(FilePath);
            }
            else
            {
                Console.WriteLine("file is not present");
            }
        }
    }
}
