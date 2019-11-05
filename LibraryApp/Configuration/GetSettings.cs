using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace LibraryApp.Configuration
{
   public static class GetSettings
    {

        //var builder = new ConfigurationBuilder().
        //      SetBasePath(Directory.GetCurrentDirectory()).
        //      AddJsonFile("AppSettings.json");

        //var configuration = new ConfigurationBuilder().
        //    AddJsonFile("AppSettings.json", true, true).
        //    Build(

        public  static string GetFilePath(IConfiguration configuration)
        {   
             return File.ReadAllText(configuration["DataFilePath"]);    
        }
    }
}
