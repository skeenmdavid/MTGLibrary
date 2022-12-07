using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MTGLibraryDA.Entities
{
	public class ScryfallCard
	{

		[JsonPropertyName("id")]
		public string card_id { get; set; }
		public string oracle_id { get; set; }
		public object[] multiverse_ids { get; set; }
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
		public object[] colors { get; set; }
		public object[] color_identity { get; set; }
		public object[] keywords { get; set; }
		public string[] produced_mana { get; set; }
		public Legalities legalities { get; set; }
		public string[] games { get; set; }
		public bool reserved { get; set; }
		public bool foil { get; set; }
		public bool nonfoil { get; set; }
		public string[] finishes { get; set; }
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
		public string flavor_text { get; set; }
		public string card_back_id { get; set; }
		public string artist { get; set; }
		public string[] artist_ids { get; set; }
		public string illustration_id { get; set; }
		public string border_color { get; set; }
		public string frame { get; set; }
		public string security_stamp { get; set; }
		public bool full_art { get; set; }
		public bool textless { get; set; }
		public bool booster { get; set; }
		public bool story_spotlight { get; set; }
		public int edhrec_rank { get; set; }
		public Prices prices { get; set; }
		public Related_Uris related_uris { get; set; }
		public Purchase_Uris purchase_uris { get; set; }

		public Card ToCard()
		{
			var card = new Card();
			card.card_id = card_id;
			card.oracle_id = oracle_id;
			card.tcgplayer_id = tcgplayer_id;
			card.card_name = card_name;
			card.lang = lang;
			card.released_at = released_at;
			card.card_uri = card_uri;
			card.scryfall_uri = scryfall_uri;
			card.layout = layout;
			card.highres_image = highres_image;
			card.image_status = image_status;
			card.image_uris = image_uris;
			card.mana_cost = mana_cost;
			card.cmc = cmc;
			card.type_line = type_line;
			card.oracle_text = oracle_text;
			card.colors = string.Join(",", this.colors);
			card.color_identity = string.Join(",", this.color_identity);
			card.keywords = string.Join(",", this.keywords);
			card.legalities = legalities;
			card.reserved = reserved;
			card.foil = foil;
			card.nonfoil = nonfoil;
			card.finishes = string.Join(",", this.finishes);
			card.oversized = oversized;
			card.promo = promo;
			card.reprint = reprint;
			card.variation = variation;
			card.set_id = set_id;
			card.set = set;
			card.set_type = set_type;
			card.set_uri = set_uri;
			card.set_name = set_name;
			card.set_search_uri = set_search_uri;
			card.scryfall_set_uri = scryfall_set_uri;
			card.rulings_uri = rulings_uri;
			card.prints_search_uri = prints_search_uri;
			card.collector_number = collector_number;
			card.digital = digital;
			card.rarity = rarity;
			card.flavor_text = flavor_text;
			card.card_back_id = card_back_id;
			card.artist = artist;
			card.illustration_id = illustration_id;
			card.border_color = border_color;
			card.frame = frame;
			card.security_stamp = security_stamp;
			card.full_art = full_art;
			card.textless = textless;
			card.booster = booster;
			card.story_spotlight = story_spotlight;
			card.edhrec_rank = edhrec_rank;
			card.prices = prices;
			card.related_uris = related_uris;
			card.purchase_uris = purchase_uris;

			return card;
		}
	}
}
