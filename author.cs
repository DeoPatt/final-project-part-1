using System;
using System.Collections.Generic;
 
 class Author : Person
 {
private List<Book> Books = new List<Book>();
public string isbn;
public Author():base(){

}
public void DisplayInfo(){
 Console.WriteLine(FirstName + LastName + Email);
}
public void DisplayBooks(){
   foreach(Book d in Books){
    
d.Display();


  }

}
 public void AddBook(Book b1){
Books.Add(b1);
}
public void RemoveBook(Book b1){
  
  Book b3 = Books.Find(o => o.Isbn == o.Isbn );
  Books.Remove(b1);
}

 }