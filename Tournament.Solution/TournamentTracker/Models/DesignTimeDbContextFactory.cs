using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TournamentTracker.Models {
  public class TournamentTrackerContextFactory : IDesignTimeDbContextFactory<TournamentTrackerContext> {

    TournamentTrackerContext IDesignTimeDbContextFactory<TournamentTrackerContext>.CreateDbContext(string[] args) {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
      var builder = new DbContextOptionsBuilder<TournamentTrackerContext>();
      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));
      return new TournamentTrackerContext(builder.Options);
    }
  }
}