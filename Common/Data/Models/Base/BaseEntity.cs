using System.ComponentModel.DataAnnotations;

namespace Common.Data.Models.Base;

public class BaseEntity
{
    [Key]
    [Display(Name = "Идентификатор")]
    public int Id { get; set; } = default!;

    [Required]
    [Display(Name = "Дата создания")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    [Display(Name = "Дата обновления")]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
