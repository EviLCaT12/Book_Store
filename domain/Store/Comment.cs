namespace Store;

public class Comment
{
    private int Id { get; }
    public User Author { get; set; }
    public DateOnly Date { get; set; }
    public Book Book { get; set; }
    public string Title { get; set; }
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