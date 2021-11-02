using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infasturcture.Interface
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooks();
        Task<Book> GetBook(int id);
        Task<Book> CreateBook(Book book);
    }
}
