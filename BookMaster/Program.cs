using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MainConsoleMasterManager Menu
            bool keepRunning = true;
            do
            {
                Console.WriteLine(" | C: Categories | B: Books | Q: Quit ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.C:
                        BookManager.InitCategoryMenu();
                        break;
                    case ConsoleKey.B:
                        BookManager.InitBookMenu();
                        break;
                    case ConsoleKey.Q:
                        keepRunning = false;
                        break;
                }
            } while (keepRunning);
            #endregion

        }
    }
}
