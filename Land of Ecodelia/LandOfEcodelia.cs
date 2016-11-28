using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land_of_Ecodelia
{
    class LandOfEcodelia
    {

        public void BootScreen()
        {
            Console.WriteLine("    **** COMMODORE 64 BASIC V2 ****");
            Console.WriteLine(" 64 RAM SYSTEM  38911 BASIC BYTES FREE");
            Console.WriteLine("READY.");
            Console.WriteLine();
            string ready = Console.ReadLine().ToUpper();

            if (ready == "LOAD \"$\",8")
            {
                Console.WriteLine("SEARCHING FOR $");
                TakeTwoSecondBreak();
                Console.WriteLine("LOADING");
                TakeTwoSecondBreak();
                Console.WriteLine("READY.");
            }

            else 
            {
                Console.WriteLine("?SYNTAX ERROR");
                BootScreen();
            }
        }

        public void ListScreen()
        {
            string list = Console.ReadLine().ToUpper();

            if (list == "LIST")
            {
                Console.WriteLine("0  \"ANGELA MOSS\" 13 2A");
                TakeShortBreak();
                Console.WriteLine("102  \"PINK SHIRT BOOK\"  PRG");
                TakeShortBreak();
                Console.WriteLine("0    \"----------------\" DEL");
                TakeShortBreak();
                Console.WriteLine("183  \"LAND OF ECODELIA\" DEL");
                TakeShortBreak();
                Console.WriteLine("0    \"----------------\" DEL");
                TakeShortBreak();
                Console.WriteLine("66   \"UGLY RED BOOK\"    PRG");
                TakeShortBreak();
                Console.WriteLine("0    \"----------------\" DEL");
                TakeShortBreak();
                Console.WriteLine("1    \"BLUE BOOK\"        PRG");
                TakeShortBreak();
                Console.WriteLine("15   \"GREEN BOOK\"       PRG");
                TakeShortBreak();
                Console.WriteLine("97   \"MANIAC MANSION\"   PRG");
                TakeShortBreak();
                Console.WriteLine("0    \"----------------\" DEL");
                TakeShortBreak();
                Console.WriteLine("178  \"PITFALL\"          PRG");
                TakeShortBreak();
                Console.WriteLine("0    \"----------------\" DEL");
                TakeShortBreak();
                Console.WriteLine("19   \"TAN BOOK\"         PRG");
                TakeShortBreak();
                Console.WriteLine("3 BLOCKS FREE.");
                TakeShortBreak();
                Console.WriteLine("READY.");
            }

            else
            {
                Console.WriteLine("?SYNTAX ERROR");
                TakeTwoSecondBreak();
                Console.WriteLine("READY.");
                ListScreen();
            }
        }

        public void LoadScreen()
        {
            string load = Console.ReadLine().ToUpper();

            if (load == "LOAD \"LAND OF ECODELIA\",8")
            {
                Console.WriteLine("LOAD \"LAND OF ECODELIA\",8");
                Console.WriteLine();
                TakeTwoSecondBreak();
                Console.WriteLine("SEARCHING FOR LAND OF ECODELIA");
                TakeTwoSecondBreak();
                Console.WriteLine("LOADING");
                TakeTwoSecondBreak();
                Console.WriteLine("READY");
            }

            else
            {
                Console.WriteLine("?SYNTAX ERROR");
                TakeTwoSecondBreak();
                Console.WriteLine("READY.");
                LoadScreen();
            }
        }

        public void RunScreen()
        {
            string run = Console.ReadLine().ToUpper();

            if (run =="RUN")
            {
                Console.Clear();
            }

            else
            {
                Console.WriteLine("?SYNTAX ERROR");
                TakeTwoSecondBreak();
                Console.WriteLine("READY.");
                RunScreen();
            }
        }

        public void StartScreen()
        {
            Console.WriteLine("     LAND  OF  ECODELIA");
            Console.WriteLine("         **********    ");
            Console.WriteLine("        ************   ");
            Console.WriteLine("       **************  ");
            Console.WriteLine("      **************** ");
            Console.WriteLine("     ******************");
            Console.WriteLine("   PRESS ANY KEY TO START");
            Console.WriteLine("    (c)  1984 COMMODORE");
            Console.ReadKey();
            Console.Clear();
        }

        public void EnterGame()
        {
            Console.WriteLine("     ARE YOU A GIRAFFE OR A SEAGULL?");
            Console.Write(">");

            string one = Console.ReadLine().ToUpper();

            switch (one)
            {
                case "GIRAFFE":
                    Console.Clear();
                    AskQuestionTwoAlpha();
                    break;
                case "SEAGULL":
                    Console.Clear();
                    AskQuestionTwoBeta();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    EnterGame();
                    break;
            }


        }

        public void AskQuestionTwoAlpha()
        {
            Console.WriteLine("     ARE YOU PROUD OR ASHAMED?");
            Console.Write(">");

            string two = Console.ReadLine().ToUpper();

            switch (two)
            {
                case "PROUD":
                    Console.Clear();
                    AskQuestionThree();
                    break;
                case "ASHAMED":
                    Console.Clear();
                    AskQuestionThree();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionTwoAlpha();
                    break;
            }


        }

        public void AskQuestionTwoBeta()
        {
            Console.WriteLine("     HOW MANY LIES HAVE YOU TOLD TODAY?");
            Console.Write(">");

            string two = Console.ReadLine().ToUpper();
            int convertedTwo = Int32.Parse(two);

            if (convertedTwo < 10)
                    { 
                    Console.Clear();
                    AskQuestionThree();
                    }

               else if (convertedTwo >= 10)
                    { 
                    Console.Clear();
                    AskQuestionThree();
                    }
               else
                    { 
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionTwoBeta();
            }


        }

        public void AskQuestionThree()
        {
            Console.WriteLine("     WHERE DO WE GO WHEN WE DIE?");
            Console.Write(">");

            string three = Console.ReadLine().ToUpper();

            switch (three)
            {
                case "HEAVEN":
                    Console.Clear();
                    AskQuestionFourAlpha();
                    break;
                case "NOWHERE":
                    Console.Clear();
                    AskQuestionFourBeta();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionThree();
                    break;
            }


        }

        public void AskQuestionFourAlpha()
        {
            Console.WriteLine("     VEGETABLE, ANIMAL, OR MINERAL?");
            Console.Write(">");

            string four = Console.ReadLine().ToUpper();

            switch (four)
            {
                case "VEGETABLE":
                    Console.Clear();
                    AskQuestionFive();
                    break;
                case "ANIMAL":
                    Console.Clear();
                    AskQuestionFive();
                    break;
                case "MINERAL":
                    Console.Clear();
                    AskQuestionFive();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionFourAlpha();
                    break;
            }


        }

        public void AskQuestionFourBeta()
        {
            Console.WriteLine("     WHAT ARE YOU MADE OF?");
            Console.Write(">");

            string four = Console.ReadLine().ToUpper();

            switch (four)
            {
                case "ATOMS":
                    Console.Clear();
                    AskQuestionFive();
                    break;
                case "PIXELS":
                    Console.Clear();
                    AskQuestionFive();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionFourBeta();
                    break;
            }


        }

        public void AskQuestionFive()
        {
            Console.WriteLine("     ARE THE PETALS IN THE BASKET?");
            Console.Write(">");

            string five = Console.ReadLine().ToUpper();

            switch (five)
            {
                case "YES":
                    Console.Clear();
                    AskQuestionSixAlpha();
                    break;
                case "NO":
                    Console.Clear();
                    AskQuestionSixBeta();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionFive();
                    break;
            }


        }

        public void AskQuestionSixAlpha()
        {
            Console.WriteLine("     WHERE IS GOD?");
            Console.Write(">");

            string six = Console.ReadLine().ToUpper();

            switch (six)
            {
                case "HEAVEN":
                    Console.Clear();
                    AskQuestionSeven();
                    break;
                case "NOWHERE":
                    Console.Clear();
                    AskQuestionSeven();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionSixAlpha();
                    break;
            }


        }

        public void AskQuestionSixBeta()
        {
            Console.WriteLine("     DO YOU BELIEVE IN ALETERNATE UNIVERSES?");
            Console.Write(">");

            string six = Console.ReadLine().ToUpper();

            switch (six)
            {
                case "YES":
                    Console.Clear();
                    AskQuestionSeven();
                    break;
                case "NO":
                    Console.Clear();
                    AskQuestionSeven();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionSixBeta();
                    break;
            }
        }

            public void AskQuestionSeven()
        {
            Console.WriteLine("     IS THERE ENOUGH TIME?");
            Console.Write(">");

            string seven = Console.ReadLine().ToUpper();

            switch (seven)
            {
                case "YES":
                    Console.Clear();
                    AskQuestionEight();
                    break;
                case "NO":
                    Console.Clear();
                    AskQuestionEight();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionSeven();
                    break;
            }


        }

        public void AskQuestionEight()
        {
            Console.WriteLine("     ARE YOU RED OR PURPLE?");
            Console.Write(">");

            string eight = Console.ReadLine().ToUpper();

            switch (eight)
            {
                case "RED":
                    Console.Clear();
                    AskQuestionNine();
                    break;
                case "PURPLE":
                    Console.Clear();
                    AskQuestionNine();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionEight();
                    break;
            }


        }

        public void AskQuestionNine()
        {
            Console.WriteLine("     IS THE KEY IN THE ROOM?");
            Console.Write(">");

            string nine = Console.ReadLine().ToUpper();

            switch (nine)
            {
                case "YES, THE KEY IS IN MY FIST. MY FIST IS IN MY POCKET.":
                    Console.Clear();
                    EndBootScreen();
                    break;
                default:
                    Console.WriteLine("?SYNTAX ERROR");
                    TakeTwoSecondBreak();
                    Console.Clear();
                    AskQuestionNine();
                    break;
            }


        }

        public void EndBootScreen()
        {
            Console.WriteLine("    **** COMMODORE 64 BASIC V2 ****");
            Console.WriteLine(" 64 RAM SYSTEM  38911 BASIC BYTES FREE");
            Console.WriteLine("READY.");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("     LAND  OF  ECODELIA");
            Console.WriteLine("         **********    ");
            Console.WriteLine("        ************   ");
            Console.WriteLine("       **************  ");
            Console.WriteLine("      **************** ");
            Console.WriteLine("     ******************");
            Console.WriteLine("   PRESS ANY KEY TO START");
            Console.WriteLine("    (c)  1984 COMMODORE");
            Console.ReadKey();
            Console.Clear();
            EnterGame();
        }

        public void TakeTwoSecondBreak()
        {
            System.Threading.Thread.Sleep(2000);
        }

        public void TakeShortBreak()
        {
            System.Threading.Thread.Sleep(150);
        }
    }
}
