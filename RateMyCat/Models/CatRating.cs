using System.ComponentModel.DataAnnotations.Schema;

namespace RateMyCat.Models;

public class CatRating
{
    public int Id { get; set; }
    public DateTime RatedAt { get; set; } =  DateTime.Now;
    
    public int? CatId { get; set; }
    public Cat? Cat { get; set; }
    
    public int? CatPartId { get; set; }
    public CatPart? CatPart { get; set; }

    public int? UserId { get; set; }
    public User? User { get; set; }
}