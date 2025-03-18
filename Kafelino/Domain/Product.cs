namespace Kafelino.Domain;

public class Product
{
    public int ProductId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string ImageUrl { get; set; }
    
    public decimal Price { get; set; }
    
    public int Quantity { get; set; }

    public string Brand { get; set; }

    public bool IsDeleted { get; set; } = false;
    
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    
    public int WeightId { get; set; }
    public Weight Weight { get; set; }
    
    public ICollection<TasteNote> TasteNotes { get; set; } = new HashSet<TasteNote>();

    public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
    
    public ICollection<User> Users { get; set; } = new HashSet<User>();
}