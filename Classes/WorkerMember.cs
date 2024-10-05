using System;

namespace OOPProject.Classes;

public class WorkerMember : LibraryMember
{
    public WorkerMember() : base()
    {
    }

    public WorkerMember(string name, string email, string phoneNumber, DateTime dateOfBirth, string role) 
    : base(name, email, phoneNumber, dateOfBirth, role)
    {
    }

    public override void DisplayMember()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Borrowed Books: " + BorrowedBooks.Count);
        Console.WriteLine("Phone Number: " + PhoneNumber);
        Console.WriteLine("Date of Birth: " + DateOfBirth);
    }
}
