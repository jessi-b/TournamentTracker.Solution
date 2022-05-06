using System.Collections.Generic;

namespace TournamentTracker.Models {
  public class Round {
    public int RoundId {get; set;}
    public string Description {get; set;}
    public virtual Match Match {get; set;} // one round to many matches
    public ICollection<Bracket> Bracket { get; set; } // many rounds to one bracket
  }
}