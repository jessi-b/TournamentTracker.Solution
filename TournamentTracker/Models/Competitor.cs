using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TournamentTracker.Models {
  public class Competitor {
    public Competitor() {
      this.JoinTournaments = new List<TournamentCompetitor>();
      this.JoinMatchups = new List<MatchupCompetitor>();
    }
    public int CompetitorId {get; set;}
    public string FirstName {get; set;}
    // public string LastName {get; set;}
    // public DateTime DOB {get; set;}
    // public string Email {get; set;}
    // public string Number {get; set;}
    // public string Team {get; set;} // stretch: additional class for team
    // public string Skill {get; set; } // stretch: taken into acount to be assigned to division
    // public string Weight {get; set;} // stretch: taken into acount to be assigned to division
    public virtual IList<TournamentCompetitor> JoinTournaments { get; set; } // many competitors to many tournaments
    public virtual IList<MatchupCompetitor> JoinMatchups { get; set; } // many competitors to many tournaments
    // public virtual ApplicationUser User { get; set; }
  }
}