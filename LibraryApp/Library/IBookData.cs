using LibraryApp.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Library
{
    public interface IBookData
    {
        List<Book> GetBookDataFromFile();
        void Remove(int id);
        void Update(Book item);
        void Add(Book item);
       

    }
}
