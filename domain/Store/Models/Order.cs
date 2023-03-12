using System.ComponentModel.DataAnnotations;

namespace Store.Models;

public class Order
{

    [Key]
    private int Id { get; }

    [Required]
    public User User { get; set; }

    [Required]
    public DateOnly Date { get; set; }

    [Required]
    public List<Book> ListOfBook { get; set; }

    [Required]
    public string Status { get; set; }

    public Order(int id, User user, DateOnly date, List<Book> listOfBook, string status)
    {
        Id = id;
        User = user;
        Date = date;
        ListOfBook = listOfBook;
        Status = status;
    }
}