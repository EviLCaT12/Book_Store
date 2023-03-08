using System;
namespace Store;
public class Book
{
    private int Id { get; }
    public Author Author { get; set; }
    public string Title { get; set; }
    public Genre Genre { get; set; }
    public PublishingHouses PublishingHouses { get; set; }
    public int PublishedYear { get; set; }
    public int NumberPages { get; set; }
    public string ARS { get; set; }
    public string Description { get; set; }
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