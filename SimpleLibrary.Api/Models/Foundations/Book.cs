//==========================
// Simple Library Management
//==========================

namespace SimpleLibrary.Api.Models.Foundations
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public Guid ReaderId { get; set; }
        public Reader Reader { get; set; }
    }
}
