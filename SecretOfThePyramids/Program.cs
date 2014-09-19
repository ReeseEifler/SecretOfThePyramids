﻿using System;
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

            errorMessages[0] = "Type RESTART or QUIT.";
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
            bool noErrorYet = true;

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

                    current = new Page("003S");
                    Page.read(current.Number);

                    while (clearToGo == false)
                    {
                        userValue = Page.Question();

                        if (userValue == "FOLLOW")
                        {
                            noErrorYet = true;
                            goto case "FOLLOW";
                        }
                        else if (userValue == "HOTEL")
                        {
                            noErrorYet = true;
                            goto case "HOTEL";
                        }
                        else
                        {
                            if (noErrorYet == true)
                            {
                                Console.Clear();
                                Page.read(current.Number);
                                Page.Error("firstError");
                                noErrorYet = false;

                            }
                            else
                            {
                                Console.Clear();
                                Page.read(current.Number);
                                Page.Error("firstError");
                            }
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

                    current = new Page("087a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("087bS");
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

                    current = new Page("004bS");
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

                    current = new Page("023a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("023bS");
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
                    current = new Page("073a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("073bS");
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
                    current = new Page("104a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("104b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("100a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("100bS");
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

                    current = new Page("069a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("069b");
                    Page.read(current.Number);
                    Page.Enter();
                    
                    current = new Page("027");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("068a");
                    Page.read(current.Number);
                     Page.Enter();

                    current = new Page("068bS");
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

                    current = new Page("044a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("044b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("033a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("033bS");
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

                    current = new Page("110a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("110bS");
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
                    current = new Page("108a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("108bR");
                    Page.read(current.Number);

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
                
                case "ORIGINAL":
                    current = new Page("036a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("036b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("042S");
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

                    current = new Page("029a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("029bS");
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

                    current = new Page("088a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("088b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("094a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("094bS");
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

                    current = new Page("067a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("067bR");
                    Page.read(current.Number);

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

                    current = new Page("109a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("109bR");
                    Page.read(current.Number);

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

                    current = new Page("089R");
                    Page.read(current.Number);

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

                    current = new Page("007");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("062");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("040");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("070a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("070bS");
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

                    current = new Page("021S");
                    Page.read(current.Number);

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

                    current = new Page("090a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("090bR");
                    Page.read(current.Number);

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

                    current = new Page("097a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("097b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("018");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("019");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("050a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("050b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("051S");
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

                case "STAY4":

                    current = new Page("049");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("010");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("063");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("066a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("066bR");
                    Page.read(current.Number);

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

                    current = new Page("076");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("077a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("077bR");
                    Page.read(current.Number);

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

                    current = new Page("039a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("039b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("056a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("056bR");
                    Page.read(current.Number);

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

                    current = new Page("113R");
                    Page.read(current.Number);

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

                    current = new Page("011a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("011b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("075a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("075bR");
                    Page.read(current.Number);

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

                    current = new Page("111");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("112R");
                    Page.read(current.Number);

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
                    current = new Page("084a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("084bR");
                    Page.read(current.Number);

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

                    current = new Page("114");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("116a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("116bR");
                    Page.read(current.Number);

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
                    current = new Page("016");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("008a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("008bS");
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

                    current = new Page("106a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("106bR");
                    Page.read(current.Number);

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

                    current = new Page("079bS");
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

                    current = new Page("028bR");
                    Page.read(current.Number);

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
                    current = new Page("082a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("082b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("083a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("083bR");
                    Page.read(current.Number);

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
                    current = new Page("074a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("074bS");
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

                    current = new Page("054R");
                    Page.read(current.Number);

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

                    current = new Page("030");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("005");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("031S");
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

                    current = new Page("080a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("080b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("081S");
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
                    current = new Page("092R");
                    Page.read(current.Number);

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

                    current = new Page("045");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("046a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("046b");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("085S");
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

                    current = new Page("101a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("101bR");
                    Page.read(current.Number);

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

                    current = new Page("093");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("072");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("055a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("055bS");
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

                    current = new Page("038a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("038bR");
                    Page.read(current.Number);

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

                    current = new Page("058");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("099a");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("099bR");
                    Page.read(current.Number);

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

                    current = new Page("078");
                    Page.read(current.Number);
                    Page.Enter();

                    current = new Page("020R");
                    Page.read(current.Number);

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

            }

        }    
    
    }
   
}