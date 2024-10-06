using System;

namespace OOPProject.Classes;

/// <summary>
/// Class for Customer Member, for using Polymorphism and Inheritance OOP principle
/// </summary>
public class CustomerMember : LibraryMember
{
    public CustomerMember() : base("Customer", "customer@example.com", "1234567890", DateTime.Now, "Customer") {
    }

    public CustomerMember(string name, string email, string phoneNumber, DateTime dateOfBirth, string role) 
    : base(name, email, phoneNumber, dateOfBirth, role)
    {
    }

    public override void DisplayMember()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Borrowed Books: " + BorrowedIBooks.Count);
    }
    
}
