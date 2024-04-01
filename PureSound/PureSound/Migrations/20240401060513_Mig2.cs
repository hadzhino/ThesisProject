using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureSound.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3a85e018-105f-47fe-96ef-244fd8356e1b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("440fb91c-45eb-4b0d-9d7b-1c83f7968fda"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("568741be-2893-4c6a-81c4-dd9ad192878a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("583f22bc-649e-4436-88f2-69422d437893"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("73d1d918-7b35-4861-81ad-3c9a5f1185b0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("81f892f4-bd93-46ab-86b8-59aa6f81c034"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a593b3fa-c6c3-4376-9387-e8f377c7e20f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("10f8df1b-3393-4d1c-a717-cc114f1e2233"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1684d000-a724-4fc2-b7e9-17134fa886e4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1971d2ef-9c4f-4d5c-9cf4-10f805682a1a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3b65e6ee-4b81-4068-ab30-bf3b5d4d3938"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3e5e7ce5-f42e-4f09-9185-8a572e6b72fb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3f65b233-08e9-4310-8c85-d908a28a2596"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("64d3f8a6-9df5-4d6c-9f58-803fd59c7d0f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7e875cd6-9691-4e4c-b9cc-7d2c212e9206"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("91fc3822-bb39-4fe4-b1c4-5a393b6fe53e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a9c75c4b-fb6b-4af2-81eb-1ea4feea87fd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("af4c47bb-61bf-46ca-97d2-fcf80cbeaecb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c924b407-f8e8-457b-a4ac-fee86bd48be0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e4df2d39-77d7-42bb-8a16-6ed672705588"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleCategories_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cbcd2ee-af73-408e-94b5-769230f3ae54", "AQAAAAIAAYagAAAAEAL1IbmRTm5tlT3KgESgIVyQWuuYuT1dkp0Tq8HWVjios4Blyle75ttmhHoh47NfWQ==", "3f90bd3e-6a7c-433b-b142-236315336325" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2279afeb-9e86-478a-a14c-498677a1e0e5"), "New production" },
                    { new Guid("59035821-4fcb-4315-a65e-f53407f33052"), "Lifestyle" },
                    { new Guid("99960bb8-53ca-495a-9be3-929e5f2becc8"), "BREAKING" },
                    { new Guid("f81cb7ce-432f-49ee-82ab-e8b1790643c7"), "Rising stars" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("081a1986-3e54-4bcd-b2b3-6617e5377059"), "Rap" },
                    { new Guid("566fc94d-a901-40f6-990c-38c9d775bfea"), "Phonk" },
                    { new Guid("56e579c2-9f9f-4e77-a6c0-bda366ee16b0"), "Techno" },
                    { new Guid("89da19e1-af14-457c-bedc-1a35a75a18cf"), "Drill" },
                    { new Guid("a1a76027-ad95-421c-9938-d8b7e189e5b0"), "House" },
                    { new Guid("d663d434-7b2b-4eea-bda5-2540446305bd"), "Raeggeton" },
                    { new Guid("ee1f87a0-cf4a-49df-8088-282b071a0466"), "R&B" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1412664a-21c7-4b4b-b443-f36739bfca59"), "East Coast (NORTH AMERICA)" },
                    { new Guid("2b3aa1ba-e141-4280-a397-97b96f85f90b"), "Latin America" },
                    { new Guid("32a99cba-303a-4f5e-835e-6261dacfe390"), "Balkans (EUROPE)" },
                    { new Guid("3af96622-aee5-4e15-b7ec-d4621172738e"), "Africa" },
                    { new Guid("3e96265e-29f6-4e0e-b7c9-d5668ce446be"), "Oceania" },
                    { new Guid("43609c1a-b524-4920-a635-77160af801f1"), "East Asia" },
                    { new Guid("5df0f3fd-ec78-4303-acff-a17982489555"), "South America" },
                    { new Guid("c4feb616-ee63-4527-acae-d95381afdbe4"), "West Asia" },
                    { new Guid("cdad4800-9eed-4755-8f4c-401efe494e4b"), "East Europe" },
                    { new Guid("d344a779-3aed-499f-a17a-46312b2afc1c"), "Middle Asia" },
                    { new Guid("ea8d1995-91c5-44ad-9dcf-8b3c3aa58153"), "West Coast (NORTH AMERICA)" },
                    { new Guid("f387d1f5-93ad-478c-8b9d-c4e688938ffd"), "Middle East (ASIA)" },
                    { new Guid("ff66e5af-dc77-485a-b494-44f5bca586d4"), "West Europe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_ArticleId",
                table: "ArticleCategories",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_CategoryId",
                table: "ArticleCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("081a1986-3e54-4bcd-b2b3-6617e5377059"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("566fc94d-a901-40f6-990c-38c9d775bfea"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("56e579c2-9f9f-4e77-a6c0-bda366ee16b0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("89da19e1-af14-457c-bedc-1a35a75a18cf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a1a76027-ad95-421c-9938-d8b7e189e5b0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d663d434-7b2b-4eea-bda5-2540446305bd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ee1f87a0-cf4a-49df-8088-282b071a0466"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1412664a-21c7-4b4b-b443-f36739bfca59"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2b3aa1ba-e141-4280-a397-97b96f85f90b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("32a99cba-303a-4f5e-835e-6261dacfe390"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3af96622-aee5-4e15-b7ec-d4621172738e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3e96265e-29f6-4e0e-b7c9-d5668ce446be"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("43609c1a-b524-4920-a635-77160af801f1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5df0f3fd-ec78-4303-acff-a17982489555"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c4feb616-ee63-4527-acae-d95381afdbe4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cdad4800-9eed-4755-8f4c-401efe494e4b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d344a779-3aed-499f-a17a-46312b2afc1c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ea8d1995-91c5-44ad-9dcf-8b3c3aa58153"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f387d1f5-93ad-478c-8b9d-c4e688938ffd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ff66e5af-dc77-485a-b494-44f5bca586d4"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f0e291f-a132-4d6b-b68b-047c8b688cd7", "AQAAAAIAAYagAAAAEJN3V+MkOuOc+a6+saL8HprhLS3hPQXYaV5Wx9LiGqaH/mheOPGWOIK0vKcDParKXg==", "09a18620-a033-4c07-8f2f-2abadfafc92e" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3a85e018-105f-47fe-96ef-244fd8356e1b"), "Drill" },
                    { new Guid("440fb91c-45eb-4b0d-9d7b-1c83f7968fda"), "House" },
                    { new Guid("568741be-2893-4c6a-81c4-dd9ad192878a"), "R&B" },
                    { new Guid("583f22bc-649e-4436-88f2-69422d437893"), "Techno" },
                    { new Guid("73d1d918-7b35-4861-81ad-3c9a5f1185b0"), "Rap" },
                    { new Guid("81f892f4-bd93-46ab-86b8-59aa6f81c034"), "Raeggeton" },
                    { new Guid("a593b3fa-c6c3-4376-9387-e8f377c7e20f"), "Phonk" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("10f8df1b-3393-4d1c-a717-cc114f1e2233"), "East Europe" },
                    { new Guid("1684d000-a724-4fc2-b7e9-17134fa886e4"), "West Europe" },
                    { new Guid("1971d2ef-9c4f-4d5c-9cf4-10f805682a1a"), "Middle East (ASIA)" },
                    { new Guid("3b65e6ee-4b81-4068-ab30-bf3b5d4d3938"), "South America" },
                    { new Guid("3e5e7ce5-f42e-4f09-9185-8a572e6b72fb"), "Balkans (EUROPE)" },
                    { new Guid("3f65b233-08e9-4310-8c85-d908a28a2596"), "Oceania" },
                    { new Guid("64d3f8a6-9df5-4d6c-9f58-803fd59c7d0f"), "Africa" },
                    { new Guid("7e875cd6-9691-4e4c-b9cc-7d2c212e9206"), "West Coast (NORTH AMERICA)" },
                    { new Guid("91fc3822-bb39-4fe4-b1c4-5a393b6fe53e"), "Latin America" },
                    { new Guid("a9c75c4b-fb6b-4af2-81eb-1ea4feea87fd"), "West Asia" },
                    { new Guid("af4c47bb-61bf-46ca-97d2-fcf80cbeaecb"), "East Asia" },
                    { new Guid("c924b407-f8e8-457b-a4ac-fee86bd48be0"), "East Coast (NORTH AMERICA)" },
                    { new Guid("e4df2d39-77d7-42bb-8a16-6ed672705588"), "Middle Asia" }
                });
        }
    }
}
