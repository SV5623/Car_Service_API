using System.ComponentModel.DataAnnotations;

namespace boba_API.Models;

public class UserRole
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public int RoleId { get; set; }
    public virtual Role Role { get; set; }
}
