using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stream
{
    public class WriteData
    {
        public static void WriteToFile()
        {
            try
            {
                /*string path = @"C:\Users\91951\source\repos\FileIO\FileIO\FristFile1.txt";
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine("first sentance");*/
                StreamWriter sw = new StreamWriter(@"C:\Users\91951\source\repos\FileIO\FileIO\FristFile1.txt");

                // To write on the console screen
                Console.WriteLine("Enter the Text that you want to write on File");

                // To read the input from the user
                string str = Console.ReadLine();

                // To write a line in buffer
                sw.WriteLine(str);

                // To write in output stream
                sw.Flush();

                // To close the stream
                sw.Close();

            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void ReadFromFile()
        {
            string path = @"C:\Users\91951\source\repos\FileIO\FileIO\FristFile1.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string line = sr.ReadLine();
            Console.WriteLine(line);


        }
    }
}
