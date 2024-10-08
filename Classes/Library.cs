using System;
using OOPProject.Interfaces;

namespace OOPProject.Classes;

/// <summary>
/// Defines the Library class, encapsulating library properties and behavior, 
/// demonstrating composition by containing collections of books and members, 
/// utilizing encapsulation to hide implementation details, 
/// and showcasing abstraction by providing a high-level interface for managing library operations, 
/// such as borrowing and returning books, without exposing the underlying implementation details, 
/// enabling extensibility and modularity through object-oriented design.
/// </summary>
public class Library
{
    public List<IBook> Books { get; set; }
    public List<IMember> Members { get; set; }

    public Library()
    {
        Books = new List<IBook>();
        Members = new List<IMember>();
    }
    public void AddBook(IBook iBook)
    {
        if (Books.Contains(iBook))
        {
            Console.WriteLine($"{iBook.Title} is already in the library.");
            return;
        }
        
        Books.Add(iBook);
        Console.WriteLine($"{iBook.Title} added to the library.");
    }

    public void RemoveBookFromAvailableBooks(IBook iBook){
        if (!Books.Contains(iBook))
        {
            Console.WriteLine($"{iBook.Title} is not in the library.");
            return;
        }
        Books[Books.IndexOf(iBook)].IsAvailable = false;
        Console.WriteLine($"{iBook.Title} removed from the available books of the library.");
    }
    public void MakeBookAvailable(IBook iBook)
    {
        if (!Books.Contains(iBook))
        {
            Console.WriteLine($"{iBook.Title} is not in the library.");
            return;
        }
        Books[Books.IndexOf(iBook)].IsAvailable = true;
        Console.WriteLine($"{iBook.Title} made available.");
    }
    public void RegisterMember(IMember iMember)
    {
        if (Members.Contains(iMember))
        {
            Console.WriteLine($"{iMember.Name} is already a library member.");
            return;
        }
        Members.Add(iMember);
        Console.WriteLine($"{iMember.Name} registered as a library member.");
    }
    public void DisplayAvailableBooks()
    {
        var availableBooks = Books.Where(b => b.IsAvailable).ToList();
        if(availableBooks.Count == 0){
            Console.WriteLine("No books are available");
        }
        else
        {
            Console.Write("Available books: {");
            foreach (var book in availableBooks)
            {
                Console.Write(book.Title);
                Console.Write(", ");
            }
            Console.WriteLine("}");
        }
    }

}
