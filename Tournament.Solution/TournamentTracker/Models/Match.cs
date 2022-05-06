using System.Collections.Generic;

namespace TournamentTracker.Models {
  public class Match {
    public Match()
    {
        this.Competitors = new HashSet<Competitor>(); // many matches to many competitors 
    }
    public int MatchId {get; set;}
    public string Description {get; set;}
    public ICollection<Round> Round { get; set; } // many matches to one round
    public virtual ICollection<Competitor> Competitors {get; set;} // many matches to many competitors 
  }
}