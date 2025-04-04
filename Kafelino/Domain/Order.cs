using System.Runtime.InteropServices.JavaScript;

namespace Kafelino.Domain;

public class Order
{
    public int OrderId { get; set; }

    public string UserId { get; set; }

    public User User { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public decimal TotalSum { get; set; }
    
    public DateOnly CreatedOnDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    
    public DateOnly DeliveryDate { get; set; } = DateOnly.FromDateTime(DateTime.Now.AddDays(3));

    public ICollection<OrderProduct> OrderProducts { get; set; } = new HashSet<OrderProduct>();
}