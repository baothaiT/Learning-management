using Language.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language.Domain.Interfaces;

public interface IVocabularyRepository
{
    public Task<VocabularyEntity?> GetByIdAsync(Guid id);

    public Task<IReadOnlyList<VocabularyEntity>> ListAsync();

    public Task AddAsync(VocabularyEntity entity);

    public Task UpdateAsync(VocabularyEntity entity);
}
