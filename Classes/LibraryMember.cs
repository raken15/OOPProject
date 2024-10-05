using System;
using OOPProject.Interfaces;

namespace OOPProject.Classes;

/// <summary>
/// Class for a library member, for using Encapsulation and Inheritance OOP principle
/// </summary>
public class LibraryMember : IMember
{
    #region Constants
    const int PHONENUMBERLENGTH = 10;
    #endregion
    #region Backing Fields
    private string _name;
    private string _email;
    private string _phoneNumber;
    private DateTime _dateOfBirth;
    private List<Book> _borrowedBooks;
    private string _role;
    #endregion

    #region Properties
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{nameof(Name)} cannot be null or empty", nameof(value));
            _name = value;
        }
    }
    public string Email { get => _email; set => _email = value; }
    public string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{nameof(PhoneNumber)} cannot be null or empty", nameof(value));
            if (value.Length != PHONENUMBERLENGTH)
                throw new ArgumentException($"{nameof(PhoneNumber)} must be length {PHONENUMBERLENGTH}", nameof(value));
            _phoneNumber = value;
        }
    }
    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set { 
            if (value == null || value == DateTime.MinValue)
            {
                throw new ArgumentNullException($"{nameof(DateOfBirth)} cannot be empty or null.", nameof(value)); 
            }
            if (value > DateTime.Now)
            {
                throw new ArgumentException($"{nameof(DateOfBirth)} cannot be in the future. value entered {value}", nameof(value));
            }
            _dateOfBirth = value; 
        }
    }
    public List<Book> BorrowedBooks
    {
        get => _borrowedBooks;
        set => _borrowedBooks = value ?? throw new ArgumentNullException(nameof(BorrowedBooks), $"{nameof(BorrowedBooks)} cannot be null");
    }
    public string Role
    {
        get => _role;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{nameof(Role)} cannot be null or empty", nameof(value));
            _role = value;
        }
    }
    #endregion
    #region Constructors
    public LibraryMember()
    {
        Name = "John";
        Email = "john@example.com";
        PhoneNumber = "1234567890";
        DateOfBirth = new DateTime(1990, 1, 1);
        Role = "Member";
    }
    public LibraryMember(string name, string email, string phoneNumber, DateTime dateOfBirth, string role)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
        Role = role;
    }

    #endregion
    #region Methods
    public void BorrowBook(Book book)
    {
        if(_borrowedBooks.Contains(book)){
            throw new InvalidOperationException("The book is already borrowed by this member");
        }
        if(book.TryToBorrow()){
            _borrowedBooks.Add(book);
        }
    }

    public void ReturnBook(Book book)
    {
        if (!_borrowedBooks.Contains(book))
            throw new InvalidOperationException("The book is not borrowed by this member");
        book.ReturnToLibrary();
        _borrowedBooks.Remove(book);
    }
    public void DisplayMember(){
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Phone Number: " + PhoneNumber);
        Console.WriteLine("Date of Birth: " + DateOfBirth);
        Console.WriteLine("Role: " + Role);
        Console.WriteLine("Borrowed Books: " + _borrowedBooks.Count);
    }
    #endregion
}
