using System.ComponentModel.DataAnnotations.Schema;
using RateMyCat.DTO;

namespace RateMyCat.Models;

public class Cat
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Color { get; set; }
    
    public int? OwnerId { get; set; }
    public User? Owner { get; set; }

    public ICollection<CatRating>? CatRatings { get; set; }
    
    public CatGetDto ToGetDto() =>
        new CatGetDto
        {
            Id = this.Id,
            Name = this.Name,
            Color = this.Color
        };

    public Cat FromCreateDto(CatCreateDto catCreateDto) =>
        new Cat
        {
            Name = catCreateDto.Name,
            Color = catCreateDto.Color,
            OwnerId = catCreateDto.OwnerId
        };
}