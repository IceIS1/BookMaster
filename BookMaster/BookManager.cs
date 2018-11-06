using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookMaster
{
   


    class BookManager
    {
       
 

        public static void InitBookMenu()
        {
            #region BookManager Menu
        
            bool keepRunning = true;
            do
            {
                Console.WriteLine(" | A: Add | S: Search | E: Edit | D: Delete | L: List | Q: Quit ");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        AddNewBook();
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("not implemented");
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("not implemented");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("not implemented");
                        break;
                    case ConsoleKey.L:
                        ListAllBooks();
                        break;
                    case ConsoleKey.Q:
                        keepRunning = false;
                        break;
                }
            } while (keepRunning);
            #endregion

        }

      


        public static void ListAllBooks()
        {

            // BooksWriter bookwr = new BooksWriter();
            //  bookwr.AddBook();
            // BooksWriter.AddBook(1, "Sigmar", "Cat world2");

            BooksWriter.ListBooks();
        }

        public static void AddNewBook()
        {
            BooksWriter.AddBook(1, "Sigmar", "Cat world2");
        }


        public static void InitCategoryMenu()
        {



        }

    }
}
