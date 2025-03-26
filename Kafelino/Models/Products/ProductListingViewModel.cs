using Kafelino.Domain;

namespace Kafelino.Models.Products;

public class ProductListingViewModel
{
    public ProductFiltersViewModel Filters { get; set; }
    
    public ICollection<ProductDetailsViewModel> Products { get; set; }
    

}