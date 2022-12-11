using Microsoft.EntityFrameworkCore;
using MTGLibrary.Extensions;
using MTGLibrary.Interfaces;
using MTGLibraryDA.Entities;
using Serilog;
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

		public bool AddCardToLibrary(Card card, int Libid)
		{
			try
			{
				db.Libraries.Include(library => library.scryfallCards).FirstOrDefault(l => l.Id == Libid).scryfallCards.Add(card);
				db.SaveChanges();
				return true;
			}
			catch(Exception ex)
			{
				Log.Error($"Failed to Add card to Library: {ex}");
				return false;
			}
		}

		public void AddDeck(Deck deck)
		{
			throw new NotImplementedException();
		}

		public void AddLibrary()
		{
			var library = new Library();
			library.scryfallCards = new List<Card>();
			db.Libraries.Add(library);
			db.SaveChanges();
		}

		public List<Library> GetAllLibraries()
		{
			return db.Libraries.ToList();
		}

		public Card GetCardFromLibrary(string cardId, int Libid)
		{
			try
			{
				return db.Libraries.Include(library => library.scryfallCards).ThenInclude(card => card.image_uris)
					.Include(library => library.scryfallCards).ThenInclude(card => card.prices)
					.Include(library => library.scryfallCards).ThenInclude(card => card.purchase_uris)
					.FirstOrDefault(l => l.Id == Libid).scryfallCards.FirstOrDefault(sc => sc.card_id == cardId);
			}
			catch(Exception ex)
			{
				return new Card();
			}
		}

		public Library GetLibrary(int id)
		{
			return db.Libraries.Include(library => library.scryfallCards).ThenInclude(cards => cards.image_uris)
				.FirstOrDefault(l => l.Id == id);
		}

		public bool RemoveCardFromLibrary(Card card, int Libid)
		{
			try
			{
				var library = db.Libraries.Include(library => library.scryfallCards).FirstOrDefault(l => l.Id == Libid).scryfallCards.Remove(card);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public void RemoveLibrary()
		{
			throw new NotImplementedException();
		}

		public bool UpdateCardInLibrary(Card card, int Libid)
		{
			try
			{
				var cardToUpdated = db.Libraries
					.Include(library => library.scryfallCards).ThenInclude(sc => sc.image_uris)
					.Include(library => library.scryfallCards).ThenInclude(sc => sc.prices)
					.Include(library => library.scryfallCards).ThenInclude(sc => sc.purchase_uris)
					.Include(library => library.scryfallCards).ThenInclude(sc => sc.related_uris)
					.Include(library => library.scryfallCards).ThenInclude(sc => sc.legalities)
					.FirstOrDefault(l => l.Id == Libid).scryfallCards.FirstOrDefault(scard => scard.card_id == card.card_id);

				cardToUpdated.UpdateCard(card);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				Log.Error($"Failed to Add card to Library: {ex}");
				return false;
			}
		}
	}
}
