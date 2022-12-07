using MTGLibraryDA.Entities;

namespace MTGLibrary.Extensions
{
	public static class CardExtension
	{
		public static Card UpdateCard(this Card currentCard, Card newCard)
		{
			currentCard.card_id = newCard.card_id;
			currentCard.oracle_id = newCard.oracle_id;
			currentCard.tcgplayer_id = newCard.tcgplayer_id;
			currentCard.card_name = newCard.card_name;
			currentCard.lang = newCard.lang;
			currentCard.released_at = newCard.released_at;
			currentCard.card_uri = newCard.card_uri;
			currentCard.scryfall_uri = newCard.scryfall_uri;
			currentCard.layout = newCard.layout;
			currentCard.highres_image = newCard.highres_image;
			currentCard.image_status = newCard.image_status;
			currentCard.image_uris = newCard.image_uris;
			currentCard.mana_cost = newCard.mana_cost;
			currentCard.cmc = newCard.cmc;
			currentCard.type_line = newCard.type_line;
			currentCard.oracle_text = newCard.oracle_text;
			currentCard.colors = newCard.colors;
			currentCard.color_identity = newCard.color_identity;
			currentCard.keywords = newCard.keywords;
			currentCard.legalities = newCard.legalities;
			currentCard.reserved = newCard.reserved;
			currentCard.foil = newCard.foil;
			currentCard.nonfoil = newCard.nonfoil;
			currentCard.finishes = newCard.finishes;
			currentCard.oversized = newCard.oversized;
			currentCard.promo = newCard.promo;
			currentCard.reprint = newCard.reprint;
			currentCard.variation = newCard.variation;
			currentCard.set_id = newCard.set_id;
			currentCard.set = newCard.set;
			currentCard.set_type = newCard.set_type;
			currentCard.set_uri = newCard.set_uri;
			currentCard.set_name = newCard.set_name;
			currentCard.set_search_uri = newCard.set_search_uri;
			currentCard.scryfall_set_uri = newCard.scryfall_set_uri;
			currentCard.rulings_uri = newCard.rulings_uri;
			currentCard.prints_search_uri = newCard.prints_search_uri;
			currentCard.collector_number = newCard.collector_number;
			currentCard.digital = newCard.digital;
			currentCard.rarity = newCard.rarity;
			currentCard.flavor_text = newCard.flavor_text;
			currentCard.card_back_id = newCard.card_back_id;
			currentCard.artist = newCard.artist;
			currentCard.illustration_id = newCard.illustration_id;
			currentCard.border_color = newCard.border_color;
			currentCard.frame = newCard.frame;
			currentCard.security_stamp = newCard.security_stamp;
			currentCard.full_art = newCard.full_art;
			currentCard.textless = newCard.textless;
			currentCard.booster = newCard.booster;
			currentCard.story_spotlight = newCard.story_spotlight;
			currentCard.edhrec_rank = newCard.edhrec_rank;
			currentCard.prices = newCard.prices;
			currentCard.related_uris = newCard.related_uris;
			currentCard.purchase_uris = newCard.purchase_uris;
			currentCard.CountOwned = newCard.CountOwned;

			return currentCard;
		}
	}
}
