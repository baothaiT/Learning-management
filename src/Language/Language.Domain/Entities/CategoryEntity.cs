namespace Language.Domain.Entities;

public class CategoryEntity : EntityBase
{
    protected CategoryEntity()
    {
    }
    public string Name { get; set; } = string.Empty;

    public ICollection<VocabularyEntity> Vocabularies { get; set; }
}
