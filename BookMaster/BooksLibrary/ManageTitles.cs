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
            // AddNewBook();


            BooksWriter.AddBook(12, "trest","sdfdsf");
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
          //  ListAllBooks();
            Console.WriteLine("List Title not implemented");
            Console.ReadKey();
        }

 

         


    }
}
