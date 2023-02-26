using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Kintaiapp.Models;

public class Kintai
{
    public int Id { get; set; }
    public string? status { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string? Rest { get; set; }
    private string? workTime;

    public string? WorkTime 
    {
        get { return workTime; }
        set 
        { 
            TimeSpan ts = (End - Start) - TimeSpan.Parse(Rest);
            workTime = ts.ToString(@"hh\:mm");
        }
    }
}