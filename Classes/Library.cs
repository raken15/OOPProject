using System;
using OOPProject.Interfaces;

namespace OOPProject.Classes;

/// <summary>
/// Class for a library, for using Encapsulation and Inheritance OOP principle
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
        Console.WriteLine("Available books:");
        foreach (var book in availableBooks)
        {
            Console.WriteLine(book.Title);
        }
    }

}
