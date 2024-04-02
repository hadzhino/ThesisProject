using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureSound.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1457249d-fb94-4676-9af0-6bcd6ca824d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a43cf53b-01e2-4df7-a0a4-7eae942bd0b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b73215f7-65e2-43f4-b518-5ba071f6cb66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9d0e94f-4801-49dd-b3d0-b08fd4189574"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2ed0932-d209-43df-bbac-123397577896"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("361e9025-92f3-4f89-b5ad-beb29dc8982b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("460eb626-5b66-4005-90d8-05cd171f9886"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5695dd23-4b01-4ace-aa3e-3932bf360ebe"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("666f203c-a739-4cae-9bdf-7ca5d2b0688a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9b39b8fa-f3ed-41d3-a0c4-b185998c0443"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b0b686d1-3e14-4447-a823-2e3c01d401c5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f83ed182-56b8-43fc-9b2e-bfd2f3365d06"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("01b5cabe-912c-4bf6-9541-937e09abaac5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("087281f3-1df8-4f44-8ee1-546d56f453e8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1125367f-e490-4735-bd1f-ee71633bb3d1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1686a9ac-0644-4bef-b2b5-a31a12d400e0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("57fe94c9-cbd6-4d85-acdd-a04e430155cd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("781b6c1c-7018-4451-a06e-1b7d66bc5d3a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("85ab7741-af16-4e17-86cf-682559d7bd3d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("887e05bf-2446-40e6-a46a-2318aeff8350"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8c9bd28b-d680-4d0e-ad84-8d529625d2b5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c440c301-beff-4302-af23-d79ecc582df1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cc839185-e022-4d01-8b77-ad499d1a9e37"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cea44e00-7d2c-498f-bd26-daeed7e240b5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d34ecf01-6308-4c77-82cc-abd762f2418a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "da9f09f9-1065-4120-9dbd-3c50cd62ae43", "AQAAAAIAAYagAAAAEHmXTtm1czFVsaKNLg5dd+jgMYeA/DGyJiDXmNSnOGPfJM0oxqkN8Hd3BVJriFb4ng==", "1a2b1755-da71-4736-96e1-5c2016ffecb1" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1457249d-fb94-4676-9af0-6bcd6ca824d7"), "All" },
                    { new Guid("a43cf53b-01e2-4df7-a0a4-7eae942bd0b2"), "BREAKING" },
                    { new Guid("b73215f7-65e2-43f4-b518-5ba071f6cb66"), "Lifestyle" },
                    { new Guid("c9d0e94f-4801-49dd-b3d0-b08fd4189574"), "Rising stars" },
                    { new Guid("f2ed0932-d209-43df-bbac-123397577896"), "New production" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("361e9025-92f3-4f89-b5ad-beb29dc8982b"), "Rap" },
                    { new Guid("460eb626-5b66-4005-90d8-05cd171f9886"), "House" },
                    { new Guid("5695dd23-4b01-4ace-aa3e-3932bf360ebe"), "Phonk" },
                    { new Guid("666f203c-a739-4cae-9bdf-7ca5d2b0688a"), "Techno" },
                    { new Guid("9b39b8fa-f3ed-41d3-a0c4-b185998c0443"), "Raeggeton" },
                    { new Guid("b0b686d1-3e14-4447-a823-2e3c01d401c5"), "Drill" },
                    { new Guid("f83ed182-56b8-43fc-9b2e-bfd2f3365d06"), "R&B" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01b5cabe-912c-4bf6-9541-937e09abaac5"), "South America" },
                    { new Guid("087281f3-1df8-4f44-8ee1-546d56f453e8"), "East Coast (NORTH AMERICA)" },
                    { new Guid("1125367f-e490-4735-bd1f-ee71633bb3d1"), "Oceania" },
                    { new Guid("1686a9ac-0644-4bef-b2b5-a31a12d400e0"), "West Asia" },
                    { new Guid("57fe94c9-cbd6-4d85-acdd-a04e430155cd"), "East Asia" },
                    { new Guid("781b6c1c-7018-4451-a06e-1b7d66bc5d3a"), "West Coast (NORTH AMERICA)" },
                    { new Guid("85ab7741-af16-4e17-86cf-682559d7bd3d"), "West Europe" },
                    { new Guid("887e05bf-2446-40e6-a46a-2318aeff8350"), "Balkans (EUROPE)" },
                    { new Guid("8c9bd28b-d680-4d0e-ad84-8d529625d2b5"), "East Europe" },
                    { new Guid("c440c301-beff-4302-af23-d79ecc582df1"), "Africa" },
                    { new Guid("cc839185-e022-4d01-8b77-ad499d1a9e37"), "Middle Asia" },
                    { new Guid("cea44e00-7d2c-498f-bd26-daeed7e240b5"), "Latin America" },
                    { new Guid("d34ecf01-6308-4c77-82cc-abd762f2418a"), "Middle East (ASIA)" }
                });
        }
    }
}
