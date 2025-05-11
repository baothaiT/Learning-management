namespace Language.Domain.Entities;

public class VocabularyEntity : EntityBase
{
    protected VocabularyEntity()
    {
    }
    public string Keyword { get; set; } = string.Empty;
    public string Mean { get; set; } = string.Empty;

    public string CategoryId { get; set; } = string.Empty;
    public CategoryEntity Category { get; set; }

    public string VocabularyTypeId { get; set; } = string.Empty;
    public VocabularyTypeEntity VocabularyType { get; set; }

    public string ListenId { get; set; } = string.Empty;
    public ListenEntity Listen { get; set; }
}
