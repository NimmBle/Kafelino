using System.ComponentModel;

namespace Kafelino.Domain;

public class Weight
{
    public int WeightId { get; set; }
    
    [DisplayName("Стойност")]
    public int Value { get; set; }
    
    [DisplayName("Мерна единица")]
    public string Unit { get; set; }
    
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}