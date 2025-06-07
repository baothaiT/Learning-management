using Language.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Language.Infrastructure.Data;


public class LanguageDbContext : DbContext
{
    private readonly ILogger<LanguageDbContext> _logger;
    public LanguageDbContext(ILogger<LanguageDbContext> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        // Uncomment the line below to enable logging
        // this.Database.Log = s => _logger.LogInformation(s);
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
            _logger.LogInformation("Configuring LanguageDbContext with default connection string.");
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