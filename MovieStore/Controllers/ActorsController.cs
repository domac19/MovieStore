using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using MovieStore.Models;
using MovieStore.ViewModels;
using System.Net;

namespace MovieStore.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ActorsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActionResult Index()
        {
            return View(_dbContext.Actors.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actors = _dbContext.Actors.Find(id);

            if (actors == null)
            {
                return NotFound();
            }
            return View(actors);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var actor = _dbContext.Actors.Find(id);
            
            if (actor == null)
            {
                return NotFound();
            }
            return View(actor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Actor actor)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Entry(actor).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actor);
        }

        public ActionResult PregledSvihFilmova()
        {
            var allMovies = _dbContext.Movies.ToList();

            var movieInvitation = _dbContext.Movies.Where(p => p.MovieInvitation == "pozivnica").ToList();

            var movieApplication = _dbContext.Movies.Where(a => a.MovieApplication == "moja prijava").ToList();

            var movieRole = _dbContext.Movies.Where(r => r.MovieRoles == "moja uloga").ToList();

            var viewModel = new ActorViewModel
            {
                Movies = allMovies,
                MovieInvitation = movieInvitation.ToString(),
                MovieApplication = movieApplication.ToString(),
                MovieRoles = movieRole.ToString()
            };

            return View(viewModel);
        }
    }
}
