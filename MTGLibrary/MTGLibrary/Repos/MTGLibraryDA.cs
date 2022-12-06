using MTGLibrary.Interfaces;
using MTGLibraryDA.Entities;
using System.Xml.Serialization;

namespace MTGLibrary.Repos
{
	public class MTGLibraryDataAccess : IDatabaseAccess
	{
		private MTGLibraryContext db;

		public MTGLibraryDataAccess(MTGLibraryContext db)
		{
			this.db = db;
		}

		public void AddCard(ScryfallCard card)
		{
			throw new NotImplementedException();
		}

		public void AddDeck(Deck deck)
		{
			throw new NotImplementedException();
		}

		public void AddUserOwnedCardToLibrary(Library library, ScryfallCard userOwnedCard)
		{
			throw new NotImplementedException();
		}

		public List<ScryfallCard> GetCardsByName(string name)
		{
			throw new NotImplementedException();
		}
	}
}
