using MTGLibraryDA.Entities;

namespace MTGLibrary.Interfaces
{
	public interface IDatabaseAccess
	{
		public void AddCardToLibrary(Card card);
		public void AddDeck(Deck deck);
	}
}
