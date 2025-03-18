using System.Security.Claims;
using Kafelino.Data;
using Kafelino.Domain;
using Kafelino.Models.Orders;
using Kafelino.Models.Products;
using Kafelino.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kafelino.Controllers;

public class OrdersController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly KafelinoDbContext _context;

    public OrdersController(UserManager<User> userManager, KafelinoDbContext context)
    {
        this._userManager = userManager;
        this._context = context;
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Overview()
    {
        var user = await this._userManager.GetUserAsync(User);

        var productIds = user.Cart
            .Split("; ")
            .Where(p => p != "")
            .Select(int.Parse);

        var model = new CreateOrderInputModel();

        foreach (var productId in productIds)
        {
            var product = await this._context.Products
                .Where(p => p.ProductId == productId)
                .Select(p => new ProductDetailsViewModel()
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    Brand = p.Brand,
                    Weights = p.Weight,
                    TasteNotes = p.TasteNotes,
                })
                .FirstOrDefaultAsync();

            model.Products.Add(product);

            model.TotalPrice += product.Price;
        }

        return View(model);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(CreateOrderInputModel input)
    {
        var user = await this._userManager.GetUserAsync(User);

        var productIds = user.Cart
            .Split("; ")
            .Where(p => p != "")
            .Select(int.Parse);

        var order = new Order()
        {
            TotalSum = input.TotalPrice,
            Address = input.Address,
            PhoneNumber = input.PhoneNumber,
            UserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value
        };

        await this._context.Orders.AddAsync(order);
        await this._context.SaveChangesAsync();

        foreach (var id in productIds)
        {
            var product = await this._context.Products
                .SingleOrDefaultAsync(p => p.ProductId == id);

            product.Quantity--;

            if (product.Quantity == 0)
            {
                await this._context.Users.ForEachAsync(u =>
                {
                    var products = u.Cart
                        .Split("; ")
                        .Where(p => p != "" && p != id.ToString())
                        .ToList();

                    u.Cart = string.Join("; ", products);
                });
            }

            var orderProduct = new OrderProduct()
            {
                OrderId = order.OrderId,
                ProductId = id,
            };

            await this._context.OrderProducts.AddAsync(orderProduct);
        }

        user.Cart = "";

        await this._context.SaveChangesAsync();

        return RedirectToAction("Confirmation");
    }

    [HttpGet]
    [Authorize]
    public IActionResult Confirmation()
    {
        return this.View();
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> All()
    {
        var orders = await this._context.Orders
            .Select(o => new OrderDetailsOutputModel()
            {
                Id = o.OrderId,
                TotalSum = o.TotalSum,
                Address = o.Address,
                PhoneNumber = o.PhoneNumber,
                UserId = o.UserId,
                User = this._context.Users
                    .Where(u => u.Id == o.UserId)
                    .Select(u => new UserDetailsViewModel()
                    {
                        UserId = u.Id,
                        Name = u.FirstName  + " " + u.LastName,
                        Email = u.Email
                    })
                    .SingleOrDefault(),
                Products = new List<ProductDetailsViewModel>()
            })
            .ToListAsync();

        foreach (var order in orders)
        {
            var orderProducts = await this._context.OrderProducts
                .Where(op => op.OrderId == order.Id)
                .ToListAsync();

            foreach (var orderProduct in orderProducts)
            {
                var product = await this._context.Products
                    .Where(p => p.ProductId == orderProduct.ProductId)
                    .Select(p => new ProductDetailsViewModel()
                    {
                        ProductId = p.ProductId,
                        Name = p.Name,
                        Description = p.Description,
                        ImageUrl = p.ImageUrl,
                        Price = p.Price,
                        Quantity = p.Quantity,
                        Brand = p.Brand,
                        Weights = p.Weight,
                        TasteNotes = p.TasteNotes,
                    })
                    .FirstOrDefaultAsync();

                order.Products.Add(product);
            }
        }

        return this.View(orders);
    }

}