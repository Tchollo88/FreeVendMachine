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
            string[] item = { "nutrition bar", "rations", "bangages", "canteen" };

            Console.Clear();
            Console.WriteLine("Thank you for your selection,");

            if (key.Key == ConsoleKey.D1)
            {
                Console.WriteLine("*Pulls a " + item[0] + " off shelf placement, and drops it to the despensory.*");
                Console.WriteLine("Please enjoy your " + item[0] + " and select again: \n");

                Menu();
            }
            else if (key.Key == ConsoleKey.D2)
            {
                Console.WriteLine("*Pulls a " + item[1] + " off shelf placement, and drops it to the despensory.*");
                Console.WriteLine("Please enjoy your " + item[1] + " and select again: \n");

                Menu();
            }
            else if (key.Key == ConsoleKey.D3)
            {
                Console.WriteLine("*Pulls a " + item[2] + " off shelf placement, and drops it to the despensory.*");
                Console.WriteLine("Please enjoy your " + item[2] + " and select again: \n");

                Menu();
            }
            else if (key.Key == ConsoleKey.D4)
            {
                Console.WriteLine("*Pulls a " + item[3] + " off shelf placement, and drops it to the despensory.*");
                Console.WriteLine("Please enjoy your " + item[3] + " and select again: \n");

                Menu();
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
