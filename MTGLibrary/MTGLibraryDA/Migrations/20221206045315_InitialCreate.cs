using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTGLibraryDA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image_Uris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    small = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    normal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    large = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    png = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    art_crop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    border_crop = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image_Uris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Legalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    standard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    future = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    historic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gladiator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pioneer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    explorer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modern = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    legacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pauper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vintage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    penny = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commander = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brawl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    historicbrawl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alchemy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paupercommander = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oldschool = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    premodern = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Library", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usd = table.Column<int>(type: "int", nullable: false),
                    usd_foil = table.Column<int>(type: "int", nullable: false),
                    usd_etched = table.Column<int>(type: "int", nullable: false),
                    eur = table.Column<int>(type: "int", nullable: false),
                    eur_foil = table.Column<int>(type: "int", nullable: false),
                    tix = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Uris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tcgplayer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cardmarket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cardhoarder = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Uris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Related_Uris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tcgplayer_infinite_articles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tcgplayer_infinite_decks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edhrec = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Related_Uris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScryfallCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _object = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    card_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oracle_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tcgplayer_id = table.Column<int>(type: "int", nullable: false),
                    card_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    released_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    card_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    scryfall_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    layout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    highres_image = table.Column<bool>(type: "bit", nullable: false),
                    image_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image_urisId = table.Column<int>(type: "int", nullable: false),
                    mana_cost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cmc = table.Column<float>(type: "real", nullable: false),
                    type_line = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oracle_text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    colors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color_identity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    keywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    legalitiesId = table.Column<int>(type: "int", nullable: false),
                    reserved = table.Column<bool>(type: "bit", nullable: false),
                    foil = table.Column<bool>(type: "bit", nullable: false),
                    nonfoil = table.Column<bool>(type: "bit", nullable: false),
                    finishes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oversized = table.Column<bool>(type: "bit", nullable: false),
                    promo = table.Column<bool>(type: "bit", nullable: false),
                    reprint = table.Column<bool>(type: "bit", nullable: false),
                    variation = table.Column<bool>(type: "bit", nullable: false),
                    set_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_search_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    scryfall_set_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rulings_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prints_search_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    collector_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    digital = table.Column<bool>(type: "bit", nullable: false),
                    rarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    flavor_text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    card_back_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    illustration_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    border_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    security_stamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    full_art = table.Column<bool>(type: "bit", nullable: false),
                    textless = table.Column<bool>(type: "bit", nullable: false),
                    booster = table.Column<bool>(type: "bit", nullable: false),
                    story_spotlight = table.Column<bool>(type: "bit", nullable: false),
                    edhrec_rank = table.Column<int>(type: "int", nullable: false),
                    pricesId = table.Column<int>(type: "int", nullable: false),
                    related_urisId = table.Column<int>(type: "int", nullable: false),
                    purchase_urisId = table.Column<int>(type: "int", nullable: false),
                    CountOwned = table.Column<int>(type: "int", nullable: false),
                    LibraryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScryfallCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScryfallCards_Image_Uris_image_urisId",
                        column: x => x.image_urisId,
                        principalTable: "Image_Uris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScryfallCards_Legalities_legalitiesId",
                        column: x => x.legalitiesId,
                        principalTable: "Legalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScryfallCards_Library_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Library",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScryfallCards_Prices_pricesId",
                        column: x => x.pricesId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScryfallCards_Purchase_Uris_purchase_urisId",
                        column: x => x.purchase_urisId,
                        principalTable: "Purchase_Uris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScryfallCards_Related_Uris_related_urisId",
                        column: x => x.related_urisId,
                        principalTable: "Related_Uris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScryfallCards_image_urisId",
                table: "ScryfallCards",
                column: "image_urisId");

            migrationBuilder.CreateIndex(
                name: "IX_ScryfallCards_legalitiesId",
                table: "ScryfallCards",
                column: "legalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_ScryfallCards_LibraryId",
                table: "ScryfallCards",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_ScryfallCards_pricesId",
                table: "ScryfallCards",
                column: "pricesId");

            migrationBuilder.CreateIndex(
                name: "IX_ScryfallCards_purchase_urisId",
                table: "ScryfallCards",
                column: "purchase_urisId");

            migrationBuilder.CreateIndex(
                name: "IX_ScryfallCards_related_urisId",
                table: "ScryfallCards",
                column: "related_urisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "ScryfallCards");

            migrationBuilder.DropTable(
                name: "Image_Uris");

            migrationBuilder.DropTable(
                name: "Legalities");

            migrationBuilder.DropTable(
                name: "Library");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Purchase_Uris");

            migrationBuilder.DropTable(
                name: "Related_Uris");
        }
    }
}
