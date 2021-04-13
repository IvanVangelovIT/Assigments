namespace Zoo.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Zoo.Services.Data;
    using Zoo.Web.Models;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnimalsService _animalService;

        public HomeController(ILogger<HomeController> logger,
            IAnimalsService animalService)
        {
            _logger = logger;
            this._animalService = animalService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetAll()
        {
            var viewModel = this._animalService.GetAll();
            return Ok(viewModel);
        }

        public async Task<ActionResult> GetAllSurvivors()
        {
            var viewModel = this._animalService.GetAllSurvivors();
            return Ok(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Update(bool isanimalhungry)
        {

            if (isanimalhungry)
            {
                await this._animalService.FeedAnimals();
                return Ok(true);
            }

            await this._animalService.StarveAnimals();
            return Ok(true);
        }

        //public async Task<ActionResult> UpdateFeed(bool isanimalhungry)
        //{
        //    await this._animalService.FeedAnimals();
        //    return Ok(true);
        //}
        public async Task<ActionResult> Reset()
        {
            await this._animalService.Reset();
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
