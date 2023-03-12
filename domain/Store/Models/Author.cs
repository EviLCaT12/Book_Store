using System.ComponentModel.DataAnnotations;
namespace Store.Models;

public class Author
{
    [Key]
    private int Id { get; }
    [Required(ErrorMessage = "Full name is required")]
    public string Fullname { get; set; }
    [DataType(DataType.Date, ErrorMessage = "Incorrect date")]
    [Required(ErrorMessage = "Years of life is required")]
    public DateOnly YearsOfLife { get; set;}
    public List<Genre> ListOfGenre { get; set; }
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }
    public List<Book> ListOfBook { get; set; }

    public Author(int id, string fullname, DateOnly yearsOfLife, List<Genre> listOfGenre, string description,
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