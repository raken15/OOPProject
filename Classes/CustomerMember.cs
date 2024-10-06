using System;

namespace OOPProject.Classes;

/// <summary>
/// Defines the CustomerMember class, inheriting from LibraryMember and specializing in customer member behavior, 
/// demonstrating inheritance by building upon the LibraryMember class, 
/// utilizing polymorphism through method overriding, 
/// and showcasing encapsulation by hiding implementation details, 
/// enabling extensibility and modularity through object-oriented design.
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
        Console.WriteLine("-----Member Details-----");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Borrowed Books: " + BorrowedIBooks.Count);
    }
    
}
