namespace AuthMs.Controllers;

public class UserListResponse
{
    public required int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateTime CreatedAt { get; set; }
}
