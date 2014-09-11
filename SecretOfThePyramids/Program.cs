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
            int caseSwitch = 0;
            bool clearToGo = false;
            string userValue = "";
            string page = "";

            switch (caseSwitch)
            {
                case 0:


                    page = textFileReader("TitlePage.txt");
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

                    goto case 1;

                    break;

                case 1:
                    page = textFileReader("Page002.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("Page003.txt");
                    Console.WriteLine(page);
                    userValue = Console.ReadLine();
                    userValue = userValue.ToUpper();

                    while (clearToGo == false)
                    {
                        if (userValue == "FOLLOW")
                        {
                            caseSwitch = 2;
                            break;
                        }
                        else if (userValue == "HOTEL")
                        {
                            caseSwitch = 3;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                            userValue = Console.ReadLine();
                            userValue = userValue.ToUpper();
                        }
                    }

                    break;
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

/*
 * page = textFileReader("TitlePage.txt");
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
            userValue = Console.ReadLine();
            userValue = userValue.ToUpper();

            while (clearToGo == false)
            {
                if (userValue == "FOLLOW")
                {
                    
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
                                    Console.Clear();

                                    page = textFileReader("Page110.txt");
                                    Console.WriteLine(page);
                                    userValue = Console.ReadLine();
                                    userValue = userValue.ToUpper();

                                    clearToGo = false;

                                    while (clearToGo == false)
                                    {
                                        if (userValue == "GET OUT")
                                        {
                                            clearToGo = true;
                                            Console.Clear();

                                            page = textFileReader("Page084.txt");
                                            Console.WriteLine(page);
                                            Console.ReadLine();
                                            Console.Clear();
                                             
                                        }
                                        else if (userValue == "CONTINUE")
                                        {
                                            clearToGo = true;
                                            Console.Clear();

                                            page = textFileReader("Page114.txt");
                                            Console.WriteLine(page);
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
                                else if (userValue == "CHANCE")
                                {
                                    clearToGo = true;
                                    Console.Clear();

                                    page = textFileReader("Page084.txt");
                                    Console.WriteLine(page);
                                    userValue = Console.ReadLine();
                                    userValue = userValue.ToUpper();
                                    
                                    clearToGo = false;

                                    while (clearToGo == false)
                                    {
                                        if (userValue == "RESTART")
                                        {
                                            
                                        }
                                        else if (userValue == "")
                                        {
                                            clearToGo = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Are you trying to RESTART? If not, just press ENTER.");
                                            userValue = Console.ReadLine();
                                            userValue = userValue.ToUpper();
                                        }
                                    }
                                        
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

                            page = textFileReader("Page104.txt");
                            Console.WriteLine(page);
                            Console.ReadLine();
                            Console.Clear();

                            page = textFileReader("Page100.txt");
                            Console.WriteLine(page);
                            userValue = Console.ReadLine();
                            userValue = userValue.ToUpper();
                            clearToGo = false;

                            while (clearToGo == false)
                            {
                                if (userValue == "GO")
                                {
                                    clearToGo = true;
                                    Console.Clear();

                                    page = textFileReader("Page002.txt");
                                    Console.WriteLine(page);
                                }
                                else if (userValue == "NO")
                                {
                                    clearToGo = true;
                                    Console.Clear();

                                    page = textFileReader("Page113.txt");
                                    Console.WriteLine(page);
                                }
                                else
                                {
                                    Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                                    userValue = Console.ReadLine();
                                    userValue = userValue.ToUpper();
                                }
                            }
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
  */
