using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MTGLibraryDA.Entities
{
	public class Card
	{
		public int Id { get; set; }

		[JsonPropertyName("id")]
		public string card_id { get; set; }
		public string oracle_id { get; set; }
		public int tcgplayer_id { get; set; }
		[JsonPropertyName("name")]
		public string card_name { get; set; }
		public string lang { get; set; }
		public string released_at { get; set; }
		[JsonPropertyName("uri")]
		public string card_uri { get; set; }
		public string scryfall_uri { get; set; }
		public string layout { get; set; }
		public bool highres_image { get; set; }
		public string image_status { get; set; }
		public Image_Uris image_uris { get; set; }
		public string mana_cost { get; set; }
		public float cmc { get; set; }
		public string type_line { get; set; }
		public string oracle_text { get; set; }
		public string colors { get; set; }
		public string color_identity { get; set; }
		public string keywords { get; set; }
		public Legalities legalities { get; set; }
		public bool reserved { get; set; }
		public bool foil { get; set; }
		public bool nonfoil { get; set; }
		public string finishes { get; set; }
		public bool oversized { get; set; }
		public bool promo { get; set; }
		public bool reprint { get; set; }
		public bool variation { get; set; }
		public string set_id { get; set; }
		public string set { get; set; }
		public string set_name { get; set; }
		public string set_type { get; set; }
		public string set_uri { get; set; }
		public string set_search_uri { get; set; }
		public string scryfall_set_uri { get; set; }
		public string rulings_uri { get; set; }
		public string prints_search_uri { get; set; }
		public string collector_number { get; set; }
		public bool digital { get; set; }
		public string rarity { get; set; }
		public string? flavor_text { get; set; }
		public string? card_back_id { get; set; }
		public string? artist { get; set; }
		public string? illustration_id { get; set; }
		public string? border_color { get; set; }
		public string? frame { get; set; }
		public string? security_stamp { get; set; }
		public bool full_art { get; set; }
		public bool textless { get; set; }
		public bool booster { get; set; }
		public bool story_spotlight { get; set; }
		public int edhrec_rank { get; set; }
		public Prices prices { get; set; }
		public Related_Uris related_uris { get; set; }
		public Purchase_Uris purchase_uris { get; set; }

		public Library Library { get; set; }

		public int CountOwned { get; set; }
	}
}
