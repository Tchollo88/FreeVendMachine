using System;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace FreeVendMachine
{
    public class Program
    {
        #region ** Memory Variables **
        public static bool MoneyInserted = false;
        private static int _despenceCycle = 0;

        #region ** Inventroy Stock **
        private static int _nutritionbar;
        private static int _ration;
        private static int _bandage;
        private static int _canteen;
        private static int _painkiller;
        private static int _syringe;
        private static int _water;
        private static int _alcohol;
        #endregion

        #endregion

        #region ** Engine Methods **
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            MenuIntro();
            ConsoleKeyInfo key = Console.ReadKey();
            selectEngine(key);
        }

        public static void selectEngine(ConsoleKeyInfo key)
        {
            int inventoryCount;
            string[] item = 
            { 
                "nutrition bar", 
                "rations", 
                "bandages", 
                "canteen", 
                "pain killer", 
                "syringe", 
                "water", 
                "alcohol" 
            };
            inventoryCount = _nutritionbar;

            Console.Clear();
            if (!MoneyInserted) 
            {
                if (key.Key != ConsoleKey.D9 && 
                    key.Key != ConsoleKey.NumPad9)
                {
                    MoneyError();
                    Menu();
                }
                
            }
            else if (MoneyInserted)
            {
                if (key.Key != null)
                {
                    if (key.Key != ConsoleKey.D9 &&
                        key.Key != ConsoleKey.NumPad9)
                    {
                        Console.WriteLine("Thank you for your selection,\n");
                    }
                }
            }
            

            for (int i = 0; i < item.Length; i++)
            {
                string v = item[i];
                if (key.Key == ConsoleKey.D9 || key.Key == ConsoleKey.NumPad9)
                {
                    Console.WriteLine($"$100 has been inserted");
                    Console.WriteLine($"Please make your selection: \n");
                    MoneyInserted = true;
                    Menu();
                }
                else if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    string product = "NutritionBar";
                    int keypress = 0;

                    if (_despenceCycle == 0)
                    {
                        InitialStart();
                        VendSelection(item, keypress);
                        _nutritionbar--;
                        stockAssessment(product, 2);
                        VendCycle();
                        LogTransaction(v);
                        Menu();
                    }
                    else
                    {
                        stockAssessment(product, 2);

                        if (inventoryCount > 0)
                        {
                            VendSelection(item, keypress);
                            _nutritionbar--;
                            VendCycle();
                            LogTransaction(v);
                            Menu();
                        }
                        else
                        {
                            EmptyStock();
                            Menu();
                        }
                    }
                }
                else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    string product = "Ration";
                    int keypress = 1;

                    if (_despenceCycle == 0)
                    {
                        InitialStart();
                        VendSelection(item, keypress);
                        _ration--;
                        stockAssessment(product, 5);
                        VendCycle();
                        LogTransaction(v);
                        Menu();
                    }
                    else
                    {
                        stockAssessment(product, 5);

                        if (inventoryCount > 0)
                        {
                            VendSelection(item, keypress);
                            _ration--;
                            VendCycle();
                            LogTransaction(v);
                            Menu();
                        }
                        else
                        {
                            EmptyStock();
                            Menu();
                        }
                    }
                }
                else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                {
                    string product = "Bandage";
                    int keypress = 2;

                    if (_despenceCycle == 0)
                    {
                        InitialStart();
                        VendSelection(item, keypress);
                        _bandage--;
                        stockAssessment(product, 8);
                        VendCycle();
                        LogTransaction(v);
                        Menu();
                    }
                    else
                    {
                        stockAssessment(product, 8);

                        if (inventoryCount > 0)
                        {
                            VendSelection(item, keypress);
                            _bandage--;
                            VendCycle();
                            LogTransaction(v);
                            Menu();
                        }
                        else
                        {
                            EmptyStock();
                            Menu();
                        }
                    }
                }
                else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
                {
                    string product = "Canteen";
                    int keypress = 3;

                    if (_despenceCycle == 0)
                    {
                        InitialStart();
                        VendSelection(item, keypress);
                        _canteen--;
                        stockAssessment(product, 11);
                        VendCycle();
                        LogTransaction(v);
                        Menu();
                    }
                    else
                    {
                        stockAssessment(product, 11);

                        if (inventoryCount > 0)
                        {
                            VendSelection(item, keypress);
                            _canteen--;
                            VendCycle();
                            LogTransaction(v);
                            Menu();
                        }
                        else
                        {
                            EmptyStock();
                            Menu();
                        }
                    }
                }
                else if (key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5)
                {
                    string product = "PainKiller";
                    int keypress = 4;

                    if (_despenceCycle == 0)
                    {
                        InitialStart();
                        VendSelection(item, keypress);
                        _painkiller--;
                        stockAssessment(product, 14);
                        VendCycle();
                        LogTransaction(v);
                        Menu();
                    }
                    else
                    {
                        stockAssessment(product, 14);

                        if (inventoryCount > 0)
                        {
                            VendSelection(item, keypress);
                            _painkiller--;
                            VendCycle();
                            LogTransaction(v);
                            Menu();
                        }
                        else
                        {
                            EmptyStock();
                            Menu();
                        }
                    }
                }
                else if (key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.NumPad6)
                {
                    string product = "Syringe";
                    int keypress = 5;

                    if (_despenceCycle == 0)
                    {
                        InitialStart();
                        VendSelection(item, keypress);
                        _syringe--;
                        stockAssessment(product, 17);
                        VendCycle();
                        LogTransaction(v);
                        Menu();
                    }
                    else
                    {
                        stockAssessment(product, 17);

                        if (inventoryCount > 0)
                        {
                            VendSelection(item, keypress);
                            _syringe--;
                            VendCycle();
                            LogTransaction(v);
                            Menu();
                        }
                        else
                        {
                            EmptyStock();
                            Menu();
                        }
                    }
                }
                else if (key.Key == ConsoleKey.D7 || key.Key == ConsoleKey.NumPad7)
                {
                    string product = "Water";
                    int keypress = 6;

                    if (_despenceCycle == 0)
                    {
                        InitialStart();
                        VendSelection(item, keypress);
                        _water--;
                        stockAssessment(product, 20);
                        VendCycle();
                        LogTransaction(v);
                        Menu();
                    }
                    else
                    {
                        stockAssessment(product, 20);

                        if (inventoryCount > 0)
                        {
                            VendSelection(item, keypress);
                            _water--;
                            VendCycle();
                            LogTransaction(v);
                            Menu();
                        }
                        else
                        {
                            EmptyStock();
                            Menu();
                        }
                    }
                }
                else if (key.Key == ConsoleKey.D8 || key.Key == ConsoleKey.NumPad8)
                {
                    string product = "Alcohol";
                    int keypress = 7;

                    if (_despenceCycle == 0)
                    {
                        InitialStart();
                        VendSelection(item, keypress);
                        _alcohol--;
                        stockAssessment(product, 23);
                        VendCycle();
                        LogTransaction(v);
                        Menu();
                    }
                    else
                    {
                        stockAssessment(product, 23);

                        if (inventoryCount > 0)
                        {
                            VendSelection(item, keypress);
                            _alcohol--;
                            VendCycle();
                            LogTransaction(v);
                            Menu();
                        }
                        else
                        {
                            EmptyStock();
                            Menu();
                        }
                    }
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

        }
        #endregion

        #region ** Messages **
        public static void MenuIntro()
        {
            Console.WriteLine("Welcome to NoLongerFreeAll, these are the currently available products:");
            Console.WriteLine(
                "(1) NutritionBar $1.00\n" +
                "(2) Rations\t $1.00\n" +
                "(3) Bandages\t $1.00\n" +
                "(4) Canteen\t $1.00\n" +
                "(5) Pain Killer\t $1.00\n" +
                "(6) Syringe\t $1.00\n" +
                "(7) Water\t $1.00\n" +
                "(8) Alcohol\t $1.00\n"+
                "(9) Insert $100.00\n");
            
            Console.WriteLine("Please select your desired item.\n");
        }

        public static void VendSelection(string[] item, int i)
        {
            Console.WriteLine($"*Pulls a {item[i]} off shelf placement, and drops it into the dispensary.*");
            Console.WriteLine($"Please enjoy your {item[i]} and $99.00 has been dispensed as change! \n");
        }

        public static void EmptyStock()
        {
            Console.WriteLine("Unfortunately, we are currently out of stock. Please come back after we renew and try again!\n");
        }

        public static void MoneyError()
        {
            Console.WriteLine("Please insert $100.00 to make a selection.\n");
        }
        #endregion

        #region **Text File Methods**
        public static void stockAssessment(string product, int targetline)
        {
            string filePath = "Inventory.txt";

            // Define product names and their corresponding stock line numbers
            Dictionary<string, int> productLines = new Dictionary<string, int>
            {
                { "NutritionBar", 2 },
                { "Rations", 5 },
                { "Bandages", 8 },
                { "Canteen", 11 },
                { "Pain Killer", 14 },
                { "Syringe", 17 },
                { "Water", 20 },
                { "Alcohol", 23 }
            };

            // Check if the product exists in the dictionary
            if (productLines.TryGetValue(product, out int targetLine))
            {

                int lineToModify = targetLine;
                List<string> lines = File.ReadAllLines(filePath).ToList();

                // Ensure the line exists in the file
                if (lineToModify - 1 < lines.Count &&
                    int.TryParse(lines[lineToModify - 1],
                    out int stock))
                {
                    stock = stock - 1;

                    if (stock >= 0)
                    {
                        lines[lineToModify - 1] = stock.ToString();
                        File.WriteAllLines(filePath, lines);
                    }
                    else
                    {
                        Console.WriteLine($"Product '{product}' out of stock.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid line number or non-numeric value in file.");
                }
            }
        }

        public static void LogTransaction(string item)
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
            string logEntry = $"{DateTime.Now}| {item} dispensed| Cost: $1.00| Return: $99.00";

            try
            {
                Console.WriteLine($"[DEBUG] Attempting to write log entry: {logEntry}");
                Console.WriteLine($"[DEBUG] Log file path: {logPath}");

                File.AppendAllText(logPath, logEntry + Environment.NewLine);

                Console.WriteLine($"[DEBUG] Successfully logged transaction.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to write log file: {ex.Message}\n");
            }
        }
        #endregion

        #region ** DataPoint Methods **
        public static void InitialStart()
        {
            _nutritionbar = 15;
            _ration = 15;
            _bandage = 12;
            _canteen = 7;
            _painkiller = 25;
            _syringe = 10;
            _water = 10;
            _alcohol = 7;
        }
        public static void VendCycle()
        {
            _despenceCycle++;
        }
        #endregion
    }
}
