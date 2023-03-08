using System;
namespace Store;

public class Author
{
    private int Id { get; }
    public string Fullname { get; set; }
    public string YearsOfLife { get; set;}
    public List<Genre> ListOfGenre { get; set; }
    public string Description { get; set; }
    public List<Book> ListOfBook { get; set; }

    public Author(int id, string fullname, string yearsOfLife, List<Genre> listOfGenre, string description,
        List<Book> listOfBook)
    {
        Id = id;
        Fullname = fullname;
        YearsOfLife = yearsOfLife;
        ListOfGenre = listOfGenre;
        Description = description;
        ListOfBook = listOfBook;
    }
}