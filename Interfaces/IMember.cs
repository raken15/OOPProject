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
    public List<IBook> BorrowedIBooks { get; set; }
    public string Role { get; set; }
    #endregion
    #region Methods
    public void BorrowBook(IBook iBook);
    public void ReturnBook(IBook iBook);
    public void DisplayMember();
    #endregion
}
