using Ooi.Shared;

Book book = new(isbn: "978-1803237800",
  title: "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
  book.Isbn, book.Title, book.Author, book.PageCount);
