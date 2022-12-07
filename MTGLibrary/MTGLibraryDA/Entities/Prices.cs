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
		public string usd { get; set; }
		public string usd_foil { get; set; }
		public string usd_etched { get; set; }
		public string eur { get; set; }
		public string eur_foil { get; set; }
		public string tix { get; set; }
	}
}
