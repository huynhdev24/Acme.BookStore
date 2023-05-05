using Acme.BookStore.Authors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Books
{
    public class CreateAuthorWithBookDto : CreateAuthorDto
    {
        public ICollection<CreateBookDto> Books { get; set; }

        public CreateAuthorWithBookDto()
        {
            Books = new List<CreateBookDto>();
        }
    }
}
