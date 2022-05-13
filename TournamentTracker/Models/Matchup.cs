using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TournamentTracker.Models {
  public class Matchup {
    public Matchup(){
      this.Entries = new List<MatchupCompetitor>(); // many matches to many competitors 
    }
    public int MatchId {get; set;}
    public int Round { get; set; }
    public Competitor Winner {get; set;}
    public virtual IList<MatchupCompetitor> Entries  {get; set;} = new List<MatchupCompetitor>(); // many matches to many competitors 
    public int TournamentId { get; set; }
    public virtual Tournament Tournament { get; set; }
  }
}