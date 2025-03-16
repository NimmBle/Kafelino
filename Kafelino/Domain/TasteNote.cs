namespace Kafelino.Domain;

public class TasteNote
{
    public int TasteNoteId { get; set; }
    
    public string Name { get; set; }
    
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}