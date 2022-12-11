using MTGLibraryDA.Entities;

namespace MTGLibrary.ViewModel
{
    public class LibCardVM
    {
        public string CardId { get; set; }
		public string Image_uri { get; set; }
        public string CardName { get; set; }
        public int Count { get; set; }
        public string Location { get; set; }

        public string? CKPurchaseUri { get; set; }

        public Prices Prices { get; set; }
    }
}
