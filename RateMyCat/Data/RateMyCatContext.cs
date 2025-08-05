using RateMyCat.Models;

using Microsoft.EntityFrameworkCore;

namespace RateMyCat.Data;

public class RateMyCatContext(DbContextOptions<RateMyCatContext> options) : DbContext(options)
{
    public DbSet<Cat> Cats { get; set; } =  null!;
    public DbSet<User> Users { get; set; } =  null!;
    public DbSet<CatRating> CatRatings { get; set; } =  null!;
    public DbSet<CatPart> CatParts { get; set; } =  null!;
}