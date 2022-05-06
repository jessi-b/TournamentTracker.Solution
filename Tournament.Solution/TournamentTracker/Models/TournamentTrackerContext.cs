using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TournamentTracker.Models {
  public class TournamentTrackerContext : DbContext {
    public DbSet<Competitor> Competitors { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Team> Teams { get; set; }
    public TournamentTrackerContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}