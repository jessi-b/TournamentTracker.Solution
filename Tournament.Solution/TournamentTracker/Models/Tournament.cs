using System.Collections.Generic;
using System;

namespace TournamentTracker.Models {
  public class Tournament {
    public Tournament()
    {
      this.Competitors = new HashSet<Competitor>(); // many tournaments to many competitors 
    }
    public int TournamentId {get; set;}
    public string Name {get; set;}
    // public DateTime Date {get; set;}
    // public string Location {get; set;}
    // public string Description {get; set;} 
    public int BracketId { get; set; }
    public virtual Bracket Bracket {get; set;} // one tournament to one 
    // stretch: one tournament to many brackets(divisions)
    public virtual ICollection<Competitor> Competitors {get; set;} // many tournaments to many competitors
  }
}