using System.ComponentModel.DataAnnotations;

namespace Store;

public class PublishingHouses
{
    [Key]
    private int Id { get; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title must be between 1 and 100 characters", MinimumLength = 1)]
    public string Title { get; set; }

    [Required(ErrorMessage = "Address is required")] 
    [StringLength(200, ErrorMessage = "Address must be between 1 and 200 characters", MinimumLength = 1)]
    public string Adress { get; set; }

    [Required(ErrorMessage = "Phone is required")]
    [RegularExpression(@"^(\+7|7|8){1}\ ?\(?[0-9]{3}\)?\ ?[0-9]{3}\ ?\-?\ ?[0-9]{2}\ ?\-?\ ?[0-9]{2}$", ErrorMessage = "Incorrect phone number")]
    public string Phone { get; set; }

    [StringLength(500, ErrorMessage = "Description must be between 1 and 500 characters", MinimumLength = 1)]
    public string Description { get; set; }

    public PublishingHouses(int id, string title, string adress, string phone, string description)
    {
        Id = id;
        Title = title;
        Adress = adress;
        Phone = Sanitizers.PhoneSanitizer.Sanitize(phone);
        Description = description;
    }
}