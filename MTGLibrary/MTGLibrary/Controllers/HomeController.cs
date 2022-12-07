using Microsoft.AspNetCore.Mvc;
using MTGLibrary.Interfaces;
using MTGLibrary.Models;
using MTGLibrary.ViewModel;
using MTGLibraryDA.Entities;
using System.Diagnostics;

namespace MTGLibrary.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly IExternalCardAPIAccess externalCardAPIAccess;

		private readonly IDatabaseAccess dbAccess;


		public HomeController(ILogger<HomeController> logger, IExternalCardAPIAccess externalCardAPIAccess, IDatabaseAccess dbAccess)
		{
			_logger = logger;
			this.externalCardAPIAccess = externalCardAPIAccess;
			this.dbAccess = dbAccess;
		}

		[HttpGet]
		public IActionResult Index()
		{
			LibraryViewModel vm = new LibraryViewModel();
			return View(vm);
		}

		[HttpGet]
		[Route("Home/CardSearch/{name?}")]
		public IActionResult CardSearch(string? name)
		{
			if (name == null)
				return View("Error");
			CardVM vm = new CardVM();
			var card = externalCardAPIAccess.SearchCardName(name).Result;

			vm.Cards = externalCardAPIAccess.GetAllPrints(card).Result;

			return View(vm);
		}

		[HttpPost]
		[Route("Home/CardSearchInsert/{id?}")]
		public ActionResult CardSearchInsert(string id)
		{
			CardVM vm = new CardVM();
			var card = externalCardAPIAccess.GetCardById(id).Result;

			

			var result = true;

			return Json(new {cardAdded = result});
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}