using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TournamentTracker.Models{
  public class MatchupCompetitor {
    public int MatchupCompetitorId {get; set;}
    public int MatchupId {get; set;}
    public int CompetitorId {get; set;}
    public virtual Matchup Matchup {get; set;}
    public Competitor Competing {get; set;} = new Competitor();
    public double? Score {get; set;}
    public int ParentMatchupId {get; set;}
  }
}