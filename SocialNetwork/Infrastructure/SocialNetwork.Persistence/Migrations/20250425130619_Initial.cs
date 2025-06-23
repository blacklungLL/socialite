using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SocialNetwork.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserPageId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    LikeCount = table.Column<int>(type: "integer", nullable: false),
                    DislikeCount = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "UserPageId", "Content", "LikeCount", "DislikeCount" },
                values: new object[,]
                {
                    { 1, 1, "The base model of the Suzuki Swift is perfect for urban driving. With a fuel-efficient engine and a compact design, it offers excellent maneuverability in city traffic. The manual transmission ensures a sporty driving experience, while the spacious interior provides comfort for all passengers.", 189, 21 },
                    { 2, 2, "Traveling is more than just visiting new places; it’s about experiencing different cultures, meeting new people, and discovering yourself along the way. Whether you’re exploring a bustling city, hiking through serene mountains, or relaxing on a sun-kissed beach, every journey leaves a mark on your soul. \ud83c\udf0d\u2728\n\nIt’s not about the destination—it’s about the stories you collect, the memories you create, and the perspectives you gain. So pack your bags, embrace the unknown, and let the adventure begin! \u2708\ufe0f\ud83c\udf92 #Wanderlust #TravelGoals", 140, 90 },
                    { 3, 2, "Every day brings new opportunities to grow, learn, and become a better version of yourself. Sometimes the road is smooth, and sometimes it’s bumpy—but every step counts. \ud83d\udcab\n\nLately, I’ve been focusing on gratitude and mindfulness. Taking a moment each day to appreciate the little things has made such a difference in my life. Whether it’s a sunrise, a good cup of coffee, or a meaningful conversation—these small moments add up to something truly beautiful. \u2600\ufe0f\u2615", 495, 187 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
