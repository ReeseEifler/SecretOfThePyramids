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

        public static string Reader (string textFile)
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

        public static void Error(string errorName)
        {
            int errorNumber;
            if (errorName == "restart")
            {
                errorNumber = 0; 
            }
            else if (errorName == "firstError")
            {
                errorNumber = 1;
            }
            else
            {
                errorNumber = 1;
            }

            string[] errorMessages = new string[2];

            errorMessages[0] = "Type RESTART or QUIT.";
            errorMessages[1] = "I didn't understand that entry. Try typing it in again.";
            Console.WriteLine(errorMessages[errorNumber]);
        }
        public static void Enter()
        {
            Console.ReadLine();
        }
        public static void Read(string page)
        {
            Page current = new Page(page);
            Page.Reader(current.Number);
            Page.Enter();
        }
        public static string Choice(string page, string choice1, string choice2)
        {
            bool clearToGo = false;
            Page current = new Page(page);
            Page.Reader(current.Number);
            string choice = "";

            while (clearToGo == false)
            {
                bool noErrorYet = true;
                string userValue = Page.Question();
                

                if (userValue == choice1)
                {
                    if (choice1 == "DREAM")
                    {
                        choice1 = "GO";
                        noErrorYet = true;
                        choice = choice1;
                        clearToGo = true;
                    }
                    else if ((choice1 == "ACCEPT" && choice2 == "NARROW") || (choice1 == "RAID" && choice2 == "VILLA")) 
                    {
                        choice1 += "2";
                        noErrorYet = true;
                        choice = choice1;
                        clearToGo = true;
                    }
                    else if (choice1 == "STAY" && choice2 == "ACROSS THE DESERT")
                    {
                        choice1 += "3";
                        noErrorYet = true;
                        choice = choice1;
                        clearToGo = true;
                    }
                    else if (choice1 == "INSIST" && choice2 == "STAY")
                    {
                        choice1 += "4";
                        noErrorYet = true;
                        choice = choice1;
                        clearToGo = true;
                    }
                    else
                    {
                        noErrorYet = true;
                        choice = choice1;
                        clearToGo = true;
                    }
                }
                else if (userValue == choice2)
                {
                    if ((choice1 == "TIME" && choice2 == "ESCAPE") || (choice1 == "CONVINCE" && choice2 == "AGREE"))
                    {
                        choice2 += "2";
                        noErrorYet = true;
                        choice = choice2;
                        clearToGo = true;
                    }
                    else
                    {
                        noErrorYet = true;
                        choice = choice2;
                        clearToGo = true;
                    }
                }
                else
                {
                    if (noErrorYet == true)
                    {
                        Console.Clear();
                        Page.Reader(current.Number);
                        Page.Error("firstError");
                        noErrorYet = false;

                    }
                    else
                    {
                        Console.Clear();
                        Page.Reader(current.Number);
                        Page.Error("firstError");
                    }
                }
            }

            return choice;

        }
        public static string ChooseCase(string caseSwitch)
        {
            
            switch (caseSwitch)
            {
                case "TITLE":
                    Page.Read("Title");
                    Page.Read("Warning");
                    Page.Read("001");
                    caseSwitch = "GO";
                    break;

                case "GO":
                    Page.Read("002a");
                    Page.Read("002b");
                    caseSwitch = Page.Choice("003S", "FOLLOW", "HOTEL");
                    break;

                case "FOLLOW":
                    Page.Read("013a");
                    Page.Read("013b");
                    Page.Read("037");
                    Page.Read("096");
                    Page.Read("087a");
                    caseSwitch = Page.Choice("087bS", "ACCEPT", "ESCAPE");
                    break;

                case "HOTEL":
                    Page.Read("004a");
                    caseSwitch = Page.Choice("004bS", "CHANGE", "ORIGINAL");
                    break;

                case "ACCEPT":
                    Page.Read("073a");
                    caseSwitch = Page.Choice("073bS", "JUMP", "CHANCE");
                    break;

                case "ESCAPE":
                    Page.Read("104a");
                    Page.Read("104b");
                    Page.Read("100a");
                    caseSwitch = Page.Choice("100bS", "DREAM", "NO");
                    break;

                case "CHANGE":
                    Page.Read("032a");
                    Page.Read("032b");
                    Page.Read("026");
                    Page.Read("023a");
                    caseSwitch = Page.Choice("023bS", "RISK", "POLICE");
                    break;

                case "ORIGINAL":
                    Page.Read("036a");
                    Page.Read("036b");
                    caseSwitch = Page.Choice("042S", "PILLOW", "UNCLE");
                    break;

                case "JUMP":
                    Page.Read("103");
                    Page.Read("110a");
                    caseSwitch = Page.Choice("110bS", "GET OUT", "CONTINUE");
                    break;

                case "CHANCE":
                    Page.Read("108a");
                    caseSwitch = Page.Choice("108bR", "RESTART", "QUIT");
                    break;

                case "NO":
                    caseSwitch = Page.Choice("113R", "RESTART", "QUIT");
                    break;

                case "RISK":
                    Page.Read("017");
                    Page.Read("053");
                    Page.Read("060");
                    Page.Read("069a");
                    Page.Read("069b");
                    Page.Read("027");
                    Page.Read("068a");
                    caseSwitch = Page.Choice("068bS", "TIME", "ESCAPE");
                    break;

                case "POLICE":
                    Page.Read("059");
                    Page.Read("012");
                    Page.Read("044a");
                    Page.Read("044b");
                    Page.Read("033a");
                    caseSwitch = Page.Choice("033bS", "RAID", "TOO DANGEROUS");
                    break;

                case "PILLOW":
                    Page.Read("029a");
                    caseSwitch = Page.Choice("029bS", "GO HOME", "STAY");
                    break;

                case "UNCLE":
                    Page.Read("088a");
                    Page.Read("088b");
                    Page.Read("094a");
                    caseSwitch = Page.Choice("094bS", "PYRAMID", "TRAP");
                    break;

                case "GET OUT":
                    Page.Read("084a");
                    caseSwitch = Page.Choice("084bR", "RESTART", "QUIT");
                    break;

                case "CONTINUE":
                    Page.Read("114");
                    Page.Read("116a");
                    caseSwitch = Page.Choice("116bR", "RESTART", "QUIT");
                    break;

                case "TIME":
                    Page.Read("011a");
                    Page.Read("011b");
                    Page.Read("075a");
                    caseSwitch = Page.Choice("075bR", "RESTART", "QUIT");
                    break;

                case "ESCAPE2":
                    Page.Read("111");
                    caseSwitch = Page.Choice("112R", "RESTART", "QUIT");
                    break;

                case "RAID":
                    Page.Read("016");
                    Page.Read("008a");
                    caseSwitch = Page.Choice("008bS", "ACCEPT", "NARROW");
                    break;

                case "TOO DANGEROUS":
                    Page.Read("014");
                    Page.Read("106a");
                    caseSwitch = Page.Choice("106bR", "RESTART", "QUIT");
                    break;

                case "GO HOME":
                    caseSwitch = Page.Choice("089R", "RESTART", "QUIT");
                    break;

                case "STAY":
                    Page.Read("007");
                    Page.Read("062");
                    Page.Read("040");
                    Page.Read("070a");
                    caseSwitch = Page.Choice("070bS", "CONVINCE", "AGREE");
                    break;

                case "PYRAMID":
                    Page.Read("067a");
                    caseSwitch = Page.Choice("067bR", "RESTART", "QUIT");
                    break;

                case "TRAP":
                    Page.Read("109a");
                    caseSwitch = Page.Choice("109bR", "RESTART", "QUIT");
                    break;

                case "ACCEPT2":
                    Page.Read("034a");
                    Page.Read("034b");
                    Page.Read("035");
                    Page.Read("065");
                    Page.Read("079a");
                    caseSwitch = Page.Choice("079bS", "JOIN", "TOOO FAR OUT");
                    break;

                case "NARROW":
                    Page.Read("074a");
                    caseSwitch = Page.Choice("074bS", "TELEPHONE", "CAR");
                    break;

                case "CONVINCE":
                    Page.Read("024");
                    caseSwitch = Page.Choice("021S", "INSIST",  "STAY");
                    break;

                case "AGREE2":
                    Page.Read("090a");
                    caseSwitch = Page.Choice("090bR", "RESTART", "QUIT");
                    break;

                case "JOIN":
                    Page.Read("028a");
                    caseSwitch = Page.Choice("028bR", "RESTART", "QUIT");
                    break;

                case "TOO FAR OUT":
                    Page.Read("082a");
                    Page.Read("082b");
                    Page.Read("083a");
                    caseSwitch = Page.Choice("083bR", "RESTART", "QUIT");
                    break;

                case "TELEPHONE":
                    caseSwitch = Page.Choice("054R", "RESTART", "QUIT");
                    break;

                case "CAR":
                    Page.Read("030");
                    Page.Read("005");
                    caseSwitch = Page.Choice("031S", "RAID", "VILLA");
                    break;

                case "INSIST":
                    Page.Read("097a");
                    Page.Read("097b");
                    Page.Read("018");
                    Page.Read("019");
                    Page.Read("050a");
                    Page.Read("050b");
                    caseSwitch = Page.Choice("051S", "STAY", "LEAVE");
                    break;

                case "STAY4":
                    Page.Read("049");
                    Page.Read("010");
                    Page.Read("063");
                    Page.Read("066a");
                    caseSwitch = Page.Choice("066bR", "RESTART", "QUIT");
                    break;

                case "RAID2":
                    Page.Read("080a");
                    Page.Read("080b");
                    caseSwitch = Page.Choice("081S", "KEEP FLYING", "LAND");
                    break;

                case "VILLA":
                    Page.Read("078");
                    caseSwitch = Page.Choice("020R", "RESTART", "QUIT");
                    break;

                case "STAY2":
                    Page.Read("076");
                    Page.Read("077a");
                    caseSwitch = Page.Choice("077bR", "RESTART", "QUIT");
                    break;

                case "LEAVE":
                    Page.Read("039a");
                    Page.Read("039b");
                    Page.Read("056a");
                    caseSwitch = Page.Choice("056bR", "RESTART", "QUIT");
                    break;

                case "KEEP FLYING":
                    caseSwitch = Page.Choice("092R", "RESTART", "QUIT");
                    break;

                case "LAND":
                    Page.Read("045");
                    Page.Read("046a");
                    Page.Read("046b");
                    caseSwitch = Page.Choice("085S", "STAY", "ACROSS THE DESERT"); 
                    break;

                case "STAY3":
                    Page.Read("101a");
                    caseSwitch = Page.Choice("101bR", "RESTART", "QUIT");
                    break;

                case "ACROSS THE DESERT":
                    Page.Read("093");
                    Page.Read("072");
                    Page.Read("055a");
                    caseSwitch = Page.Choice("085S", "INVESTIGATE", "SLIP AWAY"); 
                    break;

                case "INVESTIGATE":
                    Page.Read("038a");
                    caseSwitch = Page.Choice("038bR", "RESTART", "QUIT");
                    break;

                case "SLIP AWAY":
                    Page.Read("058");
                    Page.Read("099a");
                    caseSwitch = Page.Choice("099bR", "RESTART", "QUIT");
                    break;
            }
            return caseSwitch;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string caseSwitch = "TITLE";

            while (caseSwitch != "QUIT")
            {
                if ((caseSwitch != "RESTART") && (caseSwitch != "QUIT"))
                {
                    caseSwitch = Page.ChooseCase(caseSwitch);
                }
                else if (caseSwitch == "RESTART")
                {
                    caseSwitch = Page.ChooseCase("TITLE");
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
                
            }

        }    
    
    }
   
}