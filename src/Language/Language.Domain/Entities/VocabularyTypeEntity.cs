namespace Language.Domain.Entities;

public class VocabularyTypeEntity : EntityBase
{
    protected VocabularyTypeEntity()
    {
    }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<VocabularyEntity> Vocabularies { get; set; }
}