using System;
using System.IO;
using LibraryApp.FileExtensions;
using Microsoft.Extensions.Configuration;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("AppSettings.json");

            var configuration = new ConfigurationBuilder().
                AddJsonFile("AppSettings.json", true, true).
                Build();

            Xml xml = new Xml(configuration);
            xml.GetBookDataFromFile();
        }
    }
}
