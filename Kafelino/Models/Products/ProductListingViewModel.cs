using Kafelino.Domain;

namespace Kafelino.Models.Products;

public class ProductListingViewModel
{
    public ProductFiltersViewModel Filters { get; set; }
    
    public ICollection<ProductViewModel> Products { get; set; }
    
    public string sortedBy { get; set; }
    

}