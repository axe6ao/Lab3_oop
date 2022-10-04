using System;
namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new Author("David Goggins", ConsoleColor.Red), new Title("Can't hurt me", ConsoleColor.Blue), new Content("This book tells you about self development", ConsoleColor.Yellow));
            book.Show();
            Console.ReadLine();
        }
    }
}