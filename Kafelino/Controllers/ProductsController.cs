using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kafelino.Data;
using Kafelino.Domain;
using Kafelino.Models.Products;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kafelino.Controllers
{
    public class ProductsController : Controller
    {
        private readonly KafelinoDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(KafelinoDbContext context,
            IWebHostEnvironment webhostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webhostEnvironment;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
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
            var model = new CreateProductInputModel
            {
                TasteNoteIds = new List<int>()
            };
            
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
                    TasteNoteIds = p.TasteNotes.Select(t => t.TasteNoteId).ToList()
                })
                .FirstOrDefaultAsync();
            
            if (product == null)
            {
                return NotFound();
            }
            
            var tasteNotes = _context.TasteNotes.ToList();
            ViewBag.TasteNotes = tasteNotes;
            
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, EditProductInputModel inputModel)
        {
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
