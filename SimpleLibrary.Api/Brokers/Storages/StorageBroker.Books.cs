﻿//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimpleLibrary.Api.Models.Foundations.Books;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Book> Books { get; set; }

        public async Task<Book> InsertBookAsync(Book book)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Book> bookEntityEntry =
                await broker.Books.AddAsync(book);

            await broker.SaveChangesAsync();

            return bookEntityEntry.Entity;
        }

        public IQueryable<Book> SelectAllBooks() =>
            SelectAll<Book>();

        public async Task<Book> SelectBookByIdAsync(Guid bookId) =>
            await SelectAsync<Book>(bookId);

        public async Task<Book> UpdateBookAsync(Book book) =>
            await UpdateAsync(book);

        public async Task<Book> DeleteBookAsync(Book book) =>
            await DeleteAsync<Book>(book);
    }
}