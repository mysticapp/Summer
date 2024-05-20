using Summer.DAL.Entities.Base;

namespace Summer.DAL.Entities.User;

public class User : BaseAuditableEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}