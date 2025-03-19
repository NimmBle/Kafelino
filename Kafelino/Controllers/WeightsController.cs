using Kafelino.Data;
using Kafelino.Domain;
using Kafelino.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kafelino.Controllers;

public class WeightsController(KafelinoDbContext _context) : Controller
{
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> All()
    {
        var tasteNotes = await _context.Weights
            .Select(w => new WeightViewModel
            {
                WeightId = w.WeightId,
                Value = w.Value,
                Unit = w.Unit,
            })
            .OrderBy(w => w.Unit)
            .ThenBy(w => w.Value)
            .ToListAsync();
        
        return View(tasteNotes);
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create()
    {
        return View();
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create(WeightViewModel viewModel)
    {
        var weight = new Weight
        {
            Value = viewModel.Value,
            Unit = viewModel.Unit,
        };
        
        _context.Weights.Add(weight);
        await _context.SaveChangesAsync();
        
        return RedirectToAction(nameof(All));
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit(int id)
    {
        var tasteNote = await _context.Weights
            .Where(ts => ts.WeightId == id)
            .Select(w => new WeightViewModel
            {
                WeightId = w.WeightId,
                Value = w.Value,
                Unit = w.Unit,
            })
            .FirstOrDefaultAsync();
        
        return View(tasteNote);
    }
    
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit(WeightViewModel viewModel)
    {
        var weight = await _context.Weights
            .FirstOrDefaultAsync(w => w.WeightId == viewModel.WeightId);
        
        weight.Value = viewModel.Value;
        weight.Unit = viewModel.Unit;
        
        _context.Weights.Update(weight);
        await _context.SaveChangesAsync();
        
        return RedirectToAction(nameof(All));
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(int id)
    {
        var weight = await _context.Weights
            .FirstOrDefaultAsync(w => w.WeightId == id);
        
        return View(weight);
    }
    
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(WeightViewModel viewModel)
    {
        var weight = await _context.Weights
            .FirstOrDefaultAsync(w => w.WeightId == viewModel.WeightId);

        if (weight is null)
        {
            return NotFound();
        }
        
        _context.Weights.Remove(weight);
        await _context.SaveChangesAsync();
        
        return RedirectToAction(nameof(All));
    }
}