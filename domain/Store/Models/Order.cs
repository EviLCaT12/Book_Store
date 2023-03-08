namespace Store;

public class Order
{
    private int Id { get; }
    public User User { get; set; }
    public DateOnly Date { get; set; }
    public List<Book> ListOfBook { get; set; }
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