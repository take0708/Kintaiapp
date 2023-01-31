using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Kintaiapp.Models;

public class Kintaiapp
{
    public int Id { get; set; }
    public string? status { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string? Rest { get; set; }
    public DateTime WorkTime { get; set; }
}