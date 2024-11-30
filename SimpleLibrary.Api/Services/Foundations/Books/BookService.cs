//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Brokers.Storages;
using SimpleLibrary.Api.Models.Foundations.Books;

namespace SimpleLibrary.Api.Services.Foundations.Books
{
    public class BookService : IBookService
    {
        private readonly IStorageBroker storageBroker;

        public BookService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Book> AddBookAsync(Book book) =>
            await this.storageBroker.InsertBookAsync(book);

        public IQueryable<Book> RetrieveAllBooks() =>
            this.storageBroker.SelectAllBooks();

        public async ValueTask<Book> RetrieveBookByIdAsync(Guid bookId) =>
            await this.storageBroker.SelectBookByIdAsync(bookId);

        public async ValueTask<Book> ModifyBookAsync(Book book) =>
            await this.storageBroker.UpdateBookAsync(book);

        public async ValueTask<Book> RemoveBookAsync(Book book) =>
            await this.storageBroker.DeleteBookAsync(book);
    }
}
