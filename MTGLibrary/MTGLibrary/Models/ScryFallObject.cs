using MTGLibraryDA.Entities;

namespace MTGLibrary.Models
{
	public class ScryFallObject
	{
		public string _object { get; set; }
		public int total_cards { get; set; }
		public bool has_more { get; set; }
		public ScryfallCard[] data { get; set; }
	}
}
