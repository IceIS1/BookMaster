using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTools;
using BookMaster.Startup; 

namespace BookMaster
{
    public class Program
    {
        static void Main(string[] args)
        {
            NugetMenu.InitMenu();
        }
        //{
        //    var subMenu = new ConsoleMenu()
        //      .Add("Sub_One", () => SomeAction("Sub_One"))
        //      .Add("Sub_Two", () => SomeAction("Sub_Two"))
        //      .Add("Sub_Three", () => SomeAction("Sub_Three"))
        //      .Add("Sub_Four", () => SomeAction("Sub_Four"))
        //      .Add("Sub_Close", ConsoleMenu.Close)
        //      .Add("Sub_Exit", () => Environment.Exit(0));

        //    var menu = new ConsoleMenu()
        //      .Add("One", () => SomeAction("One"))
        //      .Add("Two", () => SomeAction("Two"))
        //      .Add("Three", () => SomeAction("Three"))
        //      .Add("Four", subMenu.Show)
        //      .Add("Close", ConsoleMenu.Close)
        //      .Add("Exit", () => Environment.Exit(0))
        //      .Configure(config => { config.Selector = "--> "; config.EnableFilter = true; });

        //    menu.Show();
        //}

        //private static void SomeAction(string text)
        //{
        //    Console.WriteLine(text);
        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //}
    }
}













/*
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
*/
