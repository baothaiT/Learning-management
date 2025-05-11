using Language.Domain.Entities;
using Language.Domain.Interfaces;
using Language.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language.Infrastructure.Repositories;

public class VocabularyRepository : IVocabularyRepository
{
    private readonly LanguageDbContext _db;

    public VocabularyRepository(LanguageDbContext db) => _db = db;

    public async Task<VocabularyEntity?> GetByIdAsync(Guid id)
        => await _db.VocabularyTable.FindAsync(id);

    public async Task<IReadOnlyList<VocabularyEntity>> ListAsync()
        => await _db.VocabularyTable.AsNoTracking().ToListAsync();

    public async Task AddAsync(VocabularyEntity entity)
        => await _db.VocabularyTable.AddAsync(entity);

    public async Task UpdateAsync(VocabularyEntity entity)
    {
        _db.VocabularyTable.Update(entity);
        await Task.CompletedTask;
    }
}
