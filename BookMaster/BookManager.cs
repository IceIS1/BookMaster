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
                        keepRunning = false;
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
            // Console.WriteLine("not implemented");
            BooksWriter.ListBooks();
        }

        public static void AddNewBook()
        {
            Console.WriteLine("ISBN number:");
            int isbnNr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Author name:");
            String AuthorName = Console.ReadLine();
            Console.WriteLine("Book title:");
            String BookTitle = Console.ReadLine();

            BooksWriter.AddBook(isbnNr, AuthorName, BookTitle);

            Console.Clear();
            //   BooksWriter.AddBook(1, "Sigmar", "Cat world2");
            /* bool keepRunning = true;
             do
             {
                 Console.WriteLine(" | Q: Cancel ");



                 ConsoleKeyInfo key = Console.ReadKey();
                 Console.Clear();
                 switch (key.Key)
                 {

                 //    case ConsoleKey.S:
                   //      Console.WriteLine("not implemented");
                     //    break;

                     case ConsoleKey.Escape:
                         keepRunning = false;
                         break;
                     default:
                         Console.WriteLine(key);
                         break;
                 }
             } while (keepRunning); */

        }


        public static void InitCategoryMenu()
        {



        }


    }



}

