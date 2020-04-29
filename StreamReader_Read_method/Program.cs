using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader_Read_method
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Temp\MyTest.txt";

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is some text");
                    sw.WriteLine("to test");
                    sw.WriteLine("Reading");
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() > 0)
                    {
                        Console.WriteLine((char)sr.Read());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed : {0}", e.ToString());
            }
        }
    }
}
