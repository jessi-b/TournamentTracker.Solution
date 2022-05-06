using System.Collections.Generic;

namespace TournamentTracker.Models {
  public class Competitor {
    public Competitor() {
      this.Tournaments = new HashSet<Tournament>();
      this.Matches = new HashSet<Match>();
    }
    public int CompetitorId {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public DateTime DOB {get; set;}
    public string Email {get; set;}
    public string Number {get; set;}
    public string Team {get; set;} // stretch: additional class for team
    // public string Skill {get; set; } // stretch: taken into acount to be assigned to division
    // public string Weight {get; set;} // stretch: taken into acount to be assigned to division
    public bool Winner {get; set;} // default false; iwin = true; if true advance & reset to default
    public virtual ICollection<Tournament> Tournaments  {get; set;} // many competitors to many tournaments
    public virtual ICollection<Match> Matches  {get; set;} // many competitors to many tournaments
    public virtual ApplicationUser User { get; set; }
  }
}