using Microsoft.EntityFrameworkCore;

namespace MTGLibraryDA.Entities
{
	public class MTGLibraryContext: DbContext
	{

		public MTGLibraryContext()
		{

		}

		public MTGLibraryContext(DbContextOptions<MTGLibraryContext> options): base(options)
		{
		}

		public DbSet<Deck> Decks { get; set; }
		public DbSet<Image_Uris> Image_Uris { get; set; }
		public DbSet<Legalities> Legalities { get; set; }
		public DbSet<Library> Libraries { get; set; }
		public DbSet<Prices> Prices { get; set; }
		public DbSet<Purchase_Uris> Purchase_Uris { get; set; }
		public DbSet<Related_Uris> Related_Uris { get; set; }
		public DbSet<ScryfallCard> ScryfallCards { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Deck>().ToTable("Decks");
			modelBuilder.Entity<Image_Uris>().ToTable("Image_Uris");
			modelBuilder.Entity<Legalities>().ToTable("Legalities");
			modelBuilder.Entity<Library>().ToTable("Libraries");
			modelBuilder.Entity<Prices>().ToTable("Prices");
			modelBuilder.Entity<Purchase_Uris>().ToTable("Purchase_Uris");
			modelBuilder.Entity<Related_Uris>().ToTable("Related_Uris");
			modelBuilder.Entity<ScryfallCard>().ToTable("ScryfallCards");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseSqlServer("Data Source=.\\SQLExpress;Initial Catalog=MTGLibrary;Integrated Security=True");
			}
		}
	}
}
