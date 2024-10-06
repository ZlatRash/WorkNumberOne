using System.ComponentModel.DataAnnotations;

namespace WorkNumberOne.Models.data.user;

public class User
{
    [Key] 
    public long Id { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public int Age { get; set; }
    public bool Married { get; set; }
    public GenderType Gender { get; set; }
}