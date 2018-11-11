using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMaster.BooksLibrary;

namespace BookMaster.BooksLibrary
{
    class ManageTitles
    {
        public static void Add()
        {
            AddNewBook();
            Console.WriteLine("Add Title not implemented");
            Console.ReadKey();
        }
        public static void Edit()
        {
            Console.WriteLine("Edit Title not implemented");
            Console.ReadKey();
        }
        public static void Delete()
        {
            Console.WriteLine("Delete Title not implemented");
            Console.ReadKey();
        }
        public static void List()
        {
            ListAllBooks();
            Console.WriteLine("List Title not implemented");
            Console.ReadKey();
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
            BooksWriter.AddBook(1, "Sigmar", "Cat world2");
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


    }
}
