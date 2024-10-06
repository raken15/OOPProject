using System;

namespace OOPProject.Classes;

/// <summary>
/// Defines the WorkerMember class, inheriting from LibraryMember and specializing in worker member behavior, 
/// demonstrating inheritance by building upon the LibraryMember class, 
/// utilizing polymorphism through method overriding, 
/// and showcasing encapsulation by hiding implementation details, 
/// enabling extensibility and modularity through object-oriented design.
/// </summary>
public class WorkerMember : LibraryMember
{
    public WorkerMember() : base("Worker", "worker@example.com", "1234567890", DateTime.Now, "Worker") { }

    public override void DisplayMember()
    {
        Console.WriteLine("-----Member Details-----");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Borrowed Books: " + BorrowedIBooks.Count);
        Console.WriteLine("Phone Number: " + PhoneNumber);
        Console.WriteLine("Date of Birth: " + DateOfBirth);
    }
}
