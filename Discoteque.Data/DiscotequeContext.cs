using Microsoft.EntityFrameworkCore;
using Discoteque.Data.models;

namespace Discoteque.Data;

public class DiscotequeContext : DbContext 
{
    public DiscotequeContext(
        DbContextOptions<DiscotequeContext> options) : base(options) //config db
    {
    }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
}