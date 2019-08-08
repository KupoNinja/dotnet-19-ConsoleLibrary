using System;
using ConsoleLibrary.Models;

namespace ConsoleLibrary
{
    public class App
    {
        private Library Library { get; set; }
        public bool InLibrary { get; set; }
        public void Setup()
        {
            //TODO create instances of some books
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Dune", "Frank Herbert", 500);
            Book book3 = new Book("Patsy", "Nicole Benn-Dennis", 250);

            //TODO add those books to your library
            Library.Books.Add(book1);
            Library.Books.Add(book2);
            Library.Books.Add(book3);
        }

        public void Run()
        {
            //TODO write our application
            //1. we need a greeting and menu navigation
            Console.WriteLine("Welcome to the Library!");
            while (InLibrary)
            {
                DisplayMenu();
            }
            //2. must be able to view, checkout, and return books
            //[STRETCH GOAL] allow the user to create instances of books 
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. Return a Book");
            Console.WriteLine("3. Leave the Library");
            Console.WriteLine("Please enter a number:");
            HandleUserInput();
        }

        public void HandleUserInput()
        {
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":
                    Library.ViewBooks();
                    break;
                case "2":
                    // Library.ReturnBook();
                    break;
                case "3":
                    InLibrary = false;
                    break;
                default:
                    Console.WriteLine("Not a valid option. Please choose 1, 2, or 3.");
                    HandleUserInput();
                    break;
            }
        }

        // NOTE Our constructor method runs when an instance of an App is created and the logic within assigns a new instance of a Library to the property Library on our app
        public App()
        {
            Library = new Library();
            InLibrary = true;
        }
    }
}