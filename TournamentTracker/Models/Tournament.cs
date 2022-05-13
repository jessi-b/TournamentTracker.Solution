using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models {
  public class Tournament {
    public Tournament()
    {
      this.JoinCompetitors = new List<TournamentCompetitor>(); // many tournaments to many competitors 
    }
    public int TournamentId {get; set;}
    public string Name {get; set;}
    // public DateTime Date {get; set;}
    // public string Location {get; set;}
    // public string Description {get; set;} 
    public virtual IList<IList<Matchup>> Rounds {get; set;}
    // stretch: one tournament to many divisions
    public virtual IList<TournamentCompetitor> JoinCompetitors {get; set;} // many tournaments to many competitors
  }
}