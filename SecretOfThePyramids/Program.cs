using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretOfThePyramids
{
    class Program
    {
        static void Main(string[] args)
        {
            string titlePage = textFileReader("TitlePage.txt");
            Console.WriteLine(titlePage);
            Console.ReadLine();
            Console.Clear();

            string warning = textFileReader("Warning.txt");
            Console.WriteLine(warning);
            Console.ReadLine();
            Console.Clear();

            string page1 = textFileReader("Page1.txt");
            Console.WriteLine(page1);
            Console.ReadLine();
            
            /*
            Console.WriteLine("Do you want 1 or 2?");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.WriteLine("Hopefully this will go to page 1!");
                Console.ReadLine();
            }
            else if (userValue == "2")
            {
                Console.WriteLine("This should go to page 2.");
                Console.ReadLine();
            }
             * */
        }
       private static string textFileReader(string textFile)
        {
            //this is the method that will read each text file
            
            StreamReader myReader = new StreamReader(textFile);
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            myReader.Close();
            return line;
        } 
    }
}
