using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SocialNetwork.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventName = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    EventDate = table.Column<string>(type: "text", nullable: false),
                    InterestedCnt = table.Column<int>(type: "integer", nullable: false),
                    GoingCnt = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
            
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EventName", "Image", "Author", "EventDate", "InterestedCnt", "GoingCnt" },
                values: new object[,]
                {
                    { 1, "Tech Conference 2024", "~/assets/images/events/img-1.jpg", "UK Brands", "2024-03-15", 1500, 750 },
                    { 2, "Music Festival", "~/assets/images/events/img-2.jpg", "Catiana", "2024-06-10", 3000, 1200 },
                    { 3, "Art Exhibition", "~/assets/images/events/img-3.jpg", "ArtVision", "2024-04-05", 800, 400 },
                    { 4, "Startup Pitch Night", "~/assets/images/events/img-4.jpg", "InnoVate", "2024-05-20", 500, 200 },
                    { 5, "Food Truck Festival", "~/assets/images/events/img-5.jpg", "FoodieHub", "2024-07-01", 4000, 1800 },
                    { 6, "Hackathon 2024", "~/assets/images/events/img-6.jpg", "CodeMasters", "2024-08-12", 2000, 900 },
                    { 7, "Yoga Retreat", "~/assets/images/events/img-7.jpg", "ZenLife", "2024-09-25", 600, 300 },
                    { 8, "Comic Con", "~/assets/images/events/img-8.jpg", "SuperFan", "2024-10-05", 5000, 2500 },
                    { 9, "Wine Tasting Event", "~/assets/images/events/img-9.jpg", "VinoElite", "2024-11-15", 1000, 500 },
                    { 10, "Marathon Run", "~/assets/images/events/img-10.jpg", "RunnersWorld", "2024-12-01", 10000, 6000 },
                    { 11, "Book Fair", "~/assets/images/events/img-11.jpg", "LitLovers", "2024-02-20", 2000, 1000 },
                    { 12, "Gaming Convention", "~/assets/images/events/img-12.jpg", "GameOn", "2024-03-25", 3000, 1500 },
                    { 13, "Fashion Show", "~/assets/images/events/img-13.jpg", "StyleIcons", "2024-04-10", 2500, 1200 },
                    { 14, "Charity Gala", "~/assets/images/events/img-14.jpg", "HopeFoundation", "2024-05-01", 1500, 700 },
                    { 15, "Film Screening", "~/assets/images/events/img-15.jpg", "CineClub", "2024-06-15", 800, 400 },
                    { 16, "Science Fair", "~/assets/images/events/img-16.jpg", "SciQuest", "2024-07-20", 1200, 600 },
                    { 17, "Outdoor Adventure", "~/assets/images/events/img-17.jpg", "NatureLovers", "2024-08-05", 900, 450 },
                    { 18, "Photography Workshop", "~/assets/images/events/img-18.jpg", "LensCraft", "2024-09-10", 700, 350 },
                    { 19, "Dance Party", "~/assets/images/events/img-19.jpg", "GrooveNation", "2024-10-20", 2000, 1000 },
                    { 20, "Cooking Class", "~/assets/images/events/img-20.jpg", "ChefMagic", "2024-11-05", 500, 250 },
                    { 21, "Pet Adoption Day", "~/assets/images/events/img-21.jpg", "PawsAndClaws", "2024-12-10", 3000, 1500 },
                    { 22, "Networking Mixer", "~/assets/images/events/img-22.jpg", "BizConnect", "2024-02-15", 1000, 500 },
                    { 23, "Cultural Festival", "~/assets/images/events/img-23.jpg", "Cultura", "2024-03-01", 4000, 2000 },
                    { 24, "TEDx Talk", "~/assets/images/events/img-24.jpg", "IdeaSpark", "2024-04-25", 1500, 750 },
                    { 25, "Car Show", "~/assets/images/events/img-25.jpg", "AutoElite", "2024-05-15", 2000, 1000 },
                    { 26, "Board Game Night", "~/assets/images/events/img-26.jpg", "GameNight", "2024-06-20", 800, 400 },
                    { 27, "Fitness Bootcamp", "~/assets/images/events/img-27.jpg", "FitFury", "2024-07-10", 1200, 600 },
                    { 28, "Poetry Reading", "~/assets/images/events/img-28.jpg", "VerseVibes", "2024-08-15", 600, 300 },
                    { 29, "Craft Fair", "~/assets/images/events/img-29.jpg", "HandMade", "2024-09-20", 1000, 500 },
                    { 30, "Eco-Friendly Workshop", "~/assets/images/events/img-30.jpg", "GreenFuture", "2024-10-10", 900, 450 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
