using System.Reflection;

namespace Language.Domain.Entities;

public class ListenEntity : EntityBase
{
    protected ListenEntity()
    {
    }
    public string File { get; set; } = string.Empty;

    public ICollection<VocabularyEntity> Vocabularies { get; set; }
}
