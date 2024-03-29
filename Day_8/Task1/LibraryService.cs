﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class LibraryService
    {
        public List<Book> books;
        public void AddBook(string title,string author, string genre)
        {
            books.Add(new Book()
            {
                Title = title,
                Author = author,
                Genre = genre
            });
        }
        public void RemoveBook(string title)
        {
            var BookToRemove = books.FirstOrDefault(x => x.Title == title);
            if (BookToRemove == null)
            {
                throw new InvalidOperationException("Student with given Id does not exist.");
            }
            books.Remove(BookToRemove);
        }
        public Book searchBook(string title)
        {
            var book = books.FirstOrDefault(x => x.Title == title);
            if (book == null)
            {
                Console.WriteLine($"Книга такое Название {title} нет в спиские !!! ");
            }
            else
            {
                return book;
            }
        }
        public Book searchBook(string title, string author)
        {
            var book = books.FirstOrDefault(x => x.Title == title && x.Author==author);
            if (book == null)
            {
                Console.WriteLine($"Книга такое Название {title} нет в спиские !!! ");
            }
            else
            {
                return book;
            }
        }
    }
}

