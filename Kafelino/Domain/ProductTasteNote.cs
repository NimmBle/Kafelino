namespace Kafelino.Domain;

public class ProductTasteNote
{
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    public int TasteNoteId { get; set; }
    public TasteNote TasteNote { get; set; }
}