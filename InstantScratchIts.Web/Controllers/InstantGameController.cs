using Microsoft.AspNetCore.Mvc;
using InstantScratchIts.Web.Services;
using InstantScratchIts.Web.Models;
using System;

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
                // If id is not for a valid game, generate a 404 error page
                // TODO: Add status code pages middleware to show friendly 404 page
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UpdateInstantGameCommand command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.UpdateInstantGame(command);
                    return RedirectToAction(nameof(View), new { id = command.Id });
                }
            }
            catch (Exception)
            {
                // TODO: Log error
                // Add a model-level error by using an empty string key
                ModelState.AddModelError(
                    string.Empty,
                    "An error occured saving the instant game"
                    );
            }

            //If we got to here, something went wrong
            return View(command);
        }

    }
}
