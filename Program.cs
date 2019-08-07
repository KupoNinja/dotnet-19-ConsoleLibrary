using System;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            App app = new App();
            app.Setup();
            app.Run();
            Console.Clear();
            Console.WriteLine("Thanks for visiting the Library!");
        }
    }
}
