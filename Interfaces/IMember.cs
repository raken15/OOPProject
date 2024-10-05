using System;
using OOPProject.Classes;

namespace OOPProject.Interfaces;

/// <summary>
/// Interface for a member, for using Abstraction OOP principle
/// </summary>
public interface IMember
{
    #region Properties
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Book> BorrowedBooks { get; set; }
    public string Role { get; set; }
    #endregion
    #region Methods
    public void BorrowBook(Book book);
    public void ReturnBook(Book book);
    public void DisplayMember();
    #endregion
}
