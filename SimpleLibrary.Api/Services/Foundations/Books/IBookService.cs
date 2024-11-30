//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.Books;

namespace SimpleLibrary.Api.Services.Foundations.Books
{
    public interface IBookService
    {
        ValueTask<Book> AddBookAsync(Book book);
        IQueryable<Book> RetrieveAllBooks();
        ValueTask<Book> RetrieveBookByIdAsync(Guid bookId);
        ValueTask<Book> ModifyBookAsync(Book book);
        ValueTask<Book> RemoveBookAsync(Book book);
    }
}
