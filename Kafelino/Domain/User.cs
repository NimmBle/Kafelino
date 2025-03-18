using Microsoft.AspNetCore.Identity;

namespace Kafelino.Domain;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    // public string Cart { get; set; } = "";
    
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    
    public ICollection<Product> Products { get; set; } = new List<Product>();
}