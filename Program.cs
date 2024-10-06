// See https://aka.ms/new-console-template for more information
using OOPProject.Classes;

Library library = new Library();
Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180, new DateTime(1925, 4, 10), "Fiction");
library.AddBook(book);
library.DisplayAvailableBooks();
WorkerMember workerMember = new WorkerMember();
CustomerMember customerMember = new CustomerMember();
library.RegisterMember(workerMember);
workerMember.BorrowBook(book);
customerMember.BorrowBook(book);
workerMember.ReturnBook(book);
customerMember.BorrowBook(book);
library.DisplayAvailableBooks();

