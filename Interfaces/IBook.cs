using System;

namespace OOPProject.Interfaces;

/// <summary>
/// Defines the IBook interface, abstracting book properties and behavior, 
/// promoting encapsulation, inheritance, and polymorphism, 
/// and establishing a common framework for all book implementations
/// enabling extensibility and modularity through interface-based design.
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