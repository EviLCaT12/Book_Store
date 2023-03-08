namespace Store;

public class PublishingHouses
{
    private int Id { get; }
    public string Title { get; set; }
    public string Adress { get; set; }
    public string Phone { get; set; }
    public string Description { get; set; }

    public PublishingHouses(int id, string title, string adress, string phone, string description)
    {
        Id = id;
        Title = title;
        Adress = adress;
        Phone = phone;
        Description = description;
    }
}