using Kafelino.Domain;

namespace Kafelino.Models.Products;

public class ProductListingViewModel
{
    public ICollection<TasteNote> TasteNotes { get; set; } = new List<TasteNote>();
    
    public ICollection<Weight> Weights { get; set; } = new List<Weight>();
    
    public ICollection<ProductDetailsViewModel> Products { get; set; }
    
    public int MinPrice { get; set; }

    public int MaxPrice { get; set; } = 1000;
}