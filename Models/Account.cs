using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace Kintaiapp.Models;

public class Account
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter your email address.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Please enter your password.")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}