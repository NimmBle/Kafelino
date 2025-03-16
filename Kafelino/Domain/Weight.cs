namespace Kafelino.Domain;

public class Weight
{
    public int WeightId { get; set; }
    
    public int Value { get; set; }
    
    public string Unit { get; set; }
    
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}