using Kafelino.Domain;

namespace Kafelino.Models.Products;

public class ProductListingViewModel
{
    public int ProductId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string ImageUrl { get; set; }
    
    public int Quantity { get; set; }
    
    public decimal Price { get; set; }

    public string Brand { get; set; }
    
    public Weight Weight { get; set; }
    
    public ICollection<TasteNote> TasteNotes { get; set; } = new HashSet<TasteNote>();
}