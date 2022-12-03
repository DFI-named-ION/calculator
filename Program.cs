using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            MenuManager menuManager = new MenuManager();
            CalcManager calcManager = new CalcManager();
            DialogManager dialogManager = new DialogManager();

            do
            {
                Console.WriteLine();
                menuManager.Display();

                switch (menuManager.GetChoice())
                {
                    case 1:
                        dialogManager.AddDialog();
                        break;
                    case 2:
                        dialogManager.SubDialog();
                        break;
                    case 3:
                        dialogManager.MulDialog();
                        break;
                    case 4:
                        dialogManager.DivDialog();
                        break;
                }
            } while (menuManager.AllowContinue());
        }
    }
}