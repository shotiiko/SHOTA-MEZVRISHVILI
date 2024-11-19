using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp1
{
    public class Library
    {
        
        private Book[] book = new Book[4];
        public int Countproperty = 0;
        public int Count()

        {
            return Countproperty;
        }

        public void AddBook(Book books)
        {
            if (Countproperty < book.Length)
            {
                book[Countproperty++] = books;
            }
            else
            {
                Console.WriteLine("limiti amotsurulia");
            }
        }
        public void PrintBooks()
        {
            for (int i = 0; i < Countproperty; i++)
            {
                Console.WriteLine($"sakheli: {book[i].Title} ; AVTORI: {book[i].Author} ");
            }
        }
        public void RemoveBook(string title)
        {
            bool found = false;
            for (int i = 0; i < Countproperty; i++)
            {
                if (book[i].Title == title)
                {
                    for (int j = i; j < Countproperty - 1; j++)
                    {
                        book[j] = book[j + 1];
                    }
                    book[--Countproperty] = null;
                    found = true;
                    Console.WriteLine($"Book '{title}' RemoveBook. ");
                    i--;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Book'{title}' ar arsebobs. ");
            }
        }

        public void FindBook(string title)
        {
            bool found = false;
            for (int i = 0; i < Countproperty; i++)
            {
                if (book[i].Title == title)
                {
                    Console.WriteLine($"FindBook: {book[i].Title} : {book[i].Author} ");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"book'{title}' ar arsebobs.");
            }
        }
    }


}

   