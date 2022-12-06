using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGLibraryDA.Entities
{
	public class Prices
	{
		public int Id { get; set; }
		public int usd { get; set; }
		public int usd_foil { get; set; }
		public int usd_etched { get; set; }
		public int eur { get; set; }
		public int eur_foil { get; set; }
		public int tix { get; set; }
	}
}
