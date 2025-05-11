using Language.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Language.Infrastructure.Data;


public class LanguageDbContext : DbContext
{
    public LanguageDbContext()
    {
    }
    public LanguageDbContext(DbContextOptions<LanguageDbContext> options) : base(options)
    {
    }

    public DbSet<VocabularyEntity> VocabularyTable { get; set; }
    public DbSet<CategoryEntity> CategoryTable { get; set; }
    public DbSet<ListenEntity> ListenTable { get; set; }
    public DbSet<VocabularyTypeEntity> VocabularyTypeTable { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       if (!optionsBuilder.IsConfigured)
       {
        //   optionsBuilder.UseSqlServer(
        //       "Server=127.0.0.1,1433;Database=Language_Dev1;User ID=sa;Password=YourStrong!Pass123;TrustServerCertificate=True;");
       }
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<VocabularyEntity>(b =>
        {
            b.HasKey(p => p.Id);
        });

        builder.Entity<CategoryEntity>(b =>
        {
            b.HasKey(p => p.Id);
        });

        builder.Entity<ListenEntity>(b =>
        {
            b.HasKey(p => p.Id);
        });

        builder.Entity<VocabularyTypeEntity>(b =>
        {
            b.HasKey(p => p.Id);
        });
        
    }
}