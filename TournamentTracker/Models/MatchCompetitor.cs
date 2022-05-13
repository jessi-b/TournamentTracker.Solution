using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TournamentTracker.Models{
  public class MatchCompetitor {
    public int MatchCompetitorId {get; set;}
    public int MatchId {get; set;}
    public int CompetitorId {get; set;}
    public virtual Match Match {get; set;}
    public Competitor Competing {get; set;} = new Competitor();
    public double? Score {get; set;}
    public int ParentMatchupId {get; set;}
  }
}