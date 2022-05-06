using Microsoft.AspNetCore.Mvc;

namespace TournamentTracker.Controllers {
  public class HomeController : Controller {
    [HttpGet("/")]
    public ActionResult Index() {
      // var allArticles = Article.GetArticles(EnvironmentVariables.ApiKey);
      //       return View(allArticles);
      return View();
    }
  }
}

