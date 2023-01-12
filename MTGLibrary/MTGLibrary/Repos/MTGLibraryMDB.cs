using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MTGLibrary.Interfaces;
using MTGLibrary.Models;
using MTGLibraryDA.Entities;

namespace MTGLibrary.Repos
{
    public class MTGLibraryMDB : IDatabaseAccess
    {
        private readonly IMongoCollection<Library> _librariesCollection;

        public MTGLibraryMDB(IOptions<MTGLibraryDatabaseSettings> mtgLibraryDBSettings)
        {
            var mongoClient = new MongoClient(
            mtgLibraryDBSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                mtgLibraryDBSettings.Value.DatabaseName);

            _librariesCollection = mongoDatabase.GetCollection<Library>(
                mtgLibraryDBSettings.Value.CollectionName);
        }

        public bool AddCardToLibrary(Card card, int Libid)
        {
            throw new NotImplementedException();
        }

        public void AddDeck(Deck deck)
        {
            throw new NotImplementedException();
        }

        public void AddLibrary()
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAllLibraries()
        {
            throw new NotImplementedException();
        }

        public Card GetCardFromLibrary(string cardId, int Libid)
        {
            throw new NotImplementedException();
        }

        public Library GetLibrary(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCardFromLibrary(Card card, int Libid)
        {
            throw new NotImplementedException();
        }

        public void RemoveLibrary()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCardInLibrary(Card card, int Libid)
        {
            throw new NotImplementedException();
        }
    }
}
