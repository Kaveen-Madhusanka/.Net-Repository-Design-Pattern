using Domain.Entities;
using Infasturcture.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infasturcture.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _dbContext;
        public BookRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Book> CreateBook(Book book)
        {
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
            return book;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetBook(int Id)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
