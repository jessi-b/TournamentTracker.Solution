using System.Collections.Generic;

namespace TournamentTracker.Models {
  public class Competitor {
    public Competitor() {
      this.JoinTournament = new HashSet<Tournamen>();
    }
    public int CompetitorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Number { get; set; }
    public string Team { get; set; } // 
    public string SkillLevel { get; set; }
    public string Weight { get; set; }
    public string Match { get; set; } // dynamic
    public virtual ApplicationUser User { get; set; }
  }
}