using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTGLibraryDA.Migrations
{
    public partial class UpdateCardTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScryfallCards");

            migrationBuilder.CreateTable(
                name: "Cards",
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
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Image_Uris_image_urisId",
                        column: x => x.image_urisId,
                        principalTable: "Image_Uris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Legalities_legalitiesId",
                        column: x => x.legalitiesId,
                        principalTable: "Legalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cards_Prices_pricesId",
                        column: x => x.pricesId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Purchase_Uris_purchase_urisId",
                        column: x => x.purchase_urisId,
                        principalTable: "Purchase_Uris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cards_Related_Uris_related_urisId",
                        column: x => x.related_urisId,
                        principalTable: "Related_Uris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_image_urisId",
                table: "Cards",
                column: "image_urisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_legalitiesId",
                table: "Cards",
                column: "legalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_LibraryId",
                table: "Cards",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_pricesId",
                table: "Cards",
                column: "pricesId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_purchase_urisId",
                table: "Cards",
                column: "purchase_urisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_related_urisId",
                table: "Cards",
                column: "related_urisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.CreateTable(
                name: "ScryfallCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_urisId = table.Column<int>(type: "int", nullable: false),
                    legalitiesId = table.Column<int>(type: "int", nullable: false),
                    pricesId = table.Column<int>(type: "int", nullable: false),
                    purchase_urisId = table.Column<int>(type: "int", nullable: false),
                    related_urisId = table.Column<int>(type: "int", nullable: false),
                    CountOwned = table.Column<int>(type: "int", nullable: false),
                    LibraryId = table.Column<int>(type: "int", nullable: true),
                    _object = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    booster = table.Column<bool>(type: "bit", nullable: false),
                    border_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    card_back_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    card_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    card_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    card_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cmc = table.Column<float>(type: "real", nullable: false),
                    collector_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    color_identity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    colors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    digital = table.Column<bool>(type: "bit", nullable: false),
                    edhrec_rank = table.Column<int>(type: "int", nullable: false),
                    finishes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    flavor_text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    foil = table.Column<bool>(type: "bit", nullable: false),
                    frame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    full_art = table.Column<bool>(type: "bit", nullable: false),
                    highres_image = table.Column<bool>(type: "bit", nullable: false),
                    illustration_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    keywords = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    layout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mana_cost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nonfoil = table.Column<bool>(type: "bit", nullable: false),
                    oracle_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oracle_text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oversized = table.Column<bool>(type: "bit", nullable: false),
                    prints_search_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    promo = table.Column<bool>(type: "bit", nullable: false),
                    rarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    released_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reprint = table.Column<bool>(type: "bit", nullable: false),
                    reserved = table.Column<bool>(type: "bit", nullable: false),
                    rulings_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    scryfall_set_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    scryfall_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    security_stamp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_search_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    story_spotlight = table.Column<bool>(type: "bit", nullable: false),
                    tcgplayer_id = table.Column<int>(type: "int", nullable: false),
                    textless = table.Column<bool>(type: "bit", nullable: false),
                    type_line = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    variation = table.Column<bool>(type: "bit", nullable: false)
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
                        name: "FK_ScryfallCards_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
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
    }
}
