using MTGLibrary.Interfaces;
using MTGLibrary.Models;
using MTGLibraryDA.Entities;
using System.Text.Json;

namespace MTGLibrary.Repos
{
	public class ScryfallAPIAccess : IExternalCardAPIAccess
	{
		private const string ScryfallApiUri = "https://api.scryfall.com/cards/";

		private HttpClient client = new HttpClient();

		public ScryfallAPIAccess()
		{
			client.BaseAddress = new Uri(ScryfallApiUri);
		}

		public async Task<ScryfallCard> SearchCardName(string cardName)
		{
			var card = new ScryfallCard();

			cardName = cardName.Replace(" ", "+");

			HttpResponseMessage response = await client.GetAsync("named/?exact=" + cardName);
			if (response.IsSuccessStatusCode)
			{
				card = await JsonSerializer.DeserializeAsync<ScryfallCard>(await response.Content.ReadAsStreamAsync());
			}

			return card;
		}

		public async Task<List<ScryfallCard>> GetAllPrints(ScryfallCard card)
		{
			List<ScryfallCard> cards = new List<ScryfallCard>();

			if (card.prints_search_uri != null)
			{
				var newSearchURI = card.prints_search_uri.Replace(ScryfallApiUri, "");
				HttpResponseMessage response = await client.GetAsync(newSearchURI);
				if (response.IsSuccessStatusCode)
				{
					ScryFallObject obj = await JsonSerializer.DeserializeAsync<ScryFallObject>(await response.Content.ReadAsStreamAsync());
					cards = obj.data.ToList();
				}
			}

			return cards;
		}

		public async Task<ScryfallCard> GetCardById(string cardId)
		{
			var card = new ScryfallCard();

			HttpResponseMessage response = await client.GetAsync(cardId);
			if (response.IsSuccessStatusCode)
			{
				card = await JsonSerializer.DeserializeAsync<ScryfallCard>(await response.Content.ReadAsStreamAsync());
			}

			return card;
		}
	}
}
