using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureSound.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2279afeb-9e86-478a-a14c-498677a1e0e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59035821-4fcb-4315-a65e-f53407f33052"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99960bb8-53ca-495a-9be3-929e5f2becc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f81cb7ce-432f-49ee-82ab-e8b1790643c7"));

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

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30337ff6-9bfd-42dc-a608-c0e82675dccd", "AQAAAAIAAYagAAAAEJPpNmMc9YLHeCQnjSeGO0Uc50/S8otMVLKsyhrhTN/Iz9uoZH3N4D7e6SR/hGdlVA==", "13ed8cd2-3eda-4a6d-9276-738db82a7511" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4bb7ea19-d5e7-425e-975f-d1ff8c821505"), "New production" },
                    { new Guid("5a404d01-59b0-467f-aa0c-b784965f925c"), "Rising stars" },
                    { new Guid("c13f4755-8c79-46be-aa27-7b1505eab3ac"), "BREAKING" },
                    { new Guid("ecc0c732-51bf-45d0-a646-785e578b92ed"), "Lifestyle" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0cc47a8b-fa7b-4a2f-8976-dbfd317408c6"), "House" },
                    { new Guid("1b99263a-f107-46ca-9130-1671a8b8e674"), "Drill" },
                    { new Guid("20b699af-cdf9-4d6c-83f7-7273d52403ae"), "Phonk" },
                    { new Guid("510fbafe-4d46-43f3-b9ee-d4e3273ee160"), "R&B" },
                    { new Guid("80961a64-8c18-4cc8-9476-d4d5637c6466"), "Raeggeton" },
                    { new Guid("864665ff-ed41-4f80-9fb9-ae7ff997f550"), "Techno" },
                    { new Guid("adbdd114-7d5f-49c6-883c-4134428f491b"), "Rap" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("112673bc-f145-4bcd-8329-1b10b7fe1084"), "West Europe" },
                    { new Guid("18ff037f-9216-4144-acd8-34afbc7b0ec4"), "West Coast (NORTH AMERICA)" },
                    { new Guid("290f1082-0449-49cd-86d1-0059a99be0ec"), "East Asia" },
                    { new Guid("2dcafb5c-498e-4e0e-907c-00ea009c01a4"), "East Coast (NORTH AMERICA)" },
                    { new Guid("5b225ec7-fb5d-4228-acb6-d9a14be0bbe1"), "West Asia" },
                    { new Guid("63faaca2-7b5c-463a-b76b-a784b4ed36e2"), "Middle East (ASIA)" },
                    { new Guid("8d13d374-998d-4394-ac14-2e7d416791ec"), "South America" },
                    { new Guid("95f8df2d-e7fb-4aa5-8bf9-0f8b8ee7587e"), "Balkans (EUROPE)" },
                    { new Guid("a1f4c1b9-3670-4be8-bdee-8334ec7165f4"), "Middle Asia" },
                    { new Guid("c8b05d04-4d24-4967-9d3b-499209f67358"), "Latin America" },
                    { new Guid("c8f91217-3925-420a-8350-a3eb74e2ceec"), "East Europe" },
                    { new Guid("dd6d8c55-12bd-411d-8707-afa7ce8f252c"), "Oceania" },
                    { new Guid("e9f403cc-e3de-4864-842b-62b3b90968db"), "Africa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoryId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bb7ea19-d5e7-425e-975f-d1ff8c821505"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a404d01-59b0-467f-aa0c-b784965f925c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c13f4755-8c79-46be-aa27-7b1505eab3ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecc0c732-51bf-45d0-a646-785e578b92ed"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0cc47a8b-fa7b-4a2f-8976-dbfd317408c6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1b99263a-f107-46ca-9130-1671a8b8e674"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("20b699af-cdf9-4d6c-83f7-7273d52403ae"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("510fbafe-4d46-43f3-b9ee-d4e3273ee160"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("80961a64-8c18-4cc8-9476-d4d5637c6466"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("864665ff-ed41-4f80-9fb9-ae7ff997f550"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("adbdd114-7d5f-49c6-883c-4134428f491b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("112673bc-f145-4bcd-8329-1b10b7fe1084"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("18ff037f-9216-4144-acd8-34afbc7b0ec4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("290f1082-0449-49cd-86d1-0059a99be0ec"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2dcafb5c-498e-4e0e-907c-00ea009c01a4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5b225ec7-fb5d-4228-acb6-d9a14be0bbe1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("63faaca2-7b5c-463a-b76b-a784b4ed36e2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8d13d374-998d-4394-ac14-2e7d416791ec"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("95f8df2d-e7fb-4aa5-8bf9-0f8b8ee7587e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c1b9-3670-4be8-bdee-8334ec7165f4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c8b05d04-4d24-4967-9d3b-499209f67358"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c8f91217-3925-420a-8350-a3eb74e2ceec"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dd6d8c55-12bd-411d-8707-afa7ce8f252c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e9f403cc-e3de-4864-842b-62b3b90968db"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Articles");

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
    }
}
