using Acme.BookStore.Authors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Books
{
    public class AuthorWithDetailsDto : AuthorDto
    {
        [Required]
        public ICollection<BookDto> Books { get; set; }

        public AuthorWithDetailsDto()
        {
            Books = new List<BookDto>();
        }
    }
}
