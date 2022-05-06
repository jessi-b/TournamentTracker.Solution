namespace TournamentTracker.Models
{
  public class CompetitorMatch
  {       
    public int CompetitorMatchId { get; set; }
    public int MatchId { get; set; }
    public int CompetitorId { get; set; }
    public virtual Match Match { get; set; }
    public virtual Competitor Competitor { get; set; }
  }
}