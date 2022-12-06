﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGLibraryDA.Entities
{
	public class Legalities
	{
		public int Id { get; set; }
		public string standard { get; set; }
		public string future { get; set; }
		public string historic { get; set; }
		public string gladiator { get; set; }
		public string pioneer { get; set; }
		public string explorer { get; set; }
		public string modern { get; set; }
		public string legacy { get; set; }
		public string pauper { get; set; }
		public string vintage { get; set; }
		public string penny { get; set; }
		public string commander { get; set; }
		public string brawl { get; set; }
		public string historicbrawl { get; set; }
		public string alchemy { get; set; }
		public string paupercommander { get; set; }
		public string duel { get; set; }
		public string oldschool { get; set; }
		public string premodern { get; set; }
	}
}
