﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Data;
using System.Xml.Serialization;
using System.Collections;


namespace BookMaster.BooksLibrary
{
    class BooksWriter
    {
        public static string filePath = @"../../books.xml";

        public static void AddBook(int Isbn, string Author, string Title)
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(BooksArray));
            TextWriter writer = new StreamWriter(filePath);

            BooksArray booksInst = new BooksArray();
           
            
             
            // FileStream fs = new FileStream(filePath, FileMode.Open);

            BooksArray po = new BooksArray();
           // po = (BooksArray)serializer.Deserialize(fs);

            // Creates an OrderedItem.  
            Book i1 = new Book();


            i1.Isbn = Isbn;//1;
            i1.Author = Author; //"Sigmar";
            i1.Title = Title;//"Cat world";

            Book i2 = new Book();
            i2.Isbn = 2;
            i2.Author = "1Sigmar";
            i2.Title = "Dog world";

            // Inserts the item into the array.  
            // List<Book> items = { i1, i2 };
            // po.Books = items;
            List<Book> items = po.Books;
            items.Add(i1);

            // Serializes the purchase order, and closes the TextWriter.  
            serializer.Serialize(writer, po);

            // serializer.Serialize(writer, booksInst);

            writer.Close();
        }

        public static void AddBookNew(int Isbn, string Author, string Title)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BooksArray));
            FileStream fs = new FileStream(filePath, FileMode.Open);
            // Declares an object variable of the type to be deserialized.  
            BooksArray po;
            // Uses the Deserialize method to restore the object's state   
            // with data from the XML document. */  
            po = (BooksArray)serializer.Deserialize(fs);


            // Creates an OrderedItem.  
            Book i1 = new Book();


            i1.Isbn = Isbn;//1;
            i1.Author = Author; //"Sigmar";
            i1.Title = Title;//"Cat world";


            List<Book> items = po.Books;


            ArrayList a1 = new ArrayList();

            a1.Add(i1);
            a1.Add(items);

            BooksArray booksArr = new BooksArray();
            
            // Array stuff = a1.ToArray();
            // booksArr.Books = stuff;

            TextWriter writer = new StreamWriter(filePath);


            // Serializes the purchase order, and closes the TextWriter.  
            serializer.Serialize(writer, items);

            // serializer.Serialize(writer, booksInst);

            writer.Close();

            foreach (Book oi in a1)
            {
                Console.WriteLine("\t" +
                oi.Isbn + "\t" +
                oi.Title + "\t" +
                oi.Author + "\t"); 

            }
        }

        public static void ListBooks()
        {
            // Creates an instance of the XmlSerializer class;  
            // specifies the type of object to be deserialized.  
            XmlSerializer serializer = new XmlSerializer(typeof(BooksArray));
            // If the XML document has been altered with unknown   
            // nodes or attributes, handles them with the   
            // UnknownNode and UnknownAttribute events.  
            /*serializer.UnknownNode += new
            XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new
            XmlAttributeEventHandler(serializer_UnknownAttribute); */

            // A FileStream is needed to read the XML document.  
            FileStream fs = new FileStream(filePath, FileMode.Open);
            // Declares an object variable of the type to be deserialized.  
            BooksArray po;
            // Uses the Deserialize method to restore the object's state   
            // with data from the XML document. */  
            po = (BooksArray)serializer.Deserialize(fs);

            // Reads the list of ordered items.  
            List<Book> items = po.Books;
            Console.WriteLine("List of books in shelves");
            foreach (Book oi in items)
            {
                Console.WriteLine("\t" +
                oi.Isbn + "\t" +
                oi.Title + "\t" +
                oi.Author + "\t");
          
            } 
            
        }

    }
}