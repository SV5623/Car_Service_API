using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace boba_API.Models;

public class WorkType 
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }    
    
    public List<MechaniсWorkType> MechanicWorkTypes { get; set; }
}