using System.ComponentModel.DataAnnotations;

namespace Store.Models;

public class Genre
{

    [Key]
    private int Id { get; }

    [Required]
    [StringLength(100, ErrorMessage = "Title must be between 1 and 100 characters", MinimumLength = 1)]
    public string Title { get; set; }

    [StringLength(500, ErrorMessage = "Description must be between 1 and 500 characters", MinimumLength = 1)]
    public string Description { get; set; }

    public Genre(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }
}