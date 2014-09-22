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
                    noErrorYet = true;
                    choice = choice1;
                    clearToGo = true;
                }
                else if (userValue == choice2)
                {
                    noErrorYet = true;
                    choice = choice2;
                    clearToGo = true;
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
                    Page.Enter();
                    Page.Read("Warning");
                    Page.Enter();
                    Page.Read("001");
                    Page.Enter();
                    caseSwitch = "GO";
                    break;

                case "GO":
                    Page.Read("002a");
                    Page.Enter();
                    Page.Read("002b");
                    Page.Enter();
                    caseSwitch = Page.Choice("003S", "FOLLOW", "HOTEL");
                    break;

                case "FOLLOW":
                    Page.Read("013a");
                    Page.Enter();
                    Page.Read("013b");
                    Page.Enter();
                    Page.Read("037");
                    Page.Enter();
                    Page.Read("096");
                    Page.Enter();
                    Page.Read("087a");
                    Page.Enter();
                    caseSwitch = Page.Choice("087bS", "ACCEPT", "ESCAPE");
                    break;

                case "HOTEL":
                    Page.Read("004a");
                    Page.Enter();
                    caseSwitch = Page.Choice("004bS", "CHANGE", "ORIGINAL");
                    break;

                case "ACCEPT":
                    Page.Read("073a");
                    Page.Enter();
                    Page.Read("073bS");
                    caseSwitch = Page.Choice("073bS", "JUMP", "CHANCE");
                    break;

                case "ESCAPE":
                    Page.Read("104a");
                    Page.Enter();
                    Page.Read("104b");
                    Page.Enter();
                    Page.Read("100a");
                    Page.Enter();
                    caseSwitch = Page.Choice("100bS", "GO", "NO");
                    break;

                case "CHANGE":
                    Page.Read("032a");
                    Page.Enter();
                    Page.Read("032b");
                    Page.Enter();
                    Page.Read("026");
                    Page.Enter();
                    Page.Read("023a");
                    Page.Enter();
                    caseSwitch = Page.Choice("023bS", "RISK", "POLICE");
                    break;

                case "ORIGINAL":
                    Page.Read("036a");
                    Page.Enter();
                    Page.Read("036b");
                    Page.Enter();
                    caseSwitch = Page.Choice("042S", "PILLOW", "UNCLE");
                    break;

                case "JUMP":
                    Page.Read("103");
                    Page.Enter();
                    Page.Read("110a");
                    Page.Enter();
                    Page.Read("110bS");
                    caseSwitch = Page.Choice("110bS", "GET OUT", "CONTINUE");
                    break;

                case "CHANCE":
                    Page.Read("108a");
                    Page.Enter();
                    caseSwitch = Page.Choice("108bR", "RESTART", "QUIT");
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
            /*
            switch (caseSwitch)
            {
                


                case "ESCAPE":
                    Page.Read("104a");
                    Page.Enter();
                    Page.Read("104b");
                    Page.Enter();
                    Page.Read("100a");
                    Page.Enter();
                    Page.Read("100bS");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "RISK":
                    Page.Read("017");
                    Page.Enter();
                    Page.Read("053");
                    Page.Enter();
                    Page.Read("060");
                    Page.Enter();
                    Page.Read("069a");
                    Page.Enter();
                    Page.Read("069b");
                    Page.Enter();
                    Page.Read("027");
                    Page.Enter();
                    Page.Read("068a");
                    Page.Enter();
                    Page.Read("068bS");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "POLICE":
                    Page.Read("059");
                    Page.Enter();
                    Page.Read("012");
                    Page.Enter();
                    Page.Read("044a");
                    Page.Enter();
                    Page.Read("044b");
                    Page.Enter();
                    Page.Read("033a");
                    Page.Enter();
                    Page.Read("033bS");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

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
                            Page.Error("firstError");
                        }
                    }

                    break;

                

                case "CHANCE":
                    Page.Read("108a");
                    Page.Enter();
                    Page.Read("108bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;
                
                

                case "PILLOW":
                    Page.Read("029a");
                    Page.Enter();
                    Page.Read("029bS");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "GO HOME")
                        {
                            goto case "GO HOME";
                        }
                        else if (userValue == "STAY")
                        {
                            goto case "STAY";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    } 

                    break;

                case "UNCLE":
                    Page.Read("088a");
                    Page.Enter();
                    Page.Read("088b");
                    Page.Enter();
                    Page.Read("094a");
                    Page.Enter();
                    Page.Read("094bS");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "PYRAMID")
                        {
                            goto case "PYRAMID";
                        }
                        else if (userValue == "TRAP")
                        {
                            goto case "TRAP";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "PYRAMID":
                    Page.Read("067a");
                    Page.Enter();
                    Page.Read("067bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "TRAP":
                    Page.Read("109a");
                    Page.Enter();
                    Page.Read("109bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "GO HOME":
                    Page.Read("089R");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "STAY":
                    Page.Read("007");
                    Page.Enter();
                    Page.Read("062");
                    Page.Enter();
                    Page.Read("040");
                    Page.Enter();
                    Page.Read("070a");
                    Page.Enter();
                    Page.Read("070bS");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "CONVINCE")
                        {
                            goto case "CONVINCE";
                        }
                        else if (userValue == "AGREE")
                        {
                            goto case "AGREE2";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }


                    break;

                case "CONVINCE":
                    Page.Read("024");
                    Page.Enter();
                    Page.Read("021S");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "INSIST")
                        {
                            goto case "INSIST";
                        }
                        else if (userValue == "STAY")
                        {
                            goto case "STAY4";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "AGREE2":
                    Page.Read("090a");
                    Page.Enter();
                    Page.Read("090bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "INSIST":
                    Page.Read("097a");
                    Page.Enter();
                    Page.Read("097b");
                    Page.Enter();
                    Page.Read("018");
                    Page.Enter();
                    Page.Read("019");
                    Page.Enter();
                    Page.Read("050a");
                    Page.Enter();
                    Page.Read("050b");
                    Page.Enter();
                    Page.Read("051S");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "STAY")
                        {
                            goto case "STAY2";
                        }
                        else if (userValue == "LEAVE")
                        {
                            goto case "LEAVE";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "STAY4":
                    Page.Read("049");
                    Page.Enter();
                    Page.Read("010");
                    Page.Enter();
                    Page.Read("063");
                    Page.Enter();
                    Page.Read("066a");
                    Page.Enter();
                    Page.Read("066bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "STAY2":
                    Page.Read("076");
                    Page.Enter();
                    Page.Read("077a");
                    Page.Enter();
                    Page.Read("077bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "LEAVE":
                    Page.Read("039a");
                    Page.Enter();
                    Page.Read("039b");
                    Page.Enter();
                    Page.Read("056a");
                    Page.Enter();
                    Page.Read("056bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "NO":
                    Page.Read("113R");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "TIME":
                    Page.Read("011a");
                    Page.Enter();
                    Page.Read("011b");
                    Page.Enter();
                    Page.Read("075a");
                    Page.Enter();
                    Page.Read("075bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "ESCAPE2":
                    Page.Read("111");
                    Page.Enter();
                    Page.Read("112R");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "GET OUT":
                    Page.Read("084a");
                    Page.Enter();
                    Page.Read("084bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "CONTINUE":
                    Page.Read("114");
                    Page.Enter();
                    Page.Read("116a");
                    Page.Enter();
                    Page.Read("116bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "RAID":
                    Page.Read("016");
                    Page.Enter();
                    Page.Read("008a");
                    Page.Enter();
                    Page.Read("008bS");

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
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "TOO DANGEROUS":
                    Page.Read("014");
                    Page.Enter();
                    Page.Read("106a");
                    Page.Enter();
                    Page.Read("106bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "ACCEPT2":
                    Page.Read("034a");
                    Page.Enter();
                    Page.Read("034b");
                    Page.Enter();
                    Page.Read("035");
                    Page.Enter();
                    Page.Read("065");
                    Page.Enter();
                    Page.Read("079a");
                    Page.Enter();
                    Page.Read("079bS");

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
                            Page.Error("firstError");
                        }
                    }
                    
                    break;

                case "JOIN":
                    Page.Read("028a");
                    Page.Enter();
                    Page.Read("028bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "TOO FAR OUT":
                    Page.Read("082a");
                    Page.Enter();
                    Page.Read("082b");
                    Page.Enter();
                    Page.Read("083a");
                    Page.Enter();
                    Page.Read("083bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "NARROW":
                    Page.Read("074a");
                    Page.Enter();
                    Page.Read("074bS");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "TELEPHONE")
                        {
                            goto case "TELEPHONE";
                        }
                        else if (userValue == "CAR")
                        {
                            goto case "CAR";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "TELEPHONE":
                    Page.Read("054R");
                    

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "CAR":
                    Page.Read("030");
                    Page.Enter();
                    Page.Read("005");
                    Page.Enter();
                    Page.Read("031S");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RAID")
                        {
                            goto case "RAID2";
                        }
                        else if (userValue == "VILLA")
                        {
                            goto case "VILLA";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "RAID2":
                    Page.Read("080a");
                    Page.Enter();
                    Page.Read("080b");
                    Page.Enter();
                    Page.Read("081S");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "KEEP FLYING")
                        {
                            goto case "KEEP FLYING";
                        }
                        else if (userValue == "LAND")
                        {
                            goto case "LAND";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "KEEP FLYING":
                    Page.Read("092R");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "LAND":
                    Page.Read("045");
                    Page.Enter();
                    Page.Read("046a");
                    Page.Enter();
                    Page.Read("046b");
                    Page.Enter();
                    Page.Read("085S");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "STAY")
                        {
                            goto case "STAY3";
                        }
                        else if (userValue == "ACROSS THE DESERT")
                        {
                            goto case "ACROSS THE DESERT";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "STAY3":
                    Page.Read("101a");
                    Page.Enter();
                    Page.Read("101bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "ACROSS THE DESERT":
                    Page.Read("093");
                    Page.Enter();
                    Page.Read("072");
                    Page.Enter();
                    Page.Read("055a");
                    Page.Enter();
                    Page.Read("055bS");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "INVESTIGATE")
                        {
                            goto case "INVESTIGATE";
                        }
                        else if (userValue == "SLIP AWAY")
                        {
                            goto case "SLIP AWAY";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "INVESTIGATE":
                    Page.Read("038a");
                    Page.Enter();
                    Page.Read("038bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "SLIP AWAY":
                    Page.Read("058");
                    Page.Enter();
                    Page.Read("099a");
                    Page.Enter();
                    Page.Read("099bR");

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

                case "VILLA":
                    Page.Read("078");
                    Page.Enter();
                    Page.Read("020R");                   

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "RESTART")
                        {
                            goto case "TITLE";
                        }
                        else if (userValue == "QUIT")
                        {
                            break;
                        }
                        else
                        {
                            Page.Error("restart");
                        }
                    }

                    break;

            }*/

        }    
    
    }
   
}