using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models {
  public class TournamentCompetitor {       
    public int TournamentCompetitorId { get; set; }
    public int TournamentId { get; set; }
    public int CompetitorId { get; set; }
    public virtual Tournament Tournament { get; set; }
    public virtual Competitor Competitor { get; set; }
  }
}