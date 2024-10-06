using System;

namespace OOPProject.Classes;

public class ChildrenBook : BaseBook
{
    #region Backing Fields
    private EndingEnum _ending;
    #endregion
    #region Properties
    public EndingEnum Ending    {
        get { return _ending; }
        set { _ending = value; }
    }
    #endregion
    #region Constructors
    public ChildrenBook() { 
        Ending = EndingEnum.Sad;
    }
    public ChildrenBook(string title, string author, int pagesAmount, DateTime publishDate, EndingEnum ending) 
    : base(title, author, pagesAmount, publishDate)
    {
        Ending = ending;
    }
    #endregion
    #region Public Methods
    public override void GetDetails()
    {
        base.GetDetails();
        switch(Ending)
        {
            case EndingEnum.Happy:
                Console.WriteLine("It's a happy ending");
                break;
            case EndingEnum.Exciting:
                Console.WriteLine("It's an exciting ending");
                break;
            case EndingEnum.Boring:
                Console.WriteLine("It's a boring ending");
                break;
            case EndingEnum.Sad:
                Console.WriteLine("It's a sad ending");
                break;
        }
    }
    public bool IsHappyEnding() => Ending == EndingEnum.Happy;
    #endregion
}
#region Enums
public enum EndingEnum
{
    Happy,
    Exciting,
    Boring,
    Sad
}
#endregion
