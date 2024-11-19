using ConsoleApp1;
using System;

Library library = new Library();

library.AddBook(new Book("dasakheleba1", "avtori1", 1900));
library.AddBook(new Book("dasakheleba2", "avtori2", 1900));
library.AddBook(new Book("dasakheleba3", "avtori3", 1900));
library.AddBook(new Book("dasakheleba4", "avtori4", 1900));



Console.WriteLine("Countproperty: " + library.Countproperty + " book ");
Console.WriteLine("\nchamonatvali: \n ");
library.PrintBooks();

Console.WriteLine("\nremovebook: \n ");
library.RemoveBook(Console.ReadLine());
Console.WriteLine("newlibrary: " + library.Countproperty + " book ");
Console.WriteLine("\nnew chamonatvali:\n ");
library.PrintBooks();



Console.WriteLine("\nfindbook: \n");
library.FindBook(Console.ReadLine());


