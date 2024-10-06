/// <summary>
/// This program demonstrates the usage of a library management system.
/// It creates a library, adds books, registers members, and performs borrowing and returning operations.
/// it also tests for failure states and the displays and operations are working as expected
/// </summary>
using OOPProject.Classes;

Library library = new Library();
Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald"
, 180, new DateTime(1925, 4, 10), "Fiction");
Book book2 = new Book("To Kill a Mockingbird", "Harper Lee"
, 328, new DateTime(1960, 12, 24), "Fiction"); // two hard-coded books for example of the library management system
ChildrenBook childrenBook = new ChildrenBook("The Little Mermaid", "J. R. R. Tolkien"
, 288, new DateTime(1980, 6, 3), EndingEnum.Sad); // a hard-coded children book for example of the library management system
library.AddBook(book);
library.AddBook(book2);
library.AddBook(childrenBook);
library.AddBook(book); // testing that the library can't add the same book twice
library.DisplayAvailableBooks();
WorkerMember workerMember = new WorkerMember();
CustomerMember customerMember = new CustomerMember();
library.RegisterMember(workerMember);
workerMember.BorrowBook(book, library);
workerMember.BorrowBook(book, library); // testing that the member can't borrow the same book twice
workerMember.BorrowBook(book2, library); // testing that the member can't borrow a book that isn't in the library
library.DisplayAvailableBooks(); // testing that the library displays available books correctly
                                // after a book was borrowed and new book is added
customerMember.BorrowBook(book2, library); // testing that the member can't borrow a book if he isn't registered
workerMember.ReturnBook(book2, library); // testing that the member can't return a book if he didn't borrow it
library.DisplayAvailableBooks(); // testing that the library displays available books correctly
                                // after the borrow and return operations were not successfull
library.RegisterMember(customerMember);
customerMember.BorrowBook(book, library); // testing that the member can't borrow a book that isn't available
workerMember.ReturnBook(book, library);
library.DisplayAvailableBooks();
customerMember.BorrowBook(book, library);
foreach (var libraryBook in library.Books)
{
    libraryBook.GetDetails();
    if(libraryBook is ChildrenBook)
    {
        if((libraryBook as ChildrenBook).HasHappyEnding())
        {
            Console.WriteLine($"The book {libraryBook.Title} has a happy ending");
        }
        else
        {
            Console.WriteLine($"The book {libraryBook.Title} doesn't have a happy ending");
        }
    }
}
foreach (var member in library.Members)
{
    member.DisplayMember();
}
