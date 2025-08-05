namespace RateMyCat.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = null!;
    
    public ICollection<Cat>? Cats { get; set; }
    public ICollection<CatRating>? CatRatings { get; set; }
}