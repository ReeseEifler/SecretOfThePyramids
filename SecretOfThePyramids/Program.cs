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
            /*
            StreamReader myReader = new StreamReader("TextFile1.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            Console.ReadLine();
            */
            string firstPrompt = textFileReader();
            Console.WriteLine(firstPrompt)
        }
       private string textFileReader()
        {
            //this is the method that will read each text file
            string textFile = "TextFile0";
            StreamReader myReader = new StreamReader(textFile);
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                //if (line != null)
                  //  Console.WriteLine(line);
            }

            //myReader.Close();
            //Console.ReadLine();
            return line;
        } 
    }
}
