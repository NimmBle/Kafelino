using Kafelino.Models.Products;
using Kafelino.Models.Users;

namespace Kafelino.Models.Orders;

public class OrderDetailsOutputModel
{
    public int Id { get; set; }

    public string UserId { get; set; }

    public UserDetailsViewModel User { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public decimal TotalSum { get; set; }

    public List<ProductDetailsViewModel> Products { get; set; }
}