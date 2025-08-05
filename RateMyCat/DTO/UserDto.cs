namespace RateMyCat.DTO;

public class UserGetDto
{
    public int Id { get; set; }
    public string UserName { get; set; } = null!;
}

public class UserCreateDto
{
    public string UserName { get; set; } = null!;
}

public class UserUpdateDto
{
    public int Id { get; set; }
    public string UserName { get; set; } = null!;
}