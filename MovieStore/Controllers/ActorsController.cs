using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;

namespace MovieStore.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ActorsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Details(int? id)
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
    }
}
