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
            // this makes current.Number ininto the string name of the appropriate text file

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
            
            reader.Close();
            return line;
        }

        public static string Question()
        {
            //this method returns a user-entered string

            string userValue = Console.ReadLine();
            userValue = userValue.ToUpper();
            return userValue;
        }

        public static void Error()
        {
            Console.WriteLine("This is the right error message.  Fix your entry!");
        }
        public static void Enter()
        {
            Console.ReadLine();
        }
        
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            string caseSwitch = "TITLE";
            bool clearToGo = false;
            string userValue = "";

            switch (caseSwitch)
            {
                case "TITLE":
                    Page current = new Page("Title");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("Warning");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("001");
                    Page.read(current.Number);
                    Page.Enter();

                    goto case "GO";

                case "GO":
                    current = new Page("002a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("002b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("003");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error();
                        }
                    }
                    
                    
                    break;

                case "FOLLOW":
                    current = new Page("013a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("013b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("037");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("096");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("087");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error();
                        }
                    }
                    
                    break;

                case "HOTEL":
                    current = new Page("004a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("004b");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error();
                        }
                    }

                    break;

                case "CHANGE":
                    current = new Page("032a");
                    Page.read(current.Number);
                    Page.Enter();
                    
                    current = new Page("032b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("026");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("023");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error();
                        }
                    }

                    break;

                case "ACCEPT":
                    current = new Page("073");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error();
                        }
                    }

                    break;

                case "ESCAPE":
                    current = new Page("104");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("100");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        Page.Question();

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
                            Page.Error();
                        }
                    }

                    break;

                case "RISK":
                    current = new Page("017");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("053");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("060");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("069");
                    Page.read(current.Number);
                    Page.Enter();
                    
                    current = new Page("027");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("068");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        Page.Question();

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
                            Page.Error();
                        }
                    }

                    break;

                case "POLICE":
                    current = new Page("059");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("012");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("044");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("033");
                    Page.read(current.Number);

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
                    current = new Page("103");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("110");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                    current = new Page("108");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        Page.Question();

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
                    current = new Page("036a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("036b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("042");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error();
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
                    current = new Page("084a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("084b");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                    current = new Page("016");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("008a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("008b");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error();
                        }
                    }

                    break;

                case "TOO DANGEROUS":
                    current = new Page("014");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("106");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                    current = new Page("034a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("034b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("035");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("065");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("079a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("079b");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error();
                        }
                    }
                    
                    break;

                case "JOIN":
                    current = new Page("028a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("028b");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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

                case "TOO FAR OUT":
                    current = new Page("082");
                    Page.read(current.Number);
                    Page.Enter();

                    break;

                case "NARROW":
                    current = new Page("074");
                    Page.read(current.Number);
                    Page.Enter();

                    break;

            }

        }    
    
    }
   
}