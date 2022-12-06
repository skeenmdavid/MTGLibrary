using MTGLibrary.Models;
using MTGLibraryDA.Entities;

namespace MTGLibrary.Interfaces
{
	public interface IExternalCardAPIAccess
	{
		public Task<ScryfallCard> SearchCardName(string cardName);

		public Task<List<ScryfallCard>> GetAllPrints(ScryfallCard card);

		public Task<ScryfallCard> GetCardById(string cardId);
	}
}
