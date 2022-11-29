using System;

namespace Calculator
{
    class MenuManager
    {
        public void Display()
        {
            Console.WriteLine("\n\t =======================");
            Console.WriteLine("\n\t  Arithmetic calculator ");
            Console.WriteLine("\n\t =======================");
            Console.WriteLine("\n\t       1 - Adding       ");
            Console.WriteLine("\n\t       2 - Sub...       ");
            Console.WriteLine("\n\t       3 - Multiply     ");
            Console.WriteLine("\n\t       4 - Divivsion    ");
            Console.WriteLine("\n\t       0 - Exit         ");
            Console.WriteLine("\n\t =======================");
        }

        public int GetChoice()
        {
            Console.Write("\n> Enter number of operation: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public bool AllowContinue()
        {
            Console.Write("\n> Continue? (y/n): ");
            string allow = Console.ReadLine(); 
            return (allow == "y");
        }
    }
}