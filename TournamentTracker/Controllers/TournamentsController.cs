using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TournamentTracker.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace TournamentTracker.Controllers {
  public class TournamentsController : Controller {
    private readonly TournamentTrackerContext _db;
    public TournamentsController(TournamentTrackerContext db) {
      _db = db;
    }
    public ActionResult Index() {
      List<Tournament> model = _db.Tournaments.ToList();
      return View(model);
    }

    public ActionResult Create() {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Tournament tournament) {
      _db.Tournaments.Add(tournament);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id) {
      var thisTournament = _db.Tournaments
        .Include(tournament => tournament.JoinCompetitors)
        .ThenInclude(join => join.Competitor)
        .FirstOrDefault(tournament => tournament.TournamentId == id);
      return View(thisTournament);
    }

    public ActionResult Update(int id) {
      var thisTournament = _db.Tournaments.FirstOrDefault(tournament => tournament.TournamentId == id);
      return View(thisTournament);
    }
    [HttpPost]
    public ActionResult Update(Tournament tournament) {
      _db.Entry(tournament).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id) {
      var thisTournament = _db.Tournaments.FirstOrDefault(tournament => tournament.TournamentId == id);
      return View(thisTournament);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id) {
      var thisTournament = _db.Tournaments.FirstOrDefault(tournament => tournament.TournamentId == id);
      _db.Tournaments.Remove(thisTournament);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}