using Microsoft.EntityFrameworkCore;
using GolfTrackerBackend.Models;

public class GolfTrackerDbContext : DbContext
{
    public GolfTrackerDbContext(DbContextOptions<GolfTrackerDbContext> options) : base(options)
    {
    }

    // DbSet properties representing your model classes
    public DbSet<User>? Users { get; set; }
    public DbSet<GolfRound>? GolfRounds { get; set; }
    public DbSet<Hole>? Holes { get; set; }
    public DbSet<Score>? Scores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure table mappings, relationships, and other database-specific configurations
        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<GolfRound>().HasKey(gr => gr.Id);
        modelBuilder.Entity<Hole>().HasKey(h => h.Id);
        modelBuilder.Entity<Score>().HasKey(s => s.Id);

        // Configure relationships
        modelBuilder.Entity<GolfRound>()
            .HasOne(gr => gr.User)
            .WithMany(u => u.GolfRounds)
            .HasForeignKey(gr => gr.UserId);

        modelBuilder.Entity<Score>()
            .HasOne(s => s.Round)
            .WithMany(gr => gr.Scores)
            .HasForeignKey(s => s.RoundId);

        modelBuilder.Entity<Score>()
            .HasOne(s => s.Hole)
            .WithMany(h => h.Scores)
            .HasForeignKey(s => s.HoleId);

        modelBuilder.Entity<Score>()
            .HasOne(s => s.Player)
            .WithMany()
            .HasForeignKey(s => s.PlayerId);
    }
}
