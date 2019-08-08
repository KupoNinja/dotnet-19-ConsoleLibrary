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

        public void ReturnBook()
        {
            Console.WriteLine("Please enter the book title you are returning.");
            Book bookToReturn = null;
            while (bookToReturn == null)
            {
                string bookTitle = Console.ReadLine().ToUpper();
                bookToReturn = Books.Find(b => b.Title.ToUpper() == bookTitle)
                // NOTE Our user is stuck in this until they type a valid book title
                // if (bookToReturn == null) {
                //     Console.WriteLine("Sorry we couldn't find that book.\nEnter 'back'");
                // }
            }
            bookToReturn.IsAvailable = true;
            Console.WriteLine($"Thanks for returning {bookToReturn.Title}!");
        }

        public void ViewBooks(bool onlyAvailable = false)
        {
            int bookCount = 1;
            List<Book> books = Books;

            if (onlyAvailable)
            {
                books = books.FindAll(b => b.IsAvailable);
            }
            foreach (var book in Books)
            {
                Console.WriteLine($"ID: {bookCount}");
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