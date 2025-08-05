namespace RateMyCat.DTO;

public class CatRatingGetDto
{
    public int Id { get; set; }
    public DateTime RatedAt { get; set; }
    
    public int? CatId { get; set; }
    public CatGetDto? Cat { get; set; }
    
    public int? CatPartId { get; set; }
    public CatPartGetDto? CatPart { get; set; }

    public int? UserId { get; set; }
    public UserGetDto? User { get; set; }
}

public class CatRatingCreateDto
{
    public int? CatId { get; set; }
    public int? CatPartId { get; set; }
    public int? UserId { get; set; }
}
