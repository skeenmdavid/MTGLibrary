using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGLibraryDA.Entities
{
	public class Deck
	{
		public int Id { get; set; }
		public string Name { get; set; }
		ICollection<Card> Cards { get; set; }
	}
}
