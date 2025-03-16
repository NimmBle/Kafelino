using Kafelino.Domain;

namespace Kafelino.Models.Products;

public class CreateProductInputModel
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public IFormFile Image { get; set; }
    
    public decimal Price { get; set; }
    
    public int Quantity { get; set; }

    public string Brand { get; set; }
    
    public ICollection<int> TasteNoteIds { get; set; } = new List<int>();
}