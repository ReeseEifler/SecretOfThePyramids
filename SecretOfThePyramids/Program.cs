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
                    Console.Clear();

                    page = read("Title.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("Warning.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("001.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    goto case "GO";

                case "GO":
                    page = read("002.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("003.txt");
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

                    page = read("013.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("037.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("096.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("087.txt");
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

                    page = read("004.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("032.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("026.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("023.txt");
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

                    page = read("073.txt");
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

                    page = read("104.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("100.txt");
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

                    page = read("017.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("053.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("060.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("069.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("027.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("068.txt");
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
                    Console.Clear();

                    page = read("059.txt");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();

                    page = read("012.txt");

                    break;

                case "JUMP":
                    Console.Clear();

                    page = read("103.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("110.txt");
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

                    page = read("084.txt");
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

        private static string read(string textFile)
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