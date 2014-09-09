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
            Console.Clear();

            string page2 = textFileReader("Page2.txt");
            Console.WriteLine(page2);
            Console.ReadLine();
            Console.Clear();

            string page3 = textFileReader("Page3.txt");
            Console.WriteLine(page3);
            string userValue = Console.ReadLine();
            userValue = userValue.ToUpper();
            if (userValue == "FOLLOW")
            {
                Console.WriteLine("Go to FOLLOW text file");
                Console.ReadLine();
            }
            else if (userValue == "HOTEL")
            {
                Console.WriteLine("This should go to the page for returning to the HOTEL.");
                Console.ReadLine();
            }
             
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
