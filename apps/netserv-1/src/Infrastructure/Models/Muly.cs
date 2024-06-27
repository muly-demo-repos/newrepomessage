using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Netserv1.Infrastructure.Models;

[Table("Mulies")]
public class MulyDbModel
{
    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? F1 { get; set; }

    [StringLength(1000)]
    public string? F2 { get; set; }
}
