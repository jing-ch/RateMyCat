using RateMyCat.Models;

namespace RateMyCat.DTO;

public class CatGetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Color { get; set; }
    
    public int? OwnerId { get; set; }
    public UserGetDto? Owner { get; set; }
}

public class CatCreateDto
{
    public string Name { get; set; } = null!;
    public string? Color { get; set; }
    
    public int? OwnerId { get; set; }
    
}

public class CatUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Color { get; set; }
}

