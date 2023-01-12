using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGLibraryDA.Entities
{
	public class Library
	{
		[BsonId]
		public int Id { get; set; }

		[BsonElement("Cards")]
		public ICollection<Card> scryfallCards { get; set; }
	}
}
