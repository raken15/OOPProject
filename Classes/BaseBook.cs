using System;
using OOPProject.Interfaces;

namespace OOPProject.Classes;

/// <summary>
/// Defines the BaseBook class, encapsulating common book properties and behavior, 
/// demonstrating inheritance by providing a foundation for derived book classes, 
/// promoting polymorphism through virtual methods, 
/// and utilizing abstraction to hide implementation details, 
/// enabling extensibility and modularity through object-oriented design.
/// </summary>
public class BaseBook : IBook
{
    #region Backing Fields
    private string _title;
    private string _author;
    private int _pagesAmount;
    private DateTime _publishDate;
    private bool _isAvailable;
    #endregion
    #region Properties
    public string Title 
    {
        get { return _title; }
        set {
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentNullException("Title can't be empty."); 
            } 
            _title = value; }
    }
    public string Author 
    {
        get { return _author; }
        set { 
            if (string.IsNullOrWhiteSpace(value)){ 
                throw new ArgumentNullException("Author can't be empty."); 
                } 
            _author = value; }
    }
    public int PagesAmount 
    {
        get { return _pagesAmount; }
        set { _pagesAmount = value; }
    }
    public DateTime PublishDate 
    {
        get { return _publishDate; }
        set { 
            if (value == default || value == DateTime.MinValue)
            {
                throw new ArgumentNullException("Publish date can't be empty or null."); 
            }
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Publish date can't be in the future.");
            }
            _publishDate = value; 
        }
    }
    public bool IsAvailable 
    {
        get { return _isAvailable; }
        set { _isAvailable = value; }
    }

    #endregion
    #region Constructors
    public BaseBook(){
        Title = "Basic book";
        Author = "John Doe";
        PagesAmount = 500;
        PublishDate = new DateTime(2010, 1, 1);
        IsAvailable = false;
    }
    public BaseBook(string title, string author, int pagesAmount, DateTime publishDate)
    {
        Title = title;
        Author = author;
        PagesAmount = pagesAmount;
        PublishDate = publishDate;
        IsAvailable = true;
    }
    #endregion
    #region Public Methods
    public bool TryToBorrow(){
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} has been successfully borrowed now.");
            return true;
        }
        else
        {
            Console.WriteLine($"{Title} is currently unavailable.");
            return false;
        }
    }
    public void ReturnToLibrary(){
        IsAvailable = true;
        Console.WriteLine($"{Title} has been successfully returned.");
    }
    public virtual void GetDetails(){
        Console.WriteLine("-----Book Details-----");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Pages Amount: {PagesAmount}");
        Console.WriteLine($"Publish Date: {PublishDate}");
    }
    #endregion

}