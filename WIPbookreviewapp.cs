// objective: app for booktracking

// collect book name and author

using System.ComponentModel.Design;

string? bookName;
string? bookAuthor;
bool addBook = true;

Console.WriteLine("Welcome to your book library, let's start by adding a new book");

do {
Console.WriteLine("What is the name of the book?");
    bookName = Console.ReadLine();
    
Console.WriteLine($"What is the author of the book {bookName}?");
bookAuthor = Console.ReadLine();
if ((bookAuthor.Length <= 1) ||  (bookName.Length <= 1))
{
    Console.WriteLine("please enter a valid author and book name");
        continue;
}

// add rating from 1 to 5
int bookRating;
Console.WriteLine($"please rate the book {bookName} by {bookAuthor} with a number between 1 and 5");
string Rating = Console.ReadLine();
bookRating = Convert.ToInt32(Rating);
    if (bookRating > 5) bookRating = 5;
    else if (bookRating <= 0) bookRating = 1;
    
Console.WriteLine($"Book name= {bookName}; Book Author = {bookAuthor}; Book Rating = {bookRating}");


// add starting and finishing date

// add small review
string bookReview;
Console.WriteLine("Do you want to add a review? 1. yes, 2. no");
string answerReview = Console.ReadLine();
switch(answerReview)
{
    case "1":
        Console.WriteLine("Please add your review:");
        bookReview = Console.ReadLine();
        break;
        case "2":
        break;
    default:
        break;
}


    // add book type 

    // populate a spreadsheet/ csv file

 
    // adding another review

    Console.WriteLine("Do you want to add another review? 1. yes 2. no");
    string answerNewBook = Console.ReadLine();
    switch(answerNewBook)
    {
        case "1":
            continue;
        case "2":
            Console.WriteLine("goodbye");
            addBook = false;
            continue;
        default:
            break;
            
    }
// make an gui
}while (addBook == true);  
