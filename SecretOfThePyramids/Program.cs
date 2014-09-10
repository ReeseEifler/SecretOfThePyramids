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
            string page = textFileReader("TitlePage.txt");
            Console.WriteLine(page);
            Console.ReadLine();
            Console.Clear();

            page = textFileReader("Warning.txt");
            Console.WriteLine(page);
            Console.ReadLine();
            Console.Clear();

            page = textFileReader("Page001.txt");
            Console.WriteLine(page);
            Console.ReadLine();
            Console.Clear();

            page = textFileReader("Page002.txt");
            Console.WriteLine(page);
            Console.ReadLine();
            Console.Clear();

            page = textFileReader("Page003.txt");
            Console.WriteLine(page);
            string userValue = Console.ReadLine();
            userValue = userValue.ToUpper();
            bool clearToGo = false;
            while (clearToGo == false)
            {
                if (userValue == "FOLLOW")
                {
                    clearToGo = true;
                    Console.Clear();
                    page = textFileReader("Page013.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();
                    page = textFileReader("Page037.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();
                    page = textFileReader("Page096.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();
                    page = textFileReader("Page087.txt");
                    Console.WriteLine(page);
                    userValue = Console.ReadLine();
                    userValue = userValue.ToUpper();
                    clearToGo = false;
                    while (clearToGo == false)
                    {
                        if (userValue == "ACCEPT")
                        {
                            clearToGo = true;
                            Console.Clear();
                            page = textFileReader("Page073.txt");
                            Console.WriteLine(page);
                            userValue = Console.ReadLine();
                            userValue = userValue.ToUpper();
                            clearToGo = false;
                            while (clearToGo == false)
                            {
                                if (userValue == "JUMP")
                                {
                                    clearToGo = true;
                                    Console.Clear();
                                    page = textFileReader("Page103.txt");
                                    Console.WriteLine(page);
                                    Console.ReadLine();
                                    page = textFileReader("Page110.txt");
                                    Console.WriteLine(page);

                                }
                                else if (userValue == "CHANCE")
                                {

                                }
                                else
                                {
                                    Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                                    userValue = Console.ReadLine();
                                    userValue = userValue.ToUpper();
                                }
                            }
                        }
                        else if (userValue == "ESCAPE")
                        {
                            clearToGo = true;
                            Console.Clear();
                            string page104 = textFileReader("Page104.txt");
                            Console.WriteLine(page104);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                            userValue = Console.ReadLine();
                            userValue = userValue.ToUpper();
                        }
                    }
                }
                else if (userValue == "HOTEL")
                {
                    clearToGo = true;
                    Console.Clear();
                    string page4 = textFileReader("Page004.txt");
                    Console.WriteLine(page4);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                    userValue = Console.ReadLine();
                    userValue = userValue.ToUpper();
                }

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
