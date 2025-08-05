using System.ComponentModel.DataAnnotations.Schema;

namespace RateMyCat.Models;

public class Cat
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Color { get; set; }
    
    public int? OwnerId { get; set; }
    public User? Owner { get; set; }

    public ICollection<CatRating>? CatRatings { get; set; }
}