//==========================
// Simple Library Management
//==========================

namespace SimpleLibrary.Api.Models.Foundations
{
    public class ReaderBook
    {
        public Reader Reader { get; set; }
        public List<Book> Books { get; set; }
    }
}
