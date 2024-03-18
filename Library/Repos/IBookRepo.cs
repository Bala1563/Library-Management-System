using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repos
{
    public interface IBookRepo
    {
        //operations by user
        Task<List<Book>> GetAllBooks();
        Task<List<Book>> GetByAuthor(string author);
        Task<List<Book>> GetByPublicationYear(DateTime publicationYear);
        Task<List<Book>> GetByGenre(string genre);
        Task<Book> GetBookById(int bookId);

        Task BorrowBook(int bookId, int borrowerId);
        Task ReturnBook(int bookId, int borrowerId);
        Task<List<Book>> BorrowerBooks(int borrowerId);

        //operations by admin only
        Task InsertBook(Book book);
        Task DeleteBook(int bookId);
        Task UpdateBook(int bookId, Book book);
    }
}
