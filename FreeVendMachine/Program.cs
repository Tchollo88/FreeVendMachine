using System;
using System.Security.Cryptography.X509Certificates;

namespace FreeVendMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void BootUpLogo()
        {

        }

        public static void MenuIntro()
        {
            Console.WriteLine("Welcome to FreeAll, these are the currenly available products:");
            Console.WriteLine("(1)Nutrition Bar  (2)Rations  (3)Bandages  (4)Canteen");
            Console.WriteLine("Please select your desired item.");
        }

        public static void SelectEngine(ConsoleKeyInfo key)
        {
            string item1 = "nutrition bar";
            string item2 = "rations";
            string item3 = "bangages";
            string item4 = "canteen";

            if (key.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Thank you for your selection,");
                Console.WriteLine("*Pulls a " + item1 + " off shelf placement, and drops it to the despensory.*");
                Console.WriteLine("Please enjoy your " + item1 + " .");
            }
            else if (key.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Thank you for your selection,");
                Console.WriteLine("*Pulls a " + item2 + " off shelf placement, and drops it to the despensory.*");
                Console.WriteLine("Please enjoy your " + item2 + " .");
            }
            else if (key.Key == ConsoleKey.D3)
            {
                Console.WriteLine("Thank you for your selection,");
                Console.WriteLine("*Pulls a " + item3 + " off shelf placement, and drops it to the despensory.*");
                Console.WriteLine("Please enjoy your " + item3 + " .");
            }
            else if (key.Key == ConsoleKey.D4)
            {
                Console.WriteLine("Thank you for your selection,");
                Console.WriteLine("*Pulls a " + item4 + " off shelf placement, and drops it to the despensory.*");
                Console.WriteLine("Please enjoy your " + item4 + " .");
            }
        }

        public static void Menu()
        {
            MenuIntro();
            ConsoleKeyInfo key = Console.ReadKey();
            SelectEngine(key);
        }
    }
}
