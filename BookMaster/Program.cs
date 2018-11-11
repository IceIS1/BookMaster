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
                Console.Clear();
                Console.WriteLine(" | C: Categories | B: Books | Q: Quit ");
                  ConsoleKeyInfo key = Console.ReadKey();
                 
                  switch (key.Key)
                  {
                      case ConsoleKey.C:
                          BookManager.InitCategoryMenu();
                          break;
                      case ConsoleKey.B:
                        Console.Clear();
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
