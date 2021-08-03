using System;


class Book{
public string Isbn{get;set;}
public string Title{get;set;}
public string AuthorInfo{get;set;}
public DateTime Publishedon{get;set;}
public string Publsihedby {get;set;}


public Book() : this("","",""){
Publishedon = DateTime.Today;
Publsihedby = "Unknown";
Isbn = "unknown";
AuthorInfo = "unknown";
Title = "unknown";

}
public Book(string IsbnofBook, string TitleofBook, string Author){
  Isbn = IsbnofBook;
Title = TitleofBook;
AuthorInfo = Author;
Publishedon = DateTime.Today;
Publsihedby = "";
}

public void Display(){

  Console.WriteLine("Book " + Title + " was written by " + AuthorInfo + " and published on " + Publishedon);
}



}