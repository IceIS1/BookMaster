using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace BookMaster
{
    [XmlRoot("PurchaseOrder", Namespace = "http://www.cpandl.com",
    IsNullable = false)]
    public class BooksArray
    {
       
        // The XmlArray attribute changes the XML element name  
        // from the default of "OrderedItems" to "Items".  
        [XmlArray("Items")]
        public Book[] Books;
       // public decimal SubTotal;
       // public decimal ShipCost;
       //  public decimal TotalCost;
    }
    public class Book
    {
        public int Isbn;
        public string Author;
        public string Title;

        // Calculate is a custom method that calculates the price per item  
        // and stores the value in a field.  
        /* public void Calculate()
         {
             LineTotal = UnitPrice * Quantity;
         }
         */
    }

    /*

    [XmlRoot("Books", Namespace = "http://www.cpandl.com",
    IsNullable = false)]
    public class Books
    {
        [XmlArray("Book")]
        public Book[] BooksArr;
    }
    public class Book
    {
        public int Isbn;
        public string Author;
        public string Title;
    } */
}
