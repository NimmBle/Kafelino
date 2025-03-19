using Kafelino.Data;
using Kafelino.Domain;
using Kafelino.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kafelino.Controllers;

public class TasteNotesController(KafelinoDbContext _context) : Controller
{
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> All()
    {
        var tasteNotes = await _context.TasteNotes
            .Select(ts => new TasteNoteViewModel
            {
                TasteNoteId = ts.TasteNoteId,
                Name = ts.Name,
            })
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
    public async Task<IActionResult> Create(TasteNoteViewModel viewModel)
    {
        var tasteNote = new TasteNote
        {
            Name = viewModel.Name,
        };
        
        _context.TasteNotes.Add(tasteNote);
        await _context.SaveChangesAsync();
        
        return RedirectToAction(nameof(All));
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit(int id)
    {
        var tasteNote = await _context.TasteNotes
            .Where(ts => ts.TasteNoteId == id)
            .Select(ts => new TasteNoteViewModel
            {
                TasteNoteId = ts.TasteNoteId,
                Name = ts.Name,
            })
            .FirstOrDefaultAsync();
        
        return View(tasteNote);
    }
    
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Edit(TasteNoteViewModel viewModel)
    {
        var tasteNote = await _context.TasteNotes
            .FirstOrDefaultAsync(ts => ts.TasteNoteId == viewModel.TasteNoteId);
        
        tasteNote.Name = viewModel.Name;
        
        _context.TasteNotes.Update(tasteNote);
        await _context.SaveChangesAsync();
        
        return RedirectToAction(nameof(All));
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(int id)
    {
        var tasteNote = await _context.TasteNotes
            .FirstOrDefaultAsync(ts => ts.TasteNoteId == id);
        
        return View(tasteNote);
    }
    
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(TasteNoteViewModel viewModel)
    {
        var tasteNote = await _context.TasteNotes
            .FirstOrDefaultAsync(ts => ts.TasteNoteId == viewModel.TasteNoteId);

        if (tasteNote is null)
        {
            return NotFound();
        }
        
        _context.TasteNotes.Remove(tasteNote);
        await _context.SaveChangesAsync();
        
        return RedirectToAction(nameof(All));
    }
}