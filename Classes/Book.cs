using System;
using OOPProject.Interfaces;

namespace OOPProject.Classes;

/// <summary>
/// Class for a book, for using Encapsulation and Inheritance OOP principle
/// </summary>
public class Book : BaseBook
{
    #region Backing Fields
    private string _genre;
    #endregion
    #region Properties
    public string Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }
    #endregion
    #region Constructors
    public Book() { 
        Genre = "Unknown";
    }    
    public Book(string title, string author, int pagesAmount, DateTime publishDate, string genre) 
    : base(title, author, pagesAmount, publishDate){
        Genre = genre ?? "Unknown";
    }
    #endregion
    #region Public Methods
    public override void GetDetails(){
        base.GetDetails();
        Console.WriteLine($"Genre: {Genre}");
    }
    #endregion

}
