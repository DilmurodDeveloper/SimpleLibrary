﻿//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Library Management System
//==================================================

using SimpleLibrary.Api.Models.Foundations.ReadersBooks;

namespace SimpleLibrary.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<ReaderBook> SelectReaderWithBooksAsync(Guid readerId);
    }
}
