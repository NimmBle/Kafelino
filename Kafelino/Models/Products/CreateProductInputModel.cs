using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Kafelino.Domain;

namespace Kafelino.Models.Products;

public class CreateProductInputModel
{
    [DisplayName("Име")]
    [Required(ErrorMessage = "Полето е задължително.")]
    [MinLength(2, ErrorMessage = "Въведи поне 2 символа.")]
    [MaxLength(50, ErrorMessage = "Въведи не повече от 50 символа.")]
    public string Name { get; set; }
    
    [DisplayName("Описание")]
    [Required(ErrorMessage = "Полето е задължително.")]
    [MinLength(20, ErrorMessage = "Въведи поне 20 символа.")]
    [MaxLength(500, ErrorMessage = "Въведи не повече от 500 символа.")]
    public string Description { get; set; }
    
    [DisplayName("Снимка")]
    [Required(ErrorMessage = "Полето е задължително.")]
    public IFormFile Image { get; set; }
    
    [DisplayName("Цена")]
    [Required(ErrorMessage = "Полето е задължително.")]
    [Range(0.01, Double.MaxValue, ErrorMessage = "Въведи положителна цена.")]
    public decimal Price { get; set; }
    
    [DisplayName("Налично количество")]
    [Required(ErrorMessage = "Полето е задължително.")]
    [Range(1, Int32.MaxValue, ErrorMessage = "Въведи положителна наличност.")]
    public int Quantity { get; set; }

    [DisplayName("Марка")]
    [Required(ErrorMessage = "Полето е задължително.")]
    [MinLength(2, ErrorMessage = "Въведи поне 2 символа.")]
    [MaxLength(50, ErrorMessage = "Въведи не повече от 50 символа.")]
    public string Brand { get; set; }
    
    [DisplayName("Вкусови нотки")]
    [Required(ErrorMessage = "Полето е задължително. Изберете вкусови нотки")]
    [MinLength(1, ErrorMessage = "Избери поне една")]
    public List<int> TasteNoteIds { get; set; } = new();
    
    [DisplayName("Разфасовка пакет")]
    [Required(ErrorMessage = "Полето е задължително. Изберете разфасофка")]
    public int WeightId { get; set; }
}