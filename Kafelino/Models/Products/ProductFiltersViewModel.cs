using Kafelino.Domain;

namespace Kafelino.Models.Products;

public class ProductFiltersViewModel
{
    public List<TasteNote> TasteNotes { get; set; } = new();
    
    public string TasteNote { get; set; }
    
    public List<Weight> Weights { get; set; } = new();
    
    public int Weight { get; set; }
    
    public List<string> Brands { get; set; } = new();
    
    public string Brand { get; set; }

    public int? MinPrice { get; set; } = 0; 

    public int? MaxPrice { get; set; } = 200;
}