using System;
using ConsoleTools;
using BookMaster.BooksLibrary;


namespace BookMaster.Startup
{
    class NugetMenu
    {
       
        public static void InitMenu()
       
             {
                var generesMainmenu = new ConsoleMenu()
                  .Add("Add", () => ManageGeneres.Add())
                  .Add("Edit", () => ManageGeneres.Edit())
                  .Add("Delete", () => ManageGeneres.Delete())
                  .Add("List", () => ManageGeneres.List())
                  .Add("Close Generes", ConsoleMenu.Close)
                  .Add("Exit App", () => Environment.Exit(0))
                    .Configure(config => { config.SelectedItemBackgroundColor = ConsoleColor.Blue; config.SelectedItemForegroundColor = ConsoleColor.Green; } ); ;

                var titlesMainmenu = new ConsoleMenu()
                  .Add("Add", () => ManageTitles.Add())
                  .Add("Edit", () => ManageTitles.Edit())
                  .Add("Delete", () => ManageTitles.Delete())
                  .Add("List", () => ManageTitles.List())
                  .Add("Close Titles", ConsoleMenu.Close)
                  .Add("Exit App", () => Environment.Exit(0))
                  .Configure(config => { config.Selector = "--> "; config.SelectedItemBackgroundColor = ConsoleColor.Blue; config.SelectedItemForegroundColor = ConsoleColor.Green; });

                var BookManagerMainmenu = new ConsoleMenu()
                  .Add("Generes", () => generesMainmenu.Show())
                  .Add("Titles", () => titlesMainmenu.Show())
                  .Add("Close Bookmanager", ConsoleMenu.Close)
                  .Add("Exit App", () => Environment.Exit(0))
                  .Configure(config => { config.Selector = "--> "; config.SelectedItemBackgroundColor = ConsoleColor.Blue; config.SelectedItemForegroundColor = ConsoleColor.Green; });

                var menu = new ConsoleMenu()
                  .Add("Bookmanager", () => BookManagerMainmenu.Show())  
                  .Add("Exit", () => Environment.Exit(0))
                  .Configure(config => { config.Selector = "--> "; config.SelectedItemBackgroundColor = ConsoleColor.Blue; config.SelectedItemForegroundColor = ConsoleColor.Green; });

                menu.Show();
            }
        private static void SomeAction(string value)
        {
            Console.WriteLine(value);
          
            Console.ReadKey();
        }
    }
}
