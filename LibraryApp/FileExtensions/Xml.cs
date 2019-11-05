using LibraryApp.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using LibraryApp.Configuration;

namespace LibraryApp.FileExtensions
{
    class Xml : IBookData
    {
        public void Add(Book item)
        {
            throw new NotImplementedException();
        }
        private readonly IConfiguration config;
        public Xml(IConfiguration configuration)
        {
            this.config = configuration;

        }
        public List<Book> GetBookDataFromFile()
        {
            XDocument document = XDocument.Load(GetSettings.GetFilePath(config));
            return document.
                Element("root").
                 Elements().
                 Select(x => new Book
                 {
                     ID = int.Parse(x.Attribute(nameof(Book.ID)).Value),
                     Name = x.Attribute(nameof(Book.Name)).Value,
                     Category = x.Attribute(nameof(Book.Category)).Value,
                     Status = x.Attribute(nameof(Book.Status)).Value
                 })
                 .ToList();
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
