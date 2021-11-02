using Domain.Entities;
using Infasturcture;
using Infasturcture.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository books)
        {
            _bookRepository = books;
        }
        [HttpGet("GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
             return Ok(await _bookRepository.GetAllBooks());
        }
        [HttpGet("GetBook")]
        public async Task<IActionResult> GetBook(int Id)
        {
            return Ok(await _bookRepository.GetBook(Id));
        }
        [HttpPost("CreateBook")]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            return Ok(await _bookRepository.CreateBook(book));
        }
    }
}
