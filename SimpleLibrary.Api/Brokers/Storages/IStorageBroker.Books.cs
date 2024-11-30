//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.Books;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        Task<Book> InsertBookAsync(Book book);
        Task<Book> SelectBookByIdAsync(Guid bookId);
        IQueryable<Book> SelectAllBooks();
        Task<Book> UpdateBookAsync(Book book);
        Task<Book> DeleteBookAsync(Book book);
    }
}
