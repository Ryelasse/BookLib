using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class BookRepository
    {
        public List<Book> books = new List<Book>()
       {
           (new Book(1, "Matematik for idioter", 450)),
           (new Book(2, "Hvordan du får din kæreste til at give dig ret", 300)),
           (new Book(3, "Get Rich", 600)),
           (new Book(4, "skodbogen", 50)),
           (new Book(5, "Stodderen og Millionæren", 200))
       };
       

        public Book Add(Book book)
        {
            books.Add(book);
            return book;
        }

        public List<Book> GetAllBooks()
        {
            return new List<Book>(books);
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }


        public Book GetFilterPrice()
        {
            foreach (var x in books)
            {
                if (250 <= x.Price)
                {
                    return x;
                }
            }
            throw new Exception("Der er ingen bøger der opfylder priskravet");
        }

        public Book GetFilterTitle()
        {
            throw new NotImplementedException();
        }

        public Book? Delete(int id)
        {
            Book? deletedBook = books.Find(a => a.Id == id);
            if (deletedBook != null)
            {
                books.Remove(deletedBook);
            }
            return deletedBook;
        }

        public Book? Update(int id, Book updatedBook)
        {
            
            Book? existingBook = books.Find(b => b.Id == id);

            if (existingBook != null)
            {
                
                existingBook.Title = updatedBook.Title;
                existingBook.Price = updatedBook.Price;

               

                return existingBook;
            }

            throw new ArgumentException("Book not found");
        }




    }
}
