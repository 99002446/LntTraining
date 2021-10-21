using System.ComponentModel.DataAnnotations;

namespace MyBookApp
{
    public class Book
    {
        //public Book(string title, string author, double price)
        //{
        //    Title = title;
        //    Author = author;
        //    Price = price;
        //}
        [Key]
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}