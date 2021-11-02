using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Book
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorId { get; set; }
        public DateTime Release { get; set; }
    }
}
