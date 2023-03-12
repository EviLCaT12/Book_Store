using System.ComponentModel.DataAnnotations;

namespace Store.Models;

public class Comment
{
    [Key]
    private int Id { get; }
    [Required(ErrorMessage = "Author is required")]
    public User Author { get; set; }
    [DataType(DataType.Date, ErrorMessage = "Incorrect date")]
    [Required(ErrorMessage = "Date is required")]
    public DateOnly Date { get; set; }
    [Required(ErrorMessage = "Book is required")]
    public Book Book { get; set; }
    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }
    public int Rating { get; set; }

    public Comment(int id, User author, DateOnly date, Book book, string title, string description, int rating)
    {
        Id = id;
        Author = author;
        Date = date;
        Book = book;
        Title = title;
        Description = description;
        Rating = rating;
    }
}