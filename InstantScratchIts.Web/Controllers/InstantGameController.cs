using Microsoft.AspNetCore.Mvc;
using InstantScratchIts.Web.Services;

namespace InstantScratchIts.Web.Controllers
{
    public class InstantGameController : Controller
    {
        public InstantGameService _service;
        public InstantGameController(InstantGameService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var models = _service.GetInstantGames();

            return View(models);
        }

        public IActionResult View(int id)
        {
            var model = _service.GetInstantGameDetail(id);
            if (model == null)
            {
                // If id is not for a valid instant game, generate a 404 error page
                // TODO: Add status code pages middleware to show friendly 404 page
                return NotFound();
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _service.GetInstantGameForUpdate(id);
            if (model == null)
            {
                // If id is not for a valid Recipe, generate a 404 error page
                // TODO: Add status code pages middleware to show friendly 404 page
                return NotFound();
            }
            return View(model);
        }

    }
}
