using Kafelino.Domain;

namespace Kafelino.Models.Products;

public class ProductDetailsViewModel
{
    public int ProductId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string ImageUrl { get; set; }
    
    public decimal Price { get; set; }
    
    public int Quantity { get; set; }
    
    public string Brand { get; set; }

    public bool ProductInCart { get; set; } = false;

    public bool IsDeleted { get; set; } = false;
    
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    
    public int WeightId { get; set; }
    public Weight Weights { get; set; }
    
    public ICollection<TasteNote> TasteNotes { get; set; } = new HashSet<TasteNote>();

    public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();

}