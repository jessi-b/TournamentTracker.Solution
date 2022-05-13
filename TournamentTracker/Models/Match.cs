using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TournamentTracker.Models {
  public class Match {
    public Match(){
      this.Entries = new List<MatchCompetitor>(); // many matches to many competitors 
    }
    public int MatchId {get; set;}
    public int Round { get; set; }
    public Competitor Winner {get; set;}
    public virtual IList<MatchCompetitor> Entries  {get; set;} = new List<MatchCompetitor>(); // many matches to many competitors 
    public int TournamentId { get; set; }
    public virtual Tournament Tournament { get; set; }
  }
}