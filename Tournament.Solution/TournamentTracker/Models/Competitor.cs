using System.Collections.Generic;

namespace TournamentTracker.Models {
  public class Competitor {
    public Competitor() {
      this.JoinEntities = new HashSet<TournamentTracker>();
    }
    
    public virtual ApplicationUser User { get; set; }
  }
}