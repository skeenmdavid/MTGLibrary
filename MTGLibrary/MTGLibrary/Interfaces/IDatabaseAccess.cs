using MTGLibraryDA.Entities;

namespace MTGLibrary.Interfaces
{
	public interface IDatabaseAccess
	{
		public bool AddCardToLibrary(Card card, int Libid);
		public void AddDeck(Deck deck);

		public bool RemoveCardFromLibrary(Card card, int Libid);
		public bool UpdateCardInLibrary(Card card, int Libid);
		public Card GetCardFromLibrary(string cardId, int Libid);
		public void AddLibrary();
		public void RemoveLibrary();
		public Library GetLibrary(int id);
		public List<Library> GetAllLibraries();
	}
}
