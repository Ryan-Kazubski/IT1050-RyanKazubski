using System;

namespace Lab07
{
    class Program
    {


        static void Main(string[] args)
        {
            Book book1 = new Book("A Tale of Two Cities", "Charles Dickens", "1859");
            book1.Display();

            BookTest book2 = new BookTest("House of Hades", "Rick Riordan", "2013");
            book2.Display();
        }
    }


    class Book
    {
        public string Title;
        public string Author;
        public string Year;

        public Book(string Title, string Author, string Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
        }

        public void title(string Title)
        {
            this.Title = Title;
        }

        public void author(string Author)
        {
            this.Author = Author;
        }

        public void year(string Year)
        {
            this.Year = Year;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Title: {this.Title}\n" +
                $"Author: {this.Author}\n" +
                $"Year: {this.Year}\n");
        }


    }
    class BookTest
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public BookTest(string Title, string Author, string Year)
            {
                this.Title = Title;
                this.Author = Author;
                this.Year = Year;
            }
        public void Display()
        {
            Console.WriteLine(
                $"Title: {this.Title}\n" +
                $"Author: {this.Author}\n" +
                $"Year: {this.Year}\n");
        }
    }

    /* 3.) We are creating an object that will go and retrieve our variables and returns from our methods and constructors.
     * 4.)we would be practicing object orientd coding.
     * 5.)The core advantage of exception handling is to maintain the normal flow of the application. An exception normally disrupts the normal flow of the application that is why we use exception handling.
     * 6.) private allows you to hide things in methods and propertities while public gives you the freedom to use those anyhwere elde.
     * 7.) It describes a class that references one or more objects of other classes in instance variables. This allows you to model a has-a association between objects. would allow our code to repeat things in other methods without retyping it.
     * 8.) Data abstraction refers to providing only essential information to the outside world and hiding their background details, i.e., to represent the needed information in program without presenting the details.
     */






}

