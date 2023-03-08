using System.ComponentModel.DataAnnotations;

namespace Store;

public class User
{
    private int Id { get; }
    public string FullName { get; set; }
    public string Password { get; set; }
    public DateOnly BirthDay { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public List<Book> ListFavoriteBook { get; set; }

    public User(int id, string fullName, string password, DateOnly birthday, string phone, string email)
    {
        Id = id;
        FullName = fullName;
        Password = password;
        BirthDay = birthday;
        Phone = phone;
        Email = email;
    }
}