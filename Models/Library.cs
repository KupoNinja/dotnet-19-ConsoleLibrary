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
            int index = 0;
            bool isIndex = false;
            List<Book> books = Books.FindAll(b => b.IsAvailable);
            while (!isIndex)
            {
                isIndex = Int32.TryParse(Console.ReadLine(), out index);
                if (!isIndex)
                {
                    Console.WriteLine("Please enter a number:");
                    continue;
                }

                if (index < 1 || index > Books.Count)
                {
                    Console.WriteLine("Not a valid number.");
                    isIndex = false;
                }
            }

            Book custChoice = books[index - 1];
            custChoice.IsAvailable = false;
            Console.WriteLine($"You checked out {custChoice.Title}.");
        }

        public void ReturnBook()
        {
            Console.WriteLine("Please enter the book title you are returning.");
            Book bookToReturn = null;
            while (bookToReturn == null)
            {
                string bookTitle = Console.ReadLine().ToUpper();
                bookToReturn = Books.Find(b => b.Title.ToUpper() == bookTitle);
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
            var colorOG = Console.ForegroundColor;
            int bookCount = 1;
            List<Book> books = Books;

            if (onlyAvailable)
            {
                books = books.FindAll(b => b.IsAvailable);
            }
            foreach (var book in Books)
            {
                if (!book.IsAvailable)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"ID: {bookCount}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Pages: {book.Pages}");
                Console.WriteLine($"-----------------------------------------------------");
                bookCount++;
                Console.ForegroundColor = colorOG;
            }
        }
        public Library()
        {
            Books = new List<Book>();
        }
    }
}