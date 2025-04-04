using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kafelino.Models;

public class WeightViewModel
{
    public int WeightId { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "Стойността трябва да е по-голяма от нула")]
    [Required(ErrorMessage = "Полето е задължително")]
    [DisplayName("Стойност")]
    public int Value { get; set; }
    
    [DisplayName("Мерна единица")]
    public string Unit { get; set; }
}