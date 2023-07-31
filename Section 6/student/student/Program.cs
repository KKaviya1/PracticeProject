using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string path = "F:\\main project\\"; 
                Console.WriteLine("Enter file name to read out from");
                string fName = Console.ReadLine();
                string fpath = path + fName;
                if (File.Exists(fpath))
                {
                    string[] lines = File.ReadAllLines(fpath);
                    foreach (string line in lines)
                    {

                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error!! " + ex.Message);

            }
            finally
            {

                Console.ReadKey();
            }
        }
    }
}
