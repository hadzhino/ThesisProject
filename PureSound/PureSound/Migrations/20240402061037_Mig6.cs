using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureSound.Migrations
{
    /// <inheritdoc />
    public partial class Mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dc4e336-7b32-4828-a8e5-1150c547a604"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5aead36-723f-4e91-8ae1-3483b1ece4e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9b55a91-c620-4b5c-816e-e9ab68891035"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec44d824-670f-48d8-afc6-2920c1584451"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("45221fad-7ad3-4e1f-a41d-24fc04d56928"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4b62643f-4982-40bc-ac5f-2375e079c744"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("73f5fff4-8993-4134-8061-06f751c57211"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8fdeac7e-90f9-4734-8f59-d44158d2d47a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e3116896-17e0-4cc1-8ea2-701ff0c8baa3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ee61b87e-2d87-4140-b27a-0ed7be2ad6cc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fabc34f8-c8be-44b4-b4f1-813306d49004"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("00fefb35-c407-4300-8927-8e43a63d25ac"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0d011743-2796-4c15-b894-40beee728bcf"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("305b2d56-1f6f-459c-bb47-46a24c2864f7"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("59bd3803-31ec-42ec-a520-3e6959e8ec5a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5b49776d-9219-43b8-ad7b-bd568b1053cb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("603adf35-6eb2-47a1-8fcb-9888ae468846"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("606bc68c-cdb3-4182-b91d-2831f85007a6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("63d604c8-d78b-44f4-a00b-024562348640"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("bdd29e4f-631e-4d49-ab75-b26ccaeb17d5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d081b738-96ce-4cc5-bf00-4e02d68b9166"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e7e08a06-99c2-457b-acb4-e7b693b6ea6e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ea155cef-68a1-4729-96ff-80ffa7dab707"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("eb407147-422b-4e1c-b4b3-02ad9c219eef"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8e39dfa-fbd1-437e-87c4-82415c2a1f4d", "AQAAAAIAAYagAAAAEN3u0FRPBDvLPd7waUlOwX+WkTo+vhuXSnhxJmEZsQEHmuR2mkmniwVlz6y2YpF+uA==", "cf89a856-a82e-412d-afa1-b648d9407688" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6e75a272-64fc-4ba9-a7c8-8675c0c2ff38"), "BREAKING" },
                    { new Guid("acae7e3d-be21-48ce-8c2d-3f842f6a926b"), "Lifestyle" },
                    { new Guid("cad0ec03-b6d0-4a25-b8c8-a4b8c192b325"), "Rising stars" },
                    { new Guid("ed3d11a6-b5ae-4c4b-8a46-19a695708970"), "New production" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1c055423-ab04-47e9-940e-3afb36eee456"), "Raeggeton" },
                    { new Guid("2fcc7955-6dd8-4d5d-a7dd-2350cb84c6d9"), "Drill" },
                    { new Guid("63bd0525-0baf-4419-b47f-0589bd61204d"), "Techno" },
                    { new Guid("9ab07904-884c-4545-979c-0892141b1165"), "House" },
                    { new Guid("a790711e-e812-4905-ad84-68dd53bd3ee6"), "Phonk" },
                    { new Guid("a9b0a18c-30fd-47a2-ab96-dc06fea52757"), "Rap" },
                    { new Guid("b5c3f47e-ca1f-437f-8617-78df26da060c"), "R&B" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00513d68-4f5d-44d9-9df6-246378340f4f"), "West Europe" },
                    { new Guid("34b5baaf-14fd-4a75-be35-c1705aa337a0"), "South America" },
                    { new Guid("38ed271e-076d-42d7-aa8e-b03ac9b452fc"), "East Europe" },
                    { new Guid("429ccaca-a503-44fc-b187-75f8f37197a7"), "East Asia" },
                    { new Guid("581b2327-2287-4e7f-ac87-f0bae26c0297"), "Middle Asia" },
                    { new Guid("5b382a80-e404-46d0-94c7-9a5b33199ee2"), "Oceania" },
                    { new Guid("66ead295-3b80-4925-86eb-2dd0bdb2bd54"), "West Coast (NORTH AMERICA)" },
                    { new Guid("7eb5cd16-c8a2-45ed-b42d-9fbb471cdef6"), "East Coast (NORTH AMERICA)" },
                    { new Guid("95971156-3f54-4328-9c7c-6c41a0f9333a"), "West Asia" },
                    { new Guid("d019dc12-d4a0-4ce8-b7ea-9293d90db5ae"), "Latin America" },
                    { new Guid("d7719e9c-d0b1-4424-8585-acc74da66be9"), "Balkans (EUROPE)" },
                    { new Guid("d8b86721-6f1e-4b22-a7e9-589fb3cd6cc0"), "Middle East (ASIA)" },
                    { new Guid("f6ee4b86-9a2e-4efb-b31f-6eab88cd0af9"), "Africa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e75a272-64fc-4ba9-a7c8-8675c0c2ff38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("acae7e3d-be21-48ce-8c2d-3f842f6a926b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cad0ec03-b6d0-4a25-b8c8-a4b8c192b325"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed3d11a6-b5ae-4c4b-8a46-19a695708970"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1c055423-ab04-47e9-940e-3afb36eee456"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2fcc7955-6dd8-4d5d-a7dd-2350cb84c6d9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("63bd0525-0baf-4419-b47f-0589bd61204d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9ab07904-884c-4545-979c-0892141b1165"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a790711e-e812-4905-ad84-68dd53bd3ee6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a9b0a18c-30fd-47a2-ab96-dc06fea52757"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b5c3f47e-ca1f-437f-8617-78df26da060c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("00513d68-4f5d-44d9-9df6-246378340f4f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("34b5baaf-14fd-4a75-be35-c1705aa337a0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("38ed271e-076d-42d7-aa8e-b03ac9b452fc"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("429ccaca-a503-44fc-b187-75f8f37197a7"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("581b2327-2287-4e7f-ac87-f0bae26c0297"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5b382a80-e404-46d0-94c7-9a5b33199ee2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("66ead295-3b80-4925-86eb-2dd0bdb2bd54"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7eb5cd16-c8a2-45ed-b42d-9fbb471cdef6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("95971156-3f54-4328-9c7c-6c41a0f9333a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d019dc12-d4a0-4ce8-b7ea-9293d90db5ae"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d7719e9c-d0b1-4424-8585-acc74da66be9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d8b86721-6f1e-4b22-a7e9-589fb3cd6cc0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f6ee4b86-9a2e-4efb-b31f-6eab88cd0af9"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9260676d-d699-4936-82a3-45b90d09a5fe", "AQAAAAIAAYagAAAAEO/wbIUCLYorYKU1zm/vbs6SQoDSw4wcAGhbPc9H//31+/TnwXSgazMcJx2Rj+MT7Q==", "bfcdb850-75dc-4403-8607-742547efd717" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5dc4e336-7b32-4828-a8e5-1150c547a604"), "Lifestyle" },
                    { new Guid("a5aead36-723f-4e91-8ae1-3483b1ece4e0"), "New production" },
                    { new Guid("c9b55a91-c620-4b5c-816e-e9ab68891035"), "Rising stars" },
                    { new Guid("ec44d824-670f-48d8-afc6-2920c1584451"), "BREAKING" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("45221fad-7ad3-4e1f-a41d-24fc04d56928"), "Drill" },
                    { new Guid("4b62643f-4982-40bc-ac5f-2375e079c744"), "Phonk" },
                    { new Guid("73f5fff4-8993-4134-8061-06f751c57211"), "R&B" },
                    { new Guid("8fdeac7e-90f9-4734-8f59-d44158d2d47a"), "Raeggeton" },
                    { new Guid("e3116896-17e0-4cc1-8ea2-701ff0c8baa3"), "Rap" },
                    { new Guid("ee61b87e-2d87-4140-b27a-0ed7be2ad6cc"), "House" },
                    { new Guid("fabc34f8-c8be-44b4-b4f1-813306d49004"), "Techno" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00fefb35-c407-4300-8927-8e43a63d25ac"), "East Asia" },
                    { new Guid("0d011743-2796-4c15-b894-40beee728bcf"), "Oceania" },
                    { new Guid("305b2d56-1f6f-459c-bb47-46a24c2864f7"), "West Asia" },
                    { new Guid("59bd3803-31ec-42ec-a520-3e6959e8ec5a"), "Middle East (ASIA)" },
                    { new Guid("5b49776d-9219-43b8-ad7b-bd568b1053cb"), "East Europe" },
                    { new Guid("603adf35-6eb2-47a1-8fcb-9888ae468846"), "Africa" },
                    { new Guid("606bc68c-cdb3-4182-b91d-2831f85007a6"), "South America" },
                    { new Guid("63d604c8-d78b-44f4-a00b-024562348640"), "West Europe" },
                    { new Guid("bdd29e4f-631e-4d49-ab75-b26ccaeb17d5"), "Middle Asia" },
                    { new Guid("d081b738-96ce-4cc5-bf00-4e02d68b9166"), "Latin America" },
                    { new Guid("e7e08a06-99c2-457b-acb4-e7b693b6ea6e"), "Balkans (EUROPE)" },
                    { new Guid("ea155cef-68a1-4729-96ff-80ffa7dab707"), "West Coast (NORTH AMERICA)" },
                    { new Guid("eb407147-422b-4e1c-b4b3-02ad9c219eef"), "East Coast (NORTH AMERICA)" }
                });
        }
    }
}
