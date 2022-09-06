namespace AvaliacaoLP3.ViewModels;

public class Shopping
{
    public int Id { get; set; }
    public string Floor { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Store { get; set; }
    public string Email { get; set; }

    public Shopping(int id, string floor, string name, string description, string store, string email)
    {
        Id = id;
        Floor = floor;
        Name = name;
        Description = description;
        Store = store;
        Email = email;
    }
}