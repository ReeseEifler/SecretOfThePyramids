using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretOfThePyramids
{

    public class Page
    {

        public string Number { get; set; }
        public Page(string number)
        {
            Number = number + ".txt";
        }
        public static string read(string textFile)
        {
            //this method reads each text file

            StreamReader reader = new StreamReader(textFile);
            string line = "";

            Console.Clear();

            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            Console.ReadLine();
            reader.Close();
            return line;
        }
    }

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
                    Page current = new Page("Title");
                    Page.read(current.Number);

                    current = new Page("Warning");
                    Page.read(current.Number);

                    current = new Page("001");
                    Page.read(current.Number);

                    goto case "GO";

                case "GO":
                    Console.Clear();
                    page = read("002a.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();

                    Console.Clear();
                    page = read("002b.txt");
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
                            Console.WriteLine("The choices are in BOLD, so only use that word.");
                        }
                    }
                    
                    
                    break;

                case "FOLLOW":
                    Console.Clear();

                    page = read("013a.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("013b.txt");
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

                    page = read("004a.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("004b.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "CHANGE")
                        {
                            goto case "CHANGE";
                        }
                        else if (userValue == "ORIGINAL")
                        {
                            goto case "ORIGINAL";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }

                    break;

                case "CHANGE":
                    Console.Clear();

                    page = read("032a.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("032b.txt");
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
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("012.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("044.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("033.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        if (userValue == "RAID")
                        {
                            goto case "RAID";
                        }
                        else if (userValue == "TOO DANGEROUS")
                        {
                            goto case "TOO DANGEROUS";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry. Try typing it in again.");
                        }
                    }

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
                    Console.Clear();

                    page = read("108.txt");
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
                
                case "ORIGINAL":
                    Console.Clear();

                    page = read("036a.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("036b.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("042.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "PILLOW")
                        {
                            goto case "PILLOW";
                        }
                        else if (userValue == "UNCLE")
                        {
                            goto case "UNCLE";
                        }
                        else
                        {
                            Console.WriteLine("Try typing that in again.");
                        }
                    }

                    break;

                case "PILLOW":

                    break;

                case "UNCLE":

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

                case "RAID":
                    Console.Clear();

                    page = read("016.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("008a.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("008b.txt");
                    Console.WriteLine();

                    while (clearToGo == false)
                    {
                        if (userValue == "ACCEPT")
                        {
                            goto case "ACCEPT2";
                        }
                        else if (userValue == "NARROW")
                        {
                            goto case "NARROW";
                        }
                        else
                        {
                            Console.WriteLine("Type RESTART to restart or just press ENTER to quit.");
                        }
                    }

                    break;

                case "TOO DANGEROUS":
                    Console.Clear();

                    page = read("014.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    Console.Clear();

                    page = read("106.txt");
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

                case "ACCEPT2":
                    Console.Clear();
                    page = read("034a.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();

                    Console.Clear();
                    page = read("034b.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    
                    Console.Clear();
                    page = read("035.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    
                    Console.Clear();
                    page = read("065.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    
                    Console.Clear();
                    page = read("079a.txt");
                    Console.WriteLine(page);
                    Console.ReadLine();
                    
                    Console.Clear();
                    page = read("079b.txt");
                    Console.WriteLine(page);

                    while (clearToGo == false)
                    {
                        userValue = Console.ReadLine();
                        userValue = userValue.ToUpper();

                        if (userValue == "JOIN")
                        {
                            goto case "JOIN";
                        }
                        else if (userValue == "TOO FAR OUT")
                        {
                            goto case "TOO FAR OUT";
                        }
                        else
                        {
                            Console.WriteLine("I didn't understand that entry");
                        }
                    }
                    
                    break;

                case "JOIN":
                    Console.Clear();

                    page = read("028.txt");
                    Console.WriteLine(page);

                    break;

                case "TOO FAR OUT":

                    Console.Clear();

                    page = read("082.txt");
                    Console.WriteLine(page);

                    break;

                case "NARROW":
                    Console.Clear();

                    page = read("074.txt");
                    Console.WriteLine(page);
                    break;

            }
        }

        private static string read(string textFile)
        {
            //this is the method that will read each text file
            
            StreamReader reader = new StreamReader(textFile);
            string line = "";

            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }
            reader.Close();
            return line;
        }
    
    }
   
}