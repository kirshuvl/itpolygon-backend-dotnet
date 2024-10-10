using System.ComponentModel.DataAnnotations;
using Common.Data.Models.Base;

namespace Common.Data.Models.Users;

public class UserEntity : BaseEntity
{
    [Required]
    [Display(Name = "Имя")]
    public required string FirstName { get; set; }

    [Required]
    [Display(Name = "Фамилия")]
    public required string LastName { get; set; }

    [Required]
    [Display(Name = "Электронная почта")]
    public required string Email { get; set; }

    [Required]
    [Display(Name = "Хэш пароля")]
    public required string PasswordHash { get; set; }
}