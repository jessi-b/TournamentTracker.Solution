using System.Collections.Generic;

namespace TournamentTracker.Models {
  public class Competitor {
    public Competitor() {
      this.Tournaments = new HashSet<Tournament>();
      this.Matches = new HashSet<Match>();
    }
    public int CompetitorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Number { get; set; }
    public string Team { get; set; } // 
    public string SkillLevel { get; set; } // stretch: taken into acount to be assigned to division
    public string Weight { get; set; } // stretch: taken into acount to be assigned to division
    public string Match { get; set; } // dynamic
    public virtual ICollection<Tournament> Tournaments  {get; }
    public virtual ICollection<Match> Matches  {get; }
    public virtual ApplicationUser User { get; set; }
  }
}