using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TournamentTracker.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace TournamentTracker.Controllers
{
  public class CompetitorsController : Controller
  {
    private readonly TournamentTrackerContext _db;

    public CompetitorsController(TournamentTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Competitors.OrderBy(competitor => competitor.Name).ToList());
    }

    public ActionResult Create()
    {
      ViewBag.TournamentId = new SelectList(_db.Tournaments, "TournamentId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Competitor competitor, int TournamentId)
    {
        _db.Competitors.Add(competitor);
        _db.SaveChanges();
        if (TournamentId != 0)
        {
            _db.TournamentCompetitors.Add(new TournamentCompetitor() { TournamentId = TournamentId, CompetitorId = competitor.CompetitorId });
            _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id) {
    var thisCompetitor = _db.Competitors
        .Include(competitor => competitor.JoinTournaments)
        .ThenInclude(join => join.Tournament)
        .FirstOrDefault(competitor => competitor.CompetitorId == id);
    return View(thisCompetitor);
    }

    public ActionResult Update(int id)
    {
      var thisCompetitor = _db.Competitors.FirstOrDefault(competitor => competitor.CompetitorId == id);
      ViewBag.TournamentId = new SelectList(_db.Tournaments, "TournamentId", "Name");
      return View(thisCompetitor);
    }

    [HttpPost]
    public ActionResult Update(Competitor competitor, int TournamentId)
    {
      if (TournamentId != 0)
      {
        _db.TournamentCompetitors.Add(new TournamentCompetitor() { TournamentId = TournamentId, CompetitorId = competitor.CompetitorId });
      }
      _db.Entry(competitor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // ALLOWS USER TO ADD MANY CATEGORIES TO AN ITEM
    public ActionResult AddTournament(int id)
    {
      var thisCompetitor = _db.Competitors.FirstOrDefault(competitor => competitor.CompetitorId == id);
      ViewBag.TournamentId = new SelectList(_db.Tournaments, "TournamentId", "Name");
      return View(thisCompetitor);
    }

    [HttpPost]
    public ActionResult AddTournament(Competitor competitor, int TournamentId)
    {
      if (TournamentId != 0)
      {
        _db.TournamentCompetitors.Add(new TournamentCompetitor() { TournamentId = TournamentId, CompetitorId = competitor.CompetitorId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        var thisCompetitor = _db.Competitors.FirstOrDefault(competitor => competitor.CompetitorId == id);
        return View(thisCompetitor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisCompetitor = _db.Competitors.FirstOrDefault(competitor => competitor.CompetitorId == id);
        _db.Competitors.Remove(thisCompetitor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteTournament(int joinId)
    {
        var joinEntry = _db.TournamentCompetitors.FirstOrDefault(entry => entry.TournamentCompetitorId == joinId);
        _db.TournamentCompetitors.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}