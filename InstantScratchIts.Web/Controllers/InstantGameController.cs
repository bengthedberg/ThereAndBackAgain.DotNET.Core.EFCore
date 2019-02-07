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
    }
}
