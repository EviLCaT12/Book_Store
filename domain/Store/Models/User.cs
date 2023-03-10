using System.ComponentModel.DataAnnotations;

namespace Store;

public class User
{
    [Key]
    private int Id { get; }

    [Required(ErrorMessage = "Full Name is required")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Birth Day is required")]
    [DataType(DataType.Date, ErrorMessage = "Incorrect date")]
    public DateOnly BirthDay { get; set; }

    [Required(ErrorMessage = "Phone is required")]
    [RegularExpression(@"^(\+7|7|8){1}\ ?\(?[0-9]{3}\)?\ ?[0-9]{3}\ ?\-?\ ?[0-9]{2}\ ?\-?\ ?[0-9]{2}$", ErrorMessage = "Incorrect phone number")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Incorrect email address")]
    public string Email { get; set; }


    public List<Book> ?ListFavoriteBook { get; set; }

    public User(int id, string fullName, string password, DateOnly birthday, string phone, string email)
    {
        Id = id;
        FullName = fullName;
        Password = password;
        BirthDay = birthday;
        Phone = Sanitizers.PhoneSanitizer.Sanitize(phone);
        Email = email;
    }
}