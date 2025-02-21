using System;
using System.IO;
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
        public static bool MoneyInserted = false;
        public static void MenuIntro()
        {
            Console.WriteLine("Welcome to NoLongerFreeAll, these are the currently available products:");
            Console.WriteLine(
                "(1) NutritionBar\t $1.00\n" +
                "(2) Rations\t $1.00\n" +
                "(3) Bandages\t $1.00\n" +
                "(4) Canteen\t $1.00\n" +
                "(5) Pain Killer\t $1.00\n" +
                "(6) Syringe\t $1.00\n" +
                "(7) Water\t $1.00\n" +
                "(8) Alcohol\t $1.00\n"+
                "(9) Insert $100.00");
            
            Console.WriteLine("Please select your desired item.");
        }

        public static void SelectEngine(ConsoleKeyInfo key)
        {
            string[] item = { "nutrition bar", "rations", "bandages", "canteen", "pain killer", "syringe", "water", "alcohol" };

            Console.Clear();
            Console.WriteLine("Thank you for your selection,");
            if (key.Key == ConsoleKey.D9 || key.Key == ConsoleKey.NumPad9)
            {
                    Console.WriteLine($"$100 has been inserted");
                    Console.WriteLine($"Please make your selection: \n");
                MoneyInserted = true;
                Menu();
            }
            

            else
            {
                if (MoneyInserted == false)
                {
                    Console.WriteLine("Please insert $100.00 to make a selection.");
                    Menu();
                }
            }

            if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine($"*Pulls a {item[0]} off shelf placement, and drops it into the dispensary.*");
                Console.WriteLine($"Please enjoy your {item[0]} and $99.00 has been dispensed as change! \n");
                LogTransaction(item[0]);
                Menu();
            }
            else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine($"*Pulls a {item[1]} off shelf placement, and drops it into the dispensary.*");
                Console.WriteLine($"Please enjoy your {item[1]} and $99.00 has been dispensed as change! \n");
                LogTransaction(item[1]);
                Menu();
            }
            else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
            {
                Console.WriteLine($"*Pulls a {item[2]} off shelf placement, and drops it into the dispensary.*");
                Console.WriteLine($"Please enjoy your {item[2]} and $99.00 has been dispensed as change! \n");
                LogTransaction(item[2]);
                Menu();
            }
            else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
            {
                Console.WriteLine($"*Pulls a {item[3]} off shelf placement, and drops it into the dispensary.*");
                Console.WriteLine($"Please enjoy your {item[3]} and $99.00 has been dispensed as change! \n");
                LogTransaction(item[3]);
                Menu();
            }
            else if (key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5)
            {
                Console.WriteLine($"*Pulls a {item[4]} off shelf placement, and drops it into the dispensary.*");
                Console.WriteLine($"Please enjoy your {item[4]} and $99.00 has been dispensed as change! \n");
                LogTransaction(item[4]);
                Menu();
            }
            else if (key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.NumPad6)
            {
                Console.WriteLine($"*Pulls a {item[5]} off shelf placement, and drops it into the dispensary.*");
                Console.WriteLine($"Please enjoy your {item[5]} and $99.00 has been dispensed as change! \n");
                LogTransaction(item[5]);
                Menu();
            }
            else if (key.Key == ConsoleKey.D7 || key.Key == ConsoleKey.NumPad7)
            {
                Console.WriteLine($"*Pulls a {item[6]} off shelf placement, and drops it into the dispensary.*");
                Console.WriteLine($"Please enjoy your {item[6]} and $99.00 has been dispensed as change! \n");
                LogTransaction(item[6]);
                Menu();
            }
            else if (key.Key == ConsoleKey.D8 || key.Key == ConsoleKey.NumPad8)
            {
                Console.WriteLine($"*Pulls a {item[7]} off shelf placement, and drops it into the dispensary.*");
                Console.WriteLine($"Please enjoy your {item[7]} and $99.00 has been dispensed as change! \n");
                LogTransaction(item[7]);
                Menu();
            }
            
            else if (key.Key == ConsoleKey.D0 || key.Key == ConsoleKey.NumPad0)
            {
                Console.WriteLine("Too rich for your blood now eh? Well, have a great day!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nInvalid selection. Please press a number between 1 and 9.");
                Menu();
            }
        }

        public static void LogTransaction(string item)
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
            string logEntry = $"{DateTime.Now}: {item} dispensed";

            try
            {
                Console.WriteLine($"[DEBUG] Attempting to write log entry: {logEntry}");
                Console.WriteLine($"[DEBUG] Log file path: {logPath}");

                File.AppendAllText(logPath, logEntry + Environment.NewLine);

                Console.WriteLine($"[DEBUG] Successfully logged transaction.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to write log file: {ex.Message}");
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
