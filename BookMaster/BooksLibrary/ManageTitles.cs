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
            Console.WriteLine("ISBN number:");
            int isbnNr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Author name:");
            String AuthorName = Console.ReadLine();
            Console.WriteLine("Book title:");
            String BookTitle = Console.ReadLine();

            BooksWriter.AddBook(isbnNr, AuthorName, BookTitle);
            
            // Console.WriteLine("Add Title not implemented");
            //Console.ReadKey();
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
            BooksWriter.ListBooks();
          //  Console.WriteLine("List Title not implemented");
            Console.ReadKey();
        }

 

         


    }
}
