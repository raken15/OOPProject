using System;

namespace OOPProject.Interfaces;

/// <summary>
/// Interface for a book, for using abstraction principle
/// </summary>
public interface IBook
{
    #region Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int PagesAmount { get; set; }
    public DateTime PublishDate { get; set; }
    public bool IsAvailable { get; set; }
    #endregion
    #region Public Methods
    public bool TryToBorrow();
    public void ReturnToLibrary();
    public void GetDetails();
    #endregion
}