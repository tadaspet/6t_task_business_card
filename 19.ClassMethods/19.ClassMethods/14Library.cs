using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _19.ClassMethods
{
    public class Library
    {
        public List<Book> BookLibr { get; set; } = new List<Book>();
        public void BookAdd(string bookName)
        {
            Book newBook = new Book();
            newBook.BookList.Add(bookName);
            BookLibr.Add(newBook);
        }
        public void BookRemove(string bookName)
        {
            foreach(var book in BookLibr)
            {
                book.BookList.Remove(bookName);
            }
        }
        public void PrintLibrary()
        {
            int count = 1;
            foreach(var book in BookLibr)
            {
                foreach (var item in book.BookList)
                {
                    Console.WriteLine($"{count}. {item}");
                }
                count++;
            } 
        }
        public void CreateLibrary()
        {
            Console.WriteLine("Sukurkite biblioteka knygoms:");
            int count = 1;
            bool check = true;
            while(check)
            {
                Console.WriteLine($"Pridekite knyga nr {count} ivesdami pavadnima:");
                string input1 = Console.ReadLine();
                if (input1 == "q") 
                { 
                    check = false;
                }
                else 
                {
                    BookAdd(input1);
                }
                count++;
            }
        }
        public void DeleteLibrary()
        {
            Console.WriteLine("Istrinkite bibliotekos knygas:");
            int count = 1;
            bool check = true;
            while (check)
            {
                Console.WriteLine($"Pasalinkite knyga nr {count} ivesdami pavadnima:");
                string input1 = Console.ReadLine();
                if (input1 == "q")
                {
                    check = false;
                }
                else
                {
                    BookRemove(input1);
                }
                count++;
            }
        }
    }
}
