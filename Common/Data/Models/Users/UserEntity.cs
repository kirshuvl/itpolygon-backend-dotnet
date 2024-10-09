using System.ComponentModel.DataAnnotations;
using Common.Data.Models.Base;

namespace Common.Data.Models.Users;

public class UserEntity : BaseEntity
{
    [Required]
    [Display(Name = "Имя пользователя")]
    public required string UserName { get; set; }

    [Required]
    [Display(Name = "Электронная почта")]
    public required string Email { get; set; }

    [Required]
    [Display(Name = "Хэш пароля")]
    public required string PasswordHash { get; set; }
}