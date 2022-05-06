using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using TournamentTracker.Models;

namespace TournamentTracker.Controllers {
  [Authorize]
  public class ClassNamesController : Controller {
    private readonly TournamentTrackerContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public ClassNamesController(UserManager<ApplicationUser> userManager,TournamentTrackerContext db) {
      _userManager = userManager;
      _db = db;
    }
  }
}