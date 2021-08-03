using System;

class MainClass {
  public static void Main (string[] args) {


Author a1 = new Author();
Author a2 = new Author();
a1.FirstName = "dugh";
a1.LastName = "tomp";
a1.DisplayInfo();
a2.FirstName = "larry";
a2.LastName = "Bird";
Book b1 = new Book("122","deo", "patt");
Book b2 = new Book("123","eod", "ttap");
Book b3 = new Book("121","oed", "tapt");
Book b4 = new Book();
Book b5 = new Book(); 
Book b6 = new Book();

b1.AuthorInfo = a1.FirstName ;
b3.AuthorInfo = a1.FirstName;
b5.AuthorInfo = a1.FirstName;
b1.Display();
b3.Display();
b5.Display();
b2.AuthorInfo = a2.FirstName;
b4.AuthorInfo = a2.FirstName;
b6.AuthorInfo = a2.FirstName;
b2.Display();
b4.Display();
b6.Display();


Console.WriteLine("start");

a1.AddBook(b1);
a1.AddBook(b3);
a1.AddBook(b5);
a1.DisplayBooks();
Console.WriteLine("author 2 books");
a2.AddBook(b2);
a2.AddBook(b4);
a2.AddBook(b6);
a2.DisplayBooks();
a1.RemoveBook(b1);
a1.DisplayBooks();
}
}