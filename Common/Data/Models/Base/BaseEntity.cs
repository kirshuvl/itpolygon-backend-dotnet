using System.ComponentModel.DataAnnotations;

namespace Common.Data.Models.Base;

public class BaseEntity
{
    [Key]
    [Display(Name = "Идентификатор")]
    public required int Id { get; set; }

    [Required]
    [Display(Name = "Дата создания")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;

    [Required]
    [Display(Name = "Дата обновления")]
    public required DateTime UpdatedAt { get; set; } = DateTime.Now;
}
