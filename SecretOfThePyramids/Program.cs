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
            string caseSwitch = "TITLE";
            bool clearToGo = false;
            string userValue = "";
            string page = "";

            switch (caseSwitch)
            {
                case "TITLE":
                    page = textFileReader("Title.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("Warning.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("001.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    goto case "GO";

                case "GO":
                    page = textFileReader("002.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("003.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "FOLLOW")
                        {
                            goto case "FOLLOW";
                        }
                        else if (userValue == "HOTEL")
                        {
                            goto case "HOTEL";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }
                    
                    
                    break;

                case "FOLLOW":
                    Console.Clear();

                    page = textFileReader("013.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("037.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("096.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("087.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "ACCEPT")
                        {
                            goto case "ACCEPT";
                        }
                        else if (userValue == "ESCAPE")
                        {
                            goto case "ESCAPE";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }
                    
                    break;

                case "HOTEL":
                    Console.Clear();

                    page = textFileReader("004.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("032.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("026.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("023.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "RISK")
                        {
                            goto case "RISK";
                        }
                        else if (userValue == "POLICE")
                        {
                            goto case "POLICE";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }

                    break;

                case "ACCEPT":
                    Console.Clear();

                    page = textFileReader("073.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "JUMP")
                        {
                            goto case "JUMP";
                        }
                        else if (userValue == "CHANCE")
                        {
                            goto case "CHANCE";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }

                    break;

                case "ESCAPE":
                    Console.Clear();

                    page = textFileReader("104.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("100.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "GO")
                        {
                            goto case "GO";
                        }
                        else if (userValue == "NO")
                        {
                            goto case "NO";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }

                    break;

                case "RISK":
                    Console.Clear();

                    page = textFileReader("017.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("053.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("060.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("069.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("027.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("068.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "TIME")
                        {
                            goto case "TIME";
                        }
                        else if (userValue == "ESCAPE")
                        {
                            goto case "ESCAPE2";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }

                    break;

                case "POLICE":

                    break;

                case "JUMP":
                    Console.Clear();

                    page = textFileReader("103.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = textFileReader("110.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "GET OUT")
                        {
                            goto case "GET OUT";
                        }
                        else if (userValue == "CONTINUE")
                        {
                            goto case "CONTINUE";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }

                    break;

                case "CHANCE":

                    break;

                case "NO":

                    break;

                case "TIME":

                    break;

                case "ESCAPE2":

                    break;

                case "GET OUT":
                    Console.Clear();

                    page = textFileReader("084.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Type RESTART to restart or just press ENTER to quit.");
                        }
                    }

                    break;

                case "CONTINUE":

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
