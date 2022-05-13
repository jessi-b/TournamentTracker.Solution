using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models {
  public static class BracketLogic {
  // ramdomize competitors X
  // add by if odd competitors X
  // generate initial round of matches
  // generate winner rounds matches
    public static void GenerateBracket(Tournament model) {
      //randomize matches
      IList<TournamentCompetitor> randomizedCompetitors = RandomizeCopmetitors(model.JoinCompetitors);
      //count rounds
      int rounds = CountRounds(randomizedCompetitors.Count);
      //add byes
      int bye = CountByes(rounds, randomizedCompetitors.Count);
    }

  //methods
    //randomize matches
    private static IList<TournamentCompetitor> RandomizeCopmetitors(IList<TournamentCompetitor> competitors) {
      return competitors.OrderBy(x => Guid.NewGuid()).ToList();
    }
    //count rounds
    private static int CountRounds(int competitorCount) {
      int count = 1; 
      int min = 2;
      while(min < competitorCount) { 
        count += 1;
        min *= 2;
      }
      return count;
      System.Console.WriteLine("round count = " + count + "competitor count = " + competitorCount);
    }
    //add byes
    private static int CountByes(int numRounds, int numCompetitors) {
      int count = 0;
      int totalCompetitors = 0;
      for(int i = 1; 1 <= numRounds; i++){
        totalCompetitors *= 2;
      }
      count = totalCompetitors - numCompetitors;
      return count;
      System.Console.WriteLine( "total competitors = " + totalCompetitors + "; bye count = " + count);
    }
  }
}