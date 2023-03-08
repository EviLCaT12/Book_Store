namespace Store;

public class Genre
{
    private int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }

    public Genre(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }
}