using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.Projeto.MVCScryfall.Controllers
{
	public class MagicCardsController : Controller
	{
		private readonly ILogger<MagicCardsController> _logger;

		public MagicCardsController(ILogger<MagicCardsController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[Route("result")]
		public PartialViewResult CardsList_Partial()
		{
			//Fazer chamada a api
			return PartialView();
		}
	}
}
