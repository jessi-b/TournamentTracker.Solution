using System.Collections.Generic;

namespace TournamentTracker.Models {
  public class Bracket {
    public int BracketId {get; set;}
    public string Description {get; set;}
    public int TournamentId { get; set; }
    public virtual Tournament Tournament {get; set;} // one bracket to tournament 
    public virtual Round Round {get; set;} // one bracket to many rounds
  }
}