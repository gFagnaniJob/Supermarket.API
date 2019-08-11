using System.ComponentModel.DataAnnotations;

namespace Supermarket.API.Resources
{
  public class SaveProductResource
  {
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required]
    [Range(0,100)]
    public int QuantityInPackage { get; set; }

    [Required]
    [Range(1,5)]
    public string UnitOfMeasurement { get; set; }

    [Required]
    public int CategoryId { get; set; }
  }
}