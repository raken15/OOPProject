using System;
using OOPProject.Interfaces;

namespace OOPProject.Classes;

/// <summary>
/// Defines the Book class, inheriting from BaseBook and implementing specific book behavior, 
/// demonstrating inheritance by building upon the BaseBook class, 
/// utilizing polymorphism through method overriding, 
/// and showcasing encapsulation by hiding implementation details, 
/// enabling extensibility and modularity through object-oriented design.
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
