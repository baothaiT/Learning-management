using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Language.Domain.Entities;
using Language.Infrastructure.Data;

namespace Language.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VocabularyController : ControllerBase
    {
        private readonly LanguageDbContext _context;

        public VocabularyController(LanguageDbContext context)
        {
            _context = context;
        }

        // GET: api/Vocabulary
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VocabularyEntity>>> GetVocabularyTable()
        {
            return await _context.VocabularyTable.ToListAsync();
        }

        // GET: api/Vocabulary/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VocabularyEntity>> GetVocabularyEntity(Guid id)
        {
            var vocabularyEntity = await _context.VocabularyTable.FindAsync(id);

            if (vocabularyEntity == null)
            {
                return NotFound();
            }

            return vocabularyEntity;
        }

        // PUT: api/Vocabulary/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVocabularyEntity(Guid id, VocabularyEntity vocabularyEntity)
        {
            if (id != vocabularyEntity.Id)
            {
                return BadRequest();
            }

            _context.Entry(vocabularyEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VocabularyEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vocabulary
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VocabularyEntity>> PostVocabularyEntity(VocabularyEntity vocabularyEntity)
        {
            _context.VocabularyTable.Add(vocabularyEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVocabularyEntity", new { id = vocabularyEntity.Id }, vocabularyEntity);
        }

        // DELETE: api/Vocabulary/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVocabularyEntity(Guid id)
        {
            var vocabularyEntity = await _context.VocabularyTable.FindAsync(id);
            if (vocabularyEntity == null)
            {
                return NotFound();
            }

            _context.VocabularyTable.Remove(vocabularyEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VocabularyEntityExists(Guid id)
        {
            return _context.VocabularyTable.Any(e => e.Id == id);
        }
    }
}
