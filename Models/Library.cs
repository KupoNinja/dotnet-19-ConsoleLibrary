using System;
using System.Collections.Generic;

namespace ConsoleLibrary.Models
{
    public class Library
    {
        //TODO Create the properties and methods that this class will need
        public List<Book> Books { get; set; }

        public void CheckOut()
        {
            Console.WriteLine("Which book number?:");
            int index;
            bool isIndex = false;
            while (!isIndex)
            {
                Int32.TryParse(Console.ReadLine(), out index);
            }
        }

        public void ViewBooks()
        {
            int bookCount = 0;
            foreach (var book in Books)
            {
                Console.WriteLine($"{bookCount}.");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Pages: {book.Pages}");
                Console.WriteLine($"-----------------------------------------------------");
                bookCount++;
            }
        }
        public Library()
        {
            Books = new List<Book>();
        }
    }
}