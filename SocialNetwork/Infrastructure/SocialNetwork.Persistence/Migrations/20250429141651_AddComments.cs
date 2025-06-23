using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SocialNetwork.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Avatar = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });
            
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "UserId", "PostId", "Content", "Avatar" },
                values: new object[,]
                {
                    { 1, 1, 1, "Great post! I love the insights you shared.", "~/assets/images/avatars/avatar-1.jpg" },
                    { 2, 2, 1, "This is so helpful! Thanks for sharing.", "~/assets/images/avatars/avatar-2.jpg" },
                    { 3, 1, 1, "I completely agree with your point of view.", "~/assets/images/avatars/avatar-1.jpg" },
                    { 4, 3, 2, "Wow, this is exactly what I needed to read today.", "~/assets/images/avatars/avatar-3.jpg" },
                    { 5, 4, 2, "Thanks for the detailed explanation!", "~/assets/images/avatars/avatar-4.jpg" },
                    { 6, 2, 2, "I have a question about this part. Can you clarify?", "~/assets/images/avatars/avatar-2.jpg" },
                    { 7, 5, 3, "Amazing content! Keep it up.", "~/assets/images/avatars/avatar-5.jpg" },
                    { 8, 6, 3, "I learned so much from this post.", "~/assets/images/avatars/avatar-6.jpg" },
                    { 9, 1, 3, "This is pure gold! Thank you.", "~/assets/images/avatars/avatar-1.jpg" },
                    { 10, 7, 4, "I love how you explained this topic.", "~/assets/images/avatars/avatar-7.jpg" },
                    { 11, 8, 4, "This is so inspiring! Thank you.", "~/assets/images/avatars/avatar-8.jpg" },
                    { 12, 3, 4, "I can't wait to try this out!", "~/assets/images/avatars/avatar-3.jpg" },
                    { 13, 9, 5, "You always share such valuable content.", "~/assets/images/avatars/avatar-9.jpg" },
                    { 14, 10, 5, "This is exactly what I was looking for.", "~/assets/images/avatars/avatar-10.jpg" },
                    { 15, 5, 5, "I appreciate the effort you put into this.", "~/assets/images/avatars/avatar-5.jpg" },
                    { 16, 11, 6, "Such an interesting perspective!", "~/assets/images/avatars/avatar-11.jpg" },
                    { 17, 12, 6, "Thank you for sharing this with us.", "~/assets/images/avatars/avatar-12.jpg" },
                    { 18, 7, 6, "I never thought about it this way.", "~/assets/images/avatars/avatar-7.jpg" },
                    { 19, 13, 7, "This is so well-written and insightful.", "~/assets/images/avatars/avatar-13.jpg" },
                    { 20, 14, 7, "I’m definitely bookmarking this post.", "~/assets/images/avatars/avatar-14.jpg" },
                    { 21, 9, 7, "Your posts always inspire me.", "~/assets/images/avatars/avatar-9.jpg" },
                    { 22, 15, 8, "This is such a great idea!", "~/assets/images/avatars/avatar-15.jpg" },
                    { 23, 16, 8, "I’m going to share this with my friends.", "~/assets/images/avatars/avatar-16.jpg" },
                    { 24, 11, 8, "Thank you for making this so easy to understand.", "~/assets/images/avatars/avatar-11.jpg" },
                    { 25, 17, 9, "This is exactly what I needed to hear.", "~/assets/images/avatars/avatar-17.jpg" },
                    { 26, 18, 9, "I’m so glad I found this post.", "~/assets/images/avatars/avatar-18.jpg" },
                    { 27, 13, 9, "You’re amazing at explaining things.", "~/assets/images/avatars/avatar-13.jpg" },
                    { 28, 19, 10, "This is so motivating! Thank you.", "~/assets/images/avatars/avatar-19.jpg" },
                    { 29, 20, 10, "I can’t wait to apply this in my life.", "~/assets/images/avatars/avatar-20.jpg" },
                    { 30, 15, 10, "You’re doing an incredible job!", "~/assets/images/avatars/avatar-15.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
