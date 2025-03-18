using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kafelino.Data;
using Kafelino.Domain;
using Kafelino.Models.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Kafelino.Controllers
{
    public class ProductsController : Controller
    {
        private readonly KafelinoDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<User> _userManager;

        public ProductsController(KafelinoDbContext context,
            IWebHostEnvironment webhostEnvironment,
            UserManager<User> userManager)
        {
            _context = context;
            _webHostEnvironment = webhostEnvironment;
            _userManager = userManager;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products
                .Include(p => p.TasteNotes)
                .Include(p => p.Weight)
                .ToListAsync();

            Console.WriteLine(User);
            
            return View(products);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            var tasteNotes = _context.TasteNotes.ToList();
            var weights = _context.Weights.ToList();
            var model = new CreateProductInputModel
            {
                TasteNoteIds = new List<int>()
            };
            ViewBag.Weights = weights; 
            ViewBag.TasteNotes = tasteNotes;
            return View(model);
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.TasteNotes = _context.TasteNotes.ToList();
                ViewBag.Weights = _context.Weights.ToList();
                return View(inputModel);
            }

            var fileName = UploadImage(inputModel.Image);

            var product = new Product
            {
                Name = inputModel.Name,
                Description = inputModel.Description,
                ImageUrl = fileName,
                Price = inputModel.Price,
                Brand = inputModel.Brand,
                Quantity = inputModel.Quantity,
                WeightId = inputModel.WeightId,
                TasteNotes = new List<TasteNote>()
            };
            
            if (inputModel.TasteNoteIds != null && inputModel.TasteNoteIds.Any())
            {
                product.TasteNotes = _context.TasteNotes
                    .Where(tn => inputModel.TasteNoteIds.Contains(tn.TasteNoteId))
                    .ToList();
            }
            
            _context.Add(product);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
            
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var tasteNotes = _context.TasteNotes.ToList();
            var weights = _context.Weights.ToList();
            ViewBag.Weights = weights; 
            ViewBag.TasteNotes = tasteNotes;
            
            var product = await _context.Products
                .Where(p => p.ProductId == id)
                .Select(p => new EditProductInputModel
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Brand = p.Brand,
                    Quantity = p.Quantity,
                    TasteNoteIds = p.TasteNotes.Select(t => t.TasteNoteId).ToList(),
                    WeightId = p.WeightId,
                })
                .FirstOrDefaultAsync();
            
            if (product == null)
            {
                return NotFound();
            }
            
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, EditProductInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.TasteNotes = _context.TasteNotes.ToList();
                ViewBag.Weights = _context.Weights.ToList();
                return View(inputModel);
            }
            
            var product = await _context.Products
                .Where(p => p.ProductId == id)
                .Include(p => p.TasteNotes)
                .FirstOrDefaultAsync();

            if (product is null)
            {
                return NotFound();
            }

            if (inputModel.Image is not null)
            {
                var fileName = UploadImage(inputModel.Image);
                product.ImageUrl = fileName;
            }
            
            product.Name = inputModel.Name;
            product.Description = inputModel.Description;
            product.Price = inputModel.Price;
            product.Brand = inputModel.Brand;
            product.Quantity = inputModel.Quantity;
            product.WeightId = inputModel.WeightId;
            
            if (inputModel.TasteNoteIds != null && inputModel.TasteNoteIds.Any())
            {
                product.TasteNotes.Clear();
                
                product.TasteNotes = _context.TasteNotes
                    .Where(tn => inputModel.TasteNoteIds.Contains(tn.TasteNoteId))
                    .ToList();
            }

            _context.Update(product);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddToCart(int productId)
        {
            var user = await this._userManager.GetUserAsync(User);

            var productsInCart = user.Cart.Split("; ").Where(p => p != "").ToList();

            if (!productsInCart.Contains(productId.ToString()))
            {
                productsInCart.Add(productId.ToString());
            }
        
            user.Cart = string.Join("; ", productsInCart);

            await this._context.SaveChangesAsync();

            return RedirectToAction("Details", "Products", new { Id = productId });
        }
        
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> RemoveFromCart(string id)
        {
            var user = await this._userManager.GetUserAsync(User);

            var products = user.Cart.Split("; ").Where(p => p != "").ToList();

            products.Remove(id);

            user.Cart = string.Join("; ", products);

            await this._context.SaveChangesAsync();

            return RedirectToAction("Details", "Products", new { Id = id });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Cart()
        {
            var user = await this._userManager.GetUserAsync(User);

            var products = user.Cart.Split("; ").Where(p => p != "").ToList();

            
            var productInCart = await _context.Products
                .Where(p => products.Contains(p.ProductId.ToString()))
                .ToListAsync();
            
            return View(productInCart);
        }
        
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        private string UploadImage(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                // Създаване на уникално име за файла
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            
                // Път към папката wwwroot/Image
                string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "Images");

                // Увери се, че папката съществува
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                string filePath = Path.Combine(uploadPath, fileName);

                // Запис на файла чрез FileStream
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return fileName; // Връща името на файла, което ще запазим в базата
            }

            return "";
        }
    }
}
