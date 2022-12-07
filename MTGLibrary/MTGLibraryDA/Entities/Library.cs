using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGLibraryDA.Entities
{
	public class Library
	{
		public int Id { get; set; }

		public ICollection<Card> scryfallCards { get; set; }
	}
}
