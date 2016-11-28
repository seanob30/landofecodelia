using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Land_of_Ecodelia
{
    class Program
    {
        static void Main(string[] args)
        {
            LandOfEcodelia ecodelia = new LandOfEcodelia();
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WindowWidth = 50;
                ecodelia.BootScreen();
                ecodelia.ListScreen();
                ecodelia.LoadScreen();
                ecodelia.RunScreen();
                ecodelia.StartScreen();
                ecodelia.EnterGame();

                if(Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    keepRunning = false;
                }
            }
        }
    }
}
