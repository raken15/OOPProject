using System;
using OOPProject.Classes;

namespace OOPProject.Interfaces;

/// <summary>
/// Defines the IMember interface, abstracting member properties and behavior, 
/// promoting encapsulation, inheritance, and polymorphism, 
/// and establishing a common framework for all member implementations, 
/// enabling extensibility and modularity through interface-based design.
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
    public void BorrowBook(IBook iBook, Library library);
    public void ReturnBook(IBook iBook, Library library);
    public void DisplayMember();
    #endregion
}
