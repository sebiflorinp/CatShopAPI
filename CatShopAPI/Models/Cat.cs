using System.ComponentModel.DataAnnotations;

namespace CatShopAPI.Models;

public class Cat
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string FurColor { get; set; } = null!;
    public int Age { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime? AvailableFrom { get; set; } = DateTime.Now;
    public DateTime? SoldOn { get; set; }
}