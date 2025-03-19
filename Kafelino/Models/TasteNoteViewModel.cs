using System.ComponentModel.DataAnnotations;

namespace Kafelino.Models;

public class TasteNoteViewModel
{
    public int TasteNoteId { get; set; }
    
    [Required(ErrorMessage = "Полето е задължително.")]
    [MinLength(2, ErrorMessage = "Въведи поне 2 символа.")]
    [MaxLength(50, ErrorMessage = "Въведи не повече от 50 символа.")]
    public string Name { get; set; }
}