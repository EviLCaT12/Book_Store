using System.ComponentModel.DataAnnotations;

namespace Store.Models;
public class Book
{
    [Key]
    private int Id { get; }
    [Required(ErrorMessage = "Author is required")]
    public Author Author { get; set; }
    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Genre is required")]
    public Genre Genre { get; set; }
    [Required(ErrorMessage = "PublishingHouses is required")]
    public PublishingHouses PublishingHouses { get; set; }
    [Required(ErrorMessage = "PublishedYear is required")]
    [DataType(DataType.Date, ErrorMessage = "Incorrect date")]
    public int PublishedYear { get; set; }
    public int NumberPages { get; set; }
    [Required(ErrorMessage = "ARS is required")]
    [MaxLength(4, ErrorMessage = "Max lenght = 4"), MinLength(2, ErrorMessage = "Min lenght = 2")]
    public string ARS { get; set; }
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Price is required")]
    [DataType(DataType.Currency)] 
    public int Price { get; set; }
    public Comment Comment { get; set; }
    
    public Book(
        int id, Author author, string title, Genre genre, PublishingHouses publishingHouses,
        int publishedYear, int numberPages, string ars, string description,
        int price, Comment comment)
    {
        Id = id;
        Author = author;
        Title = title;
        Genre = genre;
        PublishingHouses = publishingHouses;
        PublishedYear = publishedYear;
        NumberPages = numberPages;
        ARS = ars;
        Description = description;
        Price = price;
        Comment = comment;
    }
    
    
}