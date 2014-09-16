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

            errorMessages[0] = "Type RESTART to restart or just press ENTER to quit.";
            errorMessages[1] = "I didn't understand that entry. Try typing it in again.";
            Console.WriteLine(errorMessages[errorNumber]);
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
                            Page.Error("firstError");
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
                            Page.Error("firstError");
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
                            Page.Error("firstError");
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
                            Page.Error("firstError");
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
                            Page.Error("firstError");
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
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "CHANCE":
                    current = new Page("108");
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
                            Page.Error("restart");
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
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "PILLOW":

                    current = new Page("029");
                    Page.read(current.Number);

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

                    current = new Page("088");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("094");
                    Page.read(current.Number);

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

                    current = new Page("067");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "TRAP":

                    current = new Page("109");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "GO HOME":

                    current = new Page("089");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "STAY":

                    current = new Page("007");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("062");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("040");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("070");
                    Page.read(current.Number);

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

                    current = new Page("024");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("021");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "INSIST")
                        {
                            goto case "INSIST";
                        }
                        else if (userValue == "STAY BEHIND")
                        {
                            goto case "STAY BEHIND";
                        }
                        else
                        {
                            Page.Error("firstError");
                        }
                    }

                    break;

                case "AGREE2":

                    current = new Page("090");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "INSIST":

                    current = new Page("097");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("018");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("019");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("050");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("051");
                    Page.read(current.Number);

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

                case "STAY BEHIND":

                    current = new Page("049");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("010");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("063");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("066");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "STAY2":

                    current = new Page("076");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("077");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "LEAVE":

                    current = new Page("039");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("056");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "NO":

                    current = new Page("113");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "TIME":

                    current = new Page("011");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("075");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "ESCAPE2":

                    current = new Page("111");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("112");
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
                            Page.Error("restart");
                        }
                    }

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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "CONTINUE":

                    current = new Page("114");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("116");
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
                            Page.Error("restart");
                        }
                    }

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
                            Page.Error("firstError");
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
                            Page.Error("restart");
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
                            Page.Error("firstError");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "TOO FAR OUT":
                    current = new Page("082");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("083");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "NARROW":
                    current = new Page("074");
                    Page.read(current.Number);

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

                    current = new Page("054");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "CAR":

                    current = new Page("030");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("005");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("031");
                    Page.read(current.Number);

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

                    current = new Page("080");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("081");
                    Page.read(current.Number);

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
                    current = new Page("092");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "LAND":

                    current = new Page("045");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("046");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("085");
                    Page.read(current.Number);

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

                    current = new Page("101");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "ACROSS THE DESERT":

                    current = new Page("093");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("072");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("055");
                    Page.read(current.Number);

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

                    current = new Page("038");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "SLIP AWAY":

                    current = new Page("058");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("099");
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
                            Page.Error("restart");
                        }
                    }

                    break;

                case "VILLA":

                    current = new Page("078");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("020");
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
                            Page.Error("restart");
                        }
                    }

                    break;

            }

        }    
    
    }
   
}