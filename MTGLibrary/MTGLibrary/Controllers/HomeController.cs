using Microsoft.AspNetCore.Mvc;
using MTGLibrary.Extensions;
using MTGLibrary.Interfaces;
using MTGLibrary.Models;
using MTGLibrary.ViewModel;
using MTGLibraryDA.Entities;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Tesseract;

namespace MTGLibrary.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly IExternalCardAPIAccess externalCardAPIAccess;

		private readonly IDatabaseAccess dbAccess;

		private const int LIBRARY_ID = 1;


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
			ScryFallCardVM vm = new ScryFallCardVM();
			var card = externalCardAPIAccess.SearchCardName(name).Result;

			vm.Cards = externalCardAPIAccess.GetAllPrints(card).Result;

			return View(vm);
		}

		[HttpPost]
		[Route("Home/CardSearchInsert/{id?}")]
		public ActionResult CardSearchInsert(string id)
		{
			ScryFallCardVM vm = new ScryFallCardVM();
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
			card.Location = "Bulk Storage";

			var result = dbAccess.AddCardToLibrary(card, LIBRARY_ID);

			return Json(new {cardAdded = result});
		}

		[HttpPost]
		public IActionResult ProcessImageForResults(string data)
		{
			byte[] bytes = Convert.FromBase64String(data);
			var trainerLoc = System.AppDomain.CurrentDomain.BaseDirectory + "Tesseract";

			using (var engine = new TesseractEngine(trainerLoc, "eng", EngineMode.Default))
			{
				using (var ms = new MemoryStream(bytes))
				{
					using (var loadedImg = Pix.LoadFromMemory(ms.ToArray()))
					using (var page = engine.Process(loadedImg))
					{
						var c = page.GetText();
						//foreach (var word in words) if (c.Contains(word)) found.Add(word);
					}
				}
			}
			//Change this to JSON
			return View();
		}

		[HttpGet]
		public ActionResult LibCardEdit(string cardId)
		{
			
			Card editCard = dbAccess.GetCardFromLibrary(cardId, LIBRARY_ID);
			ScryfallCard cardForPrices = externalCardAPIAccess.GetCardById(cardId).Result;
			LibCardVM vm = new LibCardVM()
			{
				CardId = cardId,
				CardName = editCard.card_name,
				Image_uri = editCard.image_uris.normal,
				CKPurchaseUri = editCard.purchase_uris.cardmarket,
				Count = editCard.CountOwned,
				Location = editCard.Location == null ? "" : editCard.Location,
				Prices = cardForPrices.prices
			};

			return View(vm);
		}

		[HttpPost]
		public ActionResult LibCardEdit(LibCardVM vm)
		{
			Card editCard = dbAccess.GetCardFromLibrary(vm.CardId, LIBRARY_ID);
			editCard.CountOwned = vm.Count;
			editCard.Location = vm.Location;

			var success = dbAccess.UpdateCardInLibrary(editCard, LIBRARY_ID);

			if(success)
				return RedirectToAction("Index");

			return View(vm);
		}

		public static string Base64Encode(string plainText)
		{
			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
			return System.Convert.ToBase64String(plainTextBytes);
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