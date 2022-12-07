using Microsoft.AspNetCore.Mvc;
using MTGLibrary.Extensions;
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

		private const int LIBRARY_ID = 2;


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
			vm.Library = dbAccess.GetLibrary(LIBRARY_ID);
			return View(vm);
		}

		[HttpPost]
		[Route("Home/RemoveCardFromLibrary/{id?}")]
		public ActionResult RemoveCardFromLibrary(string id)
		{
			var cardToRemove = dbAccess.GetCardFromLibrary(id, LIBRARY_ID);

			var result = dbAccess.RemoveCardFromLibrary(cardToRemove, LIBRARY_ID);

			return Json(new { cardRemoved = result });
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
			var scryfall = externalCardAPIAccess.GetCardById(id).Result;

			var card = scryfall.ToCard();

			//Check and see if Card already exists in library
			if(dbAccess.GetLibrary(LIBRARY_ID).scryfallCards.Any(c => c.card_id == card.card_id))
			{
				var currentCard = dbAccess.GetCardFromLibrary(card.card_id, LIBRARY_ID);
				currentCard.CountOwned += 1;
				var success = dbAccess.UpdateCardInLibrary(currentCard, LIBRARY_ID);
				return Json(new { cardAdded = success });
			}

			card.CountOwned = 1;

			var result = dbAccess.AddCardToLibrary(card, LIBRARY_ID);

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