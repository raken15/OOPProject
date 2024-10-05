using System;

namespace OOPProject.Classes;

/// <summary>
/// Class for a book, for using Encapsulation and Inheritance OOP principle
/// </summary>
public class Book
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
            if (value == null || value == DateTime.MinValue)
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
    #region Methods
    public void Borrow(){
        throw new NotImplementedException();
    }
    public void Return(){
        throw new NotImplementedException();
    }
    public void ReadDescription(){
        throw new NotImplementedException();
    }
    #endregion

}
