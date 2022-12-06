using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGLibraryDA.Entities
{
	public class Image_Uris
	{
		public int Id { get; set; }
		public string small { get; set; }
		public string normal { get; set; }
		public string large { get; set; }
		public string png { get; set; }
		public string art_crop { get; set; }
		public string border_crop { get; set; }
	}
}
