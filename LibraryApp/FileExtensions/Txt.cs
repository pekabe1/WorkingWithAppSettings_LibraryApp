using LibraryApp.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace LibraryApp.FileExtensions
{
    class Txt : IBookData
    {
        public void Add(Book item)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBookDataFromFile()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
