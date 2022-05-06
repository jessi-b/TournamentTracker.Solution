using System.Collections.Generic;

namespace TournamentTracker.Models {
  public class Tournament {
    public Tournament() {
      this.Competitors = new HashSet<Competitor>();
      this.Rounds = new HashSet<Round>();
      this.Matches = new HashSet<Match>();
    }
    public int TournamentId {get; set;}
    public string Name {get; set;}
    public string Date {get; set;}
    public string Location {get; set;}
    public string Description {get; set;}
    public string Bracket {get; set;} // stretch: many brackets/divisions
    public virtual ICollection<Competitor> Competitors {get; set;}
    public virtual ICollection<Round> Rounds {get; set;}
    public virtual ICollection<Match> Matches {get; set;}
  }
}