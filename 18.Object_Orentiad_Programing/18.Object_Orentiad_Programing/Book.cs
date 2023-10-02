using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Object_Orentiad_Programing
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string OriginCountry { get; set; }
        public Book(string title, string author, int year) 
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }
}
