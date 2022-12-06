using MTGLibraryDA.Entities;

namespace MTGLibrary.Interfaces
{
	public interface IDatabaseAccess
	{
		public void AddCard(ScryfallCard card);
		public void AddDeck(Deck deck);
		public List<ScryfallCard> GetCardsByName(string name);

		public void AddUserOwnedCardToLibrary(Library library, ScryfallCard userOwnedCard);
	}
}
