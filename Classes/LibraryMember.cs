using System;
using OOPProject.Interfaces;

namespace OOPProject.Classes;

/// <summary>
/// Defines the LibraryMember class, encapsulating common member properties and behavior, 
/// demonstrating inheritance by providing a foundation for derived member classes, 
/// promoting polymorphism through virtual methods, 
/// and utilizing abstraction to hide implementation details, 
/// enabling extensibility and modularity through object-oriented design.
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
    private List<IBook> _borrowedIBooks;
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
            if (value == default || value == DateTime.MinValue)
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
    public List<IBook> BorrowedIBooks
    {
        get => _borrowedIBooks;
        set => _borrowedIBooks = value ?? throw new ArgumentNullException(nameof(BorrowedIBooks), $"{nameof(BorrowedIBooks)} cannot be null");
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
        BorrowedIBooks = new List<IBook>();
    }
    public LibraryMember(string name, string email, string phoneNumber, DateTime dateOfBirth, string role)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        DateOfBirth = dateOfBirth;
        Role = role;
        BorrowedIBooks = new List<IBook>();
    }

    #endregion
    #region Public Methods
    public void BorrowBook(IBook iBook, Library library)
    {
        if(_borrowedIBooks.Contains(iBook)){
            Console.WriteLine($"Can't borrow book: The book is already borrowed by this member: (name: {Name}, email: {Email})");
            return;
        }
        if(!library.Members.Contains(this)){
            Console.WriteLine($"Can't borrow book: This member: (name: {Name}, email: {Email}) is not registered in this library");
            return;
        }
        if(!library.Books.Contains(iBook)){
            Console.WriteLine($"Can't borrow book: This book {iBook.Title} is not a property of this library");
            return;
        }
        if(iBook.TryToBorrow()){
            library.RemoveBookFromAvailableBooks(iBook);
            _borrowedIBooks.Add(iBook);
        }
    }

    public void ReturnBook(IBook iBook, Library library)
    {
        if (!_borrowedIBooks.Contains(iBook)){
            Console.WriteLine($"Can't return book: The member: (name: {Name}, email: {Email}) didn't borrow this book {iBook.Title}");
            return;
        }
        if(!library.Members.Contains(this)){
            Console.WriteLine($"Can't return book: This member: (name: {Name}, email: {Email}) is not registered in this library");
            return;
        }
        if(!library.Books.Contains(iBook)){
            Console.WriteLine($"Can't return book: This book {iBook.Title} is not a property of this library");
            return;
        }
        iBook.ReturnToLibrary();
        library.MakeBookAvailable(iBook);
        _borrowedIBooks.Remove(iBook);
    }
    public virtual void DisplayMember(){
        Console.WriteLine("-----Member Details-----");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Phone Number: " + PhoneNumber);
        Console.WriteLine("Date of Birth: " + DateOfBirth);
        Console.WriteLine("Role: " + Role);
        Console.WriteLine("Borrowed Books: " + _borrowedIBooks.Count);
    }
    #endregion
}
