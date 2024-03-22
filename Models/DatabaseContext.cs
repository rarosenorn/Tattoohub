using Microsoft.EntityFrameworkCore;

namespace Tattoohub.Models;
public class DatabaseContext : DbContext {
    public DatabaseContext (DbContextOptions<DatabaseContext> options) :
        base(options)
    {
    }
    public DbSet<Article> Articles {get; set;}
    public DbSet<Artist> Artists {get; set;}
    public DbSet<Shop> Shops {get; set;}
    public DbSet<Style> Styles {get; set;}
    public DbSet<Tattoo> Tattoos {get; set;}
    public DbSet<ArtistStyle> ArtistStyles {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<ArtistStyle>()
            .HasKey(e => new {e.ArtistId, e.StyleId});
    }
}